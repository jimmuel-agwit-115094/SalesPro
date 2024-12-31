using SalesPro.Helpers;
using SalesPro.Services;
using System;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class PayForm : Form
    {
        public int _orderId;
        public int _rowVersion;
        private DateTime _curDate;
        private readonly OrderService _service;
        public PayForm()
        {
            InitializeComponent();
            _service = new OrderService();
        }

        private async void pay_btn_Click(object sender, EventArgs e)
        {
            try
            {
                await _service.PayOrder(_orderId, decimal.Parse(cash_tx.Text), _curDate, _rowVersion);
                MessageHandler.ShowInfo("Order paid successfully");
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error pay button click: {ex.Message}");
            }
        }

        private async void PayForm_Load(object sender, EventArgs e)
        {
            _curDate = await ClockHelper.GetServerDateTime();
        }
    }
}
