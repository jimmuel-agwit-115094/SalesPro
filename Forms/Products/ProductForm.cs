using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Products
{
    public partial class ProductForm : Form
    {
        private readonly ProductService _service;
        public ProductForm()
        {
            InitializeComponent();
            _service = new ProductService();
        }

        public async Task LoadProducts()
        {
            var products = await _service.GetAllProducts();
            dgProduct.DataSource = products;
            DgExtensions.ConfigureDataGrid(dgProduct, true, 0, notFound_lbl, "ProductId", "ProductName",
                "UnitOfMeasure","SubUnit", "Description", "ReorderLevel");
        }

        private async void ProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadProducts();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading product form: , {ex.Message}");
            }
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgProduct, search_tx);
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            var form = new ManageProductForm(this);
            form._actionType = Constants.SystemConstants.New;
            form.ShowDialog();
        }

        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int productId = DgFormatHelper.GetSelectedId(dgProduct, e, "ProductId");
            if (productId == 0) return;
            var form = new ManageProductForm(this);
            form._productId = productId;
            form._actionType = Constants.SystemConstants.Edit;
            form.ShowDialog();
        }
    }
}
