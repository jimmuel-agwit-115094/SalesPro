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
            addSupplierForm.ShowDialog();
        }

        private async void PurchaseOrderDetailsForm_Load(object sender, EventArgs e)
        {
            _curDate = await ClockHelper.GetServerDateTime();
            await LoadPurchaseOrderItemsByPoId();
            poId_tx.Text = _poId.ToString("D9");
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
                }
                //Update PO to set the supplier id
                await _service.UpdatePurchaseOrder_SupplierId(_poId, supplierId);
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error setting supplier data {ex.Message}");
                throw;
            }
        }

        private async void addProduct_btn_Click(object sender, EventArgs e)
        {
            AddPurchaseProductForm form = new AddPurchaseProductForm(this);
            if (_actionType == SystemConstants.New)
            {
                form._rowVersion = await _service.GetPoRowVersion(_poId);
            }
            else
            {
                form._rowVersion = _rowVersion;
            }
            form._poId = _poId;
            form.ShowDialog();
        }

        private void dgPoItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int poItemId = DgFormatHelper.GetSelectedId(dgPoItems, e, "PurchaseOrderItemId");
            if (poItemId == 0) return;
            var form = new AddPurchaseProductForm(this)
            {
                _poId = _poId,
                _rowVersion = _rowVersion,
                _actionType = SystemConstants.Edit,
                _poItemId = poItemId
            };
            form.ShowDialog();
        }

        private async void action_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var sentLog = BuildPurchaseOrderLogsModel(ProcessStatus.Sent, string.Empty);
                await _service.UpdatePurchaseOrder_ProcessStatus(_poId, _rowVersion, ProcessStatus.Sent, sentLog);
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
    }
}
