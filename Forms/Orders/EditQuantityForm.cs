using SalesPro.Helpers;
using SalesPro.Services;
using System;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class EditQuantityForm : Form
    {
        private readonly OrderForm _orderForm;
        public int _orderId;
        public int _orderItemId;
        public int _rowVersion;
        private int _availableQty;

        private readonly OrderService _service;
        public EditQuantityForm(OrderForm orderForm)
        {
            InitializeComponent();
            _service = new OrderService();
            _orderForm = orderForm;
            KeyPreview = true;
        }

        private async void EditQuantityForm_Load(object sender, EventArgs e)
        {
            try
            {
                qty_tx.Select();
                var orderItem = await _service.GetOrderItemById(_orderItemId);
                if (orderItem != null)
                {
                    var inv = await _service.GetInventoryById(orderItem.InventoryId);
                    if (inv != null)
                    {
                        _availableQty = inv.QuantityOnHand;
                        availableQty_tx.Text = $"Stock : {_availableQty}";
                    }
                    product_tx.Text = orderItem.ProductName;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error edit quantity load: {ex.Message}");
            }
        }

        private async void enter_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var qty = int.Parse(qty_tx.Text);
                if (!Validators.IntValidator(qty_tx.Text, "Quantity")) return;
                if (qty > _availableQty)
                {
                    MessageHandler.ShowWarning("Quantity cannot be greater than the available stocks.");
                    return;
                }
                var updatedorder = await _service.UpdateQuantity(_orderItemId, qty, isEdit: true, _rowVersion);

                if (updatedorder.RowVersion == _rowVersion)
                {
                    // Set order control
                    _orderForm.SetOrderControls(updatedorder);
                }
                await _orderForm.LoadOrderedItems(_orderId);
                await _orderForm.ReloadRowVersion();

                Close();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error changing quantity : {ex.Message}");
            }
        }

        private void EditQuantityForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
