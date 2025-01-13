using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Services;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.PaymentsAndBilling
{
    public partial class ManageSupplierPayableForm : Form
    {
        public int _poId;
        public int _rowVersion;
        private DateTime _dateCreated;

        private readonly PaymentsAndBillingForm _form;
        private readonly PaymentsService _service;
        private readonly PurchaseOrderService _poService;
        public ManageSupplierPayableForm(PaymentsAndBillingForm form)
        {
            InitializeComponent();
            _service = new PaymentsService();
            _poService = new PurchaseOrderService();
            _form = form;
        }

        public async Task LoadOrderItems()
        {
            var orderItems = await _poService.LoadPurchaseOrderItemsByPoId(_poId);
            dgOrderedItems.DataSource = orderItems;
            DgExtensions.ConfigureDataGrid(dgOrderedItems, false, 2, notFound_lbl,
                   "ProductName", "Quantity", "SupplierPrice", "MarkUpPrice", "RetailPrice", "TotalPrice");
        }

        public async Task SetControls()
        {
            var pos = await _service.GetPurchaseOrderById(_poId);
            if (pos != null)
            {
                pos.PurchaseOrderId = _poId;
                pos.RowVersion = _rowVersion;
                _dateCreated = pos.DateCreated;

                supplier_tx.Text = pos.SupplierName;
                contactNumber_tx.Text = pos.SupplierContactNumber;
                address_tx.Text = pos.SupplierAddress;
                dateCredited_tx.Text = DateFormatHelper.FormatDate(pos.DateCreated);
                dueDate_dt.Value = pos.DueDate;

                total_tx.Text = pos.PoTotal.ToString("N2");
                paymentStatus_tx.Text = pos.PaymentStatus.ToString();
                creditTerms_tx.Text = $"{pos.CreditTerms.ToString()} days";
                processedBy_tx.Text = pos.UserFullName;

                if (pos.PaymentStatus == PaymentStatus.Paid)
                {
                    dueDate_dt.Enabled = false;
                    update_btn.Visible = false;

                    pay_btn.Text = "Update Payment";
                    pay_btn.BackColor  = SystemColors.Highlight;
                }
                else
                {
                    dueDate_dt.Enabled = true;
                    update_btn.Visible = true;

                    pay_btn.Text = "Pay";
                    pay_btn.BackColor = Color.Green;
                }
            }
        }

        private async void ManageSupplierPayableForm_Load(object sender, EventArgs e)
        {
            try
            {
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
                    await _service.UpdateDueDate(_poId, dueDate_dt.Value.Date);
                    await SetControls();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error updating due date: {ex.Message}");
            }
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            var form = new PaymentForm(this);
            form._paymentType = PaymentType.SupplierPayable;
            form._referenceId = _poId;
            form._rowVersion = _rowVersion;
            form.ShowDialog();
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
    }
}
