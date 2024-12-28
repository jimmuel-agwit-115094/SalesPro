using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class OrderForm : Form
    {
        private DateTime _curDate;
        private int _rowVersion;
        private readonly OrderService _service;
        public OrderForm()
        {
            InitializeComponent();
            _service = new OrderService();
        }

        private async void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
                SetFormSize();
                _service.SaveOrder(new OrderModel
                {
                    AmountDue = 0,
                    AmountPaid = 0,
                    Change = 0,
                    CustomerId = 1,
                    DatePaid = DateTime.Now,
                    DateTaken = DateTime.Now,
                    DiscountAmount = 0,
                    DiscountRate = 0,
                    NetAmount = 0,
                    OrderStatus = "Open",
                    PaymentMethod = "Cash",
                    PaymentStatus = "Unpaid",
                    Total = 0,
                    UserId = 1,
                    Vat = 0,
                    VatAmount = 0
                });
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error order form load : {ex.Message}");
            }
        }

        private void SetFormSize()
        {
            WindowState = FormWindowState.Maximized;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            Size = workingArea.Size;
            Location = workingArea.Location;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            var form = new AddOrderItemForm();
            form.ShowDialog();
        }
    }
}
