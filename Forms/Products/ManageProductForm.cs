using Org.BouncyCastle.Asn1.X509;
using SalesPro.Constants;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
        private readonly UnitOfMeasureService _unitOfMeasureService;
        private readonly ProductForm _productForm;
        public ManageProductForm(ProductForm productForm)
        {
            InitializeComponent();
            _service = new ProductService();
            _productForm = productForm;
            _unitOfMeasureService = new UnitOfMeasureService();
            TextBoxHelper.FormatIntegerTextbox(reorder_tx);
            TextBoxHelper.FormatIntegerTextbox(barCode_tx);
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
            try
            {
                List<UnitOfMeasuresModel> uoms = await _unitOfMeasureService.GetAllUnitOfMeasures();
                unit_cb.DataSource = uoms;
                unit_cb.DisplayMember = "UnitName";
                unit_cb.ValueMember = "UnitOfMeasureId";

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
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error manage product form load: {ex.Message}");
            }
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            if (!UserSession.HasAccess(RoleConstants.UpsertProduct))
            {
                MessageHandler.ShowRestrictionMessage("You do not have permission to perform this action");
                return;
            }
            if (!Validators.EmptyStringValidator(productName_tx.Text, "Product Name")) return;
            if (unit_cb.SelectedIndex == -1)
            {
                MessageHandler.ShowError("Please select a unit of measure");
                return;
            }
            if (!Validators.EmptyStringValidator(reorder_tx.Text, "Reorder Level")) return;
            if (!Validators.IntValidator(reorder_tx.Text, "Reorder Level")) return;
            if (int.Parse(reorder_tx.Text) < 0)
            {
                MessageHandler.ShowError("Reorder level must be greater than 0");
                return;
            }

            try
            {
                if (MessageHandler.ShowQuestionGeneric("Confirm add/update product?"))
                {
                    int success = 0;
                    if (_actionType == SystemConstants.New)
                    {
                        success = await _service.SaveProduct(new ProductModel
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
                        success = await _service.UpdateProduct(_productId, new ProductModel
                        {
                            ProductName = productName_tx.Text,
                            BarCode = barCode_tx.Text,
                            UnitOfMeasure = unit_cb.Text,
                            Description = desc_tx.Text,
                            ReorderLevel = int.Parse(reorder_tx.Text),
                        }, _rowVersion);
                    }

                    if (success > 0)
                    {
                        Close();
                    }

                    await _productForm.LoadProducts();
                }

            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error managing product {_actionType}: {ex.Message}");
            }
        }

        private void barCode_tx_TextChanged(object sender, EventArgs e)
        {
            barCode_tx.Text = Regex.Replace(barCode_tx.Text, @"[^a-zA-Z0-9]", "");
        }

        private void logs_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ProductLogsForm();
            form._productId = _productId;
            form.ShowDialog();
        }
    }
}
