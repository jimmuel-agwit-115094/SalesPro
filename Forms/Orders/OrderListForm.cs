using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Collections.Generic;
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
                var orderList = new List<OrderModelExtended>();
                if (_action == Constants.FormConstants.ResumeOrder)
                {
                    orderList = await _service.LoadOrdersByStatus(_orderStatus);
                }
                else
                {
                    orderList = await _service.LoadOrdersByStatus();
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
                var order = await _service.GetOrderById(_orderId);
                await _orderForm.InitializeOrderDisplay(order);
                await _orderForm.ReloadRowVersion();
                Close();
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
    }
}
