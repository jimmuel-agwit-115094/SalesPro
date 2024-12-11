using POS_Generic.Helpers;
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
        public string _actionType;
        private DateTime _curDate;
        public int _transactionId;
        private string _userFullname;
        public int _rowVersion;

        private readonly TransactionService _transactionService;
        private readonly DatabaseContext _context;
        public TransactionDetailsForm()
        {
            _context = new DatabaseContext();
            _transactionService = new TransactionService(_context);
            InitializeComponent();
            CurrencyTextboxHelper.ApplyNumericProperty(transactionData_tab);
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

        private TransactionModel BuilTransactionModel(BalanceStatusEnum balanceStatus)
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
                IsClosed = false,
                BalanceStatus = balanceStatus
            };
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            if (!Validators.AmountValidator(begBal_tx.Text, "Beginning Balance")) return;

            if (_actionType == SystemConstants.New)
            {
                if (MessageHandler.ShowQuestion(Resources.ConfirmSave, FormConstants.Transaction))
                {
                    var transaction = BuilTransactionModel(balanceStatus: BalanceStatusEnum.NotSet);
                    var saveLogModel = BuildTransactionLogModel(ActionsEnum.Addded, 1); // We set to 1 because we don't have the transactionId yet
                    await _transactionService.SaveTransaction(transaction, saveLogModel);
                }
            }
            else
            {
                if (MessageHandler.ShowQuestion(Resources.ConfirmUpdate, FormConstants.Transaction))
                {
                    var updateLogModel = BuildTransactionLogModel(ActionsEnum.Updated, _transactionId);
                    var begBal = decimal.Parse(begBal_tx.Text);
                    await _transactionService.UpdateTransaction(_transactionId, _rowVersion, begBal, updateLogModel);
                }
            }
            Close();
        }

        private async void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageHandler.ShowQuestion(Resources.ConfirmClose, FormConstants.Transaction))
            {
                var balanceStatus = decimal.Parse(endingCash_tx.Text) == decimal.Parse(expCash_tx.Text) ? BalanceStatusEnum.Balanced : BalanceStatusEnum.NotBalance;
                var transaction = BuilTransactionModel(balanceStatus: balanceStatus);
                var transactionLog = BuildTransactionLogModel(ActionsEnum.Closed, _transactionId);
                await _transactionService.CloseTransaction(_transactionId, _rowVersion, transaction, transactionLog);
                Close();
            }
        }

        private async void undo_btn_Click(object sender, EventArgs e)
        {
            if (MessageHandler.ShowQuestion(Resources.ConfirmUndo, FormConstants.Transaction))
            {
                var transaction = BuilTransactionModel(balanceStatus: BalanceStatusEnum.NotSet);
                var transactionLog = BuildTransactionLogModel(ActionsEnum.UndoClosed, _transactionId);
                await _transactionService.UndoCloseTransaction(_transactionId, _rowVersion, transaction, transactionLog);
                Close();
            }
        }

        private async Task GetTransactionLogs(int transactionId)
        {
            dgTransLogs.DataSource = await _transactionService.GetAllTransactionLogs(transactionId);
            FormatGrid();
        }

        // Todo : Refactor this method to add the value of the sales base on other tables in the database
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
                totalSales_tx.Text = transactionData.IsClosed == true ? transactionData.TotalSales.ToString() : "11"; // Need to be updated
                totalExp_tx.Text = transactionData.IsClosed == true ? transactionData.TotalExpenses.ToString() : "22"; // Need to be updated
                expCash_tx.Text = transactionData.IsClosed == true ? transactionData.ExpectedCash.ToString() : "33"; // Need to be updated
                endingCash_tx.Text = transactionData.IsClosed == true ? transactionData.EndingCash.ToString() : "44"; // Need to be updated

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

                // Controls
                save_btn.Enabled = isClosed == false;
                close_btn.Enabled = isClosed == false;
                undo_btn.Enabled = isClosed == true;
                begBal_tx.ReadOnly = isClosed == true;
            }
        }

        private void FormatGrid()
        {
            DgExtensions.ConfigureDataGrid(dgTransLogs, false, notFound_lbl,
             "DateUpdated",
             "BeginningBalance",
             "EndingBalance",
             "UserFullname",
             "ActionTaken");
        }

        private async void TransactionDetailsForm_Load(object sender, EventArgs e)
        {
            _curDate = await ClockHelper.GetServerDateTime();
            _userFullname = UserSession.FullName;

            if (_actionType == Constants.SystemConstants.New)
            {
                Text = "New Transaction";
                save_btn.Text = "Save";
                save_btn.BackColor = Color.Green;
                date_tx.Text = DateFormatHelper.FormatDate(_curDate);

                openedBy_tx.Text = _userFullname;

                // Controls
                close_btn.Enabled = false;
                undo_btn.Enabled = false;
                begBal_tx.ReadOnly = false;
            }
            else
            {
                Text = "Edit Transaction";
                save_btn.Text = "Update";
                save_btn.BackColor = SystemColors.HotTrack;

                await GetTransactionData();
                await GetTransactionLogs(_transactionId);
            }
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.FilterDataGridViewOnSearchText(dgTransLogs, search_tx);
        }

        private void begBal_tx_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

