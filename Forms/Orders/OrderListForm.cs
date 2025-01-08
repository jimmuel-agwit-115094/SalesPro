using SalesPro.Constants;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class OrderListForm : Form
    {
        public OrderStatus _orderStatus;
        public int _orderId;
        public int _rowVersion;
        public string _action;

        private readonly OrderForm _orderForm;
        private readonly OrderService _service;
        public OrderListForm(OrderForm orderForm)
        {
            InitializeComponent();
            _service = new OrderService();
            _orderForm = orderForm;
            KeyPreview = true;
        }

        private async void OrderListForm_Load(object sender, EventArgs e)
        {
            try
            {
                var orders = await _service.LoadOrders();

                if (_action == FormConstants.ResumeOrder)
                {
                    // We exclided the current order from the list
                    var suspendedOrders = orders.Where(x => x.OrderStatus != OrderStatus.Completed && x.OrderId != _orderId).ToList();

                    dgOrders.DataSource = suspendedOrders;
                    DgExtensions.ConfigureDataGrid(dgOrders, false, 3, notFound_lbl,
                     "OrderId","CustomerName", "UserName", "DateTaken", "Total", "OrderStatus");

                    // Overide datagrid format
                    dgOrders.Columns["OrderId"].DisplayIndex = 0;
                    dgOrders.Columns["Total"].DisplayIndex = dgOrders.Columns.Count - 1;
                    dgOrders.Columns["OrderId"].DefaultCellStyle.Format = "000000000";
                }
                else
                {
                    var allOrders = orders.Where(x => x.OrderStatus != OrderStatus.Suspended ).ToList();
                    dgOrders.DataSource = allOrders;
                    DgExtensions.ConfigureDataGrid(dgOrders, true, 2, notFound_lbl,
                    "OrderId", "CustomerName", "UserName", "DateTaken", "Total", "AmountPaid", "OrderStatus", "PaymentStatus", "IsCredited");
                    dgOrders.Columns["Total"].DisplayIndex = dgOrders.Columns.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error loading order list form: {ex.Message}");
            }
        }

        private void dgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = DgFormatHelper.GetSelectedId(dgOrders, e, "OrderId");
            if (orderId == 0) return;
            var form = new OrderDetailsForm();
            form._orderId = orderId;
            form.ShowDialog();
        }

        private void dgOrders_SelectionChanged(object sender, EventArgs e)
        {
            _orderId = DgFormatHelper.GetSelectedIdOnSelectionChange(dgOrders, "OrderId");
            if (_orderId == 0) return;
        }

        private async Task ProcessOrder()
        {
            try
            {
                if (_action == Constants.FormConstants.ResumeOrder)
                {
                    if (MessageHandler.ShowQuestionGeneric("Resune Order?"))
                    {
                        var resumedOrder = await _service.ChangeOrderStatus(_orderId, OrderStatus.Active, _rowVersion);
                        await _orderForm.InitializeOrderDisplay(resumedOrder);
                        await _orderForm.ReloadRowVersion();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error processing order: {ex.Message}");
            }

        }

        private async void dgOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                await ProcessOrder();
            }
        }

        private async void dgOrders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await ProcessOrder();
                e.Handled = true;
            }
        }

        private void dgOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (dgOrders.Columns[e.ColumnIndex].Name == "PaymentStatus") // Replace with your column name
            //{
            //    if (e.Value != null && e.Value.ToString() == "Paid") // Replace "SpecificString" with your condition
            //    {
            //        e.CellStyle.Font = new Font(
            //            dgOrders.DefaultCellStyle.Font.FontFamily,
            //            dgOrders.DefaultCellStyle.Font.Size,
            //            FontStyle.Bold
            //         );
            //        e.CellStyle.ForeColor = Color.Green; // Change the fore color to green
            //        e.CellStyle.SelectionForeColor = Color.Green;
            //    }
            //    else
            //    {
            //        e.CellStyle.ForeColor = Color.Black; // Default color
            //    }
            //}

            if (dgOrders.Columns[e.ColumnIndex].Name == "OrderStatus") // Replace with your column name
            {
                if (e.Value != null && e.Value.ToString() == "Completed") // Replace "SpecificString" with your condition
                {
                    e.CellStyle.Font = new Font(
                        dgOrders.DefaultCellStyle.Font.FontFamily,
                        dgOrders.DefaultCellStyle.Font.Size,
                        FontStyle.Bold
                     );
                    e.CellStyle.BackColor = Color.LawnGreen; // Change the fore color to green
                    e.CellStyle.SelectionBackColor = Color.LawnGreen;
                }
            }
        }
    }
}
