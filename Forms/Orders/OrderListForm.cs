using SalesPro.Constants;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class OrderListForm : Form
    {
        public OrderStatus _orderStatus;
        public int _orderId;
        public int _rowVersion;
        public string _action;

        private readonly OrderForm _orderForm;
        private readonly OrderService _service;
        public OrderListForm(OrderForm orderForm)
        {
            InitializeComponent();
            _service = new OrderService();
            _orderForm = orderForm;
            KeyPreview = true;
        }

        private async void OrderListForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (_action == FormConstants.ResumeOrder)
                {
                    // We exclided the current order from the list
                    var suspendedOrders = await _service.LoadForResumeOrders(_orderId);

                    dgOrders.DataSource = suspendedOrders;
                    DgExtensions.ConfigureDataGrid(dgOrders, false, 3, notFound_lbl,
                     "OrderId", "CustomerName", "UserName", "DateTaken", "Total", "OrderStatus");

                    // Overide datagrid format
                    dgOrders.Columns["OrderId"].DisplayIndex = 0;
                    dgOrders.Columns["Total"].DisplayIndex = dgOrders.Columns.Count - 1;
                    dgOrders.Columns["OrderId"].DefaultCellStyle.Format = "000000000";
                    select_lbl.Visible = true;
                    resume_pb.Visible = true;
                    filterPanel.Visible = false;
                }
                else
                {
                    filterPanel.Visible = true;
                    await LoadViewOrders();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading order list form: {ex.Message}");
            }
        }

        private async Task LoadViewOrders()
        {
            var allOrders = await _service.LoadForViewAllOrders();

            var filteredOrders = allOrders;

            if (creditePb.Checked) // Assuming `chkCredited` is your CheckBox
            {
                filteredOrders = filteredOrders.Where(o => o.IsCredited).ToList();
            }

            if (completedCb.Checked) // Assuming `chkCompleted` is your CheckBox
            {
                filteredOrders = filteredOrders.Where(o => o.OrderStatus == OrderStatus.Completed).ToList();
            }

            if (paidPb.Checked) // Assuming `chkPaid` is your CheckBox
            {
                filteredOrders = filteredOrders.Where(o => o.PaymentStatus == PaymentStatus.Paid).ToList();
            }

            if (FindByDateCb.Checked)
            {
                filteredOrders = filteredOrders.Where(o => o.DateTaken.Date == date_cb.Value.Date).ToList();
            }

            // Bind filtered data to DataGridView
            dgOrders.DataSource = filteredOrders;

            DgExtensions.ConfigureDataGrid(dgOrders, true, 2, notFound_lbl,
            "OrderId", "CustomerName", "UserName", "DateTaken", "Total", "AmountPaid", "OrderStatus", "PaymentStatus", "IsCredited");
            dgOrders.Columns["Total"].DisplayIndex = dgOrders.Columns.Count - 1;
            select_lbl.Visible = false;
            resume_pb.Visible = false;
            total_tx.Text = filteredOrders.Sum(o => o.Total).ToString("N2");
        }

        private void dgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_action == FormConstants.OrderLists)
            {
                int orderId = DgFormatHelper.GetSelectedId(dgOrders, e, "OrderId");
                if (orderId == 0) return;
                var form = new OrderDetailsForm();
                form._orderId = orderId;
                form.ShowDialog();
            }
        }

        private void dgOrders_SelectionChanged(object sender, EventArgs e)
        {
            _orderId = DgFormatHelper.GetSelectedIdOnSelectionChange(dgOrders, "OrderId");
            if (_orderId == 0) return;
        }

        private async Task ProcessOrder()
        {
            try
            {
                if (_action == FormConstants.ResumeOrder)
                {
                    if (MessageHandler.ShowQuestionGeneric("Resune Order?"))
                    {
                        var resumedOrder = await _service.ChangeOrderStatus(_orderId, OrderStatus.Active, _rowVersion);
                        await _orderForm.InitializeOrderDisplay(resumedOrder);
                        await _orderForm.ReloadRowVersion();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error processing order: {ex.Message}");
            }

        }

        private async void dgOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                await ProcessOrder();
            }
        }

        private async void dgOrders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await ProcessOrder();
                e.Handled = true;
            }
        }

        private void dgOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgOrders.Columns[e.ColumnIndex].Name == "OrderStatus" && e.Value != null)
            {
                string status = e.Value.ToString();
                Color backColor;

                // Assign background color based on order status
                if (status == OrderStatus.Suspended.ToString())
                {
                    backColor = Color.PaleTurquoise;
                }
                else if (status == OrderStatus.Cancelled.ToString())
                {
                    backColor = Color.Orange;
                }
                else if (status == OrderStatus.Completed.ToString())
                {
                    backColor = Color.LawnGreen;
                }
                else
                {
                    return; // Exit if the status does not match any condition
                }

                // Apply styles
                e.CellStyle.Font = new Font(
                    dgOrders.DefaultCellStyle.Font.FontFamily,
                    dgOrders.DefaultCellStyle.Font.Size,
                    FontStyle.Bold
                );
                e.CellStyle.BackColor = backColor;
                e.CellStyle.SelectionBackColor = backColor;
            }

            // change fore color if negative
            if (dgOrders.Columns[e.ColumnIndex].Name == "Total" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal total))
                {
                    if (total < 0)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.SelectionForeColor = Color.Red;
                    }
                }
            }

            // Change payment status color
            if (dgOrders.Columns[e.ColumnIndex].Name == "PaymentStatus" && e.Value?.ToString() == PaymentStatus.Paid.ToString())
            {
                e.CellStyle.ForeColor = e.CellStyle.SelectionForeColor = Color.Blue;
                e.CellStyle.Font = new Font(dgOrders.DefaultCellStyle.Font, FontStyle.Bold);
            }


        }

        private void OrderListForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private async void completedCb_CheckedChanged(object sender, EventArgs e)
        {
            await LoadViewOrders();
        }

        private async void paidPb_CheckedChanged(object sender, EventArgs e)
        {
            await LoadViewOrders();
        }

        private async void creditePb_CheckedChanged(object sender, EventArgs e)
        {
            await LoadViewOrders();
        }

        private async void FindByDateCb_CheckedChanged(object sender, EventArgs e)
        {
            date_cb.Visible = FindByDateCb.Checked;
            await LoadViewOrders();
        }

        private async void date_cb_ValueChanged(object sender, EventArgs e)
        {
            await LoadViewOrders();
        }
    }
}
