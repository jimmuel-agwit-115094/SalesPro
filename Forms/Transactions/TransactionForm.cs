using POS_Generic.Helpers;
using SalesPro.Accessors;
using SalesPro.Helpers;
using SalesPro.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesPro.Forms.Transactions
{
    public partial class TransactionForm : Form
    {
        private readonly DatabaseContext _context;
        private readonly GenericAccessor<TransactionModel> _accessor;
        private DateTime? _curDate;
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

        private void ShowCurrentTranscations()
        {
            transactionsTabControl.SelectedIndex = 0;
        }

        private async void ShowCurrentTransaction()
        {
            var trans = await _accessor.GetAllAsync();

        }

        private async void transactionsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            DgFormatHelper.BasicGridFormat(dgTrans);
            var allTrans = await _accessor.GetAllAsync();
            switch (transactionsTabControl.SelectedIndex)
            {
                case 0:
                    var curTrans = allTrans.Select(x => x.StartDate == _curDate).ToList();
                    dgTrans.DataSource = curTrans;
                    break;
                case 1:
                    dgTrans.DataSource = allTrans;
                    break;
            }
            DgFormatHelper.ShowOnlyField(dgTrans, "TransactionId", "StartDate", "EndDate", "BeginningBalance", "EndingCash", "OpenedBy");
            dgTrans.AutoFormat();
            DgFormatHelper.SetupLinkId(dgTrans, 0);
        }

        private void dgTrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
