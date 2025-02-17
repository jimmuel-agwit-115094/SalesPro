using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Properties;
using SalesPro.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Inventory
{
    public partial class ManageInventoryForm : Form
    {
        public int _inventoryId;
        private DateTime _curDate;

        private readonly InventoryService _service;
        private readonly InventoryForm _inventoryForm;
        public ManageInventoryForm(InventoryForm form)
        {
            InitializeComponent();
            _service = new InventoryService();
            _inventoryForm = form;
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
                qtyOnHand_tx.Text = $"{inv.QuantityOnHand.ToString()} {inv.UnitOfMeasure}";
                suppPrice_tx.Text = inv.SupplierPrice.ToString("N2");
                retailPrice_tx.Text = inv.RetailPrice.ToString("N2");
            }
        }

        private void LoadActionData()
        {
            var filtteredInvAction = Enum.GetValues(typeof(InventoryAction))
                              .Cast<InventoryAction>()
                              .Where(x => x != InventoryAction.AddedToInventory)
                              .ToList();
            action_cb.DataSource = filtteredInvAction;
        }

        private async void ManageInventoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                update_btn.Enabled = true;
                _curDate = await ClockHelper.GetServerDateTime();
                await GetInventoryData(_inventoryId);
                await LoadInventoryLogs();
                LoadActionData();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading inventory form: {ex.Message}");
            }
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
                    await _service.UpdateInventory(_inventoryId, int.Parse(adjustingQty_tx.Text), selectedAction, log);
                    await _inventoryForm.LoadInventoriesBaseOnTabSelected();
                    _inventoryForm.ResetControls();
                    update_btn.Enabled = false;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error updating inventory: {ex.Message}");
            }
        }

        private async Task LoadInventoryLogs()
        {
            var logs = await _service.GetInventoryLogsById(_inventoryId);
            dgLogs.DataSource = logs;

            DgExtensions.ConfigureDataGrid(dgLogs, false, 3, notFound_lbl,
                "UserFullName", "DateAdjusted",
                "CurrentQuantity", "AdjustmentQuantity", "FinalQuantity", "Remarks");

            dgLogs.Columns["DateAdjusted"].DisplayIndex = 0;
            // Changfe to segoe ui
            dgLogs.Columns["DateAdjusted"].DefaultCellStyle.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            // Apply row formatting based on InventoryAction
            foreach (DataGridViewRow row in dgLogs.Rows)
            {
                var log = row.DataBoundItem as InventoryLogModel; // Cast row data to the InventoryLog model
                if (log != null)
                {
                    // Find the column index for AdjustmentQuantity
                    int adjustmentQuantityColumnIndex = dgLogs.Columns["AdjustmentQuantity"].Index;
                    int dateColumnIndex = dgLogs.Columns["DateAdjusted"].Index;

                    // Format AdjustmentQuantity
                    if (adjustmentQuantityColumnIndex >= 0)
                    {
                        var cell = row.Cells[adjustmentQuantityColumnIndex];
                        var dateCell = row.Cells[dateColumnIndex];
                        int cellToInt = Convert.ToInt32(cell.Value);

                        if (log.InventoryAction == InventoryAction.Positive_Adjustment ||
                            log.InventoryAction == InventoryAction.AddedToInventory)
                        {
                            // Show negative sign and set forecolor to green
                            cell.Value = $"+{Math.Abs(Convert.ToDecimal(cell.Value))}";
                            cell.Style.ForeColor = Color.Green;
                            cell.Style.SelectionForeColor = Color.Green;

                            dateCell.Style.SelectionForeColor = Color.Green;
                            dateCell.Style.ForeColor = Color.Green;
                        }
                        else
                        {
                            // Show positive sign and set forecolor to green
                            cell.Value = $"-{Math.Abs(Convert.ToDecimal(cell.Value))}";
                            cell.Style.ForeColor = Color.Red;
                            cell.Style.SelectionForeColor = Color.Red;

                            dateCell.Style.SelectionForeColor = Color.Red;
                            dateCell.Style.ForeColor = Color.Red;
                        }

                        if (cellToInt == 0)
                        {
                            cell.Style.ForeColor = Color.Black;
                            cell.Style.SelectionForeColor = Color.Black;
                        }
                    }
                }
            }

        }
    }
}
