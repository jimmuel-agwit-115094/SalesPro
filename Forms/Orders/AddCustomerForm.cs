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
        private readonly CustomerService _customerService;
        public AddCustomerForm(OrderForm orderForm)
        {
            InitializeComponent();
            _service = new OrderService();
            _customerService = new CustomerService();
            _orderForm = orderForm;
            KeyPreview = true;
        }

        public async Task LoadCustomers()
        {
            var customers = await _customerService.GetCustomers();
            dgCustomer.DataSource = customers;
            DgExtensions.ConfigureDataGrid(dgCustomer, true, 0, notFound_lbl, "CustomerId", "FirstName",
                "MiddleName", "LastName", "Address", "ContactNumber");
        }

        private async void AddCustomerForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error customer load: {ex.Message}");
            }
        }

        private void dgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int custId = DgFormatHelper.GetSelectedId(dgCustomer, e, "CustomerId");
            if (custId == 0) return;

            var form = new ManageCustomerForm(this);
            form._customerId = custId;
            form._action = Constants.SystemConstants.Edit.ToString();
            form.ShowDialog();

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
                if (updatedOrder.RowVersion == _rowVersion)
                {
                    await _orderForm.InitializeOrderDisplay(updatedOrder);
                }
                Close();
                await _orderForm.ReloadRowVersion();
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

        private void new_btm_Click(object sender, EventArgs e)
        {
            var form = new ManageCustomerForm(this);
            form._customerId = _customerId;
            form._action = Constants.SystemConstants.New.ToString();
            form.ShowDialog();
        }
    }
}
