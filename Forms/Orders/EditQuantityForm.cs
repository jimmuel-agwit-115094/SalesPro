using SalesPro.Helpers;
using SalesPro.Services;
using System;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class EditQuantityForm : Form
    {
        public int _orderItemId;
        public int _rowVersion;

        private readonly OrderService _service;
        public EditQuantityForm()
        {
            InitializeComponent();
            _service = new OrderService();
        }

        private async void EditQuantityForm_Load(object sender, EventArgs e)
        {
            try
            {
                var orderItem = await _service.GetOrderItemById(_orderItemId);
                if (orderItem != null)
                {
                    var inv = await _service.GetInventoryById(orderItem.InventoryId);
                    if (inv != null)
                    {
                        availableQty_tx.Text = $"Available Quantity : {inv.QuantityOnHand.ToString()}";
                    }
                    product_tx.Text = orderItem.ProductName;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error edit quantity load: {ex.Message}");
            }
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
