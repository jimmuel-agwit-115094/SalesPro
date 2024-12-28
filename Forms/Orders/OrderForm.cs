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


        public async Task LoadOrderedItemsById()
        {
            var items = await _service.LoadOrderItemsByOrderId(_orderId);
            dgItems.DataSource = items;
            DgExtensions.ConfigureDataGrid(dgItems, false, 1, notFound_lbl, "ProductName", "OrderQuantity", "Price", "TotalPrice");
            total_tx.Text = items.Sum(x => x.TotalPrice).ToString("N2");
        }


        private async Task SetCustomer(int customerId)
        {
            var customer = await _service.GetCustomerById(customerId);
            customer_tx.Text = $"{customer.FirstName} {customer.MiddleName} {customer.LastName}";
        }

        private async void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetFormSize();
                // Save order
                var orderModel = BuildOrderModel();
                var savedOrder = await _service.SaveOrder(orderModel);
                await LoadOrderedItemsById();

                // Controls
                _rowVersion = savedOrder.RowVersion;
                _orderId = savedOrder.OrderId;
                _curDate = await ClockHelper.GetServerDateTime();
                orderId_lbl.Text = _orderId.ToString();
                status_lbl.Text = savedOrder.OrderStatus.ToString();
                await SetCustomer(savedOrder.CustomerId);
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
