using SalesPro.Helpers;
using SalesPro.Models;
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
    public partial class ExpensesForm : Form
    {
        private readonly ExpenseService _service;
        private readonly PaymentsAndBillingForm _form;
        public ExpensesForm(PaymentsAndBillingForm form)
        {
            InitializeComponent();
            _service = new ExpenseService();
            _form = form;
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageHandler.ShowQuestionGeneric("Confirm save expense?"))
                {
                    var model = new ExpenseModel
                    {
                        DateAdded = dateAdded_dt.Value,
                        Amount = Convert.ToDecimal(amt_tx.Text),
                        ExpenseParticular = particular_cb.Text,
                        Company = company_tx.Text,
                        ReceiptNumber = receipt_tx.Text,
                    };
                    await _service.SaveExpense(model);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error saving expense: {ex.Message}");
            }

        }

        private void ExpensesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
