using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.PaymentsAndBilling
{
    public partial class UpdatePaymentForm : Form
    {
        public int _referenceId;
        public PaymentType _paymentType;
        public int _rowVersion;
        private int _supplierRowVesion;
        private int _customerRowVersion;
        private DateTime _curDate;
        public string _actionForm;


        private readonly BankService _bankService;
        private readonly PaymentsService _paymentService;
        private readonly PaymentsAndBillingForm _form;
        private readonly GenericService _genericService;
        private readonly CustomerCreditService _custCredService;
        public UpdatePaymentForm(PaymentsAndBillingForm form)
        {
            InitializeComponent();
            _paymentService = new PaymentsService();
            _bankService = new BankService();
            _genericService = new GenericService();
            _custCredService = new CustomerCreditService();
            _form = form;
        }

        private async Task SetBanks()
        {
            var banks = await _bankService.GetBanks();
            var selectedMethod = (PaymentMethod)paymentMethod_cb.SelectedItem;

            var filteredBanks = selectedMethod == PaymentMethod.EPayment
              ? banks.Where(x => x.BankType == BankType.DigitalWallet).OrderBy(x => x.BankName).ToList()
              : banks.Where(x => x.BankType == BankType.Traditional).OrderBy(x => x.BankName).ToList();

            bank_cb.DataSource = filteredBanks;
            bank_cb.DisplayMember = "BankName";
            bank_cb.ValueMember = "BankId";
            bank_cb.SelectedIndex = -1;
        }

        private async void ViewPaymentForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
                paymentMethod_cb.DataSource = PaymentMethodHelper.GetFilteredPaymentMethods();
                await SetBanks();

                var payment = await _paymentService.GetPaymentByReferenceId(_referenceId, _paymentType);
                if (payment != null)
                {
                    // load payment logs
                    await LoadPaymentLogs_ByReferenceIdAndPaymentType(payment.ReferenceId, payment.PaymentType);

                    // Controls
                    referenceId_tx.Text = payment.ReferenceId.ToString("D7");
                    paymentType_tx.Text = $"Update {payment.PaymentType.ToString()} Payment";
                    processedBy_tx.Text = payment.UserName.ToString();
                    paymentDate_tx.Text = DateFormatHelper.FormatDate(payment.PaymentDate);

                    paymentMethod_cb.Text = payment.PaymentMethod.ToString();
                    reference_tx.Text = payment.ReferenceNumber;
                    orNunber_tx.Text = payment.OrNumber;
                    bank_cb.Text = payment.BankName;
                    notes_tx.Text = payment.Notes;
                    _rowVersion = payment.RowVersion;
                }

                if (_actionForm == Constants.FormConstants.SupplierPayables)
                {
                    var po = await _paymentService.GetPurchaseOrderById(_referenceId);
                    if (po != null)
                    {
                        total_tx.Text = po.PoTotal.ToString("N2");
                        terms_tx.Text = $"{po.CreditTerms} days";
                        supplier_tx.Text = po.SupplierName;
                        supplierCustomer_tx.Text = "Supplier";
                        _supplierRowVesion = po.RowVersion;
                    }
                }
                else
                {
                    var creds = await _custCredService.GetCustomerCreditById(_referenceId);
                    if (creds != null)
                    {
                        total_tx.Text = creds.CreditAmount.ToString("N2");
                        terms_tx.Text = $"{creds.CreditTerms} days";
                        supplier_tx.Text = creds.CustomerName;
                        supplierCustomer_tx.Text = "Customer";
                        _customerRowVersion = creds.RowVersion;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on viewing payments and billing: {ex.Message}");
            }

        }

        private async Task LoadPaymentLogs_ByReferenceIdAndPaymentType(int referenceId, PaymentType pType)
        {
            var logs = await _paymentService.LoadPaymentLogs(referenceId, pType);
            dgLogs.DataSource = logs;
            DgExtensions.ConfigureDataGrid(dgLogs, false, 3, notFound_lbl,
                 "DatePerformed", "PaymentMethod", "Action", "ReferenceNo", "OrNumber", "Bank", "Notes", "PerformedBy");

        }
        private async void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedPaymentMethod = (PaymentMethod)paymentMethod_cb.SelectedItem;

                // Call the validation service
                if (!_genericService.ValidatePayment(
                        PaymentStatus.Paid,
                        paymentMethod_cb.SelectedIndex,
                        reference_tx.Text,
                        selectedPaymentMethod,
                        bank_cb.SelectedIndex,
                        true))
                {
                    return;
                }

                if (MessageHandler.ShowQuestionGeneric("Update payment?"))
                {
                    var paymennt = new PaymentsModel()
                    {
                        PaymentDate = _curDate,
                        PaymentMethod = (PaymentMethod)paymentMethod_cb.SelectedItem,
                        ReferenceNumber = reference_tx.Text,
                        OrNumber = orNunber_tx.Text,
                        BankName = bank_cb.Text,
                        Notes = notes_tx.Text,
                        UserName = UserSession.FullName,
                    };

                    var success = await _paymentService.UpdatePayment(_referenceId, _paymentType, paymennt, _rowVersion);

                    _form.unpaid_rd.Checked = true;
                    _form.paid_rd.Checked = true;
                    if (success > 0)
                    {
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error updating payment : {ex.Message}");
            }
        }

        private void paymentMethod_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            reference_tx.Text = string.Empty;
            orNunber_tx.Text = string.Empty;
            bank_cb.SelectedIndex = -1;
        }

        private async void undo_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageHandler.ShowQuestionGeneric("Are you sure you want to undo this payment? " +
                    "This action cannot be undone."))
                {
                    int success = await _paymentService.UndoPayment(_referenceId, _paymentType, rowVersion: _rowVersion,
                        customerRowVersion: _customerRowVersion, supplierRowVersion: _supplierRowVesion);
                    if (success > 0)
                    {
                        MessageHandler.ShowInfo("Payment has been successfully undone.");
                        Close();

                        if (_paymentType == PaymentType.SupplierPayable)
                        {
                            _form.unpaid_rd.Checked = true;
                        }
                        else
                        {
                            _form.unpaidCustomer_rd.Checked = true;
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error undoing payment : {ex.Message}");
            }
        }
    }
}
