using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Services;
using System;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class AddCustomerForm : Form
    {
        private readonly OrderService _service;
        public AddCustomerForm()
        {
            InitializeComponent();
            _service = new OrderService();
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
    }
}
