using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
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

        private async void dgProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var prodInventory = await _service.GetInventoryById(_inventoryId);
                var orderItem = new OrderItemModel
                {
                    OrderId = _orderId,
                    InventoryId = _inventoryId,
                    ProductId = prodInventory.ProductId,
                    OrderQuantity = _quantity,
                    Price = prodInventory.RetailPrice,
                    TotalPrice = _quantity * prodInventory.RetailPrice,
                    OrderItemStatus = OrderItemStatus.Added,
                };
                var savedOrder = await _service.SaveItemAndUpdateOrder(_orderId, OrderItemStatus.Added, orderItem);
                _orderForm.
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error adding order item : {ex}");
            }
        }
    }
}
