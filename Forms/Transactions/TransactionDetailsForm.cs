using SalesPro.Accessors;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using System;
using System.Windows.Forms;

namespace SalesPro.Forms.Transactions
{
    public partial class TransactionDetailsForm : Form
    {
        public TransactionDetailsForm()
        {
            InitializeComponent();
            CurrencyTextboxHelper.AttachCurrencyValidation(this, "Decimal");
        }

        private void begBal_tx_TextChanged(object sender, EventArgs e)
        {
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
        }
    }
}
