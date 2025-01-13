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
        private readonly PaymentsService _service;
        public PaymentsAndBillingForm()
        {
            InitializeComponent();
            _service = new PaymentsService();
        }

        public async Task LoadAllPurchaseOrders(PaymentStatus status)
        {
            var pos = await _service.GetPurchaseOrdersByProcessStatus(status);

            dgSupplierPayables.DataSource = pos;
            DgExtensions.ConfigureDataGrid(dgSupplierPayables, true, 4, notFound_lbl, "PurchaseOrderId",
                "SupplierName", "DateCreated", "DueDate", "CreditTerms", "PoTotal", "UserFullName");

            dgSupplierPayables.Columns["PoTotal"].DisplayIndex = dgSupplierPayables.Columns.Count - 1;
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
            try
            {
                int poId = DgFormatHelper.GetSelectedId(dgSupplierPayables, e, "PurchaseOrderId");
                if (poId == 0) return;

                if (paid_rd.Checked == true)
                {
                    var form = new UpdatePaymentForm();
                    form._poId = poId;
                    form._paymentType = PaymentType.SupplierPayable;
                    form.ShowDialog();
                }
                else
                {
                    var form = new ManageSupplierPayableForm(this);
                    form._poId = poId;
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error dg supplier click: {ex.Message}");
            }
        }
    }
}
