using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Services;
using SalesPro.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Settings
{
    public partial class BankForm : Form
    {
        public string _actionForm;
        public int _bankId;
        public int _bankRowVersion;

        private readonly SettingsForm _form;
        private readonly BankService _bankService;

        public BankForm(SettingsForm form)
        {
            InitializeComponent();
            _bankService = new BankService();
            _form = form;
        }

        private BankModel BuildBankModel()
        {
            var bank = new BankModel();
            bank.BankName = bankName_tx.Text;
            bank.BankType = (BankType)bankType_cb.SelectedItem;
            bank.Address = address_tx.Text;
            bank.Contact = contact_tx.Text;
            return bank;
        }

        private void BankForm_Load(object sender, EventArgs e)
        {
            try
            {
                title_lbl.Select();
                bankType_cb.DataSource = Enum.GetValues(typeof(BankType));
                if (_actionForm == Constants.SystemConstants.Edit)
                {
                    title_lbl.Text = "Update Bank";
                    save_btn.Text = "Update";
                    save_btn.BackColor = SystemColors.Highlight;

                    var bank = _bankService.GetBankById(_bankId);
                    if (bank != null)
                    {
                        bankName_tx.Text = bank.BankName;
                        bankType_cb.Text = bank.BankType.ToString();
                        address_tx.Text = bank.Address;
                        contact_tx.Text = bank.Contact;
                        _bankRowVersion = bank.RowVersion;
                    }
                }
                else
                {
                    title_lbl.Text = "New Bank";
                    save_btn.Text = "Save";
                    save_btn.BackColor = Color.Green;

                }


            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading bank form: {ex.Message}");
            }
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int success = 0;
                var model = BuildBankModel();
                string action = _actionForm == Constants.SystemConstants.New ? "save" : "update";

                if (bankName_tx.Text == string.Empty)
                {
                    MessageHandler.ShowWarning("Please enter bank name");
                    return;
                }

                if (bankType_cb.SelectedIndex == -1)
                {
                    MessageHandler.ShowWarning("Please select bank type");
                    return;
                }

                if (MessageHandler.ShowQuestionGeneric($"Confirm {action} bank?"))
                {
                    if (_actionForm == Constants.SystemConstants.New)
                    {
                        success = await _bankService.SaveBank(model);
                    }
                    else
                    {
                        success = await _bankService.UpdateBank(_bankId, model, _bankRowVersion);
                    }
                    await _form.LoadBanks();
                    if (success > 0)
                    {
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error saving bank : {ex.Message}");
            }
        }
    }
}
