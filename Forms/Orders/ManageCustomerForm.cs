using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class ManageCustomerForm : Form
    {
        public int _customerId;

        private readonly AddCustomerForm _addCustomerForm;
        public ManageCustomerForm(AddCustomerForm addCustomerForm)
        {
            InitializeComponent();
            _addCustomerForm = addCustomerForm;
        }
    }
}
