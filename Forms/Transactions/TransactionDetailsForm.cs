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
        private readonly DatabaseContext _context;
        private readonly GenericAccessor<TransactionModel> _accessor;
        public TransactionDetailsForm()
        {
            _context = new DatabaseContext();
            _accessor = new GenericAccessor<TransactionModel>(_context);
            CurrencyTextboxHelper.AttachCurrencyValidation(this, "Decimal");
            InitializeComponent();
        }

        private void begBal_tx_TextChanged(object sender, EventArgs e)
        {
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            var date = await ServerDateTimeHelper.GetServerDateTime();
            var transaction = new TransactionModel
            {
                StartDate = date.Date,
                EndDate = date.Date,
                BeginningBalance = decimal.Parse(begBal_tx.Text),
                TotalSales = decimal.Parse(totalSales_tx.Text),
                TotalExpenses = decimal.Parse(totalExp_tx.Text),
                ExpectedCash = decimal.Parse(expCash_tx.Text),
                EndingCash = decimal.Parse(endingCash_tx.Text),
                OpenedBy = UserSession.FullName,
                ClosedBy = closedBy_tx.Text,
                IsClosed = false,
                BalanceStatus = Constants.SystemConstants.NotSet
            };

            await _accessor.AddAsync(transaction);
            MessageHandler.SuccessfullyAdded();
            Close();
        }

        private void TransactionDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
