using POS_Generic.Helpers;
using SalesPro.Constants;
using SalesPro.Enums;
using SalesPro.Forms.Inventory;
using SalesPro.Forms.Orders;
using SalesPro.Forms.PaymentsAndBilling;
using SalesPro.Forms.Products;
using SalesPro.Forms.PurchaseOrders;
using SalesPro.Forms.Transactions;
using SalesPro.Helpers;
using SalesPro.Models.Sessions;
using SalesPro.Properties;
using SalesPro.Services;
using SalesPro.Settings;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms
{
    public partial class MainForm : Form
    {
        private DateTime _curDate;
        private readonly DatabaseContext _context;
        private readonly TransactionService _transactionService;
        public MainForm()
        {
            InitializeComponent();
            _context = new DatabaseContext();
            _transactionService = new TransactionService();
        }

        private void Panel1_Resize(object sender, EventArgs e)
        {
            // Center the content panel within the main panel
            int centerX = (main_panel.Width - content_panel.Width) / 2;
            int centerY = (main_panel.Height - content_panel.Height) / 2;
            content_panel.Location = new Point(centerX, centerY);
        }

        private void LoadFormInPanel(Form form)
        {
            // Clear the content panel and load the specified form
            content_panel.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.Size = content_panel.Size;
            content_panel.Controls.Add(form);
            form.Show();
        }

        private void AdjustFormSizeToScreen()
        {
            // Maximize the form within the working area of the screen
            Rectangle workingArea = Screen.GetWorkingArea(this);
            Size = workingArea.Size; // Set form size to the working area size
            Location = workingArea.Location; // Set form location to match the working area
        }

        private void transactions_btn_Click(object sender, EventArgs e)
        {
            // Load the TransactionForm inside the content panel
            var form = new TransactionForm(this);
            LoadFormInPanel(form);
        }

        public async Task EnableDisableMenuPanel()
        {
            var activationStatus = ActivationSession.ActivationStatus;

            if (activationStatus == ActivationStatus.Trial)
            {
                menuPanel.Enabled = true;
                transactions_btn.Enabled = true;
                trialPanel.Visible = true;
                inactivePanel.Visible = false;
                remaining_tx.Text = $"Days remaining: {ActivationSession.TrialDays.ToString()}";
                MessageBox.Show("Trial");
            }
            if (activationStatus == ActivationStatus.InActive)
            {
                menuPanel.Enabled = false;
                transactions_btn.Enabled = false;
                trialPanel.Visible = false;
                inactivePanel.Visible = true;
                MessageBox.Show("Inactive");
            }
            if (activationStatus == ActivationStatus.Activated)
            {
                var result = await _transactionService.HasTransactionsCurrentDay(_curDate.Date);
                menuPanel.Enabled = result;
                transactions_btn.Enabled = true;
                trialPanel.Visible = false;
                inactivePanel.Visible = false;
                MessageBox.Show("Activated");
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
                // Adjust the form size to fit the screen's working area on load
                AdjustFormSizeToScreen();
                await EnableDisableMenuPanel();
                await _transactionService.GetMaxTransactionId();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error main form load : {ex}");
            }
        }

        private void logout_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageHandler.ShowQuestion("Confirm logout", String.Empty))
            {
                Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void po_btn_Click(object sender, EventArgs e)
        {
            var form = new PurchaseOrderForm();
            LoadFormInPanel(form);
        }

        private void inventory_btn_Click(object sender, EventArgs e)
        {
            var form = new InventoryForm();
            LoadFormInPanel(form);
        }

        private void orders_btn_Click(object sender, EventArgs e)
        {
            var emptyForm = new EmptyForm();
            LoadFormInPanel(emptyForm);

            var form = new OrderForm();
            form.ShowDialog();
        }

        private void products_btn_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            LoadFormInPanel(form);
        }

        private void paymentsAndBilling_btn_Click(object sender, EventArgs e)
        {
            var form = new PaymentsAndBillingForm();
            LoadFormInPanel(form);
        }

        private void reports_btn_Click(object sender, EventArgs e)
        {

        }

        private void serttings_btn_Click(object sender, EventArgs e)
        {
            var form = new SettingsForm();
            LoadFormInPanel(form);
        }
    }
}
