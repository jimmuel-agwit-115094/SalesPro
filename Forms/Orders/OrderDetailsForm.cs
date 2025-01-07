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
    public partial class OrderDetailsForm : Form
    {
        public int _orderId;
        private readonly OrderService _service;
        public OrderDetailsForm()
        {
            InitializeComponent();
            _service = new OrderService();
        }

        private async void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                var orderedItems = await _service.LoadOrderItemsByOrderId(_orderId);
                dgItems.DataSource = orderedItems;
                DgExtensions.ConfigureDataGrid(dgItems, false, 2, notFound_lbl,
                    "OrderItemId", "ProductName", "Quantity", "Price", "Total");

                var order = await _service.GetOrderById(_orderId);
                if (order != null)
                {
                    total_tx.Text = order.Total.ToString("N2");
                    orderId_tx.Text = order.OrderId.ToString();
                    userId_tx.Text = order.UserName.ToString();
                    dateTaken_tx.Text = DateFormatHelper.FormatDateWithTime(order.DateTaken);
                    customer_tx.Text = order.CustomerName.ToString();
                    isCredited_tx.Text = order.IsCredited ? "Yes" : "No";
                    orderStatus_tx.Text =order.OrderStatus.ToString();

                    // Payment Info
                    paymentStatus_tx.Text = order.PaymentStatus.ToString();
                    paymentMethod_tx.Text = order.PaymentMethod.ToString();
                    datePaid_tx.Text = DateFormatHelper.FormatDateWithTime((DateTime)order.DatePaid);
                    amtPaid_tx.Text = order.AmountPaid.ToString("N2");
                    change_tx.Text = order.Change.ToString("N2");

                    //Totals
                    totalAmt_tx.Text = order.Total.ToString("N2");
                    discRate_tx.Text = order.DiscountRate.ToString();
                    discAmt_tx.Text = order.DiscountAmount.ToString("N2");
                    vat_tx.Text = order.Vat.ToString("N2");
                    vatAmt_tx.Text = order.VatAmount.ToString("N2");
                    netAmt_tx.Text = order.NetAmount.ToString("N2");
                    amtDue_tx.Text = order.AmountDue.ToString("N2");

                    // pb
                    paidPanel.Visible = order.PaymentStatus == Enums.PaymentStatus.Paid;
                    isCreditedPanel.Visible = order.IsCredited == true;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading order details form: {ex.Message}");
            }
        }
    }
}
