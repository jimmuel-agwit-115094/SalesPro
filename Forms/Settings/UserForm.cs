using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using SalesPro.Settings;
using System;
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
        private readonly UserService _userService;
        public UserForm(SettingsForm settingsForm)
        {
            InitializeComponent();
            _userService = new UserService();
            _form = settingsForm;
            TextBoxHelper.FormatIntegerTextbox(pin_tx);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            try
            {
                access_cb.DataSource = Enum.GetValues(typeof(UserAccess));
                access_cb.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading user form: {ex.Message}");
            }
        }

        private async Task<bool> CheckIfUserExist()
        {
            var user = await _userService.GetUserIfExist(fullname_tx.Text);
            return user != null;
        }

        private async Task<bool> CheckIfUsernameTaken()
        {
            var user = await _userService.GetUsernameIfExist(username_tx.Text);
            return user != null;
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (fullname_tx.Text == string.Empty)
                {
                    MessageHandler.ShowWarning("Please enter fullname.");
                    return;
                }

                if (username_tx.Text == string.Empty)
                {
                    MessageHandler.ShowWarning("Please enter username.");
                    return;
                }

                if (password_tx.Text == string.Empty)
                {
                    MessageHandler.ShowWarning("Please enter password.");
                    return;
                }

                if (pin_tx.Text.Length < 4)
                {
                    MessageHandler.ShowWarning("Pin must be 4 digits.");
                    return;
                }

                if (pin_tx.Text == string.Empty)
                {
                    MessageHandler.ShowWarning("Please enter pin.");
                    return;
                }

                if (access_cb.SelectedIndex == -1)
                {
                    MessageHandler.ShowWarning("Please select access.");
                    return;
                }

                if (access_cb.SelectedIndex == 0 && UserSession.UserAccess != UserAccess.Developer)
                {
                    MessageHandler.ShowWarning("You are not the developer. :)");
                    return;
                }

                if (await CheckIfUserExist())
                {
                    MessageHandler.ShowWarning("User already exist.");
                    return;
                }

                if (await CheckIfUsernameTaken())
                {
                    MessageHandler.ShowWarning("Username already taken.");
                    return;
                }

                if (MessageHandler.ShowQuestionGeneric("Save new user?"))
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
                    await _userService.SaveUser(user);
                    await _form.LoadUsers();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error saving user: {ex.Message}");
            }
        }
    }
}
