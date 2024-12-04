using POS_Generic.Helpers;
using SalesPro.Accessors;
using SalesPro.Models;
using System;
using System.Windows.Forms;

namespace SalesPro.Forms.Transactions
{
    public partial class TransactionForm : Form
    {
        private readonly DatabaseContext _context;
        private readonly GenericAccessor<TransactionModel> _accessor;
        public TransactionForm()
        {
            _context = new DatabaseContext();
            _accessor = new GenericAccessor<TransactionModel>(_context);
            InitializeComponent();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            var form = new TransactionDetailsForm();
            form.ShowDialog();
        }

        private async void transactionsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var trans = await _accessor.GetAllAsync();
            dgTrans.DataSource = trans;
            DgExtenstions.ShowOnlyField(dgTrans, "TransactionId", "StartDate", "EndDate", "BeginningBalance");
        }
    }
}
