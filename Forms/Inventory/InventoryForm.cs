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
        private List<InventoryProductExtended> _productList;
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
                //filter_cb.DataSource = Enum.GetValues(typeof(InventoryFilterType));
                //var selectedFilter = (InventoryFilterType)filter_cb.SelectedItem;
                filter_cb.SelectedIndex = 0; // Default to All Inventories
                _curDate = await ClockHelper.GetServerDateTime();
                await LoadFilteredInventories();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading inventory form: {ex.Message}");
            }
        }
        public async Task LoadFilteredInventories()
        {
            if (filter_cb.SelectedIndex == 0)
            {
                var allInventories = await _service.GetAllInventories();
                _inventoryList = allInventories;
                dgInventory.DataSource = allInventories;
                FormatInventoryGrid();
            }
            else if (filter_cb.SelectedIndex == 1)
            {
                var outOfStockProducts = await _service.GetOutOfStockProducts();
                dgInventory.DataSource = outOfStockProducts;
                _productList = outOfStockProducts;
                FormatProductGrid();
            }
            else if (filter_cb.SelectedIndex == 2)
            {
                var lowStoocks = await _service.GetLowStockProducts();
                dgInventory.DataSource = lowStoocks;
                _productList = lowStoocks;
                FormatProductGrid();
            }
        }

        private void dgInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (filter_cb.SelectedIndex == 0)
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
            try
            {
                if (filter_cb.SelectedIndex == 0)
                {
                    PrintInventory();
                }
                else
                {
                    PrintProductInventory();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError(ex.Message);
            }
            if (dgInventory.Rows.Count == 0)
            {
                MessageHandler.ShowWarning("No data to print.");
                return;
            }
        }

        private void PrintInventory()
        {
            var form = new PrintingForm();
            form._inventoryList = _inventoryList;
            form._formAction = Constants.FormConstants.Inventory;
            form.ShowDialog();
        }

        // Print product inventory
        public void PrintProductInventory()
        {
            var form = new PrintingForm();
            form._productParam = new Dictionary<string, string>
            {
                { "FilterType", title_lbl.Text }
            };
            form._productList = _productList;
            form._formAction = Constants.FormConstants.ProductInventory;
            form.ShowDialog();
        }

        private void FormatInventoryGrid()
        {
            DgExtensions.ConfigureDataGrid(dgInventory, true, 7, notFound_lbl,
                         "InventoryId",
                         "ProductName",
                         "DateAdded",
                         "QuantityOnHand",
                         "RetailPrice");
            DgFormatHelper.ZeroCellValuesFormat(dgInventory, "QuantityOnHand");
        }

        private void FormatProductGrid()
        {
            DgExtensions.ConfigureDataGrid(dgInventory, false, 0, notFound_lbl,
                      "ProductName",
                      "Description",
                      "Stock");
            dgInventory.Columns["ProductName"].DisplayIndex = 0;
        }

        private async void filter_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                await LoadFilteredInventories();
                if (filter_cb.SelectedIndex == 0)
                {
                    title_lbl.Text = "All Inventories";
                }
                else if (filter_cb.SelectedIndex == 1)
                {
                    title_lbl.Text = "Out Of Stock Products";
                }
                else if (filter_cb.SelectedIndex == 2)
                {
                    title_lbl.Text = "Low Stock Products";
                }
            }

            catch (Exception ex)
            {
                MessageHandler.ShowError(ex.Message);
            }
        }

    }
}
