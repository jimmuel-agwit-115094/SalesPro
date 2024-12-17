using POS_Generic.Helpers;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
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
            await LoadProducts();
            if (_actionType == Constants.SystemConstants.Edit)
            {
                var poItem = await _service.GetPurchaseOrderItemByPoItemId(_poItemId);
                NullCheckerHelper.NullChecker(poItem);
                qty_tx.Text = poItem.Quantity.ToString();
                supplierPrice_tx.Text = poItem.SupplierPrice.ToString();
                markUpPrice_tx.Text = poItem.MarkUpPrice.ToString();
                retailPrice_tx.Text = poItem.RetailPrice.ToString();
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
                TotalPrice = decimal.Parse(retailPrice_tx.Text) + decimal.Parse(markUpPrice_tx.Text)
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
                var poItem = BuildPurchaseOrderItem();
                decimal total = (await _service.GetPurchaseOrderItemsByPoid(_poId)).Sum(x => x.TotalPrice) + decimal.Parse(retailPrice_tx.Text);
                var success = await _service.SavePurchaseOrderItem(_poId, total, poItem, _rowVersion);
                await _purchaseOrderDetailsForm.LoadPurchaseOrderItemsByPoId();
                if (!success)
                {
                    _purchaseOrderDetailsForm.Close();
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error adding product: {ex.Message}");
                throw;
            }
        }
    }
}

