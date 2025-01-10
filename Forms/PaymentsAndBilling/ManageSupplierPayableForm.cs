using SalesPro.Helpers;
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

namespace SalesPro.Forms.PaymentsAndBilling
{
    public partial class ManageSupplierPayableForm : Form
    {
        public int _poId;
        public int _rowVersion;

        private readonly PaymentsAndBillingForm _form;
        private readonly PaymentsAndBillingService _service;
        public ManageSupplierPayableForm(PaymentsAndBillingForm form)
        {
            InitializeComponent();
            _service = new PaymentsAndBillingService();
            _form = form;
        }

        private async void ManageSupplierPayableForm_Load(object sender, EventArgs e)
        {
            try
            {
                var pos = await _service.GetPurchaseOrderById(_poId);
                if (pos != null)
                {
                    pos.PurchaseOrderId = _poId;
                    pos.RowVersion = _rowVersion;

                    supplier_tx.Text = pos.SupplierName;
                    contactNumber_tx.Text = pos.SupplierContactNumber;
                    address_tx.Text = pos.SupplierAddress;
                    dateCredited_tx.Text = DateFormatHelper.FormatDate(pos.DateCreated);
                    dueDate_dt.Value = pos.DueDate;

                    total_tx.Text = pos.PoTotal.ToString("N2");
                    paymentStatus_tx.Text = pos.PaymentStatus.ToString();
                    creditTerms_tx.Text = $"{pos.CreditTerms.ToString()} days";
                    processedBy_tx.Text = pos.UserFullName;

                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on loading manage supplier payable form: {ex.Message}");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
