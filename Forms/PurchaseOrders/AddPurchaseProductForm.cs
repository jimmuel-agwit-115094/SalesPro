using System;
using System.Windows.Forms;

namespace SalesPro.Forms.PurchaseOrders
{
    public partial class AddPurchaseProductForm : Form
    {
        public int _poId;
        public int _rowVersion;
        private readonly PurchaseOrderDetailsForm _purchaseOrderDetailsForm;
        public AddPurchaseProductForm(PurchaseOrderDetailsForm purchaseOrderDetailsForm)
        {
            InitializeComponent();
            _purchaseOrderDetailsForm = purchaseOrderDetailsForm;
        }

        private void AddPurchaseProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
