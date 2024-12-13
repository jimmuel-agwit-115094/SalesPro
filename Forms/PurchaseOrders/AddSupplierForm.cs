using POS_Generic.Helpers;
using SalesPro.Accessors;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
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
        private readonly Accessor<PurchaseOrderModel> _purchaseOrderAccessor;
        private readonly PurchaseOrderDetailsForm _form;
        private int _supplierId;
        public AddSupplierForm(PurchaseOrderDetailsForm form)
        {
            _context = new DatabaseContext();
            InitializeComponent();
            _form = form;
        }

        private async void AddSupplierForm_Load(object sender, EventArgs e)
        {
            using (var _context = new DatabaseContext())
            {
                var suppliers = await _context.dgSupplier.DataSource = suppliers.Where(x => x.SupplierId != 1).ToList();
                DgExtensions.ConfigureDataGrid(dgSupplier, false, 0, notFound_lbl, "SupplierName", "SupplierAddress", "SupplierNumber");
            }

        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgSupplier, search_tx);
        }

        private void dgSupplier_SelectionChanged(object sender, EventArgs e)
        {
            _supplierId = DgFormatHelper.GetSelectedRowId(dgSupplier, "SupplierId");
        }

        private async void dgSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgSupplier.Rows.Count > 0)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                await _form.SetSupplierDataOnControls(_supplierId);
                Close();
            }
        }

        private void dgSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void dgSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            await _form.SetSupplierDataOnControls(_supplierId);
            Close();
        }
    }
}
