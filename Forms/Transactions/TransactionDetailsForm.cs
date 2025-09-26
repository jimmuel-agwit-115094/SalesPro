using SalesPro.Constants;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Properties;
using SalesPro.Services;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Transactions
{
    public partial class TransactionDetailsForm : Form
    {
        private TransactionForm _transactionForm;
        public string _actionType;
        private DateTime _curDate;
        public int _transactionId;
        private string _userFullname;
        public int _rowVersion;

        private readonly ReportService _reportService;
        private readonly TransactionService _transactionService;
        public TransactionDetailsForm(TransactionForm transactionForm)
        {
            _transactionService = new TransactionService();
            InitializeComponent();
            CurrencyTextboxHelper.ApplyNumericProperty(transactionData_tab);
            _transactionForm = transactionForm;
            _reportService = new ReportService();
            TextBoxHelper.FormatDecimalTextbox(begBal_tx);
            TextBoxHelper.FormatDecimalTextbox(endingCash_tx);
        }

        private TransactionLogModel BuildTransactionLogModel(ActionsEnum action, int transactionId)
        {
            return new TransactionLogModel
            {
                TransactionId = transactionId,
                BeginningBalance = decimal.Parse(begBal_tx.Text),
                EndingBalance = decimal.Parse(endingCash_tx.Text),
                DateUpdated = _curDate,
                UserFullname = _userFullname,
                ActionTaken = action
            };
        }

        private TransactionModel BuilTransactionModel(BalanceStatusEnum balanceStatus, bool isClosed)
        {
            return new TransactionModel
            {
                StartDate = _curDate,
                EndDate = _curDate,
                BeginningBalance = decimal.Parse(begBal_tx.Text),
                TotalSales = decimal.Parse(totalSales_tx.Text),
                TotalExpenses = decimal.Parse(totalExp_tx.Text),
                ExpectedCash = decimal.Parse(expCash_tx.Text),
                EndingCash = decimal.Parse(endingCash_tx.Text),
                OpenedBy = _userFullname,
                ClosedBy = _userFullname,
                IsClosed = isClosed,
                BalanceStatus = balanceStatus
            };
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validators.AmountValidator(begBal_tx.Text, "Beginning Balance")) return;
                var hasTransaction = await _transactionService.HasTransactionsCurrentDay(_curDate.Date);

                if (_actionType == SystemConstants.New)
                {
                    if (hasTransaction)
                    {
                        MessageHandler.ShowWarning("Transaction already exists for the current date");
                        return;
                    }
                    if (MessageHandler.ShowQuestionGeneric("Save Transaction?"))
                    {
                        var transaction = BuilTransactionModel(balanceStatus: BalanceStatusEnum.NotSet, isClosed: false);
                        var saveLogModel = BuildTransactionLogModel(ActionsEnum.Addded, _transactionId); // We set to 1 because we don't have the transactionId yet
                        await _transactionService.SaveTransaction(transaction, saveLogModel);
                        await _transactionForm.EnableDisableMenuPanel();
                        Close();
                    }
                }
                else
                {
                    if (MessageHandler.ShowQuestionGeneric("Update transaction?"))
                    {
                        var updateLogModel = BuildTransactionLogModel(ActionsEnum.Updated, _transactionId);
                        var begBal = decimal.Parse(begBal_tx.Text);
                        await _transactionService.UpdateTransaction(_transactionId, begBal, updateLogModel, _rowVersion);
                        Close();
                    }
                }
                await _transactionForm.ProcessTransactionLoad();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error saving transaction: {ex.Message}");
            }

        }

        private async void close_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageHandler.ShowQuestion(Resources.ConfirmClose, FormConstants.Transaction))
                {
                    var balanceStatus = decimal.Parse(endingCash_tx.Text) == decimal.Parse(expCash_tx.Text) ? BalanceStatusEnum.Balanced : BalanceStatusEnum.NotBalance;
                    var transaction = BuilTransactionModel(balanceStatus: balanceStatus, isClosed: true);
                    var transactionLog = BuildTransactionLogModel(ActionsEnum.Closed, _transactionId);
                    await _transactionService.CloseTransaction(_transactionId, _rowVersion, transaction, transactionLog);
                    await _transactionForm.EnableDisableMenuPanel();
                    await _transactionForm.ProcessTransactionLoad();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error closing transaction: {ex.Message}");
            }
        }

        private async void undo_btn_Click(object sender, EventArgs e)
        {
            if (MessageHandler.ShowQuestion(Resources.ConfirmUndo, FormConstants.Transaction))
            {
                var transaction = BuilTransactionModel(balanceStatus: BalanceStatusEnum.NotSet, isClosed: false);
                var transactionLog = BuildTransactionLogModel(ActionsEnum.UndoClosed, _transactionId);
                await _transactionService.UndoCloseTransaction(_transactionId, _rowVersion, transaction, transactionLog);
                await _transactionForm.EnableDisableMenuPanel();
                await _transactionForm.ProcessTransactionLoad();
                Close();
            }
        }

        private async Task GetTransactionLogs(int transactionId)
        {
            dgTransLogs.DataSource = await _transactionService.GetAllTransactionLogs(transactionId);
            FormatGrid();
        }

        private async Task GetTransactionData()
        {
            var transactionData = await _transactionService.GetTransactionById(_transactionId);
            if (transactionData == null)
            {
                MessageHandler.ShowError("Transaction not found");
                Close();
            }
            else
            {
                var isClosed = transactionData.IsClosed;
                _rowVersion = transactionData.RowVersion;
                //Properties
                balStatus_tx.Text = transactionData.BalanceStatus == BalanceStatusEnum.Balanced ? "Balanced" : "Unbalanced";
                closeStatus_tx.Text = transactionData.IsClosed ? "Closed" : string.Empty;
                closeStatus_tx.Visible = transactionData.IsClosed == true;
                openedBy_tx.Text = transactionData.OpenedBy;
                closedBy_tx.Text = transactionData.ClosedBy;
                date_tx.Text = DateFormatHelper.FormatDate(transactionData.StartDate);
                begBal_tx.Text = transactionData.BeginningBalance.ToString();
                // System Generated Data

                DateTime startDate = transactionData.StartDate.Date;
                DateTime endDate = transactionData.EndDate.Date;

                decimal totalSales = await _reportService.GetTotalSalesByDate(startDate, endDate);
                decimal totalExpenses = await _reportService.GetTotalExpensesByDate(startDate, endDate);
                decimal totalCash = await _reportService.GetTotalCashSalesByDate(startDate, endDate);

                decimal expectedCash = (totalCash + transactionData.BeginningBalance) - totalExpenses;

                totalSales_tx.Text = transactionData.IsClosed == true ? transactionData.TotalSales.ToString() : totalSales.ToString();
                totalExp_tx.Text = transactionData.IsClosed == true ? transactionData.TotalExpenses.ToString() : totalExpenses.ToString();
                expCash_tx.Text = transactionData.IsClosed == true ? transactionData.ExpectedCash.ToString() : expectedCash.ToString();
                endingCash_tx.Text = transactionData.IsClosed == true ? transactionData.EndingCash.ToString() : "0.00";

                // Notifications
                if (balStatus_tx.Text == BalanceStatusEnum.Balanced.ToString())
                {
                    StatusIconHelper.ShowStatus(Enums.IconStatusType.Good, bal_panel, "Balanced");
                }
                else
                {
                    StatusIconHelper.ShowStatus(Enums.IconStatusType.Bad, bal_panel, "Unbalanced");
                }
                if (closeStatus_tx.Text == ActionsEnum.Closed.ToString())
                {
                    StatusIconHelper.ShowStatus(Enums.IconStatusType.Good, close_panel, "Closed Transaction");
                }

                var id = TransactionSession._transactionId;
                bool showUndoButton = transactionData.IsClosed && transactionData.TransactionId >= id;
                // Controls
                save_btn.Enabled = isClosed == false;
                close_btn.Enabled = isClosed == false;
                undo_btn.Visible = showUndoButton;
                begBal_tx.ReadOnly = isClosed == true;
                endingCash_tx.ReadOnly = isClosed == true;
            }
        }

        private void FormatGrid()
        {
            DgExtensions.ConfigureDataGrid(dgTransLogs, false, 0, notFound_lbl,
             "DateUpdated",
             "BeginningBalance",
             "EndingBalance",
             "UserFullname",
             "ActionTaken");
        }

        private async void TransactionDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
                _userFullname = UserSession.FullName;

                if (_actionType == SystemConstants.New)
                {
                    Text = "New Transaction";
                    save_btn.Text = "Create Transaction";
                    save_btn.BackColor = Color.Green;
                    date_tx.Text = DateFormatHelper.FormatDate(_curDate);

                    openedBy_tx.Text = _userFullname;

                    // Controls
                    endingCash_tx.ReadOnly = true;
                    close_btn.Enabled = false;
                    undo_btn.Enabled = false;
                    begBal_tx.ReadOnly = false;
                }
                else
                {
                    endingCash_tx.ReadOnly = false;
                    Text = "Edit Transaction";
                    save_btn.Text = "Update";
                    save_btn.BackColor = SystemColors.HotTrack;
                    await GetTransactionData();
                    await GetTransactionLogs(_transactionId);
                }

            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading transaction details: {ex}");
            }

        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgTransLogs, search_tx);
        }

        private void begBal_tx_ValueChanged(object sender, EventArgs e)
        {

        }

        private void begBal_tx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

