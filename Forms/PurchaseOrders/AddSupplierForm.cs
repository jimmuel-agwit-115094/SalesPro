using POS_Generic.Helpers;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SalesPro.Forms.PurchaseOrders
{
    public partial class AddSupplierForm : Form
    {
        private readonly DatabaseContext _context;
        private readonly PurchaseOrderService _service;
        private readonly PurchaseOrderDetailsForm _form;
        private int _supplierId;
        public AddSupplierForm(PurchaseOrderDetailsForm form)
        {
            _context = new DatabaseContext();
            InitializeComponent();
            _service = new PurchaseOrderService(_context);
            _form = form;
        }

        private async void AddSupplierForm_Load(object sender, EventArgs e)
        {
            var suppliers = await _service.LoadSuppliers();
            dgSupplier.DataSource = suppliers.Where(x => x.SupplierId != 1).ToList();
            DgExtensions.ConfigureDataGrid(dgSupplier, false, 0, notFound_lbl, "SupplierName", "SupplierAddress", "SupplierNumber");
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgSupplier, search_tx);
        }

        private void dgSupplier_SelectionChanged(object sender, EventArgs e)
        {
            _supplierId = DgFormatHelper.GetSelectedRowId(dgSupplier, "SupplierId");
        }

        private async void dgSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                await _form.SetSupplierDataOnControls(_supplierId);
                Close();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError(ex.Message);
                throw;
            }
        }
    }
}
