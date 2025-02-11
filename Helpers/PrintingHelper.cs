using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SalesPro.Helpers
{
    public class PrintingHelper
    {
        public static void PrintReport(ReportViewer reportViewer, string reportName, object dataSource, string dataSetName)
        {
            try
            {
                reportViewer.LocalReport.DataSources.Clear(); // Clear old data

                reportViewer.LocalReport.DataSources.Add(new ReportDataSource(dataSetName, dataSource)); // Add new data source

                reportViewer.LocalReport.ReportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", $"{reportName}.rdlc"); // Set report path

                reportViewer.RefreshReport(); // Refresh to display
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing: {ex.Message}");
            }
        }

    }
}
