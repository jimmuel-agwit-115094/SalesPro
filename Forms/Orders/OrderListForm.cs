using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class OrderListForm : Form
    {
        public OrderStatus _orderStatus;

        private readonly OrderService _service;
        public OrderListForm()
        {
            InitializeComponent();
            _service = new OrderService();
        }

        private async void OrderListForm_Load(object sender, EventArgs e)
        {
            try
            {
                var orders = await _service.LoadOrdersByStatus(_orderStatus);
                dgOrders.DataSource = orders;
                DgExtensions.ConfigureDataGrid(dgOrders, false, 3, notFound_lbl,
                     "CustomerName", "DateTaken", "Total", "AmountPaid", "AmountDue", "OrderStatus");
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading order list form: {ex.Message}");
            }
        }
    }
}
