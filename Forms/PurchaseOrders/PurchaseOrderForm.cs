using POS_Generic.Helpers;
using SalesPro.Constants;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Properties;
using SalesPro.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.PurchaseOrders
{
    public partial class PurchaseOrderForm : Form
    {
        private readonly DatabaseContext _context;
        private readonly PurchaseOrderService _service;
        private DateTime _curDate;
        public PurchaseOrderForm()
        {
            _context = new DatabaseContext();
            _service = new PurchaseOrderService();
            InitializeComponent();
        }

        private async void new_btn_Click(object sender, EventArgs e)
        {
            var purchaseOrders = await _service.GetAllPurchaseOrders();
            var existingPO = purchaseOrders.FirstOrDefault(po => po.ProcessStatus == ProcessStatus.Created);

            if (existingPO == null || MessageHandler.ShowQuestion($"An existing Purchase Order has already been created.\n {Resources.ConfirmNew}", FormConstants.PurchaseOrder))
            {
                var savedPO = await SavePurchaseOrder();
                var form = new PurchaseOrderDetailsForm(this)
                {
                    _poId = savedPO.PurchaseOrderId,
                    _actionType = SystemConstants.New
                };
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
                    CancellationReason = string.Empty,
                    Remarks = string.Empty,
                };
                return await _service.SavePurchaseOrder(po);
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

        public async Task LoadPurchaseOrdersByProcessStatus()
        {
            // Note : The order of the tabs in the tab control should match the order of the ProcessStatus enum
            var tabProcess = (ProcessStatus)transactionsTabControl.SelectedIndex;
            var purchaseOrders = await _service.GetPurchaseOrdersByProcessStatus(tabProcess);
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
                    "PaymentStatus");
            }
        }

        private async void transactionsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadPurchaseOrdersByProcessStatus();
        }

        private void find_btn_Click(object sender, EventArgs e)
        {

        }

        private async void dgPo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int poId = DgFormatHelper.GetSelectedId(dgPo, e, "PurchaseOrderId");
                if (poId == 0) return;
                var form = new PurchaseOrderDetailsForm(this)
                {
                    _poId = poId,
                    _actionType = SystemConstants.Edit
                };
                form._rowVersion = await _service.GetPoRowVersion(poId);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error purchase order cell click: {ex.Message}");
                throw;
            }
        }
    }
}