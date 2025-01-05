using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class AddOrderItemForm : Form
    {
        public int _inventoryId;
        public int _rowVersion;
        public int _orderId;
        public int _quantity;
        public OrderAction _orderAction;

        private readonly OrderService _service;
        private readonly OrderForm _orderForm;
        public AddOrderItemForm(OrderForm orderForm)
        {
            InitializeComponent();
            _service = new OrderService();
            _orderForm = orderForm;
            KeyPreview = true;
        }

        private async void AddOrderItemForm_Load(object sender, EventArgs e)
        {
            try
            {
                var prods = await _service.LoadProductsFromInventory();
                dgProduct.DataSource = prods;
                DgExtensions.ConfigureDataGrid(dgProduct, false, 1, notFound_lbl, "ProductName", "QuantityOnHand", "RetailPrice");

                if (_orderAction == OrderAction.New)
                {
                    title_lbl.Text = "Add Item";
                    title_lbl.ForeColor = Color.Black;
                    return_pb.Visible = false;
                }
                else
                {
                    title_lbl.Text = "Return Item";
                    title_lbl.ForeColor = Color.Red;
                    return_pb.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error add order item form load : {ex}");
            }
        }

        private async Task AddOrderItem()
        {
            if (_orderAction == OrderAction.New)
            {
                await ProcessOrderItem(OrderItemStatus.Added);
            }
            else
            {
                await ProcessOrderItem(OrderItemStatus.Returned);
            }
        }

        private void dgProduct_SelectionChanged(object sender, EventArgs e)
        {
            _inventoryId = DgFormatHelper.GetSelectedIdOnSelectionChange(dgProduct, "InventoryId");
            if (_inventoryId == 0) return;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async Task ProcessOrderItem(OrderItemStatus itemStatus)
        {
            var prodInventory = await _service.GetInventoryById(_inventoryId);
            if (prodInventory == null)
            {
                MessageHandler.ShowWarning("Product not found on inventory.");
                return;
            }

            if (itemStatus == OrderItemStatus.Added && _quantity > prodInventory.QuantityOnHand)
            {
                MessageHandler.ShowWarning("Quantity is greater than the available stock.");
                return;
            }

            // Check if product is out of stock when already added item
            var existingOrderItem = await _service.GetExistingOrderItem(_inventoryId, _orderId);
            if (existingOrderItem != null)
            {
                if (itemStatus == OrderItemStatus.Added && existingOrderItem.OrderQuantity >= prodInventory.QuantityOnHand)
                {
                    MessageHandler.ShowWarning("The product is out of stock.");
                    return;
                }

                // to absolut quantity
                int absQuantity = Math.Abs(existingOrderItem.OrderQuantity);
                if (existingOrderItem.InventoryId == prodInventory.InventoryId
                    && _quantity == absQuantity
                    && existingOrderItem.ProductId == prodInventory.ProductId
                    && itemStatus != existingOrderItem.OrderItemStatus)
                {
                    MessageHandler.ShowWarning("You cannot add and return the same quantity of a product, as it results in a zero quantity. Please adjust the quantity to keep the order valid.");
                    return;
                }
            }

            // Assess if item is for addition or returned
            int newQuantity = itemStatus == OrderItemStatus.Added ? _quantity : -_quantity;

            // Save order item
            var orderItem = new OrderItemModel
            {
                OrderId = _orderId,
                InventoryId = _inventoryId,
                ProductId = prodInventory.ProductId,
                OrderQuantity = newQuantity,
                Price = prodInventory.RetailPrice,
                TotalPrice = newQuantity * prodInventory.RetailPrice,
                OrderItemStatus = itemStatus,
            };

            var savedOrder = await _service.SaveOrderItem(_orderId, _inventoryId, itemStatus, orderItem, _rowVersion);

            // Set controls
            _orderForm.vatRate_tx.Text = savedOrder.Vat.ToString();
            _orderForm.vat_tx.Text = savedOrder.VatAmount.ToString();
            _orderForm.net_tx.Text = savedOrder.NetAmount.ToString();
            _orderForm.gross_tx.Text = savedOrder.Total.ToString();
            _orderForm.discount_tx.Text = savedOrder.DiscountAmount.ToString();
            _orderForm.amountPaid_tx.Text = savedOrder.AmountPaid.ToString();

            //Load ordered items
            await _orderForm.LoadOrderedItems(_orderId);
            await _orderForm.ReloadRowVersion();
            _orderForm.qty_tx.Value = 1;
            Close();
        }

        private async void dgProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    await AddOrderItem();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error adding order item : {ex}");
            }
        }

        private void search_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgProduct, search_tx);
        }

        private async void dgProduct_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    await AddOrderItem();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error adding order item  via enter key press: {ex}");
            }

        }

        private void AddOrderItemForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void dgProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgProduct.Columns[e.ColumnIndex].Name == "QuantityOnHand") // Replace with your column name
            {
                // Ensure the value is not null and is numeric
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal quantityOnHand))
                {
                    if (quantityOnHand == 0) // Check if the value is negative
                    {
                        e.CellStyle.ForeColor = Color.Red; // Set text color to red
                        e.CellStyle.SelectionForeColor = Color.Red; // Set selection text color to red
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.Black; // Default color for zero or other values
                        e.CellStyle.SelectionForeColor = Color.Black;
                    }
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black; // Default color for non-numeric or null values
                    e.CellStyle.SelectionForeColor = Color.Black;
                }
            }
        }
    }
}