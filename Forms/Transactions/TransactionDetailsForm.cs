using POS_Generic.Helpers;
using SalesPro.Accessors;
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
            InitializeComponent();
            CurrencyTextboxHelper.AttachCurrencyValidation(this, "Decimal");
        }

        private void begBal_tx_TextChanged(object sender, EventArgs e)
        {
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            var transaction = new TransactionModel
            {
                StartDate = startDtp.Value,
                EndDate = endDtp.Value,
                BeginningBalance = decimal.Parse(begBal_tx.Text),
                TotalSales = decimal.Parse(totalSales_tx.Text),
                TotalExpenses = decimal.Parse(totalExp_tx.Text),
                ExpectedCash = decimal.Parse(expCash_tx.Text),
                EndingCash = decimal.Parse(endCash_tx.Text),
                OpenedBy = openedBy_tx.Text,
                ClosedBy = closedBy_tx.Text,
                IsClosed = isClosed_tx.Text,
                BalanceStatus = balStatus_tx.Text
            };

            await _accessor.AddAsync(transaction);
            this.Close();
        }
    }
}
