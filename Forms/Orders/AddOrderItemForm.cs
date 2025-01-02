using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
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

        private readonly OrderService _service;
        private readonly OrderForm _orderForm;
        public AddOrderItemForm(OrderForm orderForm)
        {
            InitializeComponent();
            _service = new OrderService();
            _orderForm = orderForm;
        }

        private async void AddOrderItemForm_Load(object sender, EventArgs e)
        {
            try
            {
                var prods = await _service.LoadProductsFromInventory();
                dgProduct.DataSource = prods;
                DgExtensions.ConfigureDataGrid(dgProduct, false, 1, notFound_lbl, "ProductName", "QuantityOnHand", "RetailPrice");
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error add order item form load : {ex}");
            }
        }

        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgProduct_SelectionChanged(object sender, EventArgs e)
        {
            _inventoryId = DgFormatHelper.GetSelectedIdOnSelectionChange(dgProduct, "InventoryId");
            if (_inventoryId == 0) return;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private async Task ProcessOrderItem(OrderItemStatus itemStatus)
        {
            var prodInventory = await _service.GetInventoryById(_inventoryId);
            if (prodInventory == null)
            {
                MessageHandler.ShowError("Product not found on inventory.");
                return;
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

            var savedOrder = await _service.SaveItemAndUpdateOrder(_orderId, _inventoryId, itemStatus, orderItem, _rowVersion);

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
            Close();
        }

        private async void dgProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                await ProcessOrderItem(OrderItemStatus.Added);
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
                    await ProcessOrderItem(OrderItemStatus.Added);
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error adding order item  via enter key press: {ex}");
            }

        }
    }
}
