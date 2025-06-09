using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Transactions
{
    public partial class TransactionForm : Form
    {
        private MainForm _mainForm;
        private readonly TransactionService _service;
        private DateTime _curDate;
        public TransactionForm(MainForm mainForm)
        {
            _service = new TransactionService();
            InitializeComponent();
            _mainForm = mainForm;
        }

        private async void TransactionForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
                date_cb.MaxDate = _curDate.Date;
                await ProcessTransactionLoad();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading transaction: {ex.Message}");
            }
        }

        private async void TransactionDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await ProcessTransactionLoad();
        }

        private async void new_btn_Click(object sender, EventArgs e)
        {
            var currentTransactions = await _service.GetTransactionByDate(_curDate.Date);
            var pastTransactions = await _service.GetUnclosedPastTransactions(_curDate.Date);

            if (currentTransactions.Any())
            {
                MessageHandler.ShowWarning("Transaction already exists for the current date");
                return;
            }
            if (pastTransactions.Any())
            {
                MessageHandler.ShowWarning("Past transaction not yet closed. Please close transaction first");
                return;
            }
            TransactionDetailsForm form = new TransactionDetailsForm(this);
            form.FormClosed += TransactionDetailsForm_FormClosed;
            form._actionType = Constants.SystemConstants.New;
            form.ShowDialog();
        }

        public async Task EnableDisableMenuPanel()
        {
            await _mainForm.EnableDisableMenuPanel();
        }

        private void FormatGrid()
        {
            DgExtensions.ConfigureDataGrid(dgTrans, true, 0, notFound_lbl,
             "TransactionId",
             "StartDate",
             "OpenedBy",
             "ClosedBy",
             "EndDate",
             "BalanceStatus",
             "BeginningBalance",
             "EndingCash",
             "IsClosed");
        }

        private async Task ProcessTransactionLoad()
        {
            var transactions = new List<TransactionModel>();
            // Get the unclosed transaction that is not dated on the current date
            var unclosedTransactions = await _service.GetUnclosedTransactions(_curDate.Date);
            var currentTransactions = await _service.GetTransactionByDate(_curDate.Date);

            if (unclosedTransactions.Any())
            {
                // Display unclosed transactions
                transactions = unclosedTransactions;
                unclosed_panel.Visible = true;
                find_btn.Enabled = false;
            }
            else
            {
                // Display all transactions
                transactions = await _service.GetAllTransactions();
                unclosed_panel.Visible = false;
                find_btn.Enabled = true;
            }

            noTransactionPanel.Visible = !currentTransactions.Any();

            dgTrans.DataSource = transactions;
            transactionDate_lbl.Visible = false;
            noRecordDate_lbl.Visible = false;
            search_tx.Clear();
            FormatGrid();
            new_btn.Enabled = !currentTransactions.Any() && !unclosedTransactions.Any();
        }

        private async void transactionsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            await ProcessTransactionLoad();
        }

        private async void find_btn_Click(object sender, EventArgs e)
        {
            var date = date_cb.Value.Date;

            var filteredTrans = await _service.GetTransactionByDate(date);
            dgTrans.DataSource = filteredTrans.OrderBy(x => x.TransactionId).ToList();
            if (filteredTrans.Count() == 0)
            {
                noRecordDate_lbl.Visible = true;
            }
            noRecordDate_lbl.Text = $"No records found for {date_cb.Value.Date:MMM. dd, yyyy}";
            if (date == _curDate.Date)
            {
                noRecordDate_lbl.Visible = false;
            }

            transactionDate_lbl.Text = $"Transaction Date: {date:MMMM dd, yyyy}";
            transactionDate_lbl.Visible = true;
            FormatGrid();

        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgTrans, search_tx);
        }

        private void dgTrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedId = DgFormatHelper.GetSelectedId(dgTrans, e, "TransactionId");
            if (selectedId == 0) return;
            TransactionDetailsForm form = new TransactionDetailsForm(this);
            form.FormClosed += TransactionDetailsForm_FormClosed;
            form._actionType = Constants.SystemConstants.Edit;
            form._transactionId = (int)selectedId;
            form.ShowDialog();
        }

        private void date_cb_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void refresh_btn_Click(object sender, EventArgs e)
        {
            await ProcessTransactionLoad();
        }

        private void dgTrans_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgTrans.Columns[e.ColumnIndex].Name == "BalanceStatus") // Replace with your column name
            {
                if (e.Value.ToString() == "Balanced")
                {
                    e.CellStyle.BackColor = Color.LimeGreen; // Change the fore color to red
                    e.CellStyle.SelectionBackColor = Color.LimeGreen;
                }
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
