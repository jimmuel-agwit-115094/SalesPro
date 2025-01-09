using SalesPro.Helpers.UiHelpers;
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

namespace SalesPro.Forms.Products
{
    public partial class ProductLogsForm : Form
    {
        public int _productId;
        private readonly ProductService _productService;
        public ProductLogsForm()
        {
            InitializeComponent();
            _productService = new ProductService();
        }

        private async void ProductLogsForm_Load(object sender, EventArgs e)
        {
            var logs = await _productService.GetProductLogs(_productId);
            dgLogs.DataSource = logs;
            DgExtensions.ConfigureDataGrid(dgLogs, false, 3, notFound_lbl, "ProductName", "ProductActionType",
                "OldValue", "NewValue", "PerformedBy", "DatePerformed");
        }
    }
}
