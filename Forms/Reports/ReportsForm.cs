using SalesPro.Helpers;
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

namespace SalesPro.Forms.Reports
{
    public partial class ReportsForm : Form
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private readonly ReportService _reportService;
        public ReportsForm()
        {
            InitializeComponent();
            _reportService = new ReportService();
        }

        private async void findBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _startDate = startDate_dt.Value.Date;
                _endDate = endDate_dt.Value.Date;

                if (_startDate > _endDate)
                {
                    MessageHandler.ShowWarning("Start date cannot be greater than end date");
                    return;
                }

                decimal totalSales = await _reportService.GetTotalSalesByDate(_startDate, _endDate);
                decimal totalExpenses = await _reportService.GetTotalExpensesByDate(_startDate, _endDate);
                decimal totalCustomerCreditPayment = await _reportService.GetTotalCustomerCreditPaymentByDate(_startDate, _endDate);
                decimal totalPaymentToSuppliers = await _reportService.GetTotalPaymentToSuppliersByDate(_startDate, _endDate);
                decimal overAllSales = _reportService.GetOverAllSales();

                totalSales_tx.Text = totalSales.ToString("N2");
                totalExpenses_tx.Text = totalExpenses.ToString("N2");
                customerCreditTotal_tx.Text = totalCustomerCreditPayment.ToString("N2");
                paymentToSupplier_tx.Text = totalPaymentToSuppliers.ToString("N2");
                overAllSales_tx.Text = overAllSales.ToString("N2");


            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error getting reports: {ex.Message}");
            }
        }

        private async void ReportsForm_Load(object sender, EventArgs e)
        {
            try
            {

                startDate_dt.Value = DateTime.Now;
                endDate_dt.Value = DateTime.Now;
                movement_cb.SelectedIndex = 0;

                var products = await _reportService.GetFastSellingProduct();
                dgProducts.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error reports load: {ex.Message}");
            }
        }
    }
}
