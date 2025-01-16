using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.PaymentsAndBilling
{
    public partial class PaymentForm : Form
    {
        public int _referenceId;
        public int _rowVersion;
        public int _paymentRowVersion;
        private DateTime _curDate;
        public PaymentType _paymentType;
        public PaymentStatus _paymentStatus;

        private readonly BankService _bankService;
        private readonly PaymentsService _paymentService;
        private readonly PurchaseOrderService _poService;
        private readonly SupplierPayableForm _form;
        private readonly GenericService _genericService;

        public PaymentForm(SupplierPayableForm form)
        {
            InitializeComponent();
            _poService = new PurchaseOrderService();
            _paymentService = new PaymentsService();
            _bankService = new BankService();
            _genericService = new GenericService();
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

        private void SetControls()
        {

        }

        private async void PaymentCreditForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
                paymentMethod_cb.DataSource = PaymentMethodHelper.GetFilteredPaymentMethods();

                paymentTitle_tx.Text = _paymentType == PaymentType.SupplierPayable
                      ? "Supplier Payable Payment"
                      : "Customer Credit Payment";

                await SetBanks();

                if (_paymentType == PaymentType.SupplierPayable)
                {
                    var po = await _poService.GetPurchaseorderById(_referenceId);
                    if (po != null)
                    {
                        _rowVersion = po.RowVersion;
                        _paymentStatus = po.PaymentStatus;
                        total_tx.Text = po.PoTotal.ToString("N2");
                    }

                    if (_paymentStatus == PaymentStatus.Unpaid)
                    {
                        pay_btn.BackColor = Color.Green;
                        pay_btn.Text = "Pay";
                    }
                    else
                    {
                        pay_btn.BackColor = SystemColors.Highlight;
                        pay_btn.Text = "View Payment";

                        var payment = await _paymentService.GetPaymentByReferenceId(_referenceId, _paymentType);
                        if (payment != null)
                        {
                            paymentMethod_cb.Text = payment.PaymentMethod.ToString();
                            reference_tx.Text = payment.ReferenceNumber;
                            orNunber_tx.Text = payment.OrNumber;
                            bank_cb.Text = payment.BankName;
                            notes_tx.Text = payment.Notes;
                            _paymentRowVersion = payment.RowVersion;
                        }
                    }
                }
                else if (_paymentType == PaymentType.CustomerCredit)
                {
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading payment form: {ex.Message}");
            }
        }


        private async void pay_btn_Click(object sender, EventArgs e)
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

                if (MessageHandler.ShowQuestionGeneric("Confirm Payment?"))
                {
                    var model = new PaymentsModel();
                    {
                        model.BankName = bank_cb.Text;
                        model.Notes = notes_tx.Text;
                        model.OrNumber = orNunber_tx.Text;
                        model.PaymentDate = _curDate;
                        model.PaymentMethod = (PaymentMethod)paymentMethod_cb.SelectedValue;
                        model.ReferenceNumber = reference_tx.Text;
                        model.UserName = UserSession.FullName;
                        model.ReferenceId = _referenceId;
                    }
                    var success = await _paymentService.Pay(_referenceId, _paymentType, model, _rowVersion, _paymentRowVersion);
                    if (success == 1)
                    {
                        await _form.SetControls();
                        _form.ClosePaymentsAndBillingForm();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error pay button: {ex.Message}");
            }
        }

        private async void paymentMethod_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            bank_cb.Enabled = ((PaymentMethod)paymentMethod_cb.SelectedItem != PaymentMethod.Cash);
            await SetBanks();
        }

        private void bank_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
