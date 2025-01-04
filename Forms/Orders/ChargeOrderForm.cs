using SalesPro.Services;
using System;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class ChargeOrderForm : Form
    {
        public int _orderId;
        public int _rowVersion;
        public int _customerId;

        private readonly OrderForm _orderForm;
        private readonly OrderService _service;
        public ChargeOrderForm(OrderForm orderForm)
        {
            InitializeComponent();
            _service = new OrderService();
            _orderForm = orderForm;
        }

        private void ChargeOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
