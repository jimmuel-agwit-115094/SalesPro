using POS_Generic.Helpers;
using SalesPro.Accessors;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using System;
using System.Windows.Forms;

namespace SalesPro.Forms.Transactions
{
    public partial class TransactionDetailsForm : Form
    {
        public string actionType;
        private DateTime _curDate;
        public int transactionId;
        private string _userFullname;
        private readonly DatabaseContext _context;
        private readonly Accessor<TransactionModel> _accessor;
        public TransactionDetailsForm()
        {
            _context = new DatabaseContext();
            _accessor = new Accessor<TransactionModel>(_context);
            CurrencyTextboxHelper.AttachCurrencyValidation(this, "Decimal");
            InitializeComponent();
        }

        private void begBal_tx_TextChanged(object sender, EventArgs e)
        {
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
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
                ClosedBy = closedBy_tx.Text,
                IsClosed = false,
                BalanceStatus = Constants.SystemConstants.NotSet
            };

            await _accessor.AddAsync(transaction);
            MessageHandler.SuccessfullyAdded();
            Close();
        }

        private async void GetTransactionData()
        {
            var transactionData = await _accessor.GetByIdAsync(transactionId);
            if (transactionData != null)
            {
                switch (transactionData.BalanceStatus)
                {
                    case Constants.SystemConstants.NotSet:
                        balStatus_tx.Text = "Not Set";
                        break;
                    case Constants.SystemConstants.Balanced:
                        balStatus_tx.Text = "Balanced";
                        break;
                    default:
                        balStatus_tx.Text = "Not Balanced";
                        break;
                }

                openedBy_tx.Text = transactionData.OpenedBy;
                closedBy_tx.Text = transactionData.ClosedBy;
                begBal_tx.Text = transactionData.BeginningBalance.ToString();
                totalSales_tx.Text = transactionData.TotalSales.ToString();
                totalExp_tx.Text = transactionData.TotalExpenses.ToString();
                expCash_tx.Text = transactionData.ExpectedCash.ToString();
                endingCash_tx.Text = transactionData.EndingCash.ToString();
            }
        }

        private async void TransactionDetailsForm_Load(object sender, EventArgs e)
        {
            _curDate = await ServerDateTimeHelper.GetServerDateTime();
            _userFullname = UserSession.FullName;
            openedBy_tx.Text = _userFullname;

            GetTransactionData();
            if (actionType == Constants.SystemConstants.New)
            {
                Text = "New Transaction";
                save_btn.Text = "Save";
            }
            else
            {
                Text = "Edit Transaction";
                save_btn.Text = "Update";
            }
        }
    }
}
