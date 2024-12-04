using System;
using System.Windows.Forms;

namespace SalesPro.Forms.Transactions
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            var form = new TransactionDetailsForm();
            form.ShowDialog();
        }
    }
}
