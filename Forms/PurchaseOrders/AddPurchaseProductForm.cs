using POS_Generic.Helpers;
using SalesPro.Constants;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Properties;
using SalesPro.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.PurchaseOrders
{
    public partial class AddPurchaseProductForm : Form
    {
        public int _poId;
        public int _poItemId;
        public int _rowVersion;
        private int _productId;
        public string _actionType;
        public decimal _totalPrice;
        private bool _isSubQty;
        private bool _isInitialized = false;

        private readonly PurchaseOrderService _service;
        private readonly ProductService _prodService;
        private readonly PurchaseOrderDetailsForm _purchaseOrderDetailsForm;
        public AddPurchaseProductForm(PurchaseOrderDetailsForm purchaseOrderDetailsForm)
        {
            InitializeComponent();
            _purchaseOrderDetailsForm = purchaseOrderDetailsForm;
            _service = new PurchaseOrderService();
            _prodService = new ProductService();
            TextBoxHelper.FormatIntegerTextbox(qty_tx);
            TextBoxHelper.FormatDecimalTextbox(supplierPrice_tx);
            TextBoxHelper.FormatDecimalTextbox(markUpPrice_tx);
        }

        private async Task LoadProducts()
        {
            using (var _context = new DatabaseContext())
            {
                var products = await _service.LoadProducts();
                dgProducts.DataSource = products;
                DgExtensions.ConfigureDataGrid(dgProducts, false, 0, notFound_lbl, "ProductName");
                dgProducts.ClearSelection();
            }
        }

        private bool IsProductSelected()
        {
            return dgProducts.SelectedRows.Count > 0 &&
                   dgProducts.SelectedRows[0].Cells["ProductId"].Value != null &&
                   int.TryParse(dgProducts.SelectedRows[0].Cells["ProductId"].Value.ToString(), out int productId) &&
                   productId > 0;
        }

        private async void AddPurchaseProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                qty_tx.Select();
                if (_actionType == Constants.SystemConstants.New)
                {
                    await LoadProducts();
                    add_btn.Text = "Add";
                    add_btn.Enabled = false;
                    delete_btn.Visible = false;
                    dgProducts.Enabled = true;
                    search_tx.ReadOnly = false;
                    productName_tx.Text = "-";
                    unitOfMeasure_tx.Text = "-";
                    subUnit_tx.Text = "-";
                    subUnitQty_tx.Text = "0";
                    supplierPrice_tx.Text = "0";
                    poPb.Image = Resources.add;
                    prodTitel_tx.Text = "Add Product";
                }
                else
                {
                    DgFormatHelper.DisableDatagrid(dgProducts);
                    search_tx.ReadOnly = true;
                    poPb.Image = Resources.edit;
                    prodTitel_tx.Text = "Edit Product";
                    var poItem = await _service.GetPurchaseOrderItemByPoItemId(_poItemId);
                    if (poItem != null)
                    {
                        productName_tx.Text = poItem.ProductName;
                        unitOfMeasure_tx.Text = poItem.UnitOfMeasure;
                        subUnit_tx.Text = poItem.SubUnit;
                        subUnitQty_tx.Text = poItem.SubQuantity.ToString();
                        qty_tx.Text = poItem.Quantity.ToString();
                        supplierPrice_tx.Text = poItem.SupplierPrice.ToString();
                        markUpPrice_tx.Text = poItem.MarkUpPrice.ToString();
                        retailPrice_tx.Text = poItem.RetailPrice.ToString();

                        _productId = poItem.ProductId;
                        // Check if sub unit is applicable
                        _isSubQty = IsSubQuantity(poItem.SubUnit, poItem.SubQuantity);
                        noProductSelectedPanel.Visible = false;
                    }
                    else
                    {
                        MessageHandler.ShowError($"Error getting purchase order item: {_poItemId} {_actionType}");
                    }
                    delete_btn.Visible = true;
                    add_btn.Text = "Update";
                   
                }
                _isInitialized = true; // Mark initialization as complete
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error add prodcut form load: {ex.Message}");
                throw;
            }

        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgProducts, search_tx);
        }

        private async Task GetPropertiesOnGrid()
        {
            if (!IsProductSelected())
            {
                productName_tx.Text = "-";
                unitOfMeasure_tx.Text = "-";
                subUnit_tx.Text = "-";
                subUnitQty_tx.Text = "0";
                supPrice_tx.Text = "0";
                retailPriceLabel.Text = "Retail Price";
                supplierPrice_tx.Text = "0";

                noProductSelectedPanel.Visible = true;
                add_btn.Enabled = false;
                return;
            }

            _productId = DgFormatHelper.GetSelectedRowId(dgProducts, "ProductId");
            var product = await _prodService.GetProductById(_productId);
            if (product != null)
            {
                productName_tx.Text = product.ProductName;
                unitOfMeasure_tx.Text = product.UnitOfMeasure;
                subUnit_tx.Text = product.SubUnit;
                subUnitQty_tx.Text = product.SubQuantity.ToString();
                supPrice_tx.Text = _service.GetLatestSupplierPrice(_productId).ToString();
                _isSubQty = IsSubQuantity(product.SubUnit, product.SubQuantity);

                retailPriceLabel.Text = _isSubQty
                    ? $"Retail Price per {product.SubUnit}"
                    : $"Retail Price per {product.UnitOfMeasure}";

                noProductSelectedPanel.Visible = false;
                add_btn.Enabled = true;
            }
            else
            {
                productName_tx.Text = "-";
                unitOfMeasure_tx.Text = "-";
                subUnit_tx.Text = "-";
                subUnitQty_tx.Text = "0";
                supPrice_tx.Text = "0";
                retailPriceLabel.Text = "Retail Price";

                noProductSelectedPanel.Visible = true;
                add_btn.Enabled = false;
            }
        }

        private bool IsSubQuantity(string prodName, int quantity)
        {   
            return prodName != SystemConstants.NotApplicable && quantity > 0;
        }
        private void ComputeTotal(bool isSubQty)
        {
            try
            {
                decimal retailPrice = 0;
                if (!isSubQty)
                {
                    retailPrice = decimal.Parse(supplierPrice_tx.Text) + decimal.Parse(markUpPrice_tx.Text);
                }
                else
                {
                    decimal subQty = decimal.Parse(subUnitQty_tx.Text);
                    decimal unitMarkup = decimal.Parse(markUpPrice_tx.Text) / subQty;
                    decimal pricePerSubUnit = decimal.Parse(supplierPrice_tx.Text) / subQty;
                    retailPrice = pricePerSubUnit + unitMarkup;
                }
                retailPrice_tx.Text = retailPrice.ToString();
                _totalPrice = decimal.Parse(supplierPrice_tx.Text) * int.Parse(qty_tx.Text);
                total_tx.Text = _totalPrice.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error computing total: {ex.Message}");
            }
        }

        private async void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_actionType == SystemConstants.New)
            {
                await GetPropertiesOnGrid();
            }
        }

        private async void dgProducts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (!_isInitialized) return;
                if (_actionType == SystemConstants.New)
                {
                    await GetPropertiesOnGrid();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error getting product properties on selection changed {ex.Message}");
            }
        }

        private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void supplierPrice_tx_ValueChanged(object sender, EventArgs e)
        {
            ComputeTotal(_isSubQty);
        }

        private void markUpPrice_tx_ValueChanged(object sender, EventArgs e)
        {
            ComputeTotal(_isSubQty);
        }

        private PurchaseOrderItemModel BuildPurchaseOrderItem()
        {
            var poItem = new PurchaseOrderItemModel
            {
                PurchaseOrderId = _poId,
                ProductId = _productId,
                Quantity = int.Parse(qty_tx.Text),
                SupplierPrice = decimal.Parse(supplierPrice_tx.Text),
                MarkUpPrice = decimal.Parse(markUpPrice_tx.Text),
                RetailPrice = decimal.Parse(retailPrice_tx.Text),
                TotalPrice = decimal.Parse(supplierPrice_tx.Text) * int.Parse(qty_tx.Text)
            };
            return poItem;
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_actionType == SystemConstants.New && !IsProductSelected())
                {
                    MessageHandler.ShowWarning("Please select a product");
                    return;
                }
                if (!Validators.IntValidator(qty_tx.Text, "Quantity")) return;
                if (!Validators.AmountValidator(supplierPrice_tx.Text, "Supplier Price")) return;
                if (!Validators.AmountValidator(markUpPrice_tx.Text, "Markup Price")) return;

                // Check if product already exists in the purchase order
                var existingItems = await _service.GetPurchaseOrderItemsByPoid(_poId);
                var productExist = existingItems.Where(x => x.ProductId == _productId && x.SupplierPrice == decimal.Parse(supplierPrice_tx.Text)).FirstOrDefault();
                if (productExist != null && productExist.PurchaseOrderItemId != _poItemId)
                {
                    MessageHandler.ShowWarning($"Duplicated Entry :\nProduct: '{productName_tx.Text}' with Supplier Price : '{supplierPrice_tx.Text}' already exists in the purchase order.");
                    return;
                }
                //if (!Validators.AmountComparisonValidator(markUpPrice_tx.Text, supplierPrice_tx.Text, "Markup Price", "Supplier Price")) return;

                // Note : Logic for calculating the total is done on the data access side.
                if (_actionType == Constants.SystemConstants.New)
                {
                    var poItem = BuildPurchaseOrderItem();
                    var rowsAffected = await _service.SavePurchaseOrderItem(_poId, poItem, _rowVersion);
                    if (rowsAffected == 0)
                    {
                        _purchaseOrderDetailsForm.Close();
                    }
                }
                else
                {
                    var updatedPoItem = BuildPurchaseOrderItem();
                    var rowsAffected = await _service.UpdatePurchaseOrderItems(_poId, _poItemId, updatedPoItem, _rowVersion);
                }
                Close();
                await _purchaseOrderDetailsForm.LoadPurchaseOrderItemsByPoId();
                await _purchaseOrderDetailsForm.ReloadRowVersion();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error adding product: {ex.Message}");
                throw;
            }
        }

        private void qty_tx_ValueChanged(object sender, EventArgs e)
        {
            ComputeTotal(_isSubQty);
        }

        private async void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageHandler.ShowQuestion(Resources.ConfirmDelete, Constants.FormConstants.PurchaseOrderItem);
                {
                    await _service.DeletePurchaseOrderItem(_poId, _poItemId, _rowVersion);
                    Close();
                    await _purchaseOrderDetailsForm.LoadPurchaseOrderItemsByPoId();
                    await _purchaseOrderDetailsForm.ReloadRowVersion();
                }
            }
            catch (Exception)
            {
                MessageHandler.ShowError($"Error deleting product with Id : {_poItemId}");
                throw;
            }
        }

        private void qty_tx_TextChanged(object sender, EventArgs e)
        {
            TextBoxHelper.HandleEmptyDecimalTextbox(qty_tx);
            ComputeTotal(_isSubQty);
        }

        private void supplierPrice_tx_TextChanged(object sender, EventArgs e)
        {
            TextBoxHelper.HandleEmptyDecimalTextbox(supplierPrice_tx);
            ComputeTotal(_isSubQty);
        }

        private void markUpPrice_tx_TextChanged(object sender, EventArgs e)
        {
            TextBoxHelper.HandleEmptyDecimalTextbox(markUpPrice_tx);
            ComputeTotal(_isSubQty);
        }
    }
}

