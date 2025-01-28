using Org.BouncyCastle.Asn1.X509;
using Renci.SshNet.Common;
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
    public partial class OrderForm : Form
    {
        private DateTime _curDate;
        private int _rowVersion;
        private int _orderId;
        private int _orderItemId;
        private decimal _totalPrice = 0;
        private int _quantity = 1;
        private string _barcode;
        private bool _isReturn = false;

        private readonly OrderService _service;
        public OrderForm()
        {
            InitializeComponent();
            _service = new OrderService();
            KeyPreview = true;
            KeyDown += OrderForm_KeyDown;
            TextBoxHelper.FormatBarcode(barcode_tx);
        }

        private OrderModel BuildOrderModel()
        {
            return new OrderModel
            {
                TransactionId = TransactionSession._transactionId,
                UserId = UserSession.Session_UserId,
                CustomerId = 1,
                DateTaken = _curDate,
                Total = 0,
                DiscountRate = 0,
                DiscountAmount = 0,
                Vat = 12,
                VatAmount = 0,
                NetAmount = 0,
                AmountDue = 0,
                GrossAmount = 0,
                AmountPaid = 0,
                Change = 0,
                PaymentStatus = PaymentStatus.Unpaid,
                IsCredited = false,
                OrderStatus = OrderStatus.Active,
                PaymentMethod = PaymentMethod.NotSet,
                DatePaid = _curDate.Date,
            };
        }

        public async Task ReloadRowVersion()
        {
            _rowVersion = await _service.GetRowVersion(_orderId);
        }

        public async Task LoadOrderedItems(int orderId, List<OrderItemModelExtended> invalidOrders = null)
        {
            var items = await _service.LoadOrderItemsByOrderId(orderId);
            dgItems.DataSource = items;

            DgExtensions.ConfigureDataGrid(dgItems, false, 1, notFound_lbl, "ProductName", "OrderQuantity", "Price", "TotalPrice", "UnitOfMeasure");

            _totalPrice = items.Sum(x => x.TotalPrice);
            total_tx.Text = items.Sum(x => x.TotalPrice).ToString("N2");

            if (invalidOrders != null)
            {
                foreach (DataGridViewRow row in dgItems.Rows)
                {
                    var itemId = (int)row.Cells["OrderItemId"].Value;
                    if (invalidOrders.Any(order => order.OrderItemId == itemId))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red; // Change text color to red
                        row.DefaultCellStyle.SelectionForeColor = Color.Red;
                    }
                }
            }
        }

        private async Task SetCustomer(int customerId)
        {
            var customer = await _service.GetCustomerById(customerId);
            if (customer != null)
                customer_tx.Text = $"{customer.FirstName} {customer.MiddleName} {customer.LastName}";
        }

        public async Task InitializeOrCreateOrder()
        {
            var latestOrder = await _service.GetLatestOrder();
            if (latestOrder != null && latestOrder.Total == 0)
            {
                await InitializeOrderDisplay(latestOrder);
            }
            else
            {
                await CreateNewOrder();
            }
        }

        private async void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                barcode_tx.Select();
                SetFormSize();
                _curDate = await ClockHelper.GetServerDateTime();

                await InitializeOrCreateOrder();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error order form load : {ex}");
            }
        }

        public async Task CreateNewOrder()
        {
            var newOrder = BuildOrderModel();
            var savedOrder = await _service.SaveOrder(newOrder);
            await InitializeOrderDisplay(savedOrder);
        }

        public void SetOrderControls(OrderModel order)
        {
            if (order != null)
            {
                vatRate_tx.Text = order.Vat.ToString();
                vat_tx.Text = order.VatAmount.ToString();
                net_tx.Text = order.NetAmount.ToString();
                gross_tx.Text = order.Total.ToString();
                discount_tx.Text = order.DiscountAmount.ToString();
                amountPaid_tx.Text = order.AmountPaid.ToString();
            }
        }

        public async Task InitializeOrderDisplay(OrderModel order)
        {
            await LoadOrderedItems(order.OrderId);

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
            var orderAction = _isReturn ? OrderAction.Return : OrderAction.New;
            ShowOrderItemForm(orderAction);
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
                    orderList_btn.PerformClick();
                    break;
                case Keys.F7:
                    addCustomer_btn.PerformClick();
                    break;
                case Keys.F8:
                    allOrders_btn.PerformClick();
                    break;
                case Keys.F9:
                    pay_btn.PerformClick();
                    break;
                case Keys.F10:
                    charge_btn.PerformClick();
                    break;
                case Keys.F11:
                    cancel_btn.PerformClick();
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
                form._orderId = _orderId;
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
                var form = new PaymentForm(this);
                form._orderId = _orderId;
                form._rowVersion = _rowVersion;
                form.ShowDialog();
            }
        }

        private async void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgItems.SelectedRows.Count > 0)
                {
                    if (MessageHandler.ShowQuestionGeneric("Delete Order?"))
                    {
                        await _service.DeleteOrderItem(_orderItemId, _rowVersion);
                        await LoadOrderedItems(_orderId);
                        SetOrderControls(await _service.GetOrderById(_orderId));
                        await ReloadRowVersion();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error delete button click : {ex.Message}");
            }
        }

        private async void suspend_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgItems.SelectedRows.Count != 0)
                {
                    if (MessageHandler.ShowQuestionGeneric("Suspend Order?"))
                    {
                        await _service.ChangeOrderStatus(_orderId, OrderStatus.Suspended, _rowVersion);
                        await CreateNewOrder();
                        await LoadOrderedItems(_orderId);
                        await ReloadRowVersion();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error suspending order: {ex.Message}");
            }
        }

        private void orderList_btn_Click_1(object sender, EventArgs e)
        {
            var form = new OrderListForm(this);
            form.title_lbl.Text = "Suspended Order Lists";
            form._action = Constants.FormConstants.ResumeOrder;
            form._orderStatus = OrderStatus.Suspended;
            form._orderId = _orderId;
            form._rowVersion = _rowVersion;
            form.ShowDialog();
        }

        private void ShowOrderItemForm(OrderAction orderAction)
        {
            try
            {
                var form = new AddOrderItemForm(this);

                form._orderId = _orderId;
                form._rowVersion = _rowVersion;
                form._quantity = _quantity;
                form._orderAction = orderAction;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error add order item form load:  {ex.Message}");
            }
        }


        private void addCustomer_btn_Click(object sender, EventArgs e)
        {
            var form = new AddCustomerForm(this);
            form._orderId = _orderId;
            form._rowVersion = _rowVersion;
            form.ShowDialog();
        }

        private void charge_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgItems.Rows.Count > 0)
                {
                    if (customer_tx.Text == "Generic Walkin Customer")
                    {
                        MessageHandler.ShowWarning("Cannot proceed charging order. Please select a valid customer.");
                        return;
                    }

                    if (_totalPrice < 0)
                    {
                        MessageHandler.ShowWarning("Cannot charge an order that is negative total.");
                        return;
                    }
                    var form = new ChargeOrderForm(this);
                    form._action = Constants.SystemConstants.New.ToString();
                    form._orderId = _orderId;
                    form._rowVersion = _rowVersion;
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error charge click: {ex.Message}");
            }
        }

        private void allOrders_btn_Click(object sender, EventArgs e)
        {
            var form = new OrderListForm(this);
            form.title_lbl.Text = "All Orders";
            form._orderStatus = OrderStatus.Active;
            form._action = Constants.FormConstants.OrderLists;
            form._rowVersion = _rowVersion;
            form.ShowDialog();
        }

        private void dgItems_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Specify the column name to check
            if (e.CellStyle.Font != null)
            {
                e.CellStyle.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            }
            string targetColumnName = "TotalPrice";  // Replace "Amount" with your column name

            if (dgItems.Columns[e.ColumnIndex].Name == targetColumnName && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal cellValue) && cellValue < 0)
                {
                    // Change ForeColor to red for negative values
                    e.CellStyle.ForeColor = Color.Red;

                    // Change SelectionForeColor to red for negative values
                    e.CellStyle.SelectionForeColor = Color.Red;
                }
                else
                {
                    // Reset to default colors for non-negative values
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.SelectionForeColor = Color.Black;
                }
            }
        }

        private async void cancel_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgItems.Rows.Count == 0)
                {
                    MessageHandler.ShowWarning("Cannot cancel order. Order is empty.");
                    return;
                }
                if (MessageHandler.ShowQuestionGeneric("Cancel Order?"))
                {
                    await _service.ChangeOrderStatus(_orderId, OrderStatus.Cancelled, _rowVersion);

                    await InitializeOrCreateOrder();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on cancel button click : {ex.Message}");
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void priceInquiry_btn_Click(object sender, EventArgs e)
        {
            var form = new AddOrderItemForm(this);
            form._orderAction = OrderAction.Inquiry;
            form.ShowDialog();
        }

        private void barcode_tx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Initialize defaults
                string text = barcode_tx.Text?.Trim() ?? string.Empty;
                int qty = 1; // Default quantity
                string bcode = null; // Default barcode (null if none)

                if (!string.IsNullOrWhiteSpace(text))
                {
                    if (text.Contains("@"))
                    {
                        // Split the input on '@'
                        string[] parts = text.Split('@');

                        // Handle the quantity part (before '@')
                        if (!string.IsNullOrWhiteSpace(parts[0]) && int.TryParse(parts[0], out int parsedQty))
                        {
                            qty = parsedQty; // Use parsed quantity if valid
                        }

                        // Handle the serial part (after '@')
                        if (parts.Length > 1 && !string.IsNullOrWhiteSpace(parts[1]))
                        {
                            bcode = parts[1].Trim(); // Trim and set serial
                        }
                    }
                    else
                    {
                        // No '@' present, treat the entire input as serial
                        bcode = text;
                    }
                }

                // Assign results to class-level variables
                _quantity = qty;
                _barcode = bcode ?? string.Empty;

            }
            catch (Exception ex)
            {
                // Log or display a detailed error message
                MessageHandler.ShowError($"An error occurred: {ex.Message}\nInput: {barcode_tx.Text}");
            }
        }

        private async Task ProcessOrderItem(string barcode, int qty, bool isReturn)
        {
            var orderStatus = isReturn ? OrderItemStatus.Returned : OrderItemStatus.Added;
            var invetoryId = await _service.GetInventoryIdByBarCode(barcode);
            if (invetoryId == 0)
            {
                MessageHandler.ShowWarning("Product not found.");
                return;
            }
            var savedOrder = await _service.ProcessOrderItem(orderStatus, invetoryId, _orderId, qty, _rowVersion);
            // Set order controls
            SetOrderControls(savedOrder.OrderModel);

            //Load ordered items
            await LoadOrderedItems(_orderId);
            await ReloadRowVersion();
            dgItems.Select();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F12) // Check if F12 key is pressed
            {
                _isReturn = !_isReturn; // Toggle the state
                order_lbl.Text = _isReturn ? "RETURN" : "SALES"; // Update the status label
                order_lbl.ForeColor = _isReturn ? Color.Yellow : Color.White; // Change the color of the order ID label
                return true; // Mark the key press as handled
            }

            if (!barcode_tx.Focused)
            {
                barcode_tx.Focus(); // Focus the textbox

                // Check if the key is a digit or a letter, then send the correct character
                if (keyData >= Keys.D0 && keyData <= Keys.D9) // For digits 0-9
                {
                    SendKeys.Send((keyData - Keys.D0).ToString()); // Send the numeric character
                }
                else if (keyData >= Keys.NumPad0 && keyData <= Keys.NumPad9) // For NumPad digits
                {
                    SendKeys.Send((keyData - Keys.NumPad0).ToString());
                }
                else if (keyData >= Keys.A && keyData <= Keys.Z) // For letters A-Z
                {
                    SendKeys.Send(keyData.ToString()); // Send the letter
                }

                return true; // Mark the key press as handled
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void barcode_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is '@'
            if (e.KeyChar == '@')
            {
                // Get the current text in the TextBox
                string currentText = barcode_tx.Text;

                // Check if there is a number before '@'
                if (string.IsNullOrEmpty(currentText) || !currentText.Any(char.IsDigit))
                {
                    // If no number before '@', cancel the key press
                    e.Handled = true;
                }
            }
        }

        private async void barcode_tx_KeyDown(object sender, KeyEventArgs e)
        {
            bool isProcessing = false;
            if (e.KeyCode == Keys.Enter && !isProcessing)
            {
                try
                {
                    // Set the flag to true to prevent multiple triggers
                    isProcessing = true;

                    // Process the order item asynchronously
                    await ProcessOrderItem(_barcode, _quantity, _isReturn);
                    barcode_tx.Clear();
                    barcode_tx.Select();
                }
                catch (Exception ex)
                {
                    MessageHandler.ShowError(ex.Message);
                }
                finally
                {
                    // Reset the flag to allow further processing
                    isProcessing = false;
                }
            }
        }

        private void OrderForm_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
