using SalesPro.Enums;
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
    public partial class PaymentCreditForm : Form
    {
        public int _referenceId;
        public int _rowVersion;
        public PaymentType _paymentType;

        private readonly PurchaseOrderService _poService;

        public PaymentCreditForm()
        {
            InitializeComponent();
            _poService = new PurchaseOrderService();
        }

        private async void PaymentCreditForm_Load(object sender, EventArgs e)
        {
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
    }
}
