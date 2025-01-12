using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.PaymentsAndBilling
{
    public partial class PaymentForm : Form
    {
        public int _referenceId;
        public int _rowVersion;
        private DateTime _curDate;
        public PaymentType _paymentType;

        private readonly BankService _bankService;
        private readonly PaymentsServices _paymentService;
        private readonly PurchaseOrderService _poService;

        public PaymentForm()
        {
            InitializeComponent();
            _poService = new PurchaseOrderService();
            _paymentService = new PaymentsServices();
            _bankService = new BankService();
        }

        private async Task SetBanks()
        {
            var banks = await _bankService.GetBanks();
            var selectedMethod = (PaymentMethod)paymentMethod_cb.SelectedItem;

            var filteredBanks = selectedMethod == PaymentMethod.EPayment
                ? banks.Where(x => x.BankType == BankType.DigitalWallet).ToList()
                : banks.Where(x => x.BankType == BankType.Traditional).ToList();

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

                paymentTitle_tx.Text = _paymentType == PaymentType.SupplierPayable
                      ? "Supplier Payable Payment"
                      : "Customer Credit Payment";

                await SetBanks();

                if (_paymentType == PaymentType.SupplierPayable)
                {
                    var po = await _poService.GetPurchaseorderById(_referenceId);
                    if (po != null)
                    {
                        total_tx.Text = po.PoTotal.ToString("N2");
                    }
                }
                else
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
                if (paymentMethod_cb.SelectedIndex == -1)
                {
                    MessageHandler.ShowWarning("Please select payment method.");
                    return;
                }
                if (reference_tx.Text == "")
                {
                    MessageHandler.ShowWarning("Please enter reference number.");
                    return;
                }
                if ((PaymentMethod)paymentMethod_cb.SelectedItem != PaymentMethod.Cash
                    && bank_cb.SelectedIndex == -1)
                {
                    MessageHandler.ShowWarning("Please select bank.");
                }
                var model = new PaymentsModel();
                {
                    model.BankId = 1;
                    model.Notes = notes_tx.Text;
                    model.OrNumber = orNunber_tx.Text;
                    model.PaymentDate = _curDate;
                    model.PaymentMethod = (PaymentMethod)paymentMethod_cb.SelectedValue;
                    model.ReferenceNumber = reference_tx.Text;
                    model.UserId = UserSession.Session_UserId;
                    model.ReferenceId = _referenceId;
                }
                await _paymentService.PayPurchaseOrder(_referenceId, _paymentType, model, _rowVersion);
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
    }
}
