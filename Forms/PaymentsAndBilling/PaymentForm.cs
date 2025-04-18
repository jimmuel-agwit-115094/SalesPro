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
        public int _orderId;
        public int _referenceId;
        public int _rowVersion;
        public int _paymentRowVersion;
        public int _credRowVersion;
        private DateTime _curDate;
        public PaymentType _paymentType;
        public PaymentStatus _paymentStatus;
        public string _actionForm;
        private decimal _total;

        private readonly BankService _bankService;
        private readonly PaymentsService _paymentService;
        private readonly PurchaseOrderService _poService;
        private readonly ManagePayableForm _form;
        private readonly GenericService _genericService;
        private readonly CustomerCreditService _custCredService;

        public PaymentForm(ManagePayableForm form)
        {
            InitializeComponent();
            _poService = new PurchaseOrderService();
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

        private async void PaymentCreditForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
                paymentMethod_cb.DataSource = PaymentMethodHelper.GetFilteredPaymentMethods();
                await SetBanks();

                if (_actionForm == Constants.FormConstants.SupplierPayables)
                {
                    var po = await _poService.GetPurchaseorderById(_referenceId);
                    if (po != null)
                    {
                        _rowVersion = po.RowVersion;
                        _paymentStatus = po.PaymentStatus;
                        total_tx.Text = po.PoTotal.ToString("N2");
                        _total = po.PoTotal;
                    }
                    paymentTitle_tx.Text = "Supplier Payment";
                    pay_btn.Text = "Pay Supplier";
                    pay_btn.BackColor = Color.Green;
                }
                else
                {
                    var cred = await _custCredService.GetCustomerCreditById(_referenceId);
                    if (cred != null)
                    {
                        _credRowVersion = cred.RowVersion;
                        _paymentStatus = cred.PaymentStatus;
                        total_tx.Text = cred.CreditAmount.ToString("N2");
                        _total = cred.CreditAmount;
                    }
                    paymentTitle_tx.Text = "Customer Credit Receivable";
                    pay_btn.Text = "Receive Payment";
                    pay_btn.BackColor = SystemColors.Highlight;
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
                    var paymentsModel = new PaymentsModel();
                    {
                        paymentsModel.BankName = bank_cb.Text;
                        paymentsModel.Notes = notes_tx.Text;
                        paymentsModel.OrNumber = orNunber_tx.Text;
                        paymentsModel.PaymentDate = _curDate;
                        paymentsModel.PaymentMethod = (PaymentMethod)paymentMethod_cb.SelectedValue;
                        paymentsModel.PaymentType = _paymentType;
                        paymentsModel.ReferenceNumber = reference_tx.Text;
                        paymentsModel.UserName = UserSession.FullName;
                        paymentsModel.ReferenceId = _referenceId;
                        paymentsModel.OrderId = _orderId;
                    }

                    var orderModel = new OrderModel();
                    {
                        orderModel.OrderId = _orderId;
                        orderModel.Total = _total;
                        orderModel.PaymentMethod = (PaymentMethod)paymentMethod_cb.SelectedValue;
                        orderModel.DatePaid = _curDate;
                    }

                    int newRowVersion = _actionForm == Constants.FormConstants.SupplierPayables ? _rowVersion : _credRowVersion;
                    var success = await _paymentService.Pay(_referenceId, paymentsModel, orderModel, newRowVersion, _paymentRowVersion);
                    if (success > 0)
                    {
                        Close();
                    }
                    await _form.SetControls();
                    _form.ClosePaymentsAndBillingForm();
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
