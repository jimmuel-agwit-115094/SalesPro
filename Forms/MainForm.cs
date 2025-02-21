using POS_Generic.Helpers;
using SalesPro.Constants;
using SalesPro.Enums;
using SalesPro.Forms.Inventory;
using SalesPro.Forms.Orders;
using SalesPro.Forms.PaymentsAndBilling;
using SalesPro.Forms.Products;
using SalesPro.Forms.PurchaseOrders;
using SalesPro.Forms.Reports;
using SalesPro.Forms.Transactions;
using SalesPro.Helpers;
using SalesPro.Models;
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

        private void EnableDisableButton(bool status)
        {
            orders_btn.Enabled = status;
            po_btn.Enabled = status && UserSession.HasAccess(RoleConstants.PurchaseOrdersModule);
            products_btn.Enabled = status && UserSession.HasAccess(RoleConstants.ProductsModule);
            inventory_btn.Enabled = status && UserSession.HasAccess(RoleConstants.InventoryModule);
            paymentsAndBilling_btn.Enabled = status && UserSession.HasAccess(RoleConstants.PaymentsAndBillingsModule);
            reports_btn.Enabled = status && UserSession.HasAccess(RoleConstants.ReportsModule);
            serttings_btn.Enabled = status && UserSession.HasAccess(RoleConstants.SettingsModule);
        }


        public async Task EnableDisableMenuPanel()
        {
            if (ActivationSession.ActivationStatus == ActivationStatus.Trial)
            {
                string trialDays = ActivationSession.TrialDays.ToString();
                EnableDisableButton(true);

                transactions_btn.Enabled = true;
                trialPanel.Visible = true;
                inactivePanel.Visible = false;
                remaining_tx.Text = $"Days remaining: {trialDays}";
            }
            if (ActivationSession.ActivationStatus == ActivationStatus.InActive)
            {
                EnableDisableButton(false);

                transactions_btn.Enabled = false;
                trialPanel.Visible = false;
                inactivePanel.Visible = true;
            }
            if (ActivationSession.ActivationStatus == ActivationStatus.Activated)
            {
                EnableDisableButton(false);

                transactions_btn.Enabled = true;
                trialPanel.Visible = false;
                inactivePanel.Visible = false;
            }
            bool hasTransactions = await _transactionService.HasTransactionsCurrentDay(_curDate.Date);
            EnableDisableButton(hasTransactions);
            noTransactionPanel.Visible = !hasTransactions;
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
            if (!UserSession.HasAccess(RoleConstants.PurchaseOrdersModule))
            {
                MessageHandler.ShowRestrictionMessage("You do not have permision to access Purchase Order Module");
                return;
            }
            var form = new PurchaseOrderForm();
            LoadFormInPanel(form);
        }

        private void inventory_btn_Click(object sender, EventArgs e)
        {
            if (!UserSession.HasAccess(RoleConstants.InventoryModule))
            {
                MessageHandler.ShowRestrictionMessage("You do not have permision to access Inventory Module");
                return;
            }
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
            if (!UserSession.HasAccess(RoleConstants.ProductsModule))
            {
                MessageHandler.ShowRestrictionMessage("You do not have permision to access Products Module");
                return;
            }
            var form = new ProductForm();
            LoadFormInPanel(form);
        }

        private void paymentsAndBilling_btn_Click(object sender, EventArgs e)
        {
            if (!UserSession.HasAccess(RoleConstants.PaymentsAndBillingsModule))
            {
                MessageHandler.ShowRestrictionMessage("You do not have permision to access Payments and Billings Module");
                return;
            }
            var form = new PaymentsAndBillingForm();
            LoadFormInPanel(form);
        }

        private void reports_btn_Click(object sender, EventArgs e)
        {
            if (!UserSession.HasAccess(RoleConstants.ReportsModule))
            {
                MessageHandler.ShowRestrictionMessage("You do not have permision to access Reports Module");
                return;
            }
            var form = new ReportsForm();
            LoadFormInPanel(form);
        }

        private void serttings_btn_Click(object sender, EventArgs e)
        {
            if (!UserSession.HasAccess(RoleConstants.SettingsModule))
            {
                MessageHandler.ShowRestrictionMessage("You do not have permision to access Settings Module");
                return;
            }
            var form = new SettingsForm();
            LoadFormInPanel(form);
        }
    }
}
