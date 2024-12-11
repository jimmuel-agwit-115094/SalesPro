using System;
using System.Windows.Forms;

namespace SalesPro.Forms.PurchaseOrders
{
    public partial class PurchaseOrderDetailsForm : Form
    {
        public PurchaseOrderDetailsForm()
        {
            InitializeComponent();
        }

        private void addSupplier_btn_Click(object sender, EventArgs e)
        {
            AddSupplierForm addSupplierForm = new AddSupplierForm();
            addSupplierForm.ShowDialog();
        }
    }
}
