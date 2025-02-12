using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Printing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms
{
    public partial class PrintingForm : Form
    {
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
                PrintPoDetailsReport();
                PrintInventory();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error occurred while printing on form load: {ex.Message}");
            }
         
        }
    }
}
