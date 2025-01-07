using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
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
        private DateTime _curDate;
        public string _action;

        private readonly OrderForm _orderForm;
        private readonly OrderService _service;
        private readonly CustomerCreditService _creditService;
        public ChargeOrderForm(OrderForm orderForm)
        {
            InitializeComponent();
            _service = new OrderService();
            _orderForm = orderForm;
            _creditService = new CustomerCreditService();
        }

        private async void ChargeOrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                credTerms_tx.Focus();
                _curDate = await ClockHelper.GetServerDateTime();

                var order = await _service.GetOrderById(_orderId);
                var credit = await _creditService.GetCustomerCreditByOrderId(_orderId);

                if (order == null)
                {
                    MessageHandler.ShowError("Order not found");
                    return;
                }

                if (credit != null)
                {
                    amtDue_tx.Text = credit.CreditAmount.ToString("N2");
                    customer_tx.Text = order.CustomerName;

                    dateCredited_tx.Text = DateFormatHelper.FormatDate(credit.CreditedDate);
                    dueDate_tx.Text = DateFormatHelper.FormatDate(credit.DueDate);
                    credTerms_tx.Value = credit.CreditTerms;
                    invoice_tx.Text = credit.InvoiceNumber;
                    notes_tx.Text = credit.Notes;
                }
                else
                {
                    amtDue_tx.Text = order.Total.ToString("N2");
                    customer_tx.Text = order.CustomerName;

                    dateCredited_tx.Text = DateFormatHelper.FormatDate(_curDate);
                    dueDate_tx.Text = "To be set";
                    credTerms_tx.Value = 0;
                    invoice_tx.Clear();
                    notes_tx.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error charge form load: {ex.Message}");
            }
        }

        private async void charge_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var credTerms = int.Parse(credTerms_tx.Text);
                var order = await _service.GetOrderById(_orderId);
                if (order == null)
                {
                    MessageHandler.ShowError("Order not found");
                    return;
                }

                if (order.CustomerId == 1)
                {
                    MessageHandler.ShowWarning("Credit cannot be applied to a generic customer. Please select a valid customer to proceed.");
                    return;
                }

                if (credTerms == 0)
                {
                    MessageHandler.ShowWarning("Credit terms cannot be 0. Please enter a valid credit term to proceed.");
                    return;
                }

                if (MessageHandler.ShowQuestionGeneric("Are you sure you want to charge this order?"))
                {
                    var credModel = new CustomerCreditModel()
                    {
                        OrderId = _orderId,
                        CustomerId = order.CustomerId,
                        CreditAmount = order.Total,
                        CreditTerms = credTerms,
                        CreditedDate = _curDate,
                        Notes = notes_tx.Text,
                        DueDate = _curDate.Date.AddDays(credTerms),
                        InvoiceNumber = invoice_tx.Text,
                        PaymentStatus = PaymentStatus.Unpaid,
                    };
                    var chargedOrder = await _service.ChargeOrder(_orderId, credModel, _rowVersion);
                    // Date paid is null if the order is not paid yet.
                    if (chargedOrder.DatePaid != null)
                    {
                        await _orderForm.CreateNewOrder();
                    }
                    else
                    {
                        var existingOrder = await _service.GetOrderById(_orderId);
                        await _orderForm.InitializeOrderDisplay(existingOrder);
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error charge button click: {ex.Message}");
            }
        }

        private void credTerms_tx_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
