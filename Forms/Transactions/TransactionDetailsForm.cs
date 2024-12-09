using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Accessors;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
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
        }

        private void begBal_tx_TextChanged(object sender, EventArgs e)
        {
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            if (!Validators.AmountValidator(begBal_tx.Text, "Beginning Balance")) return;

            var transaction = new TransactionModel
            {
                StartDate = _curDate,
                EndDate = _curDate,
                BeginningBalance = decimal.Parse(begBal_tx.Text),
                TotalSales = decimal.Parse(totalSales_tx.Text),
                TotalExpenses = decimal.Parse(totalExp_tx.Text),
                ExpectedCash = decimal.Parse(expCash_tx.Text),
                EndingCash = decimal.Parse(endingCash_tx.Text),
                OpenedBy = _userFullname,
                ClosedBy = string.Empty,
                IsClosed = false,
                BalanceStatus = Constants.SystemConstants.NotSet
            };

            var transactionLog = new TransactionLogModel
            {
                BeginningBalance = transaction.BeginningBalance,
                EndingBalance = transaction.EndingCash,
                DateUpdated = _curDate,
                UserFullname = _userFullname,
                ActionTaken = Constants.SystemConstants.Addded
            };

            if (actionType == Constants.SystemConstants.New)
            {
                await _transactionService.SaveTransaction(transaction, transactionLog);
            }
            else
            {
                await _transactionService.UpdateTransaction(transactionId, transaction, transactionLog);
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
            balStatus_tx.Text = transactionData.BalanceStatus == Constants.SystemConstants.Balanced ? "Balanced" : "Unbalanced";
            closeStatus_tx.Text = transactionData.IsClosed ? "Closed" : string.Empty;
            closeStatus_tx.Visible = transactionData.IsClosed == true;
            openedBy_tx.Text = transactionData.OpenedBy;
            closedBy_tx.Text = transactionData.ClosedBy;
            date_tx.Text = DateFormatHelper.FormatDate(transactionData.StartDate);
            begBal_tx.Text = transactionData.BeginningBalance.ToString();
            totalSales_tx.Text = transactionData.TotalSales.ToString();
            totalExp_tx.Text = transactionData.TotalExpenses.ToString();
            expCash_tx.Text = transactionData.ExpectedCash.ToString();
            endingCash_tx.Text = transactionData.EndingCash.ToString();

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

        private void FormatGrid()
        {
            DgExtenstions.FormatDataGrid(dgTransLogs, false);
            DgFormatHelper.ShowOnlyField(dgTransLogs, "DateUpdated", "BeginningBalance", "EndingBalance", "UserFullname", "ActionTaken");
            DgFormatHelper.SetDataGridStyles(dgTransLogs);
        }

        private async void TransactionDetailsForm_Load(object sender, EventArgs e)
        {
            CurrencyTextboxHelper.ApplyTagBehavior(transactionData_tab);
            _curDate = await ServerDateTimeHelper.GetServerDateTime();
            _userFullname = UserSession.FullName;
            openedBy_tx.Text = _userFullname;

            GetTransactionData();
            GetTransactionLogs(transactionId);
            if (actionType == Constants.SystemConstants.New)
            {
                Text = "New Transaction";
                save_btn.Text = "Save";
                save_btn.BackColor = Color.Green;
                date_tx.Text = DateFormatHelper.FormatDate(_curDate);
            }
            else
            {
                Text = "Edit Transaction";
                save_btn.Text = "Update";
                save_btn.BackColor = SystemColors.HotTrack;
            }
        }

        private void transactionData_tab_Click(object sender, EventArgs e)
        {

        }

        private async void close_btn_Click(object sender, EventArgs e)
        {
            await _transactionService.CloseTransaction(transactionId);
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.FilterDataGridViewOnSearchText(dgTransLogs, search_tx);
        }
    }
}

