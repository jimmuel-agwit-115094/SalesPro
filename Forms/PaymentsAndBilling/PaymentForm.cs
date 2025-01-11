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

        private readonly PaymentsServices _paymentService;
        private readonly PurchaseOrderService _poService;

        public PaymentForm()
        {
            InitializeComponent();
            _poService = new PurchaseOrderService();
            _paymentService = new PaymentsServices();
        }

        private async void PaymentCreditForm_Load(object sender, EventArgs e)
        {
            _curDate = await ClockHelper.GetServerDateTime();
            var filteredPaymentMethods = PaymentMethodHelper.GetFilteredPaymentMethods();
            paymentMethod_cb.DataSource = filteredPaymentMethods;

            if (_paymentType == PaymentType.SupplierPayable)
            {
                paymentTitle_tx.Text = "Supplier Payable Payment";

                var po = await _poService.GetPurchaseorderById(_referenceId);
                if (po != null)
                {
                    total_tx.Text = po.PoTotal.ToString("N2");
                }
            }
            else
            {
                paymentTitle_tx.Text = "Customer Credit Payment";
            }
        }

        private async void pay_btn_Click(object sender, EventArgs e)
        {
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
    }
}
