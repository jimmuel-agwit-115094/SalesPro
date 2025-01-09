using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private async void ProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                var products = await _service.GetAllProducts();
                dgProduct.DataSource = products;
                DgExtensions.ConfigureDataGrid(dgProduct, true, 0, notFound_lbl,"ProductId", "ProductName",
                    "UnitOfMeasure", "Description", "ReorderLevel");
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
    }
}
