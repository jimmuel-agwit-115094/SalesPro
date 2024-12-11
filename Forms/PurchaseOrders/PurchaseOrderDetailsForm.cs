using System;
using System.Windows.Forms;

namespace SalesPro.Forms.PurchaseOrders
{
    public partial class PurchaseOrderDetailsForm : Form
    {
        public int _poId;
        public PurchaseOrderDetailsForm()
        {
            InitializeComponent();
        }

        private void addSupplier_btn_Click(object sender, EventArgs e)
        {
            AddSupplierForm addSupplierForm = new AddSupplierForm();
            addSupplierForm.ShowDialog();
        }

        private void PurchaseOrderDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
