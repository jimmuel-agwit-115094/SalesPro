using POS_Generic.Helpers;
using SalesPro.Forms;
using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Models.Sessions;
using SalesPro.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro
{
    public partial class LoginForm : Form
    {
        private readonly ActivationService _activationService;
        private readonly DatabaseContext _dbContext;
        public LoginForm()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _activationService = new ActivationService();
        }

        private async void login_btn_Click(object sender, EventArgs e)
        {

            // Manual validation
            if (string.IsNullOrWhiteSpace(username_tx.Text))
            {
                MessageHandler.MissingDataError("Username");
                username_tx.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password_tx.Text))
            {
                MessageHandler.MissingDataError("Password");
                password_tx.Focus();
                return;
            }

            var userInput = new UserModel
            {
                Username = username_tx.Text,
                Password = password_tx.Text
            };

            try
            {
                using (var _dbContext = new DatabaseContext())
                {
                    var user = _dbContext.Users.SingleOrDefault(u => u.Username == userInput.Username);

                    if (user != null && user.ValidatePassword(userInput.Password))
                    {
                        // Set user's full name in the UserSession class
                        UserSession.SetUserFullName(user.Fullname);
                        UserSession.SetUserId(user.UserId);
                        UserSession.SetUserAccess(user.UserAccess);

                        // Activation
                        await ProcessActivation();

                        Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.user_tx.Text = user.Fullname;
                        mainForm.Show();
                    }
                    else
                    {
                        MessageHandler.ShowWarning("Invalid username or password. Please try again.");
                        // Optional: Clear password field and set focus
                        password_tx.Clear();
                        username_tx.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError("Error Login: " + ex);
                Console.WriteLine(ex);
            }
        }

        private async Task ProcessActivation()
        {
            var data = await _activationService.GetActivationData();
            if (data != null)
            {
                var liceseKey = data.LicenseKey;
                var signedKey = data.SignedKey;
                var publicKey = Constants.PublicKeyConstants.PublicKey;

                var isValid = ActivationService.VerifyLicenseKey(liceseKey, signedKey, publicKey);
                if (isValid)
                {
                    ActivationSession.SetIsActivated(true);
                    ActivationSession.SetLicenseKey(liceseKey);
                }
                else
                {
                    ActivationSession.SetIsActivated(false);
                }
            }
            else
            {
                ActivationSession.SetIsActivated(false);
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

