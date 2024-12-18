using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Services;
using System;
using System.Windows.Forms;

namespace SalesPro.Forms.PurchaseOrders
{
    public partial class PoLogsForm : Form
    {
        public int _poId;

        private readonly PurchaseOrderService _service;
        public PoLogsForm()
        {
            InitializeComponent();
            _service = new PurchaseOrderService();
        }

        private async void PoLogsForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                var logs = await _service.GetPurchaseOrderLogsByPoId(_poId);
                if (logs != null)
                {
                    dgLogs.DataSource = logs;
                    DgExtensions.ConfigureDataGrid(dgLogs, false, 1, notFound_lbl, "Date", "PoLogActionStatus", "UserFullName");
                    notFound_lbl.Visible = logs.Count == 0;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on PO logs form load: {ex.Message}");
                throw;
            }
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgLogs, search_tx);
        }
    }
}
