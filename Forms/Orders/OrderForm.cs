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
        private int _orderItemId;

        private readonly OrderService _service;
        public OrderForm()
        {
            InitializeComponent();
            _service = new OrderService();
            KeyPreview = true;
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

        public async Task ReloadRowVersion()
        {
            _rowVersion = await _service.GetRowVersion(_orderId);
        }

        public async Task LoadOrderedItemsById()
        {
            var items = await _service.LoadOrderItemsByOrderId(_orderId);
            dgItems.DataSource = items;
            DgExtensions.ConfigureDataGrid(dgItems, false, 1, notFound_lbl, "ProductName", "OrderQuantity", "Price", "TotalPrice", "UnitOfMeasure");
            total_tx.Text = items.Sum(x => x.TotalPrice).ToString("N2");
        }

        private async Task SetCustomer(int customerId)
        {
            var customer = await _service.GetCustomerById(customerId);
            if (customer != null)
                customer_tx.Text = $"{customer.FirstName} {customer.MiddleName} {customer.LastName}";
        }

        private async void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetFormSize();
                _curDate = await ClockHelper.GetServerDateTime();

                var latestOrder = await _service.GetLatestOrder();

                if (latestOrder != null && latestOrder.Total == 0)
                {
                    await InitializeOrderDisplay(latestOrder);
                }
                else
                {
                    var newOrder = BuildOrderModel();
                    var savedOrder = await _service.SaveOrder(newOrder);
                    await InitializeOrderDisplay(savedOrder);
                }

            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error order form load : {ex}");
            }
        }

        private async Task InitializeOrderDisplay(OrderModel order)
        {
            await LoadOrderedItemsById();

            // Update state variables
            _rowVersion = order.RowVersion;
            _orderId = order.OrderId;

            // Update UI controls
            orderId_lbl.Text = _orderId.ToString("D10");
            status_lbl.Text = order.OrderStatus.ToString();

            await SetCustomer(order.CustomerId);
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
            try
            {
                var form = new AddOrderItemForm(this);
                form._orderId = _orderId;
                form._rowVersion = _rowVersion;
                form._quantity = int.Parse(qty_tx.Text);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error add order button click : {ex}");
            }
        }

        private void OrderForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F1:
                    add_btn.PerformClick();
                    break;
                case Keys.F2:
                    edit_btn.PerformClick();
                    break;
                case Keys.F3:
                    delete_btn.PerformClick();
                    break;
                case Keys.F4:
                    priceInquiry_btn.PerformClick();
                    break;
                case Keys.F5:
                    suspend_btn.PerformClick();
                    break;
                case Keys.F6:
                    resume_btn.PerformClick();
                    break;
                case Keys.F7:
                    returnProduct_btn.PerformClick();
                    break;
                case Keys.Delete:
                    cancel_btn.PerformClick();
                    break;
                case Keys.F8:
                    addCustomer_btn.PerformClick();
                    break;
                case Keys.F9:
                    orderList_btn.PerformClick();
                    break;
                case Keys.F10:
                    pay_btn.PerformClick();
                    break;
                case Keys.F11:
                    charge_btn.PerformClick();
                    break;
            }
        }

        private void total_tx_TextChanged(object sender, EventArgs e)
        {
            total_tx.ForeColor = decimal.Parse(total_tx.Text) < 0 ? Color.Yellow : Color.White;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (dgItems.SelectedRows.Count != 0)
            {
                var form = new EditQuantityForm(this);
                form._orderItemId = _orderItemId;
                form._rowVersion = _rowVersion;
                form.ShowDialog();
            }
        }

        private void dgItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgItems_SelectionChanged(object sender, EventArgs e)
        {
            _orderItemId = DgFormatHelper.GetSelectedIdOnSelectionChange(dgItems, "OrderItemId");
            if (_orderItemId == 0) return;
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            if (dgItems.SelectedRows.Count != 0)
            {
                var form = new Pay();
                form._orderId = _orderId;
                form._rowVersion = _rowVersion;
                form.ShowDialog();
            }

        }
    }
}
