using SalesPro.Forms.Transactions;
using System;
using System.Windows.Forms;

namespace SalesPro.Forms.PurchaseOrders
{
    public partial class PurchaseOrderForm : Form
    {
        public PurchaseOrderForm()
        {
            InitializeComponent();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            PurchaseOrderDetailsForm form = new PurchaseOrderDetailsForm();
            form.ShowDialog();
        }
    }
}
