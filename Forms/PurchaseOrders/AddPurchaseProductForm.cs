using POS_Generic.Helpers;
using SalesPro.Enums;
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
        public int _rowVersion;
        private int _productId;
        private bool _isProductSelected;
        private readonly PurchaseOrderDetailsForm _purchaseOrderDetailsForm;
        private readonly DatabaseContext _context;
        private readonly PurchaseOrderService _service;
        public AddPurchaseProductForm(PurchaseOrderDetailsForm purchaseOrderDetailsForm)
        {
            InitializeComponent();
            _purchaseOrderDetailsForm = purchaseOrderDetailsForm;
            _context = new DatabaseContext();
            _service = new PurchaseOrderService(_context);
        }

        private async Task LoadProducts()
        {
            var products = await _service.LoadProducts();
            if (products != null)
            {
                dgProducts.DataSource = products;
                DgExtensions.ConfigureDataGrid(dgProducts, false, 0, notFound_lbl, "ProductName");
            }
        }

        private async void AddPurchaseProductForm_Load(object sender, EventArgs e)
        {
            await LoadProducts();
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

        // build purchase order item model
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

        private async Task SavePurchaseOrderAndUpdatePo()
        {
            var poItem = BuildPurchaseOrderItem();
            await _service.SavePurchaseOrderItem(poItem);

            // We are calling this method to get the total price of the purchase order
            var poItems = await _service.LoadPurchaseOrderItemsByPoId(_poId);
            decimal poTotal = poItems.Sum(x => x.TotalPrice);
            await _service.UpdatePurchaseOrder_PoTotal(_poId, _rowVersion, poTotal);
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if(!_isProductSelected)
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
                await SavePurchaseOrderAndUpdatePo();
                await _purchaseOrderDetailsForm.LoadPurchaseOrderItemsByPoId();
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

