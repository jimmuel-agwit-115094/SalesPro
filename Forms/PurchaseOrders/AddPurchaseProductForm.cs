using POS_Generic.Helpers;
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
        private bool _isProductSelected;
        public string _actionType;
        public decimal _totalPrice;

        private readonly PurchaseOrderService _service;
        private readonly PurchaseOrderDetailsForm _purchaseOrderDetailsForm;
        public AddPurchaseProductForm(PurchaseOrderDetailsForm purchaseOrderDetailsForm)
        {
            InitializeComponent();
            _purchaseOrderDetailsForm = purchaseOrderDetailsForm;
            _service = new PurchaseOrderService();
        }

        private async Task LoadProducts()
        {
            using (var _context = new DatabaseContext())
            {
                var products = await _service.LoadProducts();
                if (products != null)
                {
                    dgProducts.DataSource = products;
                    DgExtensions.ConfigureDataGrid(dgProducts, false, 0, notFound_lbl, "ProductName");
                }
            }
        }

        private async void AddPurchaseProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadProducts();
                if (_actionType == Constants.SystemConstants.New)
                {
                    add_btn.Text = "Add";
                }
                else
                {
                    var poItem = await _service.GetPurchaseOrderItemByPoItemId(_poItemId);
                    if (poItem != null)
                    {
                        qty_tx.Text = poItem.Quantity.ToString();
                        supplierPrice_tx.Text = poItem.SupplierPrice.ToString();
                        markUpPrice_tx.Text = poItem.MarkUpPrice.ToString();
                        retailPrice_tx.Text = poItem.RetailPrice.ToString();
                    }
                    else
                    {
                        MessageHandler.ShowError($"Error getting purchase order item: {_poItemId} {_actionType}");
                    }

                    add_btn.Text = "Update";
                }
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

        private void GetPropertiesOnGrid()
        {
            try
            {
                _productId = DgFormatHelper.GetSelectedRowId(dgProducts, "ProductId");
                productName_tx.Text = DgFormatHelper.GetSelectedRowString(dgProducts, "ProductName");
                unitOfMeasure_tx.Text = DgFormatHelper.GetSelectedRowString(dgProducts, "UnitOfMeasure");
                _isProductSelected = true;
            }
            catch (Exception ex)
            {
                _isProductSelected = false;
                MessageHandler.ShowError($"Error getting product properties {ex.Message}");
            }
        }

        private void ComputeTotal()
        {
            var retailPrice = decimal.Parse(supplierPrice_tx.Text) + decimal.Parse(markUpPrice_tx.Text);
            retailPrice_tx.Text = retailPrice.ToString();
            _totalPrice = decimal.Parse(supplierPrice_tx.Text) * int.Parse(qty_tx.Text);
            total_tx.Text = _totalPrice.ToString("N2");
        }

        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetPropertiesOnGrid();
        }

        private void dgProducts_SelectionChanged(object sender, EventArgs e)
        {
            GetPropertiesOnGrid();
        }

        private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void supplierPrice_tx_ValueChanged(object sender, EventArgs e)
        {
            ComputeTotal();
        }

        private void markUpPrice_tx_ValueChanged(object sender, EventArgs e)
        {
            ComputeTotal();
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

        private PurchaseOrderModel BuildPurchaseOrder(int supplierId)
        {
            var poItem = new PurchaseOrderModel
            {
                PurchaseOrderId = _poId,
                SupplierId = supplierId,
                UserId = UserSession.Session_UserId,
            };
            return poItem;
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if (!_isProductSelected)
            {
                MessageHandler.ShowError("Please select a product");
                return;
            }
            if (!Validators.IntValidator(qty_tx.Text, "Quantity")) return;
            if (!Validators.AmountValidator(supplierPrice_tx.Text, "Supplier Price")) return;
            if (!Validators.AmountValidator(markUpPrice_tx.Text, "Markup Price")) return;
            if (!Validators.AmountComparisonValidator(markUpPrice_tx.Text, supplierPrice_tx.Text, "Markup Price", "Supplier Price")) return;

            try
            {
                // Note : Logic for calculating the total is done on the data access side.
                if (_actionType == Constants.SystemConstants.New)
                {
                    var poItem = BuildPurchaseOrderItem();
                    var success = await _service.SavePurchaseOrderItem(_poId, poItem, _rowVersion);
                    if (!success)
                    {
                        _purchaseOrderDetailsForm.Close();
                    }
                }
                else
                {
                    var updatedPoItem = BuildPurchaseOrderItem();
                    var success = await _service.UpdatePurchaseOrderItems(_poId, _poItemId, updatedPoItem, _rowVersion);
                    if (!success)
                    {
                        _purchaseOrderDetailsForm.Close();
                    }
                }
                Close();
                await _purchaseOrderDetailsForm.LoadPurchaseOrderItemsByPoId();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error adding product: {ex.Message}");
                throw;
            }
        }

        private void qty_tx_ValueChanged(object sender, EventArgs e)
        {
            ComputeTotal();
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
                }
            }
            catch (Exception)
            {
                MessageHandler.ShowError($"Error deleting product with Id : {_poItemId}");
                throw;
            }
        }
    }
}

