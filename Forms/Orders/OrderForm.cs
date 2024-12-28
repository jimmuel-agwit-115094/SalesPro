using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class OrderForm : Form
    {
        private DateTime _curDate;
        private int _rowVersion;
        private int _orderId;

        private readonly OrderService _service;
        public OrderForm()
        {
            InitializeComponent();
            _service = new OrderService();
        }

        private OrderModel BuildOrderModel()
        {
            return new OrderModel
            {
                TransactionId = TransactionSession._transactionId,
                AmountDue = 0,
                AmountPaid = 0,
                Change = 0,
                CustomerId = 1,
                DateTaken = _curDate,
                DatePaid = _curDate,
                DiscountAmount = 0,
                DiscountRate = 0,
                NetAmount = 0,
                OrderStatus = OrderStatus.Active,
                PaymentMethod = PaymentMethod.NotSet,
                PaymentStatus = PaymentStatus.Unpaid,
                Total = 0,
                UserId = 1,
                Vat = 12,
                VatAmount = 0
            };
        }

        private async void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
                SetFormSize();
                var orderModel = BuildOrderModel();
                var savedOrder = await _service.SaveOrder(orderModel);
                _rowVersion = savedOrder.RowVersion;
                _orderId = savedOrder.OrderId;
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error order form load : {ex}");
            }
        }

        private void SetFormSize()
        {
            WindowState = FormWindowState.Maximized;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            Size = workingArea.Size;
            Location = workingArea.Location;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            var form = new AddOrderItemForm(this);
            form._orderId = _orderId;
            form._rowVersion = _rowVersion;
            form._quantity = int.Parse(qty_tx.Text);
            form.ShowDialog();
        }
    }
}
