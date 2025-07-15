﻿namespace SalesPro.Forms.PaymentsAndBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsAndBillingForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.basePanel = new System.Windows.Forms.Panel();
            this.paymentTabControl = new System.Windows.Forms.TabControl();
            this.supplierPayable_tab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.payable_pb = new System.Windows.Forms.PictureBox();
            this.po_title = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.paid_rd = new System.Windows.Forms.RadioButton();
            this.showPastDue_cb = new System.Windows.Forms.CheckBox();
            this.unpaid_rd = new System.Windows.Forms.RadioButton();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgSupplierPayables = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.customerCreditTab = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.creditPb = new System.Windows.Forms.PictureBox();
            this.credit_lbl = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.showPastCustomer_cb = new System.Windows.Forms.CheckBox();
            this.paidCustomer_rd = new System.Windows.Forms.RadioButton();
            this.unpaidCustomer_rd = new System.Windows.Forms.RadioButton();
            this.notFound_cust = new System.Windows.Forms.Label();
            this.dgCustomerCredits = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.expensesTab = new System.Windows.Forms.TabPage();
            this.dateGb = new System.Windows.Forms.GroupBox();
            this.filter_dt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.showAllExp_cb = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.total_tx = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.new_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notFoundExpense = new System.Windows.Forms.Label();
            this.dgExpenses = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.basePanel.SuspendLayout();
            this.paymentTabControl.SuspendLayout();
            this.supplierPayable_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payable_pb)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierPayables)).BeginInit();
            this.customerCreditTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditPb)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerCredits)).BeginInit();
            this.expensesTab.SuspendLayout();
            this.dateGb.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel1.Controls.Add(this.title_lbl);
            this.Panel1.Controls.Add(this.po_title);
            this.Panel1.Controls.Add(this.credit_lbl);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1166, 43);
            this.Panel1.TabIndex = 437;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(6, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(193, 25);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Payments And Billing";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1166, 31);
            this.panel3.TabIndex = 438;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(730, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(434, 29);
            this.panel4.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Controls.Add(this.basePanel);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 74);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1166, 620);
            this.panel10.TabIndex = 460;
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.Color.White;
            this.basePanel.Controls.Add(this.paymentTabControl);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(1166, 620);
            this.basePanel.TabIndex = 439;
            // 
            // paymentTabControl
            // 
            this.paymentTabControl.Controls.Add(this.supplierPayable_tab);
            this.paymentTabControl.Controls.Add(this.customerCreditTab);
            this.paymentTabControl.Controls.Add(this.expensesTab);
            this.paymentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTabControl.Location = new System.Drawing.Point(0, 0);
            this.paymentTabControl.Name = "paymentTabControl";
            this.paymentTabControl.SelectedIndex = 0;
            this.paymentTabControl.Size = new System.Drawing.Size(1166, 620);
            this.paymentTabControl.TabIndex = 6;
            this.paymentTabControl.SelectedIndexChanged += new System.EventHandler(this.transactionsTabControl_SelectedIndexChanged);
            // 
            // supplierPayable_tab
            // 
            this.supplierPayable_tab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supplierPayable_tab.Controls.Add(this.pictureBox1);
            this.supplierPayable_tab.Controls.Add(this.search_tx);
            this.supplierPayable_tab.Controls.Add(this.payable_pb);
            this.supplierPayable_tab.Controls.Add(this.panel5);
            this.supplierPayable_tab.Controls.Add(this.notFound_lbl);
            this.supplierPayable_tab.Controls.Add(this.dgSupplierPayables);
            this.supplierPayable_tab.Controls.Add(this.panel6);
            this.supplierPayable_tab.Location = new System.Drawing.Point(4, 29);
            this.supplierPayable_tab.Name = "supplierPayable_tab";
            this.supplierPayable_tab.Padding = new System.Windows.Forms.Padding(3);
            this.supplierPayable_tab.Size = new System.Drawing.Size(1158, 587);
            this.supplierPayable_tab.TabIndex = 0;
            this.supplierPayable_tab.Text = "  Supplier Payables   ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1121, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 613;
            this.pictureBox1.TabStop = false;
            // 
            // search_tx
            // 
            this.search_tx.BackColor = System.Drawing.Color.White;
            this.search_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tx.Location = new System.Drawing.Point(759, 34);
            this.search_tx.Margin = new System.Windows.Forms.Padding(2);
            this.search_tx.Name = "search_tx";
            this.search_tx.Size = new System.Drawing.Size(389, 27);
            this.search_tx.TabIndex = 612;
            this.search_tx.TextChanged += new System.EventHandler(this.search_tx_TextChanged);
            // 
            // payable_pb
            // 
            this.payable_pb.Image = ((System.Drawing.Image)(resources.GetObject("payable_pb.Image")));
            this.payable_pb.Location = new System.Drawing.Point(15, 21);
            this.payable_pb.Name = "payable_pb";
            this.payable_pb.Size = new System.Drawing.Size(40, 40);
            this.payable_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.payable_pb.TabIndex = 611;
            this.payable_pb.TabStop = false;
            // 
            // po_title
            // 
            this.po_title.AutoSize = true;
            this.po_title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.po_title.ForeColor = System.Drawing.Color.Black;
            this.po_title.Location = new System.Drawing.Point(850, 12);
            this.po_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.po_title.Name = "po_title";
            this.po_title.Size = new System.Drawing.Size(129, 21);
            this.po_title.TabIndex = 469;
            this.po_title.Text = "Purchase Orders";
            this.po_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.po_title.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.paid_rd);
            this.panel5.Controls.Add(this.showPastDue_cb);
            this.panel5.Controls.Add(this.unpaid_rd);
            this.panel5.Location = new System.Drawing.Point(69, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 35);
            this.panel5.TabIndex = 468;
            // 
            // paid_rd
            // 
            this.paid_rd.AutoSize = true;
            this.paid_rd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paid_rd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_rd.Location = new System.Drawing.Point(103, 6);
            this.paid_rd.Name = "paid_rd";
            this.paid_rd.Size = new System.Drawing.Size(52, 21);
            this.paid_rd.TabIndex = 467;
            this.paid_rd.TabStop = true;
            this.paid_rd.Text = "Paid";
            this.paid_rd.UseVisualStyleBackColor = false;
            this.paid_rd.CheckedChanged += new System.EventHandler(this.paid_rd_CheckedChanged);
            // 
            // showPastDue_cb
            // 
            this.showPastDue_cb.AutoSize = true;
            this.showPastDue_cb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPastDue_cb.Location = new System.Drawing.Point(233, 7);
            this.showPastDue_cb.Name = "showPastDue_cb";
            this.showPastDue_cb.Size = new System.Drawing.Size(150, 21);
            this.showPastDue_cb.TabIndex = 610;
            this.showPastDue_cb.Text = "Show Only Past Due";
            this.showPastDue_cb.UseVisualStyleBackColor = true;
            this.showPastDue_cb.Visible = false;
            this.showPastDue_cb.CheckedChanged += new System.EventHandler(this.showPastDue_cb_CheckedChanged);
            // 
            // unpaid_rd
            // 
            this.unpaid_rd.AutoSize = true;
            this.unpaid_rd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.unpaid_rd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpaid_rd.Location = new System.Drawing.Point(7, 6);
            this.unpaid_rd.Name = "unpaid_rd";
            this.unpaid_rd.Size = new System.Drawing.Size(73, 21);
            this.unpaid_rd.TabIndex = 466;
            this.unpaid_rd.TabStop = true;
            this.unpaid_rd.Text = "Unpaid ";
            this.unpaid_rd.UseVisualStyleBackColor = false;
            this.unpaid_rd.CheckedChanged += new System.EventHandler(this.unpaid_rd_CheckedChanged);
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(486, 293);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 464;
            this.notFound_lbl.Text = "No Record";
            // 
            // dgSupplierPayables
            // 
            this.dgSupplierPayables.AllowUserToAddRows = false;
            this.dgSupplierPayables.AllowUserToDeleteRows = false;
            this.dgSupplierPayables.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgSupplierPayables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSupplierPayables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSupplierPayables.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgSupplierPayables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSupplierPayables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSupplierPayables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSupplierPayables.ColumnHeadersHeight = 35;
            this.dgSupplierPayables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSupplierPayables.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgSupplierPayables.EnableHeadersVisualStyles = false;
            this.dgSupplierPayables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgSupplierPayables.Location = new System.Drawing.Point(10, 71);
            this.dgSupplierPayables.MultiSelect = false;
            this.dgSupplierPayables.Name = "dgSupplierPayables";
            this.dgSupplierPayables.ReadOnly = true;
            this.dgSupplierPayables.RowHeadersVisible = false;
            this.dgSupplierPayables.RowHeadersWidth = 51;
            this.dgSupplierPayables.RowTemplate.Height = 32;
            this.dgSupplierPayables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSupplierPayables.Size = new System.Drawing.Size(1138, 510);
            this.dgSupplierPayables.TabIndex = 463;
            this.dgSupplierPayables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSupplierPayables_CellContentClick);
            this.dgSupplierPayables.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgSupplierPayables_CellFormatting);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(2, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 5);
            this.panel6.TabIndex = 5;
            // 
            // customerCreditTab
            // 
            this.customerCreditTab.BackColor = System.Drawing.Color.White;
            this.customerCreditTab.Controls.Add(this.pictureBox2);
            this.customerCreditTab.Controls.Add(this.textBox1);
            this.customerCreditTab.Controls.Add(this.creditPb);
            this.customerCreditTab.Controls.Add(this.panel11);
            this.customerCreditTab.Controls.Add(this.notFound_cust);
            this.customerCreditTab.Controls.Add(this.dgCustomerCredits);
            this.customerCreditTab.Controls.Add(this.panel7);
            this.customerCreditTab.Location = new System.Drawing.Point(4, 29);
            this.customerCreditTab.Name = "customerCreditTab";
            this.customerCreditTab.Padding = new System.Windows.Forms.Padding(3);
            this.customerCreditTab.Size = new System.Drawing.Size(1158, 587);
            this.customerCreditTab.TabIndex = 1;
            this.customerCreditTab.Text = "   Customer Credit Receivable   ";
            this.customerCreditTab.Click += new System.EventHandler(this.allTransactions_tab_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1121, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 619;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(759, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 27);
            this.textBox1.TabIndex = 618;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // creditPb
            // 
            this.creditPb.Image = ((System.Drawing.Image)(resources.GetObject("creditPb.Image")));
            this.creditPb.Location = new System.Drawing.Point(16, 21);
            this.creditPb.Name = "creditPb";
            this.creditPb.Size = new System.Drawing.Size(40, 40);
            this.creditPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.creditPb.TabIndex = 617;
            this.creditPb.TabStop = false;
            // 
            // credit_lbl
            // 
            this.credit_lbl.AutoSize = true;
            this.credit_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit_lbl.ForeColor = System.Drawing.Color.Black;
            this.credit_lbl.Location = new System.Drawing.Point(740, 12);
            this.credit_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.credit_lbl.Name = "credit_lbl";
            this.credit_lbl.Size = new System.Drawing.Size(62, 21);
            this.credit_lbl.TabIndex = 616;
            this.credit_lbl.Text = "Credits";
            this.credit_lbl.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.showPastCustomer_cb);
            this.panel11.Controls.Add(this.paidCustomer_rd);
            this.panel11.Controls.Add(this.unpaidCustomer_rd);
            this.panel11.Location = new System.Drawing.Point(69, 24);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(388, 35);
            this.panel11.TabIndex = 615;
            // 
            // showPastCustomer_cb
            // 
            this.showPastCustomer_cb.AutoSize = true;
            this.showPastCustomer_cb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPastCustomer_cb.Location = new System.Drawing.Point(233, 7);
            this.showPastCustomer_cb.Name = "showPastCustomer_cb";
            this.showPastCustomer_cb.Size = new System.Drawing.Size(150, 21);
            this.showPastCustomer_cb.TabIndex = 618;
            this.showPastCustomer_cb.Text = "Show Only Past Due";
            this.showPastCustomer_cb.UseVisualStyleBackColor = true;
            this.showPastCustomer_cb.Visible = false;
            this.showPastCustomer_cb.CheckedChanged += new System.EventHandler(this.showPastCustomer_cb_CheckedChanged);
            // 
            // paidCustomer_rd
            // 
            this.paidCustomer_rd.AutoSize = true;
            this.paidCustomer_rd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidCustomer_rd.ForeColor = System.Drawing.Color.Black;
            this.paidCustomer_rd.Location = new System.Drawing.Point(103, 6);
            this.paidCustomer_rd.Name = "paidCustomer_rd";
            this.paidCustomer_rd.Size = new System.Drawing.Size(52, 21);
            this.paidCustomer_rd.TabIndex = 467;
            this.paidCustomer_rd.TabStop = true;
            this.paidCustomer_rd.Text = "Paid";
            this.paidCustomer_rd.UseVisualStyleBackColor = true;
            this.paidCustomer_rd.CheckedChanged += new System.EventHandler(this.paidCustomer_rd_CheckedChanged);
            // 
            // unpaidCustomer_rd
            // 
            this.unpaidCustomer_rd.AutoSize = true;
            this.unpaidCustomer_rd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpaidCustomer_rd.ForeColor = System.Drawing.Color.Black;
            this.unpaidCustomer_rd.Location = new System.Drawing.Point(7, 6);
            this.unpaidCustomer_rd.Name = "unpaidCustomer_rd";
            this.unpaidCustomer_rd.Size = new System.Drawing.Size(69, 21);
            this.unpaidCustomer_rd.TabIndex = 466;
            this.unpaidCustomer_rd.TabStop = true;
            this.unpaidCustomer_rd.Text = "Unpaid";
            this.unpaidCustomer_rd.UseVisualStyleBackColor = true;
            this.unpaidCustomer_rd.CheckedChanged += new System.EventHandler(this.unpaidCustomer_rd_CheckedChanged);
            // 
            // notFound_cust
            // 
            this.notFound_cust.AutoSize = true;
            this.notFound_cust.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_cust.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_cust.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_cust.Location = new System.Drawing.Point(486, 293);
            this.notFound_cust.Name = "notFound_cust";
            this.notFound_cust.Size = new System.Drawing.Size(174, 45);
            this.notFound_cust.TabIndex = 614;
            this.notFound_cust.Text = "No Record";
            // 
            // dgCustomerCredits
            // 
            this.dgCustomerCredits.AllowUserToAddRows = false;
            this.dgCustomerCredits.AllowUserToDeleteRows = false;
            this.dgCustomerCredits.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgCustomerCredits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCustomerCredits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomerCredits.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgCustomerCredits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCustomerCredits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustomerCredits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgCustomerCredits.ColumnHeadersHeight = 35;
            this.dgCustomerCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCustomerCredits.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgCustomerCredits.EnableHeadersVisualStyles = false;
            this.dgCustomerCredits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgCustomerCredits.Location = new System.Drawing.Point(10, 67);
            this.dgCustomerCredits.MultiSelect = false;
            this.dgCustomerCredits.Name = "dgCustomerCredits";
            this.dgCustomerCredits.ReadOnly = true;
            this.dgCustomerCredits.RowHeadersVisible = false;
            this.dgCustomerCredits.RowHeadersWidth = 51;
            this.dgCustomerCredits.RowTemplate.Height = 32;
            this.dgCustomerCredits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomerCredits.Size = new System.Drawing.Size(1138, 514);
            this.dgCustomerCredits.TabIndex = 613;
            this.dgCustomerCredits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomerCredits_CellContentClick);
            this.dgCustomerCredits.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgCustomerCredits_CellFormatting);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(158, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(210, 5);
            this.panel7.TabIndex = 6;
            // 
            // expensesTab
            // 
            this.expensesTab.Controls.Add(this.dateGb);
            this.expensesTab.Controls.Add(this.showAllExp_cb);
            this.expensesTab.Controls.Add(this.panel8);
            this.expensesTab.Controls.Add(this.new_btn);
            this.expensesTab.Controls.Add(this.label1);
            this.expensesTab.Controls.Add(this.notFoundExpense);
            this.expensesTab.Controls.Add(this.dgExpenses);
            this.expensesTab.Controls.Add(this.panel2);
            this.expensesTab.Location = new System.Drawing.Point(4, 29);
            this.expensesTab.Name = "expensesTab";
            this.expensesTab.Padding = new System.Windows.Forms.Padding(3);
            this.expensesTab.Size = new System.Drawing.Size(1158, 587);
            this.expensesTab.TabIndex = 2;
            this.expensesTab.Text = "        Expenses       ";
            this.expensesTab.UseVisualStyleBackColor = true;
            this.expensesTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dateGb
            // 
            this.dateGb.Controls.Add(this.filter_dt);
            this.dateGb.Controls.Add(this.label4);
            this.dateGb.Location = new System.Drawing.Point(394, 30);
            this.dateGb.Name = "dateGb";
            this.dateGb.Size = new System.Drawing.Size(314, 46);
            this.dateGb.TabIndex = 628;
            this.dateGb.TabStop = false;
            // 
            // filter_dt
            // 
            this.filter_dt.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_dt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_dt.Location = new System.Drawing.Point(106, 16);
            this.filter_dt.Name = "filter_dt";
            this.filter_dt.Size = new System.Drawing.Size(200, 23);
            this.filter_dt.TabIndex = 0;
            this.filter_dt.ValueChanged += new System.EventHandler(this.filter_dt_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 626;
            this.label4.Text = "Filter By Date :";
            // 
            // showAllExp_cb
            // 
            this.showAllExp_cb.AutoSize = true;
            this.showAllExp_cb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.showAllExp_cb.Location = new System.Drawing.Point(722, 49);
            this.showAllExp_cb.Name = "showAllExp_cb";
            this.showAllExp_cb.Size = new System.Drawing.Size(79, 21);
            this.showAllExp_cb.TabIndex = 627;
            this.showAllExp_cb.Text = "Show All";
            this.showAllExp_cb.UseVisualStyleBackColor = true;
            this.showAllExp_cb.CheckedChanged += new System.EventHandler(this.showAllExp_cb_CheckedChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Controls.Add(this.total_tx);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(820, 82);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(330, 505);
            this.panel8.TabIndex = 625;
            // 
            // total_tx
            // 
            this.total_tx.AutoSize = true;
            this.total_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_tx.ForeColor = System.Drawing.Color.Black;
            this.total_tx.Location = new System.Drawing.Point(82, 77);
            this.total_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_tx.Name = "total_tx";
            this.total_tx.Size = new System.Drawing.Size(42, 20);
            this.total_tx.TabIndex = 629;
            this.total_tx.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 628;
            this.label6.Text = "Total :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 627;
            this.label5.Text = "Summary :";
            // 
            // new_btn
            // 
            this.new_btn.BackColor = System.Drawing.Color.Green;
            this.new_btn.FlatAppearance.BorderSize = 0;
            this.new_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_btn.ForeColor = System.Drawing.Color.White;
            this.new_btn.Location = new System.Drawing.Point(10, 15);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(128, 27);
            this.new_btn.TabIndex = 624;
            this.new_btn.Text = "New Expense";
            this.new_btn.UseVisualStyleBackColor = false;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 622;
            this.label1.Text = "List Of Expenses";
            // 
            // notFoundExpense
            // 
            this.notFoundExpense.AutoSize = true;
            this.notFoundExpense.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFoundExpense.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFoundExpense.ForeColor = System.Drawing.Color.IndianRed;
            this.notFoundExpense.Location = new System.Drawing.Point(316, 332);
            this.notFoundExpense.Name = "notFoundExpense";
            this.notFoundExpense.Size = new System.Drawing.Size(174, 45);
            this.notFoundExpense.TabIndex = 620;
            this.notFoundExpense.Text = "No Record";
            // 
            // dgExpenses
            // 
            this.dgExpenses.AllowUserToAddRows = false;
            this.dgExpenses.AllowUserToDeleteRows = false;
            this.dgExpenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgExpenses.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgExpenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgExpenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgExpenses.ColumnHeadersHeight = 35;
            this.dgExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgExpenses.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgExpenses.EnableHeadersVisualStyles = false;
            this.dgExpenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgExpenses.Location = new System.Drawing.Point(10, 82);
            this.dgExpenses.MultiSelect = false;
            this.dgExpenses.Name = "dgExpenses";
            this.dgExpenses.ReadOnly = true;
            this.dgExpenses.RowHeadersVisible = false;
            this.dgExpenses.RowHeadersWidth = 51;
            this.dgExpenses.RowTemplate.Height = 32;
            this.dgExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgExpenses.Size = new System.Drawing.Size(793, 499);
            this.dgExpenses.TabIndex = 619;
            this.dgExpenses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgExpenses_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(377, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 5);
            this.panel2.TabIndex = 7;
            // 
            // PaymentsAndBillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1166, 694);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.paymentTabControl.ResumeLayout(false);
            this.supplierPayable_tab.ResumeLayout(false);
            this.supplierPayable_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payable_pb)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierPayables)).EndInit();
            this.customerCreditTab.ResumeLayout(false);
            this.customerCreditTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditPb)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerCredits)).EndInit();
            this.expensesTab.ResumeLayout(false);
            this.expensesTab.PerformLayout();
            this.dateGb.ResumeLayout(false);
            this.dateGb.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.TabControl paymentTabControl;
        private System.Windows.Forms.TabPage supplierPayable_tab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage customerCreditTab;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabPage expensesTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgSupplierPayables;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Label po_title;
        public System.Windows.Forms.RadioButton unpaid_rd;
        public System.Windows.Forms.RadioButton paid_rd;
        private System.Windows.Forms.CheckBox showPastDue_cb;
        private System.Windows.Forms.CheckBox showPastCustomer_cb;
        internal System.Windows.Forms.Label credit_lbl;
        private System.Windows.Forms.Panel panel11;
        public System.Windows.Forms.RadioButton paidCustomer_rd;
        public System.Windows.Forms.RadioButton unpaidCustomer_rd;
        private System.Windows.Forms.Label notFound_cust;
        internal System.Windows.Forms.DataGridView dgCustomerCredits;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label notFoundExpense;
        internal System.Windows.Forms.DataGridView dgExpenses;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Panel panel8;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker filter_dt;
        private System.Windows.Forms.CheckBox showAllExp_cb;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label total_tx;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox payable_pb;
        private System.Windows.Forms.PictureBox creditPb;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox search_tx;
        private System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox dateGb;
    }
}