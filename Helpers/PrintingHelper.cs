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
        public static void PrintReport(ReportViewer reportViewer, string reportName, object dataSource, string dataSetName, Dictionary<string, string> parameters = null)
        {
            try
            {
                // Clear existing data sources
                reportViewer.LocalReport.DataSources.Clear();

                // Create and add new data source
                ReportDataSource src = new ReportDataSource(dataSetName, dataSource);
                reportViewer.LocalReport.DataSources.Add(src);

                // Set report path
                string solutionDir = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)));
                string reportPath = Path.Combine(solutionDir,"Printing", "rdlc", $"{reportName}.rdlc");
                reportViewer.LocalReport.ReportPath = reportPath;

                // Clear existing parameters
                reportViewer.LocalReport.SetParameters(new ReportParameter[] { });

                // Add parameters if provided
                if (parameters != null && parameters.Count > 0)
                {
                    List<ReportParameter> reportParameters = new List<ReportParameter>();
                    foreach (var param in parameters)
                    {
                        reportParameters.Add(new ReportParameter(param.Key, param.Value));
                    }
                    reportViewer.LocalReport.SetParameters(reportParameters);
                }

                // Refresh the report
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing the report: {ex}");
            }
        }



    }
}
