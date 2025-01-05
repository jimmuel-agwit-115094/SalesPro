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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class OrderListForm : Form
    {
        public OrderStatus _orderStatus;
        private int _orderId;
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
                var orders = await _service.LoadOrdersByStatus();

                List<OrderModelExtended> orderList;

                if (_action == FormConstants.ResumeOrder)
                {
                    orderList = orders.Where(x => x.OrderStatus == OrderStatus.Suspended).ToList();
                }
                else
                {
                    orderList = orders.Where(x => x.OrderStatus != OrderStatus.Suspended).ToList();
                }

                dgOrders.DataSource = orderList;

                DgExtensions.ConfigureDataGrid(dgOrders, false, 3, notFound_lbl,
                     "CustomerName", "UserName", "DateTaken", "Total", "AmountPaid", "OrderStatus", "PaymentStatus");
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading order list form: {ex.Message}");
            }
        }

        private void dgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgOrders_SelectionChanged(object sender, EventArgs e)
        {
            _orderId = DgFormatHelper.GetSelectedIdOnSelectionChange(dgOrders, "OrderId");
            if (_orderId == 0) return;
        }

        private async Task ProcessOrder()
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
            else
            {
                //var order = await _service.GetOrderById(_orderId);
                //await _orderForm.InitializeOrderDisplay(order);
                //await _orderForm.ReloadRowVersion();
                //Close();
            }

        }

        private async void dgOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    await ProcessOrder();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error processing order on cell double click: {ex.Message}");
            }
        }

        private async void dgOrders_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    await ProcessOrder();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error processing order on cell key down: {ex.Message}");
            }
        }

        private void dgOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgOrders.Columns[e.ColumnIndex].Name == "PaymentStatus") // Replace with your column name
            {
                if (e.Value != null && e.Value.ToString() == "Paid") // Replace "SpecificString" with your condition
                {
                    e.CellStyle.Font = new Font(
                        dgOrders.DefaultCellStyle.Font.FontFamily,
                        dgOrders.DefaultCellStyle.Font.Size,
                        FontStyle.Bold
                     );
                    e.CellStyle.ForeColor = Color.Green; // Change the fore color to green
                    e.CellStyle.SelectionForeColor = Color.Green;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black; // Default color
                }
            }
        }
    }
}
