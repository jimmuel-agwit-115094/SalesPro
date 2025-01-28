using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Services;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class ManageCustomerForm : Form
    {
        public int _customerId;
        public string _action;

        private readonly AddCustomerForm _addCustomerForm;
        private readonly CustomerService _customerService;
        public ManageCustomerForm(AddCustomerForm addCustomerForm)
        {
            InitializeComponent();
            _addCustomerForm = addCustomerForm;
            _customerService = new CustomerService();
        }

        private CustomerModel BuildCustomerModel()
        {
            return new CustomerModel
            {
                FirstName = firstName_tx.Text,
                MiddleName = middleName_tx.Text,
                LastName = lastName_tx.Text,
                Address = address_tx.Text,
                Email = email_tx.Text,
                ContactNumber = contact_tx.Text
            };
        }

        private async void save_btn_Click(object sender, System.EventArgs e)
        {
            // validations
            if (firstName_tx.Text == string.Empty)
            {
                MessageHandler.ShowWarning("First Name is required.");
                firstName_tx.Select();
                return;
            }
            if (lastName_tx.Text == string.Empty)
            {
                MessageHandler.ShowWarning("Last Name is required.");
                lastName_tx.Select();
                return;
            }
            if (address_tx.Text == string.Empty)
            {
                MessageHandler.ShowWarning("Address is required.");
                address_tx.Select();
                return;
            }
            if (contact_tx.Text == string.Empty)
            {
                MessageHandler.ShowWarning("Contact Number is required.");
                contact_tx.Select();
                return;
            }

            var customerExists = await _customerService.IsCustomerExist(firstName_tx.Text, lastName_tx.Text, middleName_tx.Text);
            if (customerExists != null && customerExists.CustomerId != _customerId)
            {
                MessageHandler.ShowWarning("Customer already exists.");
                firstName_tx.Select();
                return;
            }

            var customer = BuildCustomerModel();
            if (_action == Constants.SystemConstants.New.ToString())
            {
                await _customerService.SaveCustomer(customer);
            }
            else
            {
                await _customerService.UpdateCustomer(_customerId, customer);
            }
            await _addCustomerForm.LoadCustomers();
            Close();
        }

        private async void ManageCustomerForm_Load(object sender, System.EventArgs e)
        {
            if (_action == Constants.SystemConstants.New.ToString())
            {
                title_lbl.Text = "Add Customer";
                save_btn.Text = "Save";
            }
            else
            {
                title_lbl.Text = "Update Customer";
                save_btn.Text = "Update";

                var customer = await _customerService.GetCustomerById(_customerId);
                if (customer != null)
                {
                    firstName_tx.Text = customer.FirstName;
                    middleName_tx.Text = customer.MiddleName;
                    lastName_tx.Text = customer.LastName;
                    address_tx.Text = customer.Address;
                    email_tx.Text = customer.Email;
                    contact_tx.Text = customer.ContactNumber;
                }
            }
        }

        private void ManageCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
