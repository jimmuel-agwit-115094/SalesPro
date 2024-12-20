using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesPro.Forms.Inventory
{
    public partial class InventoryForm : Form
    {
        private int _inventoryId;
        private int _rowVersion;
        private DateTime _curDate;
        private readonly InventoryService _service;
        public InventoryForm()
        {
            InitializeComponent();
            action_cb.DataSource = Enum.GetValues(typeof(InventoryAction));
            _service = new InventoryService();
        }

        private async void InventoryForm_Load(object sender, EventArgs e)
        {
            _curDate = await ClockHelper.GetServerDateTime();
            await LoadFilteredInventories(false);
        }

        private void FormatGrid()
        {
            DgExtensions.ConfigureDataGrid(dgInventory, true, 3, notFound_lbl,
                   "InventoryId", "SupplierName",
                   "ProductName", "DateAdded",
                   "QuantityFromPo", "QuantityOnHand", "SupplierPrice", "RetailPrice");
        }

        private async Task LoadAllInventories()
        {
            var allInventory = await _service.GetAllInventories();
            dgInventory.DataSource = allInventory;
            FormatGrid();
        }

        private async Task LoadFilteredInventories(bool isOutofStock)
        {
            var inv = await _service.GetFilteredInventories(isOutofStock);
            dgInventory.DataSource = inv;
            FormatGrid();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private async void inventoryTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTab = inventoryTabControl.SelectedIndex;
            switch (selectedTab)
            {
                case 0:
                    await LoadFilteredInventories(false);
                    break;
                case 1:
                    await LoadFilteredInventories(true);
                    break;
                case 2:
                    await LoadAllInventories();
                    break;
            }
        }

        private void allTab_Click(object sender, EventArgs e)
        {

        }

        private async Task GetInventoryData(int inventoryId)
        {
            var inv = await _service.GetExtendedInventoryById(inventoryId);
            if (inv != null)
            {
                productName_tx.Text = inv.ProductName;
                supplier_tx.Text = inv.SupplierName;
                processedBy_tx.Text = inv.UserFullName;
                dateAdded_tx.Text = inv.DateAdded.ToString("MMM dd, yyyy");
                qtyFromPo_tx.Text = inv.QuantityFromPo.ToString();
                qtyOnHand_tx.Text = inv.QuantityOnHand.ToString();
                suppPrice_tx.Text = inv.SupplierPrice.ToString("N2");
                retailPrice_tx.Text = inv.RetailPrice.ToString("N2");
                remakrs_tx.Text = inv.Remarks;
            }
        }

        private void dgInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int invId = DgFormatHelper.GetSelectedId(dgInventory, e, "InventoryId");
                if (invId == 0) return;
                var form = new InventoryLogsForm();
                form._inventoryId = invId;
                form.total_tx.Text = qtyOnHand_tx.Text;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on cell content click: {ex.Message}");
            }
        }

        private void dgInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void dgInventory_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                _inventoryId = DgFormatHelper.GetSelectedIdOnSelectionChange(dgInventory, "InventoryId");
                if (_inventoryId == 0) return;
                await GetInventoryData(_inventoryId);
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error getting inventory data: {ex.Message}");
            }
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            InventoryAction selectedAction = (InventoryAction)action_cb.SelectedItem;
            try
            {
                if (MessageHandler.ShowQuestionGeneric("Are you sure to adjust the inventory?"))
                {
                    var log = new InventoryLogModel();
                    var inv = await _service.GetInventoryById(_inventoryId);
                    if (inv != null)
                    {
                        log.InventoryId = inv.InventoryId;
                        log.UserId = inv.UserId;
                        log.DateAdded = inv.DateAdded;
                        log.DateAdjusted = _curDate;
                        log.InventoryAction = selectedAction;
                        log.Reason = reason_tx.Text;
                        log.CurrentQuantity = inv.QuantityOnHand;
                        log.AdjustmentQuantity = int.Parse(adjustingQty_tx.Text);

                        log.FinalQuantity = selectedAction == InventoryAction.Positive_Adjustment
                            ? log.CurrentQuantity + log.AdjustmentQuantity
                            : log.CurrentQuantity - log.AdjustmentQuantity;

                    }
                    await _service.UpdateInventory(_inventoryId, int.Parse(adjustingQty_tx.Text), selectedAction, log, _rowVersion);
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error updating inventory: {ex.Message}");
            }
        }
    }
}
