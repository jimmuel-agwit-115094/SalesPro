using POS_Generic.Helpers;
using SalesPro.Helpers.UiHelpers;
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

namespace SalesPro.Forms.PurchaseOrders
{
    public partial class AddSupplierForm : Form
    {
        private readonly DatabaseContext _context;
        private readonly PurchaseOrderService _service;
        public AddSupplierForm()
        {
            _context = new DatabaseContext();
            InitializeComponent();
            _service = new PurchaseOrderService(_context);
        }

        private async void AddSupplierForm_Load(object sender, EventArgs e)
        {
            var suppliers = await _service.LoadSuppliers();
            dgSupplier.DataSource = suppliers.Where(x=>x.SupplierId != 1).ToList();
            DgExtensions.ConfigureDataGrid(dgSupplier, false, 0, notFound_lbl, "SupplierName", "SupplierAddress", "SupplierNumber");
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgSupplier, search_tx);
        }

        private void dgSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgSupplier_SelectionChanged(object sender, EventArgs e)
        {
            var id = DgFormatHelper.GetSelectedRowId(dgSupplier, "SupplierId");
        }
    }
}
