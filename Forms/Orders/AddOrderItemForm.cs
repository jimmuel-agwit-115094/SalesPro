using SalesPro.Helpers;
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

        private void dgProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
