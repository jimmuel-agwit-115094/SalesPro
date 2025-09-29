using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Enums;
using SalesPro.Forms;
using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Models.Sessions;
using SalesPro.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SalesPro
{
    public partial class LoginForm : Form
    {
        public bool _isLogout = false;
        private readonly ActivationService _activationService;
        private DateTime _curDate;
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
                    var user = _dbContext.Users
                        .Include(u => u.UserAccesses)
                        .ThenInclude(ua => ua.Role)
                        .FirstOrDefault(u => u.Username == userInput.Username);

                    if (user != null && user.ValidatePassword(userInput.Password))
                    {
                        // Set user's full name in the UserSession class
                        UserSession.SetUserFullName(user.Fullname);
                        UserSession.SetUserId(user.UserId);
                        UserSession.Roles = user.UserAccesses.Select(ua => ua.Role.Role).ToList();

                        // Activation
                        var data = await _activationService.GetActivationData();
                        if (data == null)
                        {
                            await SaveActivation();
                        }
                        else
                        {
                            ProcessActivation(data);
                        }

                        Hide();
                        MainForm mainForm = new MainForm();
                        string userFullName = user.Fullname;
                        mainForm.user_tx.Text = userFullName;
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

        private async Task SaveActivation()
        {
            var model = new ActivationModel
            {
                LicenseKey = "NOTSET",
                SignedKey = "NOTSET",
                DateActivated = new DateTime(),
                DateInstalled = DateTime.Now,
            };

            await _activationService.SaveActivationData(model);
        }

        private void ProcessActivation(ActivationModel data)
        {
            var licenseKey = data.LicenseKey;
            var signedKey = data.SignedKey;
            var publicKey = Constants.PublicKeyConstants.PublicKey;
            var remainingTrialDays = (data.DateInstalled.Date.AddMonths(1) - _curDate.Date).Days;

            ActivationSession.SetTrialDays(remainingTrialDays);
            DateTime expirationDate = data.DateInstalled.Date.AddMonths(1);

            if (licenseKey == "NOTSET" || licenseKey == string.Empty || licenseKey == null)
            {
                if (expirationDate.Date > _curDate.Date)
                {
                    ActivationSession.SetActivationStatus(ActivationStatus.Trial);
                }
                else
                {
                    ActivationSession.SetActivationStatus(ActivationStatus.InActive);
                }
            }
            else
            {
                var isValid = ActivationService.VerifyLicenseKey(licenseKey, signedKey, publicKey);
                if (isValid)
                {
                    ActivationSession.SetActivationStatus(ActivationStatus.Activated);
                    ActivationSession.SetLicenseKey(licenseKey);
                }
                else
                {
                    ActivationSession.SetActivationStatus(ActivationStatus.InActive);
                }
            }

        }


        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isLogout)
            {
                Application.Exit();
            }
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            _curDate = await ClockHelper.GetServerDateTime();
        }
    }
}

