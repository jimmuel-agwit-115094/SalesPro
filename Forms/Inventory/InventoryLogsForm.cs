using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesPro.Forms.Inventory
{
    public partial class InventoryLogsForm : Form
    {
        public int _inventoryId;
        private readonly InventoryService _service;
        public InventoryLogsForm()
        {
            InitializeComponent();
            _service = new InventoryService();
        }

        private async void InventoryLogsForm_Load(object sender, EventArgs e)
        {
            try
            {
                var logs = await _service.GetInventoryLogsById(_inventoryId);
                dgLogs.DataSource = logs;
                DgExtensions.ConfigureDataGrid(dgLogs, false, 3, notFound_lbl,
                    "UserFullName", "DateAdded", "DateAdjusted", "InventoryAction",
                    "CurrentQuantity", "AdjustmentQuantity", "FinalQuantity", "Remarks");

                var inv = await _service.GetExtendedInventoryById(_inventoryId);
                if (inv != null)
                {
                    product_tx.Text = inv.ProductName;
                }
              
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on inv logs form load: {ex.Message}");
            }
        }

        private void dgLogs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgLogs.Columns[e.ColumnIndex].Name == "InventoryAction") // Replace with your column name
            {
                if (e.Value != null && e.Value.ToString() == "Negative_Adjustment") // Replace "SpecificString" with your condition
                {
                    e.CellStyle.ForeColor = Color.Red; // Change the fore color to green
                    e.CellStyle.SelectionForeColor = Color.Red;
                }
                else if (e.Value != null && e.Value.ToString() == "Positive_Adjustment")
                {
                    e.CellStyle.ForeColor = Color.Green; // Change the fore color to red
                    e.CellStyle.SelectionForeColor = Color.Green;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black; // Default color
                }
            }
        }
    }
}
