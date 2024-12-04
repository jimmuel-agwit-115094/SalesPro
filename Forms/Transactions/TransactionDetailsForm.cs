using SalesPro.Helpers.UiHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
