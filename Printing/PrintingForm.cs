using Microsoft.Reporting.WinForms;
using SalesPro.Helpers;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalesPro.Forms
{
    public partial class PrintingForm : Form
    {
        public string _formAction;
        public List<PurchaseOrderItemModelExntended> _purchseOrderItemList;
        public Dictionary<string, string> _poDetailsParam;

        public List<InventoryModelExtended> _inventoryList;

        public List<OrderItemModelExtended> _customerCreditList;
        public Dictionary<string, string> _customerCreditParam;

        public List<InventoryProductExtended> _productList;
        public Dictionary<string, string> _productParam;

        public PrintingForm()
        {
            InitializeComponent();
        }

        private void PrintPoDetailsReport()
        {
            const string reportName = "PoDetailsRdlc";
            PrintingHelper.PrintReport(reportRv, reportName, _purchseOrderItemList, "PoDataSet", _poDetailsParam);
        }

        private void PrintInventory()
        {
            const string reportName = "InventoryRdlc";
            PrintingHelper.PrintReport(reportRv, reportName, _inventoryList, "InventoryDataSet");
        }

        private void PrintCustomerCredit()
        {
            const string reportName = "CustomerCreditRdlc";
            PrintingHelper.PrintReport(reportRv, reportName, _customerCreditList, "CustomerCreditDataSet", _customerCreditParam);
        }

        private void PrintProductInventory()
        {
            const string reportName = "ProductRdlc";
            PrintingHelper.PrintReport(reportRv, reportName, _productList, "ProductDataSet", _productParam);
        }

        private void Printing_Load(object sender, EventArgs e)
        {
            try
            {
                if (_formAction == Constants.FormConstants.Inventory)
                {
                    PrintInventory();
                    return;
                }
                else if (_formAction == Constants.FormConstants.PurchaseOrderItem)
                {
                    PrintPoDetailsReport();
                    return;
                }
                else if (_formAction == Constants.FormConstants.CustomerCreditPayment)
                {
                    PrintCustomerCredit();
                    return;
                }
                else if (_formAction == Constants.FormConstants.ProductInventory)
                {
                    PrintProductInventory();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error occurred while printing on form load: {ex.Message}");
            }

        }
    }
}
