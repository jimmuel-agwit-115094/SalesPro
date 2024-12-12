using POS_Generic.Helpers;
using SalesPro.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.PurchaseOrders
{
    public partial class PurchaseOrderDetailsForm : Form
    {
        public int _poId;
        public int _rowVersion;
        private readonly DatabaseContext _context;
        private readonly PurchaseOrderService _service;
        private readonly PurchaseOrderForm _purchaseOrderForm;
        public PurchaseOrderDetailsForm(PurchaseOrderForm purchaseOrderForm)
        {
            InitializeComponent();
            _context = new DatabaseContext();
            _service = new PurchaseOrderService(_context);
            _purchaseOrderForm = purchaseOrderForm;
        }

        private void addSupplier_btn_Click(object sender, EventArgs e)
        {
            AddSupplierForm addSupplierForm = new AddSupplierForm(this);
            addSupplierForm.ShowDialog();
        }

        private void PurchaseOrderDetailsForm_Load(object sender, EventArgs e)
        {
            poId_tx.Text = _poId.ToString("D9");
        }

        private void dgPo_KeyDown(object sender, KeyEventArgs e)
        {
            DgFormatHelper.HandleEnterKey(e, dgPo);
        }

        public async Task SetSupplierDataOnControls(int supplierId)
        {
            // Set the supplier data on the controls
            var supplier = await _service.GetSupplierById(supplierId);
            if (supplier != null)
            {
                supplier_tx.Text = supplier.SupplierName;
                address_tx.Text = supplier.SupplierAddress;
                contactPerson_tx.Text = supplier.SupplierContactPerson;
                number_tx.Text = supplier.SupplierNumber;
            }
            //Update PO to set the supplier id
            await _service.UpdatePurchaseOrder(_poId, _rowVersion, supplierId);
        }

        private async void PurchaseOrderDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await _purchaseOrderForm.LoadPurchaseOrdersByProcessStatus();
        }
    }
}
