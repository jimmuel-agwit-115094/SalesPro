using POS_Generic.Helpers;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
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

        private async void PurchaseOrderDetailsForm_Load(object sender, EventArgs e)
        {
            await LoadPurchaseOrderItemsByPoId();
            poId_tx.Text = _poId.ToString("D9");
        }


        public async Task LoadPurchaseOrderItemsByPoId()
        {
            var poItems = await _service.LoadPurchaseOrderItemsByPoId(_poId);
            if (poItems != null)
            {
                dgPoItems.DataSource = poItems;
                DgExtensions.ConfigureDataGrid(dgPoItems, true, 1, notFound_lbl,
                    "PurchaseOrderItemId", "ProductName", "Quantity", "SupplierPrice", "MarkUpPrice", "RetailPrice", "TotalPrice");
            }
        }

        private void dgPo_KeyDown(object sender, KeyEventArgs e)
        {
            DgFormatHelper.HandleEnterKey(e, dgPoItems);
        }

        public async Task SetSupplierDataOnControls(int supplierId)
        {
            try
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
                await _service.UpdatePurchaseOrder_SupploerId(_poId, _rowVersion, supplierId);
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error setting supplier data {ex.Message}");
                throw;
            }
        }



        private async void PurchaseOrderDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await _purchaseOrderForm.LoadPurchaseOrdersByProcessStatus();
        }

        private void addProduct_btn_Click(object sender, EventArgs e)
        {
            AddPurchaseProductForm form = new AddPurchaseProductForm(this);
            form._poId = _poId;
            form._rowVersion = _rowVersion;
            form.ShowDialog();
        }
    }
}
