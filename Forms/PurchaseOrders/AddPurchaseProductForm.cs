using POS_Generic.Helpers;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Services;
using System;
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
                MessageHandler.ShowError($"Error getting product properties {ex.Message}");
                throw;
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

        private void add_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
