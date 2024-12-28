using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            SetFormSize();
        }

        private void SetFormSize()
        {
            WindowState = FormWindowState.Maximized;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            Size = workingArea.Size;
            Location = workingArea.Location;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            var form = new AddOrderItemForm();
            form.ShowDialog();
        }
    }
}
