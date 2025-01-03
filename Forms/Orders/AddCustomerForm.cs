using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class AddCustomerForm : Form
    {
        private int _customerId;
        public int _orderId;
        public int _rowVersion;

        private readonly OrderForm _orderForm;
        private readonly OrderService _service;
        public AddCustomerForm(OrderForm orderForm)
        {
            InitializeComponent();
            _service = new OrderService();
            _orderForm = orderForm;
            KeyPreview = true;
        }

        private async void AddCustomerForm_Load(object sender, EventArgs e)
        {
            try
            {
                var customers = await _service.GetCustomers();
                dgCustomer.DataSource = customers;
                DgExtensions.ConfigureDataGrid(dgCustomer, true, 0, notFound_lbl, "CustomerId", "FirstName",
                    "MiddleName", "LastName", "Address", "ContactNumber");
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error customer load: {ex.Message}");
            }
        }

        private void dgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgCustomer_SelectionChanged(object sender, EventArgs e)
        {
            _customerId = DgFormatHelper.GetSelectedIdOnSelectionChange(dgCustomer, "CustomerId");
            if (_customerId == 0) return;
        }

        private async void dgCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            await ProcessCustomer();
        }

        private async Task ProcessCustomer()
        {
            if (dgCustomer.SelectedRows.Count > 0)
            {
                var updatedOrder = await _service.UpdateOrderCustomer(_orderId, _customerId, _rowVersion);
                await _orderForm.InitializeOrderDisplay(updatedOrder);
                Close();
            }
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DgFormatHelper.SearchOnGrid(dgCustomer, search_tx);
        }

        private async void dgCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await ProcessCustomer();
            }
        }
    }
}
