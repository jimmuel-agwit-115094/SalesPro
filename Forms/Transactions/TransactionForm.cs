using POS_Generic.Helpers;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Transactions
{
    public partial class TransactionForm : Form
    {
        private MainForm _mainForm;
        private readonly TransactionService _service;
        private DateTime _curDate;
        public TransactionForm(MainForm mainForm)
        {
            _service = new TransactionService();
            InitializeComponent();
            _mainForm = mainForm;
        }

        private async void TransactionForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
                date_cb.MaxDate = _curDate.Date;
                // Triggers the SelectedIndexChanged event
                transactionsTabControl.SelectedIndex = 0;
                transactionsTabControl_SelectedIndexChanged(transactionsTabControl, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading transaction: {ex.Message}");
            }
        }

        private void TransactionDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProcessTransactionLoad();
        }

        private async void new_btn_Click(object sender, EventArgs e)
        {
            var currentTransactions = await _service.GetTransactionByDate(_curDate.Date);
            var pastTransactions = await _service.GetUnclosedPastTransactions(_curDate.Date);

            if (currentTransactions.Any())
            {
                MessageHandler.ShowWarning("Transaction already exists for the current date");
                return;
            }
            if (pastTransactions.Any())
            {
                MessageHandler.ShowWarning("Past transaction not yet closed. Please close transaction first");
                return;
            }
            TransactionDetailsForm form = new TransactionDetailsForm(this);
            form.FormClosed += TransactionDetailsForm_FormClosed;
            form._actionType = Constants.SystemConstants.New;
            form.ShowDialog();
        }

        public async Task EnableDisableMenuPanel()
        {
            await _mainForm.EnableDisableMenuPanel();
        }

        private void FormatGrid()
        {
            DgExtensions.ConfigureDataGrid(dgTrans, true, 0, notFound_lbl,
             "TransactionId",
             "StartDate",
             "OpenedBy",
             "ClosedBy",
             "EndDate",
             "BalanceStatus",
             "BeginningBalance",
             "EndingCash",
             "IsClosed");
        }

        private async void ProcessTransactionLoad()
        {
            var allTrans = await _service.GetAllTransactions();
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
            transactionDate_lbl.Visible = false;
            noRecordDate_lbl.Visible = false;
            FormatGrid();
        }

        private void transactionsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessTransactionLoad();
        }

        private async void find_btn_Click(object sender, EventArgs e)
        {
            transactionsTabControl.SelectedIndex = 1;
            var date = date_cb.Value.Date;

            var filteredTrans = await _service.GetTransactionByDate(date);
            dgTrans.DataSource = filteredTrans.OrderBy(x => x.TransactionId).ToList();
            if (filteredTrans.Count() == 0)
            {
                noRecordDate_lbl.Visible = true;
            }
            noRecordDate_lbl.Text = $"No records found for {date_cb.Value.Date:MMM. dd, yyyy}";
            if (date == _curDate.Date)
            {
                noRecordDate_lbl.Visible = false;
            }

            transactionDate_lbl.Text = $"Transaction Date: {date:MMMM dd, yyyy}";
            transactionDate_lbl.Visible = true;
            FormatGrid();

        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgTrans, search_tx);
        }

        private void dgTrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedId = DgFormatHelper.GetSelectedId(dgTrans, e, "TransactionId");
            if (selectedId == 0) return;
            TransactionDetailsForm form = new TransactionDetailsForm(this);
            form.FormClosed += TransactionDetailsForm_FormClosed;
            form._actionType = Constants.SystemConstants.Edit;
            form._transactionId = (int)selectedId;
            form.ShowDialog();
        }

        private void date_cb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            ProcessTransactionLoad();
        }
    }
}
