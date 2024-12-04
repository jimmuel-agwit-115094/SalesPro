using SalesPro.Forms.Transactions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesPro.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Panel1_Resize(object sender, EventArgs e)
        {
            int centerX = (main_panel.Width - content_panel.Width) / 2;
            int centerY = (main_panel.Height - content_panel.Height) / 2;
            content_panel.Location = new Point(centerX, centerY);
        }

        private void LoadFormInPanel(Form form)
        {
            content_panel.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.Size = content_panel.Size;
            content_panel.Controls.Add(form);
            form.Show();
        }

        private void SetFormSize()
        {
            WindowState = FormWindowState.Maximized;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            Size = workingArea.Size;
            Location = workingArea.Location;
        }

        private void transactions_btn_Click(object sender, EventArgs e)
        {
            var form = new TransactionForm();
            LoadFormInPanel(form);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetFormSize();
        }
    }
}
