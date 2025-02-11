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
        public PrintingForm()
        {
            InitializeComponent();
        }

        private void PrintPoDetailsReport()
        {
            try
            {
                const string reportName = "PoDetailsRdlc";
                PrintingHelper.PrintReport(reportRv, reportName, _purchseOrderItemList, "PoDataSet");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Printing_Load(object sender, EventArgs e)
        {
            PrintPoDetailsReport();
        }
    }
}
