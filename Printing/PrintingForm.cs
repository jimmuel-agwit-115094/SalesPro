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
        public Dictionary<string, string> _inventoryParam;
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
            PrintingHelper.PrintReport(reportRv, reportName, _inventoryList, "InventoryDataSet", _inventoryParam);
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
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error occurred while printing on form load: {ex.Message}");
            }

        }
    }
}
