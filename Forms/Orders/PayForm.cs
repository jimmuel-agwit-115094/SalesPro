using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class Pay : Form
    {
        public int _orderId;
        public int _rowVersion;
        private decimal _amountDue;
        private DateTime _curDate;

        private readonly OrderService _service;
        public Pay()
        {
            InitializeComponent();
            _service = new OrderService();
        }

        private async void pay_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var cash = cash_tx.Value;
                if (cash == 0)
                {
                    MessageHandler.ShowWarning("Please enter cash amount. Amount cannot be 0");
                    return;
                }
                if (cash < _amountDue)
                {
                    MessageHandler.ShowWarning("Cash amount is less than the amount due");
                    return;
                }
                var order = CalculateOrderPayment(_amountDue);
                await _service.PayOrder(_orderId, cash, _curDate, _rowVersion, order);
                MessageHandler.ShowInfo("Order paid successfully");
                Close();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error pay button click: {ex.Message}");
            }
        }

        private OrderModel CalculateOrderPayment(decimal total)
        {
            var orderModel = new OrderModel();
            try
            {
                decimal cashTendered = cash_tx.Value;
                int discountRate = (int)discRate_tx.Value;
                // Calculate the discount amount
                decimal discountAmount = (total * discountRate) / 100;

                // Calculate the final total after discount
                decimal finalTotal = total - discountAmount;

                // Calculate the change
                decimal change = cashTendered - finalTotal;

                discAmt_tx.Value = discountAmount;
                change_tx.Value = change;

                // model
                orderModel.AmountPaid = cashTendered;
                orderModel.DiscountRate = discountRate;
                orderModel.DiscountAmount = discountAmount;
                orderModel.Change = change;
                orderModel.PaymentMethod = (PaymentMethod)paymentMethod_cb.SelectedValue;
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error calculating order payment: {ex.Message}");
            }
            return orderModel;
        }

        private async void PayForm_Load(object sender, EventArgs e)
        {
            try
            {
                var filteredPaymentMethods = Enum.GetValues(typeof(PaymentMethod))
                                  .Cast<PaymentMethod>()
                                  .Where(x => x != PaymentMethod.NotSet)
                                  .ToList();
                paymentMethod_cb.DataSource = filteredPaymentMethods;

                _curDate = await ClockHelper.GetServerDateTime();
                var order = await _service.GetOrderById(_orderId);
                if (order != null)
                {
                    amtDue_tx.Text = $"₱{order.AmountDue.ToString("N2")}";
                    _amountDue = order.AmountDue;
                    customer_tx.Text = order.CustomerName;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error pay load: {ex.Message}");
            }
        }

        private void cash_tx_ValueChanged(object sender, EventArgs e)
        {
            CalculateOrderPayment(_amountDue);
        }

        private void cash_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            // CalculateOrderPayment(_amountDue);
        }

        private void discRate_tx_ValueChanged(object sender, EventArgs e)
        {
            CalculateOrderPayment(_amountDue);
        }

        private void discAmt_tx_ValueChanged(object sender, EventArgs e)
        {

        }

        private void change_tx_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
