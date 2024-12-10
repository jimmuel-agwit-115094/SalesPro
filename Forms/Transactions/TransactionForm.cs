using POS_Generic.Helpers;
using SalesPro.Accessors;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesPro.Forms.Transactions
{
    public partial class TransactionForm : Form
    {
        private readonly DatabaseContext _context;
        private readonly Accessor<TransactionModel> _accessor;
        private readonly TransactionAccessor _transactionAccessor;
        private DateTime _curDate;
        public TransactionForm()
        {
            _context = new DatabaseContext();
            _accessor = new Accessor<TransactionModel>();
            _transactionAccessor = new TransactionAccessor();
            InitializeComponent();
        }

        private async void TransactionForm_Load(object sender, EventArgs e)
        {
            _curDate = await ClockHelper.GetServerDateTime();
            // Triggers the SelectedIndexChanged event
            transactionsTabControl.SelectedIndex = 0;
            transactionsTabControl_SelectedIndexChanged(transactionsTabControl, EventArgs.Empty);
        }

        private void TransactionDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProcessTransactionLoad();
        }

        private async void new_btn_Click(object sender, EventArgs e)
        {
            var currentTransactions = await _transactionAccessor.GetTransactionByDate(_curDate);
            if (currentTransactions.Any())
            {
                MessageHandler.ShowWarning("Transaction already exists for the current date");
                return;
            }
            TransactionDetailsForm form = new TransactionDetailsForm();
            form.FormClosed += TransactionDetailsForm_FormClosed;
            form._actionType = Constants.SystemConstants.New;
            form.ShowDialog();
        }


        private void FormatGrid()
        {
            DgExtenstions.FormatDataGrid(dgTrans, true);
            DgFormatHelper.ShowOnlyField(dgTrans, "TransactionId", "StartDate", "OpenedBy", "ClosedBy", "EndDate", "BalanceStatus", "BeginningBalance", "EndingCash", "IsClosed");
            notFound_lbl.Visible = dgTrans.Rows.Count == 0;
        }

        private async void ProcessTransactionLoad()
        {
            var allTrans = (await _accessor.GetAllAsync()).OrderByDescending(x => x.TransactionId).ToList();
            switch (transactionsTabControl.SelectedIndex)
            {
                case 0:
                    var curTrans = allTrans.Where(x => x.StartDate.Date == _curDate.Date).ToList();
                    dgTrans.DataSource = curTrans;
                    break;
                case 1:
                    dgTrans.DataSource = allTrans;
                    break;
            }
            noRecordDate_lbl.Visible = false;
            FormatGrid();
        }

        private void transactionsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessTransactionLoad();
        }

        private async void find_btn_Click(object sender, EventArgs e)
        {
            var date = date_cb.Value.Date;

            var filteredTrans = await _transactionAccessor.GetTransactionByDate(date);
            dgTrans.DataSource = filteredTrans.OrderBy(x => x.TransactionId);
            if (filteredTrans.Count() == 0)
                noRecordDate_lbl.Visible = true;
            noRecordDate_lbl.Text = $"No records found for {date_cb.Value.Date:MMM. dd, yyyy}";
            if (date == _curDate.Date)
                noRecordDate_lbl.Visible = false;
            FormatGrid();

        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.FilterDataGridViewOnSearchText(dgTrans, search_tx);
        }

        private void dgTrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedId = DgFormatHelper.GetSelectedId(dgTrans, e, "TransactionId");
            if (selectedId == 0) return;
            TransactionDetailsForm form = new TransactionDetailsForm();
            form.FormClosed += TransactionDetailsForm_FormClosed;
            form._actionType = Constants.SystemConstants.Edit;
            form._transactionId = (int)selectedId;
            form.ShowDialog();
        }
    }
}
