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

        private readonly PaymentsService _paymentService;
        public UpdatePaymentForm()
        {
            InitializeComponent();
            _paymentService = new PaymentsService();
        }

        private async void ViewPaymentForm_Load(object sender, EventArgs e)
        {
            try
            {
                var payment = await _paymentService.GetPaymentByReferenceId(_poId, _paymentType);
                if (payment != null)
                {
                    paymentMethod_cb.Text = payment.PaymentMethod.ToString();
                    reference_tx.Text =payment.ReferenceNumber;
                    orNunber_tx.Text = payment.OrNumber;
                    bank_cb.Text = payment.BankName;
                    notes_tx.Text = payment.Notes;
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
