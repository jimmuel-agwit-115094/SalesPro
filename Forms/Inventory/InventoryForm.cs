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
            _service = new InventoryService();
        }

        private async void InventoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
                var filtteredInvAction = Enum.GetValues(typeof(InventoryAction))
                                    .Cast<InventoryAction>()
                                    .Where(x => x != InventoryAction.AddedToInventory)
                                    .ToList();
                action_cb.DataSource = filtteredInvAction;
                await LoadFilteredInventories(false);
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading inventory form: {ex.Message}");
            }

        }

        private void FormatGrid()
        {
            try
            {
                DgExtensions.ConfigureDataGrid(dgInventory, true, 3, notFound_lbl,
                  "InventoryId", "SupplierName",
                  "ProductName", "DateAdded",
                  "QuantityFromPo", "QuantityOnHand", "SupplierPrice", "RetailPrice");
                DgFormatHelper.ZeroCellValuesFormat(dgInventory, "QuantityOnHand");
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error formatting grid: {ex.Message}");
            }
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

        private async Task LoadInventoriesBaseOnTabSelected()
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

        private async void inventoryTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadInventoriesBaseOnTabSelected();
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
                _rowVersion = inv.RowVersion;
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
                update_btn.Enabled = true;
                await GetInventoryData(_inventoryId);
           
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error getting inventory data: {ex.Message}");
            }
        }

        private void ResetControls()
        {
            productName_tx.Text = "-";
            supplier_tx.Text = "-";
            processedBy_tx.Text = "-";
            dateAdded_tx.Text = "-";

            qtyFromPo_tx.Text = "0";
            qtyOnHand_tx.Text = "0";
            suppPrice_tx.Text = "0.00";
            retailPrice_tx.Text = "0.00";

            adjustingQty_tx.Value = 0;
            action_cb.SelectedIndex = -1;
            reason_tx.Clear();
            dgInventory.ClearSelection();

            update_btn.Enabled = false;
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var inventory = new InventoryModel();
                var inv = await _service.GetInventoryById(_inventoryId);
                if (inv != null)
                {
                    inventory = inv;
                }

                if (dgInventory.SelectedRows.Count == 0)
                {
                    MessageHandler.ShowWarning("Please select an inventory to update.");
                    return;
                }
                if (UserSession.UserAccess != UserAccess.Admin && UserSession.UserAccess != UserAccess.Developer)
                {
                    MessageHandler.ShowRestrictionMessage(Resources.UserRestrictionMessage);
                    return;
                }
                if (!Validators.IntValidator(adjustingQty_tx.Text, "Adjusting Quantity"))
                    return;

                if (!Validators.ComboBoxValidator(action_cb, "Action"))
                    return;

                if (!Validators.EmptyStringValidator(reason_tx.Text, "Reason"))
                    return;

                if (action_cb.SelectedIndex == 1 && inventory.QuantityOnHand <= 0)
                {
                    MessageHandler.ShowWarning("Cannot perform negative adjustment on zero quantity.");
                    return;
                }

                if (action_cb.SelectedIndex == 1 && decimal.Parse(adjustingQty_tx.Text) > inventory.QuantityOnHand)
                {
                    MessageHandler.ShowWarning("The adjusted quantity will result in a negative value for the Quantity On Hand. This operation is not allowed. Please check the adjustment amount and try again.");
                    return;
                }

                if (MessageHandler.ShowQuestionGeneric("Are you sure to adjust the inventory?"))
                {
                    InventoryAction selectedAction = (InventoryAction)action_cb.SelectedItem;
                    var log = new InventoryLogModel();

                    if (inventory != null)
                    {
                        log.InventoryId = inventory.InventoryId;
                        log.UserId = inventory.UserId;
                        log.DateAdded = inventory.DateAdded;
                        log.DateAdjusted = _curDate;
                        log.InventoryAction = selectedAction;
                        log.Remarks = reason_tx.Text;
                        log.CurrentQuantity = inventory.QuantityOnHand;
                        log.AdjustmentQuantity = int.Parse(adjustingQty_tx.Text);

                        log.FinalQuantity = selectedAction == InventoryAction.Positive_Adjustment
                            ? log.CurrentQuantity + log.AdjustmentQuantity
                            : log.CurrentQuantity - log.AdjustmentQuantity;

                    }
                    await _service.UpdateInventory(_inventoryId, int.Parse(adjustingQty_tx.Text), selectedAction, log, _rowVersion);
                    dgInventory.SelectionChanged -= dgInventory_SelectionChanged;
                    await LoadInventoriesBaseOnTabSelected();
                    ResetControls();
                    dgInventory.SelectionChanged += dgInventory_SelectionChanged;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error updating inventory: {ex.Message}");
            }
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgInventory, search_tx);
        }
    }
}
