using SalesPro.Constants;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using SalesPro.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Settings
{
    public partial class UserForm : Form
    {
        private DateTime _curDate;
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

        private async void UserForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();

                if (_actionForm == Constants.SystemConstants.Edit)
                {
                    title_lbl.Text = "Edit User";
                    save_btn.Text = "Update";

                    var user = await _userService.GetUserById(_userId);
                    if (user != null)
                    {
                        fullname_tx.Text = user.Fullname;
                        username_tx.Text = user.Username;
                        pin_tx.Text = user.Pin;
                        _rowVersion = user.RowVersion;
                    }
                    await LoadRoles();

                    // Show the tab when editing
                    if (!userTabControl.TabPages.Contains(rolesTab))
                    {
                        userTabControl.TabPages.Add(rolesTab);
                    }
                }
                else
                {
                    title_lbl.Text = "New User";
                    save_btn.Text = "Save";

                    // Hide the tab when adding a new user
                    if (userTabControl.TabPages.Contains(rolesTab))
                    {
                        userTabControl.TabPages.Remove(rolesTab);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading user form: {ex.Message}");
            }
        }

        private async Task LoadRoles()
        {
            var allRoles = await _userService.LoadRoles(); // Get all roles
            var userRoles = await _userService.GetUserRoles(_userId); // Get user-assigned roles

            dgRoles.DataSource = null;
            dgRoles.Columns.Clear();
            dgRoles.Rows.Clear();

            // ✅ Ensure DataGridView is Editable
            dgRoles.AllowUserToAddRows = false;
            dgRoles.EditMode = DataGridViewEditMode.EditOnEnter;
            dgRoles.ReadOnly = false; // Ensure DataGridView is not fully read-only

            // ✅ Add Checkbox Column (Editable)
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Select",
                Name = "chkColumn",
                TrueValue = true,
                FalseValue = false
            };
            dgRoles.Columns.Add(checkBoxColumn);

            // ✅ Add RoleId (Hidden) and Role Name (Read-Only)
            DataGridViewTextBoxColumn roleIdColumn = new DataGridViewTextBoxColumn
            {
                Name = "RoleId",
                HeaderText = "Role ID",
                Visible = false, // Hide Role ID
                ReadOnly = true
            };
            dgRoles.Columns.Add(roleIdColumn);

            DataGridViewTextBoxColumn roleNameColumn = new DataGridViewTextBoxColumn
            {
                Name = "Role",
                HeaderText = "Role Name",
                ReadOnly = true // Make Role Name read-only
            };
            dgRoles.Columns.Add(roleNameColumn);

            // ✅ Add Roles and Check Assigned Ones
            foreach (var role in allRoles)
            {
                bool isChecked = userRoles.Contains(role.RoleId); // Check if user has this role
                dgRoles.Rows.Add(isChecked, role.RoleId, role.Role);
            }

            // ✅ Explicitly Allow Editing Only for Checkboxes
            foreach (DataGridViewColumn column in dgRoles.Columns)
            {
                column.ReadOnly = column.Name != "chkColumn"; // Only allow checkbox to be edited
            }

            // change index
            dgRoles.Columns["Role"].DisplayIndex = 0;
            // aling roles to left
            dgRoles.Columns["Role"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgFormatHelper.BasicGridFormat(dgRoles);
        }

        private async Task UpsertUserRoles()
        {
            if (dgRoles.Rows.Count == 0) return;

            var selectedRoleIds = new List<int>();

            // ✅ Get Selected Roles from DataGridView
            foreach (DataGridViewRow row in dgRoles.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["chkColumn"].Value);
                int roleId = Convert.ToInt32(row.Cells["RoleId"].Value);

                if (isChecked)
                {
                    selectedRoleIds.Add(roleId);
                }
            }

            // ✅ Get Current Roles from Database
            var currentUserRoles = await _userService.GetUserRoles(_userId);

            // ✅ Determine Roles to Add and Remove
            var rolesToAdd = selectedRoleIds.Except(currentUserRoles).ToList();     // New roles
            var rolesToRemove = currentUserRoles.Except(selectedRoleIds).ToList();  // Removed roles

            // ✅ Update Database
            if (rolesToAdd.Any() || rolesToRemove.Any())
            {
                await _userService.UpdateUserRoles(_userId, rolesToAdd, rolesToRemove);
                MessageBox.Show("User roles updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No changes made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task<bool> CheckIfUserExist()
        {
            var user = await _userService.GetUserIfExist(fullname_tx.Text, _userId);
            return user != null;
        }

        private async Task<bool> CheckIfUsernameTaken()
        {
            var user = await _userService.GetUsernameIfExist(username_tx.Text, _userId);
            return user != null;
        }

        private UserModel BuildUserModel(bool isNew)
        {
            var password = EncryptionHelper.EncryptPassword(password_tx.Text);
            var user = new UserModel
            {
                Username = username_tx.Text,
                Password = password,
                Fullname = fullname_tx.Text,
                Pin = pin_tx.Text,
                AccountStatus = 0,
                DateAdded = isNew ? _curDate : default, // Set DateAdded only if it's a new user
                DateUpdated = _curDate
            };
            return user;
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!UserSession.HasAccess(RoleConstants.UpsertUser))
                {
                    MessageHandler.ShowRestrictionMessage($"You do not have permission to manage user.");
                    return;
                }

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

                var action = _actionForm == Constants.SystemConstants.New ? "save" : "update";
                int success = 0;
                if (MessageHandler.ShowQuestionGeneric($"Confirm {action} user?"))
                {
                    if (_actionForm == Constants.SystemConstants.New)
                    {
                        var user = BuildUserModel(true);
                        success = await _userService.SaveUser(user);
                    }
                    else
                    {
                        var user = BuildUserModel(false);
                        success = await _userService.UpdateUser(_userId, user, _rowVersion);
                    }

                    if (success > 0)
                    {
                        Close();
                    }
                    await _form.LoadUsers();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error saving user: {ex.Message}");
            }
        }

        private async void updateRole_btn_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasSelectedRole = dgRoles.Rows.Cast<DataGridViewRow>()
                     .Any(row => Convert.ToBoolean(row.Cells["chkColumn"].Value) == true);

                if (!hasSelectedRole)
                {
                    MessageHandler.ShowWarning("Please select at least one role.");
                    return; // Stop execution
                }
                await UpsertUserRoles();
                Close();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error upsert users: {ex.Message}");
            }
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgRoles, search_tx);
        }

        private void userTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == rolesTab && !UserSession.HasAccess(RoleConstants.ManageRoles))
            {
                MessageHandler.ShowRestrictionMessage("You do not have permission to manage roles.");
                e.Cancel = true; // Prevents the tab change
            }
        }
    }
}
