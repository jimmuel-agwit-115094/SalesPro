﻿using SalesPro.Helpers.UiHelpers;
using SalesPro.Services;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.PurchaseOrders
{
    public partial class AddSupplierForm : Form
    {
        private readonly PurchaseOrderService _service;
        private readonly PurchaseOrderDetailsForm _form;
        private int _supplierId;
        public int _rowVersion;
        public AddSupplierForm(PurchaseOrderDetailsForm form)
        {
            InitializeComponent();
            _service = new PurchaseOrderService();
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

        private async void dgSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgSupplier.Rows.Count > 0)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                await ProcessSupplier();
            }
        }

        private async Task ProcessSupplier()
        {
            await _form.SetSupplierDataOnControls(_supplierId);
            await _form.ReloadRowVersion();
            Close();
        }

        private async void dgSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Disable column header click
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            await ProcessSupplier();
        }

        private void dgSupplier_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                return; // Do nothing
            }
        }

        private void dgSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
