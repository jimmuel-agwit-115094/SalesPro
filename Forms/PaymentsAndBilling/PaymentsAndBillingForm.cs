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
        private DateTime _curDate;
        public PaymentsAndBillingForm()
        {
            InitializeComponent();
            _service = new PaymentsService();
        }

        public async Task LoadAllPurchaseOrders(PaymentStatus status, bool showPastDue)
        {
            var pos = await _service.GetPurchaseOrdersByProcessStatus(status);

            if (showPastDue)
            {
                pos = pos.Where(x => x.DueDate < _curDate.Date).ToList();
            }

            dgSupplierPayables.DataSource = pos;
            DgExtensions.ConfigureDataGrid(dgSupplierPayables, true, 4, notFound_lbl, "PurchaseOrderId",
                "SupplierName", "DateCreated", "DueDate", "CreditTerms", "PoTotal", "UserFullName");

            dgSupplierPayables.Columns["PoTotal"].DisplayIndex = dgSupplierPayables.Columns.Count - 1;
        }

        private async void PaymentsAndBillingForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
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
            paid_lbl.Visible = false;
            showPastDue_cb.Visible = true;
            unpaid_panel.Visible = true;
            paid_panel.Visible = false;
            showPastDue_cb.Checked = false;
            await LoadAllPurchaseOrders(PaymentStatus.Unpaid, false);
        }

        private async void paid_rd_CheckedChanged(object sender, EventArgs e)
        {
            po_title.Text = "Paid Purchase Orders";
            paid_lbl.Visible = true;
            showPastDue_cb.Visible = false;
            paid_panel.Visible = true;
            unpaid_panel.Visible = false;
            await LoadAllPurchaseOrders(PaymentStatus.Paid, false);
        }

        private void dgSupplierPayables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int poId = DgFormatHelper.GetSelectedId(dgSupplierPayables, e, "PurchaseOrderId");
                if (poId == 0) return;

                if (paid_rd.Checked == true)
                {
                    var form = new UpdatePaymentForm(this);
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

        private void dgSupplierPayables_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgSupplierPayables.Columns[e.ColumnIndex].Name == "DueDate") // Replace with your column name
            {
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime dueDate))
                {
                    if (dueDate < _curDate.Date) // If the due date is in the past
                    {
                        e.CellStyle.ForeColor = Color.Red; // Change the fore color to red
                        e.CellStyle.SelectionForeColor = Color.Red;
                    }
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black; // Default color for invalid or null dates
                }
            }

        }

        private async void showPastDue_cb_CheckedChanged(object sender, EventArgs e)
        {
            await LoadAllPurchaseOrders(PaymentStatus.Unpaid, showPastDue_cb.Checked);
        }
    }
}
