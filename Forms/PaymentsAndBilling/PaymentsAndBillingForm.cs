using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.PaymentsAndBilling
{
    public partial class PaymentsAndBillingForm : Form
    {
        private readonly PaymentsService _service;
        private readonly CustomerCreditService _customerCredService;
        private readonly ExpenseService _expenseService;

        private string _selectedTab;
        private DateTime _curDate;
        public PaymentsAndBillingForm()
        {
            InitializeComponent();
            _service = new PaymentsService();
            _customerCredService = new CustomerCreditService();
            _expenseService = new ExpenseService();
        }

        public async Task LoadAllPurchaseOrders(PaymentStatus status, bool showPastDue)
        {
            var pos = await _service.GetPurchaseOrdersByProcessStatus(status);

            if (showPastDue)
            {
                pos = pos.Where(x => x.DueDate < _curDate.Date).ToList();
            }

            dgSupplierPayables.DataSource = pos;
            DgExtensions.ConfigureDataGrid(dgSupplierPayables, true, 4, notFound_lbl, "PurchaseOrderId",
                "SupplierName", "DateCreated", "DueDate", "CreditTerms", "PoTotal", "UserFullName");

            dgSupplierPayables.Columns["PoTotal"].DisplayIndex = dgSupplierPayables.Columns.Count - 1;
            search_tx.Clear();
        }

        public async Task GetCustomerCrtedits(PaymentStatus status)
        {
            var creds = await _service.GetCustomerCrtedits(status);

            dgCustomerCredits.DataSource = creds;
            DgExtensions.ConfigureDataGrid(dgCustomerCredits, true, 2, notFound_cust, "CustomerCreditId",
                "CustomerName", "CreditAmount", "CreditTerms", "CreditedDate", "DueDate");

            dgCustomerCredits.Columns["PoTotal"].DisplayIndex = dgSupplierPayables.Columns.Count - 1;
        }


        private async void PaymentsAndBillingForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
                filter_dt.MaxDate = _curDate.Date;
                unpaid_rd.Checked = true;
                unpaidCustomer_rd.Checked = true;
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on loading payments and billing: {ex.Message}");
            }
        }

        private async void unpaid_rd_CheckedChanged(object sender, EventArgs e)
        {
            po_title.Text = "Unpaid Purchase Orders";
            showPastDue_cb.Visible = true;
            showPastDue_cb.Checked = false;
            await LoadAllPurchaseOrders(PaymentStatus.Unpaid, false);
            payable_pb.Image = Properties.Resources.deliveryNotPaid;
        }

        private async void paid_rd_CheckedChanged(object sender, EventArgs e)
        {
            po_title.Text = "Paid Purchase Orders";
            showPastDue_cb.Visible = false;
            await LoadAllPurchaseOrders(PaymentStatus.Paid, false);
            payable_pb.Image = Properties.Resources.deliveryPaid;
        }

        private void dgSupplierPayables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int poId = DgFormatHelper.GetSelectedId(dgSupplierPayables, e, "PurchaseOrderId");
                if (poId == 0) return;

                if (paid_rd.Checked == true)
                {
                    var form = new UpdatePaymentForm(this);
                    form._referenceId = poId;
                    form._actionForm = Constants.FormConstants.SupplierPayables;
                    form._paymentType = PaymentType.SupplierPayable;
                    form.ShowDialog();
                }
                else if (unpaid_rd.Checked == true)
                {
                    var form = new ManagePayableForm(this);
                    form._actionForm = Constants.FormConstants.SupplierPayables;
                    form._poId = poId;
                    form.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error dg supplier click: {ex.Message}");
            }
        }

        private void dgSupplierPayables_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgSupplierPayables.Columns[e.ColumnIndex].Name == "DueDate") // Replace with your column name
            {
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime dueDate))
                {
                    if (dueDate < _curDate.Date) // If the due date is in the past
                    {
                        e.CellStyle.ForeColor = Color.Red; // Change the fore color to red
                        e.CellStyle.SelectionForeColor = Color.Red;
                    }
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black; // Default color for invalid or null dates
                }
            }

        }

        private async void showPastDue_cb_CheckedChanged(object sender, EventArgs e)
        {
            await LoadAllPurchaseOrders(PaymentStatus.Unpaid, showPastDue_cb.Checked);
        }


        // ------------------------------------------------- Customer Credits-------------------------------------------------
        private async void unpaidCustomer_rd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                showPastCustomer_cb.Visible = true;
                await LoadCustomerCredits(PaymentStatus.Unpaid, false);
                credit_lbl.Text = "Unpaid Customer Credits";
                creditPb.Image = Properties.Resources.atmUnpaid;
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on unpaid customer credits: {ex.Message}");
            }
        }

        private async void paidCustomer_rd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                showPastCustomer_cb.Visible = false;
                await LoadCustomerCredits(PaymentStatus.Paid, false);
                credit_lbl.Text = "Paid Customer Credits";
                creditPb.Image = Properties.Resources.atmPaid;
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on paid customer credits: {ex.Message}");
            }
        }

        private async Task LoadCustomerCredits(PaymentStatus status, bool showPastDue)
        {
            var custCreds = await _customerCredService.GetCustomerCreditsByStatus(status);
            if (showPastDue)
            {
                custCreds = custCreds.Where(x => x.DueDate < _curDate.Date).ToList();
            }
            dgCustomerCredits.DataSource = custCreds;
            DgExtensions.ConfigureDataGrid(dgCustomerCredits, true, 3, notFound_cust, "CustomerCreditId",
                "CustomerName", "CreditAmount", "CreditTerms", "CreditedDate", "DueDate");
            dgCustomerCredits.Columns["CreditAmount"].DisplayIndex = dgCustomerCredits.Columns.Count - 1;
            textBox1.Clear();
        }

        private void allTransactions_tab_Click(object sender, EventArgs e)
        {

        }

        private async void transactionsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedTabName = paymentTabControl.SelectedTab.Name;

                if (selectedTabName == Constants.CustomerCreditPaymentTabSelection.SupplierPayableTab)
                {
                    _selectedTab = Constants.CustomerCreditPaymentTabSelection.SupplierPayableTab;
                    unpaid_rd.Checked = true;
                }
                else if (selectedTabName == Constants.CustomerCreditPaymentTabSelection.CustomerCreditTab)
                {
                    _selectedTab = Constants.CustomerCreditPaymentTabSelection.CustomerCreditTab;
                    unpaidCustomer_rd.Checked = true;
                }
                else
                {
                    _selectedTab = Constants.CustomerCreditPaymentTabSelection.ExpensesTab;
                    await LoadExpensesByDate();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error tab control: {ex.Message}");
            }
        }

        public async Task LoadExpensesByDate()
        {
            var date = filter_dt.Value.Date;
            var allExp = await _expenseService.LoadAllExpensesByDate(date);
            dgExpenses.DataSource = allExp;
            FormatGrid(allExp);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgCustomerCredits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int custId = DgFormatHelper.GetSelectedId(dgCustomerCredits, e, "CustomerCreditId");
            if (custId == 0) return;

            if (paidCustomer_rd.Checked == true)
            {
                var form = new UpdatePaymentForm(this);
                form._actionForm = Constants.FormConstants.CustomerCredits;
                form._referenceId = custId;
                form._paymentType = PaymentType.CustomerCredit;
                form.ShowDialog();
            }
            else if (unpaidCustomer_rd.Checked == true)
            {
                var form = new ManagePayableForm(this);
                form._customerCreditId = custId;
                form._actionForm = Constants.FormConstants.CustomerCredits;
                form.ShowDialog();
            }
        }

        private async void showPastCustomer_cb_CheckedChanged(object sender, EventArgs e)
        {
            await LoadCustomerCredits(PaymentStatus.Unpaid, showPastCustomer_cb.Checked);
        }

        private void dgCustomerCredits_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgCustomerCredits.Columns[e.ColumnIndex].Name == "DueDate") // Replace with your column name
            {
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime dueDate))
                {
                    if (dueDate < _curDate.Date) // If the due date is in the past
                    {
                        e.CellStyle.ForeColor = Color.Red; // Change the fore color to red
                        e.CellStyle.SelectionForeColor = Color.Red;
                    }
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black; // Default color for invalid or null dates
                }
            }
        }
        // ----------------------------------------------- Expenses ------------------------------------------------
        private void new_btn_Click(object sender, EventArgs e)
        {
            var form = new ExpensesForm(this);
            form._formAction = Constants.SystemConstants.New;
            form.ShowDialog();
        }


        private void FormatGrid(List<ExpenseModel> expenses)
        {
            DgExtensions.ConfigureDataGrid(dgExpenses, true, 0, notFoundExpense, "ExpenseId",
               "Amount", "ExpenseParticular", "Company", "ReceiptNumber", "DateAdded");
            // amount index to last
            dgExpenses.Columns["Amount"].DisplayIndex = dgExpenses.Columns.Count - 1;
            total_tx.Text = expenses.Sum(x => x.Amount).ToString("N2");

        }

        private async void showAllExp_cb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                filter_dt.Value = _curDate.Date;
                var newExpList = new List<ExpenseModel>();
                if (showAllExp_cb.Checked == true)
                {
                    newExpList = await _expenseService.LoadAllExpenses();
                }
                else
                {
                    newExpList = await _expenseService.LoadAllExpensesByDate(_curDate.Date);
                }
                dgExpenses.DataSource = newExpList;
                FormatGrid(newExpList);
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error showing all expenses: {ex.Message}");
            }
        }

        private async void filter_dt_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                showAllExp_cb.Checked = false;
                await LoadExpensesByDate();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error showing date filtered expenses: {ex.Message}");
            }
        }

        private void dgExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int expId = DgFormatHelper.GetSelectedId(dgExpenses, e, "ExpenseId");
            if (expId == 0) return;

            var form = new ExpensesForm(this);
            form._formAction = Constants.SystemConstants.Edit;
            form._expenseId = expId;
            form.ShowDialog();
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgSupplierPayables, search_tx);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgCustomerCredits, textBox1);
        }
    }
}
