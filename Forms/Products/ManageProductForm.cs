using Org.BouncyCastle.Asn1.X509;
using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Products
{
    public partial class ManageProductForm : Form
    {
        public int _productId;
        public string _actionType;
        private int _rowVersion;

        private readonly ProductService _service;
        private readonly ProductForm _productForm;
        public ManageProductForm(ProductForm productForm)
        {
            InitializeComponent();
            _service = new ProductService();
            _productForm = productForm;
        }

        private async Task DisplayProductDetails()
        {
            var product = await _service.GetProductById(_productId);
            if (product != null)
            {
                productName_tx.Text = product.ProductName;
                barCode_tx.Text = product.BarCode;
                unit_cb.Text = product.UnitOfMeasure;
                desc_tx.Text = product.Description;
                reorder_tx.Text = product.ReorderLevel.ToString();
                _rowVersion = product.RowVersion;
            }
        }

        private async void ManageProductForm_Load(object sender, EventArgs e)
        {
            if (_actionType == Constants.SystemConstants.New)
            {
                title_lbl.Text = "New Product";
                save_btn.Text = "Save";
            }
            else
            {
                title_lbl.Text = "Edit Product";
                save_btn.Text = "Update";

                await DisplayProductDetails();
            }
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_actionType == Constants.SystemConstants.New)
                {
                    await _service.SaveProduct(new ProductModel
                    {
                        ProductName = productName_tx.Text,
                        BarCode = barCode_tx.Text,
                        UnitOfMeasure = unit_cb.Text,
                        Description = desc_tx.Text,
                        ReorderLevel = int.Parse(reorder_tx.Text),
                    });
                }
                else
                {
                    await _service.UpdateProduct(_productId, new ProductModel
                    {
                        ProductName = productName_tx.Text,
                        BarCode = barCode_tx.Text,
                        UnitOfMeasure = unit_cb.Text,
                        Description = desc_tx.Text,
                        ReorderLevel = int.Parse(reorder_tx.Text),
                    }, _rowVersion);
                }
                Close();
                await _productForm.LoadProducts();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error managing product {_actionType}: {ex.Message}");
            }
        }
    }
}
