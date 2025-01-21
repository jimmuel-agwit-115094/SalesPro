using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Services;
using SalesPro.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Settings
{
    public partial class UserForm : Form
    {
        public int _userId;
        public int _rowVersion;
        public string _actionForm;  

        private readonly SettingsForm _form;
        private readonly SettingService _service;
        public UserForm(SettingsForm settingsForm)
        {
            InitializeComponent();
            _service = new SettingService();
            _form = settingsForm;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            try
            {
                access_cb.DataSource = Enum.GetValues(typeof(UserAccess));
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading user form: {ex.Message}");
            }
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var password = EncryptionHelper.EncryptPassword(password_tx.Text);
                var user = new UserModel
                {
                    Username = username_tx.Text,
                    Password = password,
                    Fullname = fullname_tx.Text,
                    UserAccess = Enum.TryParse(access_cb.Text, out UserAccess userAccess) ? userAccess : throw new InvalidOperationException("Invalid UserAccess value"),
                    Pin = pin_tx.Text,
                    AccountStatus = 0
                };

                await _service.SaveUser(user);
                await _form.LoadUsers();
                Close();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error saving user: {ex.Message}");
            }
        }
    }
}
