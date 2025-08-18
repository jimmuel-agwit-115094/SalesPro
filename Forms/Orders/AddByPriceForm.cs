using SalesPro.Constants;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class AddByPriceForm : Form
    {
        public int _inventoryId;
        private readonly OrderService _ordeService;
        private readonly ProductService _productService;
        private readonly InventoryService _inventoryService;

        private readonly AddOrderItemForm _addOrderItemForm;
        private decimal _price = 0;
        private string _unit;
        private int _quantity = 0;

        public AddByPriceForm(AddOrderItemForm addOrderItemForm)
        {
            InitializeComponent();
            _ordeService = new OrderService();
            _productService = new ProductService();
            _inventoryService = new InventoryService();
            _addOrderItemForm = addOrderItemForm;
            TextBoxHelper.FormatIntegerTextbox(amt_tx);
        }

        private async void AddByPriceForm_Load(object sender, EventArgs e)
        {
            try
            {
                amt_tx.Select();
                await SetProductsToControls();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"An error occurred while loading the form: {ex.Message}");
            }
        }

        private async Task SetProductsToControls()
        {
            var inv = await _inventoryService.GetInventoryById(_inventoryId);
            if (inv != null)
            {
                var prod = await _productService.GetProductById(inv.ProductId);
                if (prod == null)
                {
                    MessageHandler.ShowError("Product not found.");
                    return;
                }
                var unit = prod.SubUnit == SystemConstants.NotApplicable ? prod.UnitOfMeasure : prod.SubUnit;
                product_tx.Text = prod.ProductName;
                unit_tx.Text = $"{inv.QuantityOnHand} {unit}";
                _price = inv.RetailPrice;
                _unit = unit;
            }
            else
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void enter_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(amt_tx.Text))
                {
                    MessageHandler.MissingDataError("Quantity to give");
                    return;
                }
                if (_quantity <= 0)
                {
                    MessageHandler.ShowWarning("Please enter a valid positive integer for quantity.");
                    return;
                }

                var result = await _addOrderItemForm.ProcessOrderItem(Enums.OrderItemStatus.Added, _quantity);
                if (!result.IsSuccess)
                {
                    MessageHandler.ShowWarning(result.Message);
                    return;
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError("Error on adding by price enter: " + ex.Message);
            }
        }

        private void amt_tx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(amt_tx.Text, out decimal amount) && _price > 0)
                {
                    int qtyToGive = (int)(amount / _price); // Truncate to integer
                    qtyToGive_tx.Text = $"{qtyToGive.ToString()} {_unit}";
                    _quantity = qtyToGive;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError("Error on amount text change: " + ex.Message);
            }
        }
    }
}
