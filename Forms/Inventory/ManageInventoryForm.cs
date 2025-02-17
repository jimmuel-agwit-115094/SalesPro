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
                "UserFullName", "DateAdded", "DateAdjusted", "InventoryAction",
                "CurrentQuantity", "AdjustmentQuantity", "FinalQuantity", "Remarks");
        }
    }
}
