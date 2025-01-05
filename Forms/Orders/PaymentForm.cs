using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class PaymentForm : Form
    {
        public int _orderId;
        public int _rowVersion;
        private decimal _amountDue;
        private DateTime _curDate;

        private readonly OrderService _service;
        private readonly OrderForm _orderForm;
        public PaymentForm(OrderForm orderForm)
        {
            InitializeComponent();
            _service = new OrderService();
            TextBoxHelper.FormatDecimalTextbox(cash_tx);
            TextBoxHelper.FormatPercentageTextbox(discRate_tx);
            _orderForm = orderForm;
            KeyPreview = true;
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
                    SetControls(order.PaymentStatus);
                }
                CalculateOrderPayment(_amountDue);
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error pay load: {ex.Message}");
            }
        }

        private async void pay_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var cash = decimal.Parse(cash_tx.Text);
                if (_amountDue > 0 && cash == 0)
                {
                    MessageHandler.ShowWarning("Please enter cash amount. Amount cannot be 0");
                    return;
                }
                if (cash < _amountDue)
                {
                    MessageHandler.ShowWarning("Cash amount is less than the amount due");
                    return;
                }
                if (MessageHandler.ShowQuestionGeneric("Are you sure you want to pay this order?"))
                {
                    var order = CalculateOrderPayment(_amountDue);
                    var (invalidOrdersDetected, successUpdate) = await _service.PayOrder(_orderId, cash, _curDate, _rowVersion, order);
                    if (invalidOrdersDetected.Count() == 0 && successUpdate)
                    {
                        SetControls(PaymentStatus.Paid);
                    }
                    await _orderForm.LoadOrderedItems(_orderId, invalidOrdersDetected);
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error pay button click: {ex.Message}");
            }
        }

        private void SetControls(PaymentStatus status)
        {
            bool isPaid = (status == PaymentStatus.Paid);

            cash_tx.ReadOnly = isPaid;
            discRate_tx.ReadOnly = isPaid;
            paymentMethod_cb.Enabled = !isPaid;
            pay_btn.Enabled = !isPaid;

            paymentPhoto.Image = isPaid ? Properties.Resources.paid : Properties.Resources.payment;
        }


        private OrderModel CalculateOrderPayment(decimal total)
        {
            var orderModel = new OrderModel();
            try
            {
                decimal cashTendered = decimal.Parse(cash_tx.Text);
                decimal discountRate = decimal.Parse(discRate_tx.Text);
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
                orderModel.OrderStatus = OrderStatus.Completed;
                orderModel.DatePaid = _curDate;
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error calculating order payment: {ex.Message}");
            }
            return orderModel;
        }


        private void cash_tx_ValueChanged(object sender, EventArgs e)
        {
            CalculateOrderPayment(_amountDue);
        }


        private void discRate_tx_ValueChanged(object sender, EventArgs e)
        {
            CalculateOrderPayment(_amountDue);
        }

        private void cash_tx_KeyDown(object sender, KeyEventArgs e)
        {
            CalculateOrderPayment(_amountDue);
        }

        private void c_TextChanged(object sender, EventArgs e)
        {
            if (cash_tx.Text == string.Empty)
            {
                cash_tx.Text = "0";
            }
            CalculateOrderPayment(_amountDue);
        }

        private void discRate_tx_TextChanged(object sender, EventArgs e)
        {
            if (discRate_tx.Text == string.Empty)
            {
                discRate_tx.Text = "0";
            }
            CalculateOrderPayment(_amountDue);
        }

        private async void PaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var order = await _service.GetOrderById(_orderId);
                if (order != null && order.PaymentStatus == PaymentStatus.Paid && order.OrderStatus == OrderStatus.Completed)
                {
                    await _orderForm.CreateNewOrder();
                }
                else
                {
                    await _orderForm.InitializeOrderDisplay(order);
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on payment closing: {ex.Message}");
            }
        }

        private void PaymentForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
