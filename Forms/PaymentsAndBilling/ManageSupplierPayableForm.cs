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

        private void ManageSupplierPayableForm_Load(object sender, EventArgs e)
        {

        }
    }
}
