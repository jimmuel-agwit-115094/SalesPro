using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Inventory
{
    public partial class InventoryForm : Form
    {
        private readonly InventoryService _service;
        private InventoryStatus _tabProcess;
        public InventoryForm()
        {
            InitializeComponent();
            _service = new InventoryService();
        }

        private async void InventoryForm_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error Occured on inventory form load:\n{ex.Message}");
            }
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
            var allInv = await _service.GetAllInventories();
            dgInventory.DataSource = allInv;
        }

        private async Task LoadInventoriesByInventoryStatus(InventoryStatus status)
        {
            var inv = await _service.GetInventoryByInventoryStatus(status);
            dgInventory.DataSource = inv;
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
            FormatGrid();
        }

        private void allTab_Click(object sender, EventArgs e)
        {

        }
    }
}
