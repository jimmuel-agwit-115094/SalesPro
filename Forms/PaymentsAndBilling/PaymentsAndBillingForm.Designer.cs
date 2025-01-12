namespace SalesPro.Forms.PaymentsAndBilling
{
    partial class PaymentsAndBillingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.basePanel = new System.Windows.Forms.Panel();
            this.transactionsTabControl = new System.Windows.Forms.TabControl();
            this.cuurent_tab = new System.Windows.Forms.TabPage();
            this.po_title = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.paid_rd = new System.Windows.Forms.RadioButton();
            this.unpaid_rd = new System.Windows.Forms.RadioButton();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgSupplierPayables = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.allTransactions_tab = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.basePanel.SuspendLayout();
            this.transactionsTabControl.SuspendLayout();
            this.cuurent_tab.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierPayables)).BeginInit();
            this.allTransactions_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel1.Controls.Add(this.title_lbl);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1555, 53);
            this.Panel1.TabIndex = 437;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(8, 11);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(244, 32);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Payments And Billing";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1555, 38);
            this.panel3.TabIndex = 438;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(974, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(579, 36);
            this.panel4.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Controls.Add(this.basePanel);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 91);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1555, 763);
            this.panel10.TabIndex = 460;
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.Color.White;
            this.basePanel.Controls.Add(this.transactionsTabControl);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(1555, 763);
            this.basePanel.TabIndex = 439;
            // 
            // transactionsTabControl
            // 
            this.transactionsTabControl.Controls.Add(this.cuurent_tab);
            this.transactionsTabControl.Controls.Add(this.allTransactions_tab);
            this.transactionsTabControl.Controls.Add(this.tabPage1);
            this.transactionsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsTabControl.Location = new System.Drawing.Point(0, 0);
            this.transactionsTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transactionsTabControl.Name = "transactionsTabControl";
            this.transactionsTabControl.SelectedIndex = 0;
            this.transactionsTabControl.Size = new System.Drawing.Size(1555, 763);
            this.transactionsTabControl.TabIndex = 6;
            // 
            // cuurent_tab
            // 
            this.cuurent_tab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cuurent_tab.Controls.Add(this.po_title);
            this.cuurent_tab.Controls.Add(this.panel5);
            this.cuurent_tab.Controls.Add(this.notFound_lbl);
            this.cuurent_tab.Controls.Add(this.dgSupplierPayables);
            this.cuurent_tab.Controls.Add(this.panel6);
            this.cuurent_tab.Location = new System.Drawing.Point(4, 34);
            this.cuurent_tab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuurent_tab.Name = "cuurent_tab";
            this.cuurent_tab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuurent_tab.Size = new System.Drawing.Size(1547, 725);
            this.cuurent_tab.TabIndex = 0;
            this.cuurent_tab.Text = "    Supplier Payables       ";
            // 
            // po_title
            // 
            this.po_title.AutoSize = true;
            this.po_title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.po_title.ForeColor = System.Drawing.Color.Black;
            this.po_title.Location = new System.Drawing.Point(12, 86);
            this.po_title.Name = "po_title";
            this.po_title.Size = new System.Drawing.Size(192, 32);
            this.po_title.TabIndex = 469;
            this.po_title.Text = "Purchase Orders";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.paid_rd);
            this.panel5.Controls.Add(this.unpaid_rd);
            this.panel5.Location = new System.Drawing.Point(13, 26);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1517, 43);
            this.panel5.TabIndex = 468;
            // 
            // paid_rd
            // 
            this.paid_rd.AutoSize = true;
            this.paid_rd.Location = new System.Drawing.Point(136, 7);
            this.paid_rd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paid_rd.Name = "paid_rd";
            this.paid_rd.Size = new System.Drawing.Size(69, 29);
            this.paid_rd.TabIndex = 467;
            this.paid_rd.TabStop = true;
            this.paid_rd.Text = "Paid";
            this.paid_rd.UseVisualStyleBackColor = true;
            this.paid_rd.CheckedChanged += new System.EventHandler(this.paid_rd_CheckedChanged);
            // 
            // unpaid_rd
            // 
            this.unpaid_rd.AutoSize = true;
            this.unpaid_rd.Location = new System.Drawing.Point(11, 7);
            this.unpaid_rd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unpaid_rd.Name = "unpaid_rd";
            this.unpaid_rd.Size = new System.Drawing.Size(94, 29);
            this.unpaid_rd.TabIndex = 466;
            this.unpaid_rd.TabStop = true;
            this.unpaid_rd.Text = "Unpaid";
            this.unpaid_rd.UseVisualStyleBackColor = true;
            this.unpaid_rd.CheckedChanged += new System.EventHandler(this.unpaid_rd_CheckedChanged);
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(685, 340);
            this.notFound_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(216, 54);
            this.notFound_lbl.TabIndex = 464;
            this.notFound_lbl.Text = "No Record";
            // 
            // dgSupplierPayables
            // 
            this.dgSupplierPayables.AllowUserToAddRows = false;
            this.dgSupplierPayables.AllowUserToDeleteRows = false;
            this.dgSupplierPayables.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgSupplierPayables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgSupplierPayables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSupplierPayables.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgSupplierPayables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSupplierPayables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSupplierPayables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgSupplierPayables.ColumnHeadersHeight = 35;
            this.dgSupplierPayables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSupplierPayables.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgSupplierPayables.EnableHeadersVisualStyles = false;
            this.dgSupplierPayables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgSupplierPayables.Location = new System.Drawing.Point(13, 129);
            this.dgSupplierPayables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgSupplierPayables.MultiSelect = false;
            this.dgSupplierPayables.Name = "dgSupplierPayables";
            this.dgSupplierPayables.ReadOnly = true;
            this.dgSupplierPayables.RowHeadersVisible = false;
            this.dgSupplierPayables.RowHeadersWidth = 51;
            this.dgSupplierPayables.RowTemplate.Height = 32;
            this.dgSupplierPayables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSupplierPayables.Size = new System.Drawing.Size(1517, 586);
            this.dgSupplierPayables.TabIndex = 463;
            this.dgSupplierPayables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSupplierPayables_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(13, -1);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 6);
            this.panel6.TabIndex = 5;
            // 
            // allTransactions_tab
            // 
            this.allTransactions_tab.Controls.Add(this.panel7);
            this.allTransactions_tab.Location = new System.Drawing.Point(4, 34);
            this.allTransactions_tab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allTransactions_tab.Name = "allTransactions_tab";
            this.allTransactions_tab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allTransactions_tab.Size = new System.Drawing.Size(1547, 725);
            this.allTransactions_tab.TabIndex = 1;
            this.allTransactions_tab.Text = "     Customer Credits   ";
            this.allTransactions_tab.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(253, -1);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(187, 6);
            this.panel7.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1547, 725);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "        Expenses       ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(447, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 6);
            this.panel2.TabIndex = 7;
            // 
            // PaymentsAndBillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1555, 854);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentsAndBillingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PaymentsAndBillingForm";
            this.Load += new System.EventHandler(this.PaymentsAndBillingForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.basePanel.ResumeLayout(false);
            this.transactionsTabControl.ResumeLayout(false);
            this.cuurent_tab.ResumeLayout(false);
            this.cuurent_tab.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierPayables)).EndInit();
            this.allTransactions_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.TabControl transactionsTabControl;
        private System.Windows.Forms.TabPage cuurent_tab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage allTransactions_tab;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgSupplierPayables;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Label po_title;
        public System.Windows.Forms.RadioButton unpaid_rd;
        public System.Windows.Forms.RadioButton paid_rd;
    }
}