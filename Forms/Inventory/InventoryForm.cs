using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SalesPro.Forms.Inventory
{
    public partial class InventoryForm : Form
    {
        private readonly InventoryService _service;
        private InventoryStatus _tabProcess;
        public InventoryForm()
        {
            InitializeComponent();
            action_cb.DataSource = Enum.GetValues(typeof(InventoryStatus));
            _service = new InventoryService();
        }

        private async void InventoryForm_Load(object sender, EventArgs e)
        {
            await LoadInventoriesByInventoryStatus(InventoryStatus.Active);
        }

        private void FormatGrid()
        {
            DgExtensions.ConfigureDataGrid(dgInventory, true, 3, notFound_lbl,
                   "InventoryId", "SupplierName",
                   "ProductName", "DateAdded",
                   "QuantityFromPo", "QuantityOnHand", "SupplierPrice", "RetailPrice"
                   );
        }

        private async Task LoadAllInventories()
        {
            var allInventory = await _service.GetAllInventories();
            dgInventory.DataSource = allInventory;
            FormatGrid();
        }

        private async Task LoadInventoriesByInventoryStatus(InventoryStatus status)
        {
            var inv = await _service.GetInventoryByInventoryStatus(status);
            dgInventory.DataSource = inv;
            FormatGrid();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {

        }

        private async void inventoryTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTab = inventoryTabControl.SelectedIndex;
            switch (selectedTab)
            {
                case 0:
                    await LoadInventoriesByInventoryStatus(InventoryStatus.Active);
                    break;
                case 1:
                    await LoadInventoriesByInventoryStatus(InventoryStatus.Inactive);
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
            var inv = await _service.GetInventoryById(inventoryId);
            if (inv != null)
            {
                productName_tx.Text = inv.ProductName;
                supplier_tx.Text = inv.SupplierName;
                processedBy_tx.Text = inv.UserFullName;
                dateAdded_tx.Text = inv.DateAdded.ToString("MMM dd, yyyy");
                qtyFromPo_tx.Text = inv.QuantityFromPo.ToString();
                qtyOnHand_tx.Text = inv.QuantityOnHand.ToString();
                suppPrice_tx.Text = inv.SupplierPrice.ToString();
                retailPrice_tx.Text = inv.RetailPrice.ToString();
                remakrs_tx.Text = inv.Remarks;
            }
        }

        private async void dgInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int inventoryId = DgFormatHelper.GetSelectedId(dgInventory, e, "InventoryId");
                if (inventoryId == 0) return;
                await GetInventoryData(inventoryId);
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error getting inventory data: {ex.Message}");
            }
        }
    }
}
