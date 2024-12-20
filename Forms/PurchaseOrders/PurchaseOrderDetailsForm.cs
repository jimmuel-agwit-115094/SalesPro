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
    public partial class PurchaseOrderDetailsForm : Form
    {
        public int _poId;
        public int _rowVersion;
        public decimal _totalPrice;
        private DateTime _curDate;
        public string _actionType;
        private bool _isSupplierSelected = false;
        public ProcessStatus _poTabProcess;
        private int _supplierId;

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
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
                var po = await _service.GetPurchaseorderById(_poId);
                if (po == null) return;

                // Notifications
                switch (po.ProcessStatus)
                {
                    case ProcessStatus.Created:
                        StatusIconHelper.ShowStatus(IconStatusType.Created, process_panel, "Created PO");
                        break;
                    case ProcessStatus.Sent:
                        StatusIconHelper.ShowStatus(IconStatusType.Sent, process_panel, "Sent To Sup.");
                        break;
                    case ProcessStatus.Completed:
                        StatusIconHelper.ShowStatus(IconStatusType.Completed, process_panel, "Completed");
                        break;
                    case ProcessStatus.Cancelled:
                        StatusIconHelper.ShowStatus(IconStatusType.Cancelled, process_panel, "Cancelled");
                        break;
                }

                switch (po.PaymentStatus)
                {
                    case PaymentStatus.Paid:
                        StatusIconHelper.ShowStatus(IconStatusType.Good, payment_panel, "Paid");
                        break;
                    case PaymentStatus.Unpaid:
                        StatusIconHelper.ShowStatus(IconStatusType.Cancelled, payment_panel, "Unpaid");
                        break;

                }

                creditTerms_tx.Text = po.CreditTerms.ToString();
                var supplier = await _service.GetSupplierById(po.SupplierId);
                if (supplier != null)
                {
                    _supplierId = supplier.SupplierId;
                    supplier_tx.Text = supplier.SupplierName;
                    address_tx.Text = supplier.SupplierAddress;
                    contactPerson_tx.Text = supplier.SupplierContactPerson;
                    number_tx.Text = supplier.SupplierNumber;
                    _isSupplierSelected = supplier.SupplierId != 1;
                }
                await LoadPurchaseOrderItemsByPoId();
                poId_tx.Text = _poId.ToString("D9");

                switch (_poTabProcess)
                {
                    case ProcessStatus.Created:
                        action_btn.Text = "Send To Supplier";
                        undo_btn.Text = "Cancel PO";
                        action_btn.Visible = true;
                        undo_btn.Visible = true;
                        creditTermsPanel.Visible = false;

                        addProduct_btn.Visible = true;
                        addSupplier_btn.Visible = true;
                        break;
                    case ProcessStatus.Sent:
                        action_btn.Text = "Receive";
                        undo_btn.Text = "Undo Process";
                        action_btn.Visible = true;
                        undo_btn.Visible = true;
                        creditTermsPanel.Visible = true;
                        creditTerms_tx.ReadOnly = false;

                        addProduct_btn.Visible = false;
                        addSupplier_btn.Visible = false;
                        DgFormatHelper.DisableColumnClick(dgPoItems, "PurchaseOrderItemId");
                        break;
                    case ProcessStatus.Completed:
                        action_btn.Visible = false;
                        undo_btn.Visible = false;
                        creditTermsPanel.Visible = true;
                        creditTerms_tx.ReadOnly = true;

                        addProduct_btn.Visible = false;
                        addSupplier_btn.Visible = false;
                        DgFormatHelper.DisableColumnClick(dgPoItems, "PurchaseOrderItemId");
                        break;
                    case ProcessStatus.Cancelled:
                        action_btn.Text = "Re-Activate";
                        action_btn.Visible = true;
                        undo_btn.Visible = false;
                        creditTermsPanel.Visible = false;

                        addProduct_btn.Visible = false;
                        addSupplier_btn.Visible = false;
                        DgFormatHelper.DisableColumnClick(dgPoItems, "PurchaseOrderItemId");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on Purchase order detail form load: {ex.Message}");
            }
        }

        private PurchaseOrderLogsModel BuildPurchaseOrderLogsModel(PoLogActionStatus processStatus)
        {
            return new PurchaseOrderLogsModel
            {
                PurchaseOrderId = _poId,
                UserId = UserSession.Session_UserId,
                PoLogActionStatus = processStatus,
                Date = _curDate
            };
        }

        private async Task<List<InventoryModel>> BuildInventoryModel(int purchaseOrderId, int supplierId)
        {
            var poItems = await _service.GetPurchaseOrderItemsByPoid(purchaseOrderId);
            var inventoryModels = new List<InventoryModel>();

            foreach (var poItem in poItems)
            {
                inventoryModels.Add(new InventoryModel
                {
                    PurchaseOrderId = poItem.PurchaseOrderId,
                    ProductId = poItem.ProductId,
                    SupplierId = supplierId,
                    UserId = UserSession.Session_UserId,
                    QuantityFromPo = poItem.Quantity,
                    QuantityOnHand = poItem.Quantity,
                    SupplierPrice = poItem.SupplierPrice,
                    RetailPrice = poItem.RetailPrice,
                    DateAdded = _curDate,
                });
            }
            return inventoryModels;
        }

        private async Task<List<InventoryLogModel>> BuildInventoryLogsModel(int purchaseOrderId)
        {
            var poItems = await _service.GetPurchaseOrderItemsByPoid(purchaseOrderId);
            var inventoryLogsModel = new List<InventoryLogModel>();
            foreach(var  item in poItems)
            {
                inventoryLogsModel.Add(new InventoryLogModel
                {
                    InventoryId = item.PurchaseOrderItemId,
                    UserId = UserSession.Session_UserId,
                    DateAdded = _curDate,
                    DateAdjusted = _curDate,
                    InventoryAction = InventoryAction.AddedToInventory,
                    Remarks = "Added from Purchase Order",
                    AdjustmentQuantity = 0,
                    CurrentQuantity = item.Quantity,
                    FinalQuantity = item.Quantity
                });
            }
            return inventoryLogsModel;
        }

        public async Task LoadPurchaseOrderItemsByPoId()
        {
            var poItems = await _service.LoadPurchaseOrderItemsByPoId(_poId);
            if (poItems != null)
            {
                dgPoItems.DataSource = poItems;
                DgExtensions.ConfigureDataGrid(dgPoItems, true, 2, notFound_lbl,
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
                if (!_isSupplierSelected && _poTabProcess != ProcessStatus.Cancelled)
                {
                    MessageHandler.ShowWarning("Please select a supplier.");
                    return;
                }
                if (dgPoItems.Rows.Count == 0 && _poTabProcess != ProcessStatus.Cancelled)
                {
                    MessageHandler.ShowWarning("Please add products to the purchase order.");
                    return;
                }

                switch (_poTabProcess)
                {
                    case ProcessStatus.Created:
                        if (MessageHandler.ShowQuestionGeneric("Are you sure you want to send to supplier?"))
                        {
                            var sentLog = BuildPurchaseOrderLogsModel(PoLogActionStatus.SentToSupplier);
                            await _service.UpdatePurchaseOrder_ProcessStatus(_poId, _rowVersion, 0, ProcessStatus.Sent, sentLog);
                            _purchaseOrderForm.transactionsTabControl.SelectedIndex = 1;
                            Close();
                        }
                        break;
                    case ProcessStatus.Sent:
                        if (!Validators.IntValidator(creditTerms_tx.Text, "Credit Terms")) return;
                        if (MessageHandler.ShowQuestionGeneric("Are you sure you want to receive purchase order?"))
                        {
                            var completedLog = BuildPurchaseOrderLogsModel(PoLogActionStatus.CompletedPo);
                            var inventory = await BuildInventoryModel(_poId, _supplierId);
                            var inventoryLogs = await BuildInventoryLogsModel(_poId);
                            await _service.UpdatePurchaseOrder_ProcessStatus(_poId, _rowVersion, int.Parse(creditTerms_tx.Text), ProcessStatus.Completed, completedLog, inventory, inventoryLogs);
                            _purchaseOrderForm.transactionsTabControl.SelectedIndex = 2;
                            Close();
                        }
                        break;
                    case ProcessStatus.Completed:
                        Close();
                        break;
                    case ProcessStatus.Cancelled:
                        if (MessageHandler.ShowQuestionGeneric("Are you sure you want to Reactivate purchase order?"))
                        {
                            var completedLog = BuildPurchaseOrderLogsModel(PoLogActionStatus.ReactivatedPo);
                            await _service.UpdatePurchaseOrder_ProcessStatus(_poId, _rowVersion, int.Parse(creditTerms_tx.Text), ProcessStatus.Created, completedLog);
                            _purchaseOrderForm.transactionsTabControl.SelectedIndex = 0;
                            Close();
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error updating PO. {ex}");
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
                        if (MessageHandler.ShowQuestionGeneric("Are you sure you want to Cancel Purchase Order?"))
                        {
                            var undoLog = BuildPurchaseOrderLogsModel(PoLogActionStatus.CancelledPo);
                            await _service.UpdatePurchaseOrder_ProcessStatus(_poId, _rowVersion, 0, ProcessStatus.Cancelled, undoLog);
                            _purchaseOrderForm.transactionsTabControl.SelectedIndex = 3;
                            Close();
                        }
                        break;
                    case ProcessStatus.Sent:
                        if (MessageHandler.ShowQuestionGeneric("Are you sure you want to Undo Purchase Order to created?"))
                        {
                            var undoLog = BuildPurchaseOrderLogsModel(PoLogActionStatus.UndoPoToCreated);
                            await _service.UpdatePurchaseOrder_ProcessStatus(_poId, _rowVersion, 0, ProcessStatus.Created, undoLog);
                            _purchaseOrderForm.transactionsTabControl.SelectedIndex = 0;
                            Close();
                        }
                        break;
                    case ProcessStatus.Completed:

                        break;
                    case ProcessStatus.Cancelled:
                        if (MessageHandler.ShowQuestionGeneric("Are you sure you want to Reactivate Purchase order?"))
                        {
                            var cancelledLog = BuildPurchaseOrderLogsModel(PoLogActionStatus.ReactivatedPo);
                            await _service.UpdatePurchaseOrder_ProcessStatus(_poId, _rowVersion, 0, ProcessStatus.Created, cancelledLog);
                            Close();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error undoing process. {ex.Message}");
                throw;
            }
        }

        private void creditTerms_tx_ValueChanged(object sender, EventArgs e)
        {

        }

        private void showLogs_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new PoLogsForm();
            form._poId = _poId;
            form.ShowDialog();
        }
    }
}
