using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesPro.Forms.Transactions
{
    public partial class TransactionDetailsForm : Form
    {
        public string actionType;
        private DateTime _curDate;
        public int transactionId;
        private string _userFullname;
        public int _rowVersion;


        private readonly TransactionService _transactionService;
        public TransactionDetailsForm()
        {
            _transactionService = new TransactionService();
            InitializeComponent();
            CurrencyTextboxHelper.ApplyNumericProperty(transactionData_tab);
        }

        private void begBal_tx_TextChanged(object sender, EventArgs e)
        {
        }

        private TransactionLogModel BuildTransactionLogModel(string action)
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

        private TransactionModel BuilTransactionModel()
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
                BalanceStatus = Constants.SystemConstants.NotSet
            };
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            if (!Validators.AmountValidator(begBal_tx.Text, "Beginning Balance")) return;

            if (actionType == Constants.SystemConstants.New)
            {
                var transaction = BuilTransactionModel();
                var saveLogModel = BuildTransactionLogModel(Constants.SystemConstants.New);
                await _transactionService.SaveTransaction(transaction, saveLogModel);
            }
            else
            {
                var updateLogModel = BuildTransactionLogModel(Constants.SystemConstants.Updated);
                var begBal = decimal.Parse(begBal_tx.Text);
                await _transactionService.UpdateTransaction(transactionId, begBal, updateLogModel);
            }
            Close();
        }

        private async void GetTransactionLogs(int transactionId)
        {
            dgTransLogs.DataSource = await _transactionService.GetAllTransactionLogs(transactionId);
            FormatGrid();
        }

        private async void GetTransactionData()
        {
            var transactionData = await _transactionService.GetTransactionById(transactionId);
            if (transactionData != null)
            {
                balStatus_tx.Text = transactionData.BalanceStatus == Constants.SystemConstants.Balanced ? "Balanced" : "Unbalanced";
                closeStatus_tx.Text = transactionData.IsClosed ? "Closed" : string.Empty;
                closeStatus_tx.Visible = transactionData.IsClosed == true;
                openedBy_tx.Text = transactionData.OpenedBy;
                closedBy_tx.Text = transactionData.ClosedBy;
                date_tx.Text = DateFormatHelper.FormatDate(transactionData.StartDate);
                begBal_tx.Text = transactionData.BeginningBalance.ToString();
                // System Generated Data
                totalSales_tx.Text = transactionData.IsClosed == true ? transactionData.TotalSales.ToString() : "69";
                totalExp_tx.Text = transactionData.IsClosed == true ? transactionData.TotalExpenses.ToString() : "69";
                expCash_tx.Text = transactionData.IsClosed == true ? transactionData.ExpectedCash.ToString() : "69";
                endingCash_tx.Text = transactionData.IsClosed == true ? transactionData.EndingCash.ToString() : "69";

                // Notifications
                if (balStatus_tx.Text == Constants.SystemConstants.Balanced)
                {
                    StatusIconHelper.ShowStatus(Enums.StatusType.Good, bal_panel, "Balanced");
                }
                else
                {
                    StatusIconHelper.ShowStatus(Enums.StatusType.Bad, bal_panel, "Unbalanced");
                }
                if (closeStatus_tx.Text == Constants.SystemConstants.Closed)
                {
                    StatusIconHelper.ShowStatus(Enums.StatusType.Good, close_panel, "Closed Transaction");

                }
            }

        }

        private void FormatGrid()
        {
            DgExtenstions.FormatDataGrid(dgTransLogs, false);
            DgFormatHelper.ShowOnlyField(dgTransLogs, "DateUpdated", "BeginningBalance", "EndingBalance", "UserFullname", "ActionTaken");
            DgFormatHelper.SetDataGridStyles(dgTransLogs);
        }

        private async void TransactionDetailsForm_Load(object sender, EventArgs e)
        {
            _curDate = await ClockHelper.GetServerDateTime();
            _userFullname = UserSession.FullName;

            if (actionType == Constants.SystemConstants.New)
            {
                Text = "New Transaction";
                save_btn.Text = "Save";
                save_btn.BackColor = Color.Green;
                date_tx.Text = DateFormatHelper.FormatDate(_curDate);

                openedBy_tx.Text = _userFullname;
            }
            else
            {
                Text = "Edit Transaction";
                save_btn.Text = "Update";
                save_btn.BackColor = SystemColors.HotTrack;

                GetTransactionData();
                GetTransactionLogs(transactionId);
            }
        }

        private void transactionData_tab_Click(object sender, EventArgs e)
        {

        }

        private async void close_btn_Click(object sender, EventArgs e)
        {
            var transaction = BuilTransactionModel();
            var transactionLog = BuildTransactionLogModel(Constants.SystemConstants.Closed);
            await _transactionService.CloseTransaction(transactionId, transaction, transactionLog);
            Close();
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.FilterDataGridViewOnSearchText(dgTransLogs, search_tx);
        }
    }
}

