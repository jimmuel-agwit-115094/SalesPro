using SalesPro.Constants;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Properties;
using SalesPro.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.PurchaseOrders
{
    public partial class PurchaseOrderForm : Form
    {
        private ProcessStatus _tabProcess;
        private readonly PurchaseOrderService _service;
        private DateTime _curDate;
        private List<PurchaseOrderModelExtended> _purchaseOrderList;
        public PurchaseOrderForm()
        {
            _service = new PurchaseOrderService();
            InitializeComponent();
        }

        private async void new_btn_Click(object sender, EventArgs e)
        {
            transactionsTabControl.SelectedIndex = 0;
            var purchaseOrders = await _service.GetAllPurchaseOrders();
            var existingPO = purchaseOrders
                 .Where(po => po.ProcessStatus == ProcessStatus.Created && po.PoTotal == 0)
                 .OrderByDescending(po => po.PurchaseOrderId)
                 .FirstOrDefault();

            //if (existingPO == null || MessageHandler.ShowQuestion($"An existing Purchase Order has already been created.\n{Resources.ConfirmNew}", FormConstants.PurchaseOrder))
            if (existingPO == null)
            {
                var savedPO = await SavePurchaseOrder();
                var form = new PurchaseOrderDetailsForm(this);
                form._poId = savedPO.PurchaseOrderId;
                form._actionType = SystemConstants.New;
                form.ShowDialog();
            }
            else
            {
                var form = new PurchaseOrderDetailsForm(this);
                form._poId = existingPO.PurchaseOrderId;
                form._rowVersion = existingPO.RowVersion;
                form._actionType = SystemConstants.New;
                form.ShowDialog();
            }
        }

        private async Task<PurchaseOrderModel> SavePurchaseOrder()
        {
            try
            {
                var po = new PurchaseOrderModel
                {
                    SupplierId = 1,
                    UserId = UserSession.Session_UserId,
                    DateCreated = _curDate.Date,
                    DueDate = _curDate.Date,
                    CreditTerms = 0,
                    PoTotal = 0,
                    ProcessStatus = ProcessStatus.Created,
                    PaymentStatus = PaymentStatus.Unpaid,
                    Remarks = string.Empty,
                };

                return await _service.SavePurchaseOrder(po, _curDate);
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error saving PO {ex.Message}");
                throw;
            }
        }

        private async void PurchaseOrderForm_Load(object sender, EventArgs e)
        {
            // Triggers the SelectedIndexChanged event
            transactionsTabControl.SelectedIndex = 0;
            transactionsTabControl_SelectedIndexChanged(transactionsTabControl, EventArgs.Empty);
            _curDate = await ClockHelper.GetServerDateTime();
        }

        public async Task<List<PurchaseOrderModelExtended>> LoadPurchaseOrdersByProcessStatus()
        {
            var purchaseOrders = new List<PurchaseOrderModelExtended>();
            // Note : The order of the tabs in the tab control should match the order of the ProcessStatus enum
            var tabProcess = (ProcessStatus)transactionsTabControl.SelectedIndex;
            purchaseOrders = await _service.GetPurchaseOrdersByProcessStatus(tabProcess);
            if (purchaseOrders != null)
            {
                dgPo.DataSource = purchaseOrders;
                DgExtensions.ConfigureDataGrid(dgPo, true, 4, notFound_lbl,
                    "PurchaseOrderId",
                    "DateCreated",
                    "SupplierName",
                    "UserFullName",
                    "DueDate",
                    "CreditTerms",
                    "PoTotal",
                    "PaymentStatus",
                    "ProcessStatus");

                dgPo.Columns["PoTotal"].DisplayIndex = dgPo.Columns.Count - 1;
            }
            return purchaseOrders;
        }

        private async void transactionsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            _purchaseOrderList = await LoadPurchaseOrdersByProcessStatus();
            _tabProcess = (ProcessStatus)transactionsTabControl.SelectedIndex;
            SetStatusBar();
        }

        private void SetStatusBar()
        {
            if (transactionsTabControl.SelectedIndex == 0)
            {
                createdPb.Image = Resources.greenCheck;
                sentPb.Image = Resources.grayCheck;
                completedPb.Image = Resources.grayCheck;
                cancelledPb.Image = Resources.grayCheck;
                statusProgress.Value = 0;
            }
            else if (transactionsTabControl.SelectedIndex == 1)
            {
                createdPb.Image = Resources.greenCheck;
                sentPb.Image = Resources.greenCheck;
                completedPb.Image = Resources.grayCheck;
                cancelledPb.Image = Resources.grayCheck;
                statusProgress.Value = 35;
            }
            else if (transactionsTabControl.SelectedIndex == 2)
            {
                createdPb.Image = Resources.greenCheck;
                sentPb.Image = Resources.greenCheck;
                completedPb.Image = Resources.greenCheck;
                cancelledPb.Image = Resources.grayCheck;
                statusProgress.Value =65;
            }
            else if (transactionsTabControl.SelectedIndex == 3)
            {
                createdPb.Image = Resources.grayCheck;
                sentPb.Image = Resources.grayCheck;
                completedPb.Image = Resources.grayCheck;
                cancelledPb.Image = Resources.delete;
                statusProgress.Value = 0;
            }
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var date = date_cb.Value.Date;
                if (_purchaseOrderList != null || _purchaseOrderList.Count != 0)
                {
                    var filteredPos = _purchaseOrderList.Where(x => x.DateCreated.Date == date).ToList();
                    dgPo.DataSource = filteredPos;
                    notFound_lbl.Visible = filteredPos.Count == 0;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error finding date on Purchase Order: {ex.Message}");
                throw;
            }
        }

        private async void dgPo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int poId = DgFormatHelper.GetSelectedId(dgPo, e, "PurchaseOrderId");
                if (poId == 0) return;

                var form = new PurchaseOrderDetailsForm(this);
                form._poId = poId;
                form._actionType = SystemConstants.Edit;
                form._poTabProcess = _tabProcess;
                form._rowVersion = await _service.GetPoRowVersion(poId);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error purchase order cell click: {ex.Message}");
                throw;
            }
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgPo, search_tx);
        }
    }
}