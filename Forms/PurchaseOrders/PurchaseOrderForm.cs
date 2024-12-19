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
            var existingPO = purchaseOrders.FirstOrDefault(po => po.ProcessStatus == ProcessStatus.Created);

            if (existingPO == null || MessageHandler.ShowQuestion($"An existing Purchase Order has already been created.\n{Resources.ConfirmNew}", FormConstants.PurchaseOrder))
            {
                var savedPO = await SavePurchaseOrder();
                var form = new PurchaseOrderDetailsForm(this);
                form._poId = savedPO.PurchaseOrderId;
                form._actionType = SystemConstants.New;
                //form._rowVersion = await _service.GetPoRowVersion(savedPO.PurchaseOrderId);
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
                DgExtensions.ConfigureDataGrid(dgPo, true, 2, notFound_lbl,
                    "PurchaseOrderId",
                    "DateCreated",
                    "SupplierName",
                    "UserFullName",
                    "DueDate",
                    "CreditTerms",
                    "PoTotal",
                    "PaymentStatus",
                    "ProcessStatus");
            }
            return purchaseOrders;
        }

        private async void transactionsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            _purchaseOrderList = await LoadPurchaseOrdersByProcessStatus();
            _tabProcess = (ProcessStatus)transactionsTabControl.SelectedIndex;
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