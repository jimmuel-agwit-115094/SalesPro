using SalesPro.Constants;
using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Services;
using SalesPro.Settings;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Settings
{
    public partial class SupplierForm : Form
    {
        public int _supplierId;
        public int _rowVersion;
        public string _actionForm;

        private readonly SettingsForm _settingsForm;
        private readonly SupplierService _supplierService;
        public SupplierForm(SettingsForm settingsForm)
        {
            InitializeComponent();
            _supplierService = new SupplierService();
            _settingsForm = settingsForm;
        }

        private async void SupplierForm_Load(object sender, EventArgs e)
        {
            if (_actionForm == Constants.SystemConstants.Edit)
            {
                title_lbl.Text = "Edit Supplier";
                save_btn.Text = "Update";
                save_btn.BackColor = SystemColors.Highlight;

                var sup = await _supplierService.GetSupplierById(_supplierId);
                if (sup != null)
                {
                    supplier_tx.Text = sup.SupplierName;
                    address_tx.Text = sup.SupplierAddress;
                    contact_tx.Text = sup.SupplierContactPerson;
                    supplierNumber_tx.Text = sup.SupplierNumber;
                    tin_tx.Text = sup.SupplierTin;
                    _rowVersion = sup.RowVersion;
                }
            }
            else
            {
                title_lbl.Text = "New Supplier";
                save_btn.Text = "Save";
                save_btn.BackColor = Color.Green;
            }
        }

        private async Task<int> SaveSupplier()
        {
            var model = new Models.SupplierModel
            {
                SupplierName = supplier_tx.Text,
                SupplierAddress = address_tx.Text,
                SupplierContactPerson = contact_tx.Text,
                SupplierNumber = supplierNumber_tx.Text,
                SupplierTin = tin_tx.Text
            };
            return await _supplierService.SaveSupplier(model);
        }

        private async Task<int> UpdateSupplier()
        {
            var model = new Models.SupplierModel
            {
                SupplierName = supplier_tx.Text,
                SupplierAddress = address_tx.Text,
                SupplierContactPerson = contact_tx.Text,
                SupplierNumber = supplierNumber_tx.Text,
                SupplierTin = tin_tx.Text
            };
            return await _supplierService.UpdateSupplier(_supplierId, model, _rowVersion);
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int success = 0;
                if (supplier_tx.Text == string.Empty)
                {
                    MessageHandler.ShowWarning("Supplier name is required");
                    return;
                }
                if (address_tx.Text == string.Empty)
                {
                    MessageHandler.ShowWarning("Supplier address is required");
                    return;
                }
                if (contact_tx.Text == string.Empty)
                {
                    MessageHandler.ShowWarning("Supplier contact person is required");
                    return;
                }
                if (supplierNumber_tx.Text == string.Empty)
                {
                    MessageHandler.ShowWarning("Supplier number is required");
                    return;
                }
                var supplier = await _supplierService.SupplierExists(supplier_tx.Text);
                if (supplier != null && supplier.SupplierId != _supplierId)
                {
                    MessageHandler.ShowWarning("Supplier already exists");
                    return;
                }

                string action = _actionForm == SystemConstants.New ? "save" : "update";
                if (!UserSession.HasAccess(RoleConstants.UpsertSupplier))
                {
                    MessageHandler.ShowRestrictionMessage($"You do not have permission to {action} supplier.");
                    return;
                }

                if (MessageHandler.ShowQuestionGeneric($"Are you sure you want to {action} this supplier?"))
                {

                    if (_actionForm == Constants.SystemConstants.New)
                    {
                        success = await SaveSupplier();
                    }
                    else
                    {
                        success = await UpdateSupplier();
                    }
                }
                await _settingsForm.LoadSuppliers();
                if (success > 0)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error saving supplier: {ex.Message}");
            }
        }

        private void tin_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (Backspace, Delete, Arrow keys, Ctrl shortcuts)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow numbers and hyphen (-)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Block other characters
            }
        }
    }
}
