using POS_Generic.Helpers;
using SalesPro.Accessors;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SalesPro.Forms.Transactions
{
    public partial class TransactionForm : Form
    {
        private readonly DatabaseContext _context;
        private readonly Accessor<TransactionModel> _accessor;
        private DateTime? _curDate;
        public TransactionForm()
        {
            _context = new DatabaseContext();
            _accessor = new Accessor<TransactionModel>(_context);
            InitializeComponent();
        }

        private async void TransactionForm_Load(object sender, EventArgs e)
        {
            _curDate = await ServerDateTimeHelper.GetServerDateTime();
            // Triggers the SelectedIndexChanged event
            transactionsTabControl.SelectedIndex = 0;
            transactionsTabControl_SelectedIndexChanged(transactionsTabControl, EventArgs.Empty);
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
            var allTrans = await _accessor.GetAllAsync();
            switch (transactionsTabControl.SelectedIndex)
            {
                case 0:
                    var curTrans = allTrans.Where(x => x.StartDate.Date == _curDate.Value.Date).ToList();
                    dgTrans.DataSource = curTrans;
                    break;
                case 1:
                    dgTrans.DataSource = allTrans;
                    break;
            }
            DgExtenstions.FormatDataGrid(dgTrans, true);
            DgFormatHelper.ShowOnlyField(dgTrans, "TransactionId", "StartDate", "EndDate", "BeginningBalance", "EndingCash", "OpenedBy");
            notFound_lbl.Visible = dgTrans.Rows.Count == 0;
        }

        private void dgTrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void find_btn_Click(object sender, EventArgs e)
        {
            var trans = await _accessor.GetAllAsync();
            var date = date_cb.Value.Date;
            if (trans != null)
            {
                dgTrans.DataSource = trans;
                DgExtenstions.FormatDataGrid(dgTrans, true);
                DgFormatHelper.ShowOnlyField(dgTrans, "TransactionId", "StartDate", "EndDate", "BeginningBalance", "EndingCash", "OpenedBy");
                notFound_lbl.Visible = dgTrans.Rows.Count == 0;
            }
        }
    }
}
