using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Collections.Generic;
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
                await LoadProducts(SearchByAction.AllProducts);

                if (_orderAction == OrderAction.New)
                {
                    title_lbl.Text = "Add Item";
                    title_lbl.ForeColor = Color.Black;
                    return_pb.Visible = false;
                }
                else if (_orderAction == OrderAction.Return)
                {
                    title_lbl.Text = "Return Item";
                    title_lbl.ForeColor = Color.Red;
                    return_pb.Visible = true;
                }
                else
                {
                    title_lbl.Text = "Price Inquiry";
                    title_lbl.ForeColor = Color.Black;
                    return_pb.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error add order item form load : {ex}");
            }
        }

        private async Task LoadProducts(SearchByAction action)
        {
            var products = new List<InventoryModelExtended>();
            if (action == SearchByAction.Barcode)
            {
                products = await _service.LoadProductsFromInventory(barcode: search_tx.Text);
            }
            else if (action == SearchByAction.ProductName)
            {
                products = await _service.LoadProductsFromInventory(productName: search_tx.Text);
            }
            else
            {
                products = await _service.LoadProductsFromInventory();
            }

            dgProduct.DataSource = products;
            DgExtensions.ConfigureDataGrid(dgProduct, false, 1, notFound_lbl, "ProductName", "QuantityOnHand", "RetailPrice");
        }

        private async Task AddOrderItem()
        {
            if (_orderAction == OrderAction.New)
            {
                await ProcessOrderItem(OrderItemStatus.Added);
            }
            else if (_orderAction == OrderAction.Return)
            {
                await ProcessOrderItem(OrderItemStatus.Returned);
            }
        }

        private void dgProduct_SelectionChanged(object sender, EventArgs e)
        {
            _inventoryId = DgFormatHelper.GetSelectedIdOnSelectionChange(dgProduct, "InventoryId");
            if (_inventoryId == 0) return;
        }

        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async Task ProcessOrderItem(OrderItemStatus itemStatus)
        {
            try
            {
                if (Convert.ToInt32(_quantity) <= 0)
                {
                    MessageHandler.ShowWarning("Quantity cannot be 0");
                    return;
                }

                var savedOrder = await _service.ProcessOrderItem(itemStatus, _inventoryId, _orderId, _quantity, _rowVersion);
                // Set order controls
                _orderForm.SetOrderControls(savedOrder.OrderModel);

                //Load ordered items
                await _orderForm.LoadOrderedItems(_orderId);
                await _orderForm.ReloadRowVersion();
                _orderForm.qty_tx.Text = "1";
                _orderForm.dgItems.Select();
                if (savedOrder.SuccessResult > 0)
                {
                    Close();
                }
            }
            catch (InvalidOperationException inEx)
            {
                MessageHandler.ShowWarning($"Validation error: \n {inEx.Message}");
            }
            catch (NullReferenceException nullEx)
            {
                MessageHandler.ShowWarning($"Not Found: \n {nullEx.Message}");
            }
            catch (Exception ex)
            {
                MessageHandler.ShowWarning($"Validation error: \n {ex.Message}");
            }
        }

        private async void dgProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            await AddOrderItem();
        }

        private async void search_tx_TextChanged(object sender, EventArgs e)
        {
            if (search_tx.Text == string.Empty)
            {
                await LoadProducts(SearchByAction.AllProducts);
            }
        }

        private async void dgProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && _orderAction != OrderAction.Inquiry)
            {
                e.Handled = true;
                await AddOrderItem();
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
            if (e.CellStyle.Font != null)
            {
                e.CellStyle.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            }

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

        private void search_tx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_btn.PerformClick();
                if (dgProduct.Rows.Count > 0)
                {
                    dgProduct.Focus();
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                dgProduct.Focus();
            }
        }

        private async void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchByCode_cb.Checked == true)
                {
                    await LoadProducts(SearchByAction.Barcode);
                }
                else
                {
                    await LoadProducts(SearchByAction.ProductName);
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on search button click: {ex}");
            }
        }
    }
}