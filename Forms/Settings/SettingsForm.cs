using SalesPro.Forms.Settings;
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

namespace SalesPro.Settings
{
    public partial class SettingsForm : Form
    {
        private int _userId;
        private int _rowVersion;

        private readonly UserService _userService;
        public SettingsForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        public async Task LoadUsers()
        {
            var users = await _userService.LoadUsers();
            dgUsers.DataSource = users;
            DgExtensions.ConfigureDataGrid(dgUsers, true, 0, noRecordUser, "UserId", "Fullname", "AccountStatus", "DateAdded");
        }

        private async void SettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadUsers();
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
            var form = new UserForm(this);
            form._actionForm = Constants.SystemConstants.New;
            form.ShowDialog();
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
    }
}
