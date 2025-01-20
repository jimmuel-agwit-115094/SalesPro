using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesPro.Forms.PaymentsAndBilling
{
    public partial class ExpensesForm : Form
    {
        public int _expenseId;
        public string _formAction;
        private int _rowVersion;
        private DateTime _curDate;

        private readonly ExpenseService _service;
        private readonly PaymentsAndBillingForm _form;
        public ExpensesForm(PaymentsAndBillingForm form)
        {
            InitializeComponent();
            _service = new ExpenseService();
            _form = form;
            TextBoxHelper.FormatDecimalTextbox(amt_tx);
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateAdded_dt.Value > _curDate.Date)
                {
                    MessageHandler.ShowWarning("Date added cannot be greater than current date");
                    return;
                }

                if (particular_cb.Text == string.Empty)
                {
                    MessageHandler.ShowWarning("Please enter expense particular");
                    return;
                }

                if (amt_tx.Text == string.Empty)
                {
                    MessageHandler.ShowWarning("Please enter expense amount");
                    return;
                }

                if (Convert.ToDecimal(amt_tx.Text) == 0)
                {
                    MessageHandler.ShowWarning("Amount cannot be 0");
                    return;
                }

                if (company_tx.Text == string.Empty)
                {
                    MessageHandler.ShowWarning("Please enter company name");
                    return;
                }
                if (receipt_tx.Text == string.Empty)
                {
                    MessageHandler.ShowWarning("Please enter receipt number");
                    return;
                }

                string type = _formAction == Constants.SystemConstants.New ? "save" : "update";
                if (MessageHandler.ShowQuestionGeneric($"Confirm {type} expense?"))
                {
                    var model = new ExpenseModel
                    {
                        DateAdded = dateAdded_dt.Value,
                        Amount = Convert.ToDecimal(amt_tx.Text),
                        ExpenseParticular = particular_cb.Text,
                        Company = company_tx.Text,
                        ReceiptNumber = receipt_tx.Text,
                    };
                    if (_formAction == Constants.SystemConstants.New)
                    {
                        await _service.SaveExpense(model);
                    }
                    else
                    {
                        await _service.UpdateExpense(_expenseId, model, _rowVersion);
                    }

                    await _form.LoadExpensesByDate();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error saving expense: {ex.Message}");
            }

        }

        private async void ExpensesForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();
                dateAdded_dt.MaxDate = _curDate.Date;
                dateAdded_dt.Select();
                if (_formAction == Constants.SystemConstants.New)
                {
                    title_lbl.Text = "Add Expense";
                    save_btn.Text = "Save";
                    save_btn.BackColor = Color.Green;
                }
                else
                {
                    title_lbl.Text = "Edit Expense";
                    var exp = await _service.GetExpenseById(_expenseId);
                    if (exp != null)
                    {
                        dateAdded_dt.Value = exp.DateAdded;
                        particular_cb.Text = exp.ExpenseParticular;
                        amt_tx.Text = exp.Amount.ToString("N2");
                        company_tx.Text = exp.Company;
                        receipt_tx.Text = exp.ReceiptNumber;
                        _rowVersion = exp.RowVersion;
                    }
                    save_btn.Text = "Update";
                    save_btn.BackColor = SystemColors.Highlight;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error expense loading: {ex.Message}");
            }
        }
    }
}
