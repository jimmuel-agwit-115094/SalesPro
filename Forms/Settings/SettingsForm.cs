using SalesPro.Forms.Settings;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
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
        public SettingsForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _bankService = new BankService();
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
            DgExtensions.ConfigureDataGrid(dgBanks, true, 0, noRecordBank, "BankId", "BankName", "BankType","Address", "Contact");
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                settingsTabControl.SelectedIndex = 1;
                settingsTabControl.SelectedIndex = 0;
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
    }
}
