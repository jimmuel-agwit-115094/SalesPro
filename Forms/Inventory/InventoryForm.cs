using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Inventory
{
    public partial class InventoryForm : Form
    {
        private int _inventoryId;
        private int _selectedTab;
        private DateTime _curDate;
        private readonly InventoryService _service;
        private List<InventoryModelExtended> _inventoryList;
        private Dictionary<string, string> _inventoryParam;
        public InventoryForm()
        {
            InitializeComponent();
            _service = new InventoryService();
        }

        private async void InventoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                filter_cb.DataSource = Enum.GetValues(typeof(InventoryFilterType));
                var selectedFilter = (InventoryFilterType)filter_cb.SelectedItem;
                _curDate = await ClockHelper.GetServerDateTime();
                await LoadFilteredInventories();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading inventory form: {ex.Message}");
            }

        }
        private async Task LoadFilteredInventories()
        {
            var selectedFilter = (InventoryFilterType)filter_cb.SelectedItem;
            var inv = await _service.GetFilteredInventories(selectedFilter);
            dgInventory.DataSource = inv;
            _inventoryList = inv;
            FormatGrid();
        }


        private void dgInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_selectedTab == 0)
                {
                    int invId = DgFormatHelper.GetSelectedId(dgInventory, e, "InventoryId");
                    if (invId == 0) return;
                    var form = new ManageInventoryForm(this);
                    form._inventoryId = invId;
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on cell content click: {ex.Message}");
            }
        }

        private void dgInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        public void ResetControls()
        {
            dgInventory.ClearSelection();
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgInventory, search_tx);
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (dgInventory.Rows.Count == 0)
            {
                MessageHandler.ShowWarning("No data to print.");
                return;
            }

            var form = new PrintingForm();
            form._inventoryList = _inventoryList;
            form._inventoryParam = new Dictionary<string, string>
            {
                { "InventoryType", inventoryTabControl.SelectedTab?.Text ?? "Unknown" }
            };
            form._formAction = Constants.FormConstants.Inventory;
            form.ShowDialog();
        }

        private void FormatGrid()
        {
            DgExtensions.ConfigureDataGrid(dgInventory, true, 7, notFound_lbl,
                         "InventoryId",
                         "ProductName",
                         "DateAdded",
                         "QuantityOnHand",
                         "RetailPrice");
            DgFormatHelper.ZeroCellValuesFormat(dgInventory, "QuantityOnHand");
        }

        private async void findBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateFilter = dateAdded_dt.Value.Date;
                var inv = await _service.GetInventoriesByDate(dateFilter);
                dgInventory.DataSource = inv;
                _inventoryList = inv;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error filtering inventories: {ex.Message}");
            }
        }

        private async void filter_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                await LoadFilteredInventories();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError(ex.Message);
            }
        }
    }
}
