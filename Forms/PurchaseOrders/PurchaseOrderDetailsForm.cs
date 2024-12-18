using SalesPro.Constants;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.PurchaseOrders
{
    public partial class PurchaseOrderDetailsForm : Form
    {
        public int _poId;
        public int _rowVersion;
        public decimal _totalPrice;
        private DateTime _curDate;
        public string _actionType;
        private bool _isSupplierSelected;
        public ProcessStatus _poTabProcess;

        private readonly PurchaseOrderService _service;
        private readonly PurchaseOrderForm _purchaseOrderForm;
        public PurchaseOrderDetailsForm(PurchaseOrderForm purchaseOrderForm)
        {
            InitializeComponent();
            _service = new PurchaseOrderService();
            _purchaseOrderForm = purchaseOrderForm;
        }

        private void addSupplier_btn_Click(object sender, EventArgs e)
        {
            AddSupplierForm addSupplierForm = new AddSupplierForm(this);
            addSupplierForm._rowVersion = _rowVersion;
            addSupplierForm.ShowDialog();
        }

        public async Task ReloadRowVersion()
        {
            _rowVersion = await _service.GetPoRowVersion(_poId);
        }

        private async void PurchaseOrderDetailsForm_Load(object sender, EventArgs e)
        {
            _curDate = await ClockHelper.GetServerDateTime();
            await LoadPurchaseOrderItemsByPoId();
            poId_tx.Text = _poId.ToString("D9");
          

            switch (_poTabProcess)
            {
                case ProcessStatus.Created:
                    action_btn.Text = "Send To Supplier";
                    action_btn.Visible = true;
                    undo_btn.Visible = false;
                    break;
                case ProcessStatus.Sent:
                    action_btn.Text = "Receive";
                    undo_btn.Text = "Undo Process";
                    action_btn.Visible = true;
                    undo_btn.Visible = true;
                    break;
                case ProcessStatus.Completed:
                    action_btn.Visible = false;
                    undo_btn.Visible = false;
                    break;
                case ProcessStatus.Cancelled:
                    action_btn.Text = "Re-Activate";
                    action_btn.Visible = true;
                    undo_btn.Visible = false;
                    break;
            }

        }

        private PurchaseOrderLogsModel BuildPurchaseOrderLogsModel(ProcessStatus processStatus, string reason)
        {
            return new PurchaseOrderLogsModel
            {
                PurchaseOrderId = _poId,
                UserId = UserSession.Session_UserId,
                ProcessStatus = processStatus,
                Reason = reason,
                Date = _curDate.Date
            };
        }

        public async Task LoadPurchaseOrderItemsByPoId()
        {
            var poItems = await _service.LoadPurchaseOrderItemsByPoId(_poId);
            if (poItems != null)
            {
                dgPoItems.DataSource = poItems;
                DgExtensions.ConfigureDataGrid(dgPoItems, true, 1, notFound_lbl,
                    "PurchaseOrderItemId", "ProductName", "Quantity", "SupplierPrice", "MarkUpPrice", "RetailPrice", "TotalPrice");
                _totalPrice = poItems.Sum(x => x.TotalPrice);
                total_tx.Text = _totalPrice.ToString("N2");
                rowCount_tx.Text = $"Product Count : {poItems.Count.ToString()}";
            }
        }

        private void dgPo_KeyDown(object sender, KeyEventArgs e)
        {
            DgFormatHelper.HandleEnterKey(e, dgPoItems);
        }

        public async Task SetSupplierDataOnControls(int supplierId)
        {
            try
            {
                // Set the supplier data on the controls
                var supplier = await _service.GetSupplierById(supplierId);
                if (supplier != null)
                {
                    supplier_tx.Text = supplier.SupplierName;
                    address_tx.Text = supplier.SupplierAddress;
                    contactPerson_tx.Text = supplier.SupplierContactPerson;
                    number_tx.Text = supplier.SupplierNumber;
                    _isSupplierSelected = true;
                }
                //Update PO to set the supplier id
                bool success = await _service.UpdatePurchaseOrder_SupplierId(_poId, supplierId, _rowVersion);
                if (!success)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error setting supplier data {ex.Message}");
                throw;
            }
        }

        private void addProduct_btn_Click(object sender, EventArgs e)
        {
            AddPurchaseProductForm form = new AddPurchaseProductForm(this);
            form._rowVersion = _rowVersion;
            form._actionType = SystemConstants.New;
            form._poId = _poId;
            form.ShowDialog();
        }

        private async void dgPoItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int poItemId = DgFormatHelper.GetSelectedId(dgPoItems, e, "PurchaseOrderItemId");
                if (poItemId == 0) return;
                var form = new AddPurchaseProductForm(this);
                form._poId = _poId;
                form._rowVersion = await _service.GetPoRowVersion(_poId);
                form._actionType = SystemConstants.Edit;
                form._poItemId = poItemId;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error getting product : {ex.Message}");
            }
        }

        private async void action_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_isSupplierSelected)
                {
                    MessageHandler.ShowWarning("Please select a supplier.");
                    return;
                }
                if (dgPoItems.Rows.Count == 0)
                {
                    MessageHandler.ShowWarning("Please add products to the purchase order.");
                    return;
                }

                switch (_poTabProcess)
                {
                    case ProcessStatus.Created:
                        var sentLog = BuildPurchaseOrderLogsModel(ProcessStatus.Sent, string.Empty);
                        await _service.UpdatePurchaseOrder_ProcessStatus(_poId, _rowVersion, ProcessStatus.Sent, sentLog);
                        break;
                    case ProcessStatus.Sent:
                        var completedLog = BuildPurchaseOrderLogsModel(ProcessStatus.Completed, string.Empty);
                        await _service.UpdatePurchaseOrder_ProcessStatus(_poId, _rowVersion, ProcessStatus.Completed, completedLog);
                        break;
                    case ProcessStatus.Completed:
                        Close();
                        break;
                    case ProcessStatus.Cancelled:
                        Close();
                        break;
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error updating PO. {ex.Message}");
            }
        }

        private async void PurchaseOrderDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await _purchaseOrderForm.LoadPurchaseOrdersByProcessStatus();
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgPoItems, search_tx);
        }

        private async void undo_btn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_poTabProcess)
                {
                    case ProcessStatus.Created:

                        break;
                    case ProcessStatus.Sent:
                        var undoLog = BuildPurchaseOrderLogsModel(ProcessStatus.Created, string.Empty);
                        await _service.UpdatePurchaseOrder_ProcessStatus(_poId, _rowVersion, ProcessStatus.Created, undoLog);
                        break;
                    case ProcessStatus.Completed:

                        break;
                    case ProcessStatus.Cancelled:
                        var cancelledLog = BuildPurchaseOrderLogsModel(ProcessStatus.Cancelled, string.Empty);
                        await _service.UpdatePurchaseOrder_ProcessStatus(_poId, _rowVersion, ProcessStatus.Created, cancelledLog);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error undoing process. {ex.Message}");
                throw;
            }
        }
    }
}
