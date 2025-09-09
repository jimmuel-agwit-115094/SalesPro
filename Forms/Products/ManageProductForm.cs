using SalesPro.Constants;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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
            TextBoxHelper.FormatIntegerTextbox(subUnitQty_tx);
        }

        private async Task DisplayProductDetails()
        {
            var product = await _service.GetProductById(_productId);
            if (product != null)
            {
                productName_tx.Text = product.ProductName;
                barCode_tx.Text = product.BarCode;
                unit_cb.Text = product.UnitOfMeasure;
                subUnit_cb.Text = product.SubUnit;
                subUnitQty_tx.Text = product.SubQuantity.ToString();
                desc_tx.Text = product.Description;
                reorder_tx.Text = product.ReorderLevel.ToString();
                isSoldByPrice_cb.SelectedItem = product.IsSoldByPrice ? "YES" : "NO";
                _rowVersion = product.RowVersion;
            }
        }

        private async Task SetUnitOfMeasureComboBox()
        {
            var uoms = await _unitOfMeasureService.GetAllUnitOfMeasures();
            if (uoms == null) uoms = new List<UnitOfMeasuresModel>();

            // Unit of measure combo box
            unit_cb.DataSource = uoms.ToList();
            unit_cb.DisplayMember = "UnitName";
            unit_cb.ValueMember = "UnitOfMeasureId";
            unit_cb.SelectedIndex = -1;

            // Sub unit combo box
            subUnit_cb.DataSource = uoms.ToList();
            subUnit_cb.DisplayMember = "UnitName";
            subUnit_cb.ValueMember = "UnitOfMeasureId";
            subUnit_cb.SelectedIndex = -1;
        }

        private async void ManageProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                await SetUnitOfMeasureComboBox();
                subUnit_cb.SelectedIndex = 0;
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
            int subUnitQty = int.Parse(subUnitQty_tx.Text);

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
            if (unit_cb.Text == SystemConstants.NotApplicable)
            {
                MessageHandler.ShowWarning($"Please select a valid unit of measure");
                return;
            }
           
            if (subUnit_cb.Text != SystemConstants.NotApplicable && subUnitQty <= 0)
            {
                MessageHandler.ShowWarning($"Please provide valid sub order quantity for a {subUnit_cb.Text}.");
                return;
            }
            if (subUnitQty > 0 && subUnit_cb.Text == SystemConstants.NotApplicable)
            {
                MessageHandler.ShowWarning($"Please remove sub quantity for it is not applicable.");
                return;
            }
            if (isSoldByPrice_cb.SelectedIndex == -1)
            {
                MessageHandler.ShowWarning($"Please select if product is sold by price.");
                return;
            }
            if (isSoldByPrice_cb.SelectedIndex == -1)
            {
                MessageHandler.ShowWarning($"Please select if product is sold by price.");
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
                            SubUnit = subUnit_cb.Text,
                            SubQuantity = int.Parse(subUnitQty_tx.Text),
                            IsSoldByPrice = isSoldByPrice_cb.SelectedItem != null && bool.TryParse(isSoldByPrice_cb.SelectedItem.ToString(), out var isSoldByPrice) ? isSoldByPrice : false,
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
                            SubUnit = subUnit_cb.Text,
                            SubQuantity = int.Parse(subUnitQty_tx.Text),
                            IsSoldByPrice = isSoldByPrice_cb.SelectedItem != null && bool.TryParse(isSoldByPrice_cb.SelectedItem.ToString(), out var isSoldByPrice) ? isSoldByPrice : false,
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
            string originalText = barCode_tx.Text;
            string sanitizedText = Regex.Replace(originalText, @"[^a-zA-Z0-9]", "");
            if (originalText != sanitizedText)
            {
                int selectionStart = barCode_tx.SelectionStart;
                barCode_tx.Text = sanitizedText;
                barCode_tx.SelectionStart = Math.Min(selectionStart, sanitizedText.Length);
            }
        }

        private void logs_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ProductLogsForm();
            form._productId = _productId;
            form.ShowDialog();
        }

        private void subUnit_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(subUnit_cb.SelectedIndex == 0)
            {
                subUnitQty_tx.Text = "0";
            }
        }
    }
}
