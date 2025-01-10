using SalesPro.Enums;
using SalesPro.Helpers;
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

namespace SalesPro.Forms.PaymentsAndBilling
{
    public partial class PaymentsAndBillingForm : Form
    {
        private readonly PurchaseOrderService _poService;
        public PaymentsAndBillingForm()
        {
            InitializeComponent();
            _poService = new PurchaseOrderService();
        }

        public async Task LoadAllPurchaseOrders(PaymentStatus status)
        {
            var pos = await _poService.GetAllPurchaseOrders();
            pos = pos.Where(p => p.PaymentStatus == status).ToList();

            dgSupplierPayables.DataSource = pos;
            DgExtensions.ConfigureDataGrid(dgSupplierPayables, true, 0, notFound_lbl, "PurchaseOrderId",
                "Supplier", "DateCreated", "DueDate", "CreditTerms", "PoTotal", "ProcessStatus");
        }

        private void PaymentsAndBillingForm_Load(object sender, EventArgs e)
        {
            try
            {
                unpaid_rd.Checked = true;
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on loading payments and billing: {ex.Message}");
            }
        }

        private async void unpaid_rd_CheckedChanged(object sender, EventArgs e)
        {
            po_title.Text = "Unpaid Purchase Orders";

            await LoadAllPurchaseOrders(PaymentStatus.Unpaid);
        }

        private async void paid_rd_CheckedChanged(object sender, EventArgs e)
        {
            po_title.Text = "Paid Purchase Orders";
            await LoadAllPurchaseOrders(PaymentStatus.Paid);
        }

        private void dgSupplierPayables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
