using SalesPro.Constants;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Properties;
using SalesPro.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.PaymentsAndBilling
{
    public partial class ManagePayableForm : Form
    {
        public int _poId;
        public int _customerCreditId;
        public int _rowVersion;
        public int _credRowVersion;
        private DateTime _dateCreated;
        private DateTime _curDate;
        public string _actionForm;

        private readonly PaymentsAndBillingForm _form;
        private readonly PaymentsService _service;
        private readonly PurchaseOrderService _poService;
        private readonly CustomerCreditService _customerCreditService;
        private readonly OrderService _orderService;
        private List<OrderItemModelExtended> _orderItemLists;
        public ManagePayableForm(PaymentsAndBillingForm form)
        {
            InitializeComponent();
            _service = new PaymentsService();
            _poService = new PurchaseOrderService();
            _customerCreditService = new CustomerCreditService();
            _orderService = new OrderService();
            _form = form;
        }

        public async Task LoadOrderItems()
        {
            if (_actionForm == FormConstants.SupplierPayables)
            {
                var orderItems = await _poService.LoadPurchaseOrderItemsByPoId(_poId);
                dgOrderedItems.DataSource = orderItems;
                DgExtensions.ConfigureDataGrid(dgOrderedItems, false, 2, notFound_lbl,
                       "ProductName", "Quantity", "SupplierPrice", "MarkUpPrice", "RetailPrice", "TotalPrice");
            }
            else
            {
                var orderId = await _customerCreditService.GetOrderIdByCustomerCreditId(_customerCreditId);
                var creditedItems = await _orderService.LoadOrderItemsByOrderId(orderId);
                dgOrderedItems.DataSource = creditedItems;
                _orderItemLists = creditedItems;
                DgExtensions.ConfigureDataGrid(dgOrderedItems, false, 2, notFound_lbl,
                  "ProductName", "OrderQuantity", "Price", "Total");
            }

        }

        public async Task SetControls()
        {
            if (_actionForm == Constants.FormConstants.SupplierPayables)
            {
                var pos = await _service.GetPurchaseOrderById(_poId);
                if (pos != null)
                {
                    _rowVersion = pos.RowVersion;
                    _dateCreated = pos.DateCreated;

                    supplier_tx.Text = pos.SupplierName;
                    contactNumber_tx.Text = pos.SupplierContactNumber;
                    address_tx.Text = pos.SupplierAddress;
                    dateCredited_tx.Text = DateFormatHelper.FormatDate(pos.DateCreated);
                    dueDate_dt.Value = pos.DueDate;

                    total_tx.Text = pos.PoTotal.ToString("N2");
                    creditTerms_tx.Text = $"{pos.CreditTerms.ToString()} days";
                    processedBy_tx.Text = pos.UserFullName;

                    bool isPastDue = _curDate.Date > pos.DueDate.Date;
                    if (isPastDue)
                    {
                        pastDue_tx.Visible = true;
                    }
                    payable_pb.Image = Resources.delivery;
                    pay_btn.Text = "Pay Supplier";
                    title_lbl.Text = "Manage Supplier Payable";
                    pay_btn.BackColor = Color.Green;
                    print_btn.Visible = false;
                }
            }
            else if (_actionForm == Constants.FormConstants.CustomerCredits)
            {
                var creds = await _customerCreditService.GetCustomerCreditById(_customerCreditId);
                if (creds != null)
                {
                    _credRowVersion = creds.RowVersion;
                    _dateCreated = creds.CreditedDate;

                    supplier_tx.Text = creds.CustomerName;
                    contactNumber_tx.Text = creds.ContactNumber;
                    dateCredited_tx.Text = DateFormatHelper.FormatDate(creds.CreditedDate);
                    dueDate_dt.Value = creds.DueDate;
                    address_tx.Text = creds.Address;

                    total_tx.Text = creds.CreditAmount.ToString("N2");
                    creditTerms_tx.Text = $"{creds.CreditTerms.ToString()} days";
                    processedBy_tx.Text = creds.UserName;

                    bool isPastDue = _curDate.Date > creds.DueDate.Date;
                    if (isPastDue)
                    {
                        pastDue_tx.Visible = true;
                    }
                    payable_pb.Image = Resources.customer;
                    title_lbl.Text = "Customer Credit";
                    pay_btn.Text = "Receive Payment";
                    pay_btn.BackColor = SystemColors.Highlight;
                    print_btn.Visible = true;
                }
            }
        }

        public void ClosePaymentsAndBillingForm()
        {
            Close();
            update_btn.Enabled = false;
            pay_btn.Enabled = false;

            if (_actionForm == Constants.FormConstants.SupplierPayables)
            {
                _form.paid_rd.PerformClick();
                _form.unpaid_rd.PerformClick();
            }
            else
            {
                _form.paidCustomer_rd.PerformClick();
                _form.unpaidCustomer_rd.PerformClick();
            }
        }

        private async void ManageSupplierPayableForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
                await SetControls();
                await LoadOrderItems();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on loading manage supplier payable form: {ex.Message}");
            }
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dateCreated.Date >= dueDate_dt.Value.Date)
                {
                    MessageHandler.ShowWarning("Due date must be greater than the date created");
                    return;
                }
                if (MessageHandler.ShowQuestionGeneric("Update due date?"))
                {
                    int success = 0;
                    if (_actionForm == Constants.FormConstants.SupplierPayables)
                    {

                        success = await _service.UpdateSupplierPayableDueDate(_poId, dueDate_dt.Value.Date, _rowVersion);
                    }
                    else
                    {
                        success = await _service.UpdateCustomerCreditDueDate(_customerCreditId, dueDate_dt.Value.Date, _credRowVersion);
                    }
                    if (success > 0)
                    {
                        await SetControls();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error updating due date: {ex.Message}");
            }
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            if (_actionForm == Constants.FormConstants.SupplierPayables)
            {
                var form = new PaymentForm(this);
                form._actionForm = Constants.FormConstants.SupplierPayables;
                form._paymentType = PaymentType.SupplierPayable;
                form._referenceId = _poId;
                form._rowVersion = _rowVersion;
                form.ShowDialog();
            }
            else
            {
                var form = new PaymentForm(this);
                form._actionForm = Constants.FormConstants.CustomerCredits;
                form._paymentType = PaymentType.CustomerCredit;
                form._referenceId = _customerCreditId;
                form._credRowVersion = _credRowVersion;
                form.ShowDialog();
            }
        }

        private void ManageSupplierPayableForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form.unpaid_rd.PerformClick();
        }

        private void paymentStatus_tx_Click(object sender, EventArgs e)
        {

        }

        private void paymentStatus_tx_TextChanged(object sender, EventArgs e)
        {

        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (_actionForm == FormConstants.CustomerCredits)
            {
                var form = new PrintingForm();
                form._customerCreditList = _orderItemLists;
                form._customerCreditParam = new Dictionary<string, string>
                  {
                  { "CustomerName", supplier_tx.Text},
                  { "Contact", contactNumber_tx.Text},
                  { "DateCreated", dateCredited_tx.Text},
                   { "DueDate", dueDate_dt.Value.ToString("MM/dd/yyyy")},
                    { "Address", address_tx.Text},
                    { "Total", total_tx.Text},
                 { "CreditTerms", creditTerms_tx.Text},
                    { "ProcessedBy", processedBy_tx.Text}
                };
                form._formAction = FormConstants.CustomerCreditPayment;
                form.ShowDialog();
            }

        }
    }
}
