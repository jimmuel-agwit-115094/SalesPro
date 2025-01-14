using SalesPro.Enums;
using SalesPro.Helpers;
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
    public partial class UpdatePaymentForm : Form
    {
        public int _poId;
        public PaymentType _paymentType;

        private readonly BankService _bankService;
        private readonly PaymentsService _paymentService;
        private readonly PurchaseOrderService _purchaseOrderService;
        public UpdatePaymentForm()
        {
            InitializeComponent();
            _paymentService = new PaymentsService();
            _purchaseOrderService = new PurchaseOrderService();
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

        private async void ViewPaymentForm_Load(object sender, EventArgs e)
        {
            try
            {
                paymentMethod_cb.DataSource = PaymentMethodHelper.GetFilteredPaymentMethods();
                await SetBanks();

                var payment = await _paymentService.GetPaymentByReferenceId(_poId, _paymentType);
                if (payment != null)
                {
                    referenceId_tx.Text = payment.ReferenceId.ToString("D7");
                    paymentType_tx.Text = payment.PaymentType.ToString();
                    processedBy_tx.Text = payment.UserName.ToString();
                    paymentDate_tx.Text = DateFormatHelper.FormatDate(payment.PaymentDate);

                    paymentMethod_cb.Text = payment.PaymentMethod.ToString();
                    reference_tx.Text = payment.ReferenceNumber;
                    orNunber_tx.Text = payment.OrNumber;
                    bank_cb.Text = payment.BankName;
                    notes_tx.Text = payment.Notes;
                }
                
                var po = await _paymentService.GetPurchaseOrderById(_poId);
                if (po != null)
                {
                    total_tx.Text = po.PoTotal.ToString("N2");
                    terms_tx.Text = $"{po.CreditTerms} days";
                    supplier_tx.Text = po.SupplierName;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on viewing payments and billing: {ex.Message}");
            }

        }

        private void update_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
