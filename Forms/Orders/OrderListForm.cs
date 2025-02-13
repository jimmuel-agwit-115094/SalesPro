using SalesPro.Constants;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Drawing;
using System.Linq;
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
                var orders = await _service.LoadOrders();

                if (_action == FormConstants.ResumeOrder)
                {
                    // We exclided the current order from the list
                    var suspendedOrders = orders.Where(x => x.OrderStatus != OrderStatus.Completed && x.OrderId != _orderId).ToList();

                    dgOrders.DataSource = suspendedOrders;
                    DgExtensions.ConfigureDataGrid(dgOrders, false, 3, notFound_lbl,
                     "OrderId", "CustomerName", "UserName", "DateTaken", "Total", "OrderStatus");

                    // Overide datagrid format
                    dgOrders.Columns["OrderId"].DisplayIndex = 0;
                    dgOrders.Columns["Total"].DisplayIndex = dgOrders.Columns.Count - 1;
                    dgOrders.Columns["OrderId"].DefaultCellStyle.Format = "000000000";
                    select_lbl.Visible = true;
                    resume_pb.Visible = true;
                }
                else
                {
                    var allOrders = orders.Where(x => x.OrderStatus != OrderStatus.Suspended).ToList();
                    dgOrders.DataSource = allOrders;
                    DgExtensions.ConfigureDataGrid(dgOrders, true, 2, notFound_lbl,
                    "OrderId", "CustomerName", "UserName", "DateTaken", "Total", "AmountPaid", "OrderStatus", "PaymentStatus", "IsCredited");
                    dgOrders.Columns["Total"].DisplayIndex = dgOrders.Columns.Count - 1;
                    select_lbl.Visible = false;
                    resume_pb.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading order list form: {ex.Message}");
            }
        }

        private void dgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = DgFormatHelper.GetSelectedId(dgOrders, e, "OrderId");
            if (orderId == 0) return;
            var form = new OrderDetailsForm();
            form._orderId = orderId;
            form.ShowDialog();
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
                if (_action == Constants.FormConstants.ResumeOrder)
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


        }

        private void OrderListForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
