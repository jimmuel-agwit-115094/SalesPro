using POS_Generic.Helpers;
using SalesPro.Forms;
using SalesPro.Helpers;
using SalesPro.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesPro
{
    public partial class LoginForm : Form
    {
        private readonly DatabaseContext _dbContext;
        public LoginForm()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
        }

        private void login_btn_Click(object sender, EventArgs e)
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

