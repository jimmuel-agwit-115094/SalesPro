using SalesPro.Enums;
using SalesPro.Forms;
using SalesPro.Forms.Settings;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Models.Sessions;
using SalesPro.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Settings
{
    public partial class SettingsForm : Form
    {
        private readonly BankService _bankService;
        private readonly UserService _userService;
        private readonly SupplierService _supplierService;
        private readonly BackupAndRestoreService _dbService;
        private readonly ActivationService _activationService;
        private readonly ActivationStatus _activationStatus = ActivationSession.ActivationStatus;
        private readonly string _publicKey = Constants.PublicKeyConstants.PublicKey;
        public SettingsForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _bankService = new BankService();
            _supplierService = new SupplierService();
            _dbService = new BackupAndRestoreService();
            _activationService = new ActivationService();
        }

        public async Task LoadUsers()
        {
            var users = await _userService.LoadUsers();
            dgUsers.DataSource = users;
            DgExtensions.ConfigureDataGrid(dgUsers, true, 0, noRecordUser, "UserId", "Fullname", "AccountStatus", "DateAdded");
        }

        public async Task LoadBanks()
        {
            var banks = await _bankService.LoadBanks();
            dgBanks.DataSource = banks;
            DgExtensions.ConfigureDataGrid(dgBanks, true, 0, noRecordBank, "BankId", "BankName", "BankType", "Address", "Contact");
        }

        public async Task LoadSuppliers()
        {
            var sups = await _supplierService.LoadSuppliers();
            dgSuppliers.DataSource = sups;
            DgExtensions.ConfigureDataGrid(dgSuppliers, true, 0, noRecordSup, "SupplierId", "SupplierName", "SupplierAddress", "SupplierContactPerson", "SupplierTin");
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                settingsTabControl.SelectedIndex = 1;
                settingsTabControl.SelectedIndex = 0;

                if (_activationStatus == ActivationStatus.InActive)
                {
                    // clear tab pages
                    settingsTabControl.TabPages.Clear();
                    settingsTabControl.TabPages.Add(activationTab);

                    new_btn.Visible = false;
                    activationGreenPanel.Visible = false;
                    inactivePanel.Visible = true;
                    activatedPanel.Visible = false;
                    activate_btn.Enabled = true;
                    activationGroupBox.Visible = true;
                 
                }
                else if (_activationStatus == ActivationStatus.Trial)
                {
                    new_btn.Visible = true;
                    activationGreenPanel.Visible = true;
                    inactivePanel.Visible = true;
                    activatedPanel.Visible = false;
                    activate_btn.Enabled = true;
                    activationGroupBox.Visible = true;
                }
                else if (_activationStatus == ActivationStatus.Activated)
                {
                    new_btn.Visible = true;
                    activationGreenPanel.Visible = true;
                    inactivePanel.Visible = false;
                    activatedPanel.Visible = true;
                    activate_btn.Enabled = false;
                    activationGroupBox.Visible = false;
                    licenseKey.Text = ActivationSession.LicenseKey;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error setting load: {ex.Message}");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void newUser_btn_Click(object sender, EventArgs e)
        {
            if (settingsTabControl.SelectedIndex == 0)
            {
                var form = new UserForm(this);
                form._actionForm = Constants.SystemConstants.New;
                form.ShowDialog();
            }

            if (settingsTabControl.SelectedIndex == 1)
            {
                var form = new BankForm(this);
                form._actionForm = Constants.SystemConstants.New;
                form.ShowDialog();
            }

            if (settingsTabControl.SelectedIndex == 2)
            {
                var form = new SupplierForm(this);
                form._actionForm = Constants.SystemConstants.New;
                form.ShowDialog();
            }

        }

        private void dgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int userId = DgFormatHelper.GetSelectedId(dgUsers, e, "UserId");
                if (userId == 0) return;
                var form = new UserForm(this);
                form._userId = userId;
                form._actionForm = Constants.SystemConstants.Edit;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error user click: {ex.Message}");
            }
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgUsers, search_tx);
        }

        private async void settingsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            new_btn.Visible = settingsTabControl.SelectedIndex != 4 && settingsTabControl.SelectedIndex != 5;
            switch (settingsTabControl.SelectedIndex)
            {
                case 0: // Users
                    new_btn.Text = "New User";
                    await LoadUsers();
                    break;
                case 1: // Banks
                    new_btn.Text = "New Bank";
                    await LoadBanks();
                    break;
                case 2: // Suppliers
                    new_btn.Text = "New Supplier";
                    await LoadSuppliers();
                    break;
                case 3: // Unit of measures
                    new_btn.Text = "New Unit";
                    break;
                case 4:// Database settings

                    break;
                case 5: // Activation

                    break;
            }
        }

        private void bankSearch_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgBanks, bankSearch_tx);
        }

        private void dgBanks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int bankId = DgFormatHelper.GetSelectedId(dgBanks, e, "BankId");
                if (bankId == 0) return;
                var form = new BankForm(this);
                form._bankId = bankId;
                form._actionForm = Constants.SystemConstants.Edit;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error clicking bank {ex.Message}");
            }
        }

        private void dgSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int supId = DgFormatHelper.GetSelectedId(dgSuppliers, e, "SupplierId");
                if (supId == 0) return;
                var form = new SupplierForm(this);
                form._supplierId = supId;
                form._actionForm = Constants.SystemConstants.Edit;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error clicking supplier {ex.Message}");
            }
        }

        private void supplierSearch_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgSuppliers, supplierSearch_tx);
        }

        private void backup_btn_Click(object sender, EventArgs e)
        {
            if (MessageHandler.ShowQuestionGeneric("Confirm backup database?"))
            {
                _dbService.BackupDatabase();
            }
        }

        private void restore_btn_Click(object sender, EventArgs e)
        {
            if (UserSession.UserAccess == UserAccess.Developer)
            {
                _dbService.RestoreDatabase();
            }
            else
            {
                MessageHandler.ShowWarning("You are not allowed to restore the database. Contact developer for this module");
            }
        }

        private async void activate_btn_Click(object sender, EventArgs e)
        {
            string license = key_tx.Text;
            string singedKey = signedKey_tx.Text;
            DateTime dateActivated = DateTime.Now;

            if (license == string.Empty)
            {
                MessageHandler.ShowWarning("Please enter license key");
                return;
            }

            if (singedKey == string.Empty)
            {
                MessageHandler.ShowWarning("Please enter signed key");
                return;
            }

            // Validate if the license and signedKey are valid Base64 strings
            if (!ActivationService.IsBase64String(singedKey))
            {
                MessageHandler.ShowWarning("Invalid Signed Key");
                return;
            }

            var data = await _activationService.GetActivationData();
            if (data != null)
            {
                bool isValid = ActivationService.VerifyLicenseKey(license, singedKey, _publicKey);
                if (isValid)
                {
                    var model = new ActivationModel
                    {
                        LicenseKey = license,
                        SignedKey = singedKey,
                        DateActivated = dateActivated,
                    };
                    await _activationService.UpdateActivationData(data.ActivationId, model);

                    // Setter
                    ActivationSession.SetActivationStatus(ActivationStatus.Activated);
                    ActivationSession.SetLicenseKey(license);
                    inactivePanel.Visible = false;
                    activatedPanel.Visible = true;
                    activationGroupBox.Visible = false;
                    MessageHandler.ShowInfo("Activation successful. Please logout for the activation to take effect.");
                }
                else
                {
                    MessageHandler.ShowError("Activation failed. Invalid license key or signed key");
                }
            }
        }

        private void signedKey_tx_TextChanged(object sender, EventArgs e)
        {
            // Remove any spaces from the text while typing
            signedKey_tx.Text = signedKey_tx.Text.Replace(" ", "");

            // Move the cursor to the end of the text
            signedKey_tx.SelectionStart = signedKey_tx.Text.Length;
        }

        private void signedKey_tx_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
