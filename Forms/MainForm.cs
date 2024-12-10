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
            // Center the content panel within the main panel
            int centerX = (main_panel.Width - content_panel.Width) / 2;
            int centerY = (main_panel.Height - content_panel.Height) / 2;
            content_panel.Location = new Point(centerX, centerY);
        }

        private void LoadFormInPanel(Form form)
        {
            // Clear the content panel and load the specified form
            content_panel.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.Size = content_panel.Size;
            content_panel.Controls.Add(form);
            form.Show();
        }

        private void AdjustFormSizeToScreen()
        {
            // Maximize the form within the working area of the screen
            Rectangle workingArea = Screen.GetWorkingArea(this);
            Size = workingArea.Size; // Set form size to the working area size
            Location = workingArea.Location; // Set form location to match the working area
        }

        private void transactions_btn_Click(object sender, EventArgs e)
        {
            // Load the TransactionForm inside the content panel
            var form = new TransactionForm();
            LoadFormInPanel(form);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Adjust the form size to fit the screen's working area on load
            AdjustFormSizeToScreen();
        }
    }
}
