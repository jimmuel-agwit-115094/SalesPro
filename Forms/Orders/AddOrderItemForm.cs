using SalesPro.Helpers;
using SalesPro.Services;
using System;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class AddOrderItemForm : Form
    {
        public int _rowVersion;
        public int _orderId;

        private readonly OrderService _service;
        public AddOrderItemForm()
        {
            InitializeComponent();
            _service = new OrderService();
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
    }
}
