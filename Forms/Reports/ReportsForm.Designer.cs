namespace SalesPro.Forms.Reports
{
    partial class ReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customDatePanel = new System.Windows.Forms.Panel();
            this.startDate_dt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.endDate_dt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.reportDate_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewByCb = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.overAllSales_tx = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.paymentToSupplier_tx = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totalExpenses_tx = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customerCreditTotal_tx = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalSales_tx = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.noRecordCustomer = new System.Windows.Forms.Label();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.movement_cb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.analyticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.analytics_cb = new System.Windows.Forms.ComboBox();
            this.Panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.customDatePanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyticsChart)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel1.Controls.Add(this.title_lbl);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1166, 43);
            this.Panel1.TabIndex = 439;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(6, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(78, 25);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Reports";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(11, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 175);
            this.groupBox1.TabIndex = 440;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // customDatePanel
            // 
            this.customDatePanel.Controls.Add(this.startDate_dt);
            this.customDatePanel.Controls.Add(this.label2);
            this.customDatePanel.Controls.Add(this.endDate_dt);
            this.customDatePanel.Controls.Add(this.label3);
            this.customDatePanel.Controls.Add(this.findBtn);
            this.customDatePanel.Location = new System.Drawing.Point(172, 59);
            this.customDatePanel.Name = "customDatePanel";
            this.customDatePanel.Size = new System.Drawing.Size(439, 53);
            this.customDatePanel.TabIndex = 538;
            // 
            // startDate_dt
            // 
            this.startDate_dt.CustomFormat = "MMMM dd,  yyyy";
            this.startDate_dt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate_dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate_dt.Location = new System.Drawing.Point(7, 23);
            this.startDate_dt.Name = "startDate_dt";
            this.startDate_dt.Size = new System.Drawing.Size(161, 23);
            this.startDate_dt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date :";
            // 
            // endDate_dt
            // 
            this.endDate_dt.CustomFormat = "MMMM dd,  yyyy";
            this.endDate_dt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate_dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate_dt.Location = new System.Drawing.Point(179, 23);
            this.endDate_dt.Name = "endDate_dt";
            this.endDate_dt.Size = new System.Drawing.Size(161, 23);
            this.endDate_dt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date :";
            // 
            // findBtn
            // 
            this.findBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.findBtn.FlatAppearance.BorderSize = 0;
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.ForeColor = System.Drawing.Color.White;
            this.findBtn.Location = new System.Drawing.Point(347, 20);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(86, 27);
            this.findBtn.TabIndex = 533;
            this.findBtn.Text = "Find ";
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // reportDate_lbl
            // 
            this.reportDate_lbl.AutoSize = true;
            this.reportDate_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportDate_lbl.Location = new System.Drawing.Point(169, 85);
            this.reportDate_lbl.Name = "reportDate_lbl";
            this.reportDate_lbl.Size = new System.Drawing.Size(90, 17);
            this.reportDate_lbl.TabIndex = 541;
            this.reportDate_lbl.Text = "Report Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 540;
            this.label4.Text = "View By Date";
            // 
            // viewByCb
            // 
            this.viewByCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewByCb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewByCb.FormattingEnabled = true;
            this.viewByCb.Items.AddRange(new object[] {
            "Past 30 Days",
            "Past 60 Days",
            "Past 90 Days",
            "Custom Date Range"});
            this.viewByCb.Location = new System.Drawing.Point(15, 81);
            this.viewByCb.Name = "viewByCb";
            this.viewByCb.Size = new System.Drawing.Size(145, 25);
            this.viewByCb.TabIndex = 539;
            this.viewByCb.SelectedIndexChanged += new System.EventHandler(this.viewByCb_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Controls.Add(this.overAllSales_tx);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(410, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 148);
            this.panel6.TabIndex = 537;
            // 
            // overAllSales_tx
            // 
            this.overAllSales_tx.AutoSize = true;
            this.overAllSales_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overAllSales_tx.ForeColor = System.Drawing.Color.White;
            this.overAllSales_tx.Location = new System.Drawing.Point(10, 25);
            this.overAllSales_tx.Name = "overAllSales_tx";
            this.overAllSales_tx.Size = new System.Drawing.Size(54, 30);
            this.overAllSales_tx.TabIndex = 4;
            this.overAllSales_tx.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Over All Sales";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Peru;
            this.panel5.Controls.Add(this.paymentToSupplier_tx);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(213, 95);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(186, 69);
            this.panel5.TabIndex = 537;
            // 
            // paymentToSupplier_tx
            // 
            this.paymentToSupplier_tx.AutoSize = true;
            this.paymentToSupplier_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentToSupplier_tx.ForeColor = System.Drawing.Color.White;
            this.paymentToSupplier_tx.Location = new System.Drawing.Point(11, 25);
            this.paymentToSupplier_tx.Name = "paymentToSupplier_tx";
            this.paymentToSupplier_tx.Size = new System.Drawing.Size(54, 30);
            this.paymentToSupplier_tx.TabIndex = 4;
            this.paymentToSupplier_tx.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(13, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "Payment To Supplier Total";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Sienna;
            this.panel4.Controls.Add(this.totalExpenses_tx);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(213, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 69);
            this.panel4.TabIndex = 536;
            // 
            // totalExpenses_tx
            // 
            this.totalExpenses_tx.AutoSize = true;
            this.totalExpenses_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalExpenses_tx.ForeColor = System.Drawing.Color.White;
            this.totalExpenses_tx.Location = new System.Drawing.Point(9, 25);
            this.totalExpenses_tx.Name = "totalExpenses_tx";
            this.totalExpenses_tx.Size = new System.Drawing.Size(54, 30);
            this.totalExpenses_tx.TabIndex = 4;
            this.totalExpenses_tx.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total Expenses";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Controls.Add(this.customerCreditTotal_tx);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(17, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 69);
            this.panel3.TabIndex = 535;
            // 
            // customerCreditTotal_tx
            // 
            this.customerCreditTotal_tx.AutoSize = true;
            this.customerCreditTotal_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCreditTotal_tx.ForeColor = System.Drawing.Color.White;
            this.customerCreditTotal_tx.Location = new System.Drawing.Point(8, 25);
            this.customerCreditTotal_tx.Name = "customerCreditTotal_tx";
            this.customerCreditTotal_tx.Size = new System.Drawing.Size(54, 30);
            this.customerCreditTotal_tx.TabIndex = 4;
            this.customerCreditTotal_tx.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(9, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "Customer Credit Payment Total";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.totalSales_tx);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(17, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 69);
            this.panel2.TabIndex = 534;
            // 
            // totalSales_tx
            // 
            this.totalSales_tx.AutoSize = true;
            this.totalSales_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSales_tx.ForeColor = System.Drawing.Color.White;
            this.totalSales_tx.Location = new System.Drawing.Point(9, 25);
            this.totalSales_tx.Name = "totalSales_tx";
            this.totalSales_tx.Size = new System.Drawing.Size(54, 30);
            this.totalSales_tx.TabIndex = 4;
            this.totalSales_tx.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Sales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Summary";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noRecordCustomer);
            this.groupBox2.Controls.Add(this.dgCustomers);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.notFound_lbl);
            this.groupBox2.Controls.Add(this.dgProducts);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.movement_cb);
            this.groupBox2.Location = new System.Drawing.Point(640, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 604);
            this.groupBox2.TabIndex = 441;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // noRecordCustomer
            // 
            this.noRecordCustomer.AutoSize = true;
            this.noRecordCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.noRecordCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.noRecordCustomer.ForeColor = System.Drawing.Color.IndianRed;
            this.noRecordCustomer.Location = new System.Drawing.Point(174, 453);
            this.noRecordCustomer.Name = "noRecordCustomer";
            this.noRecordCustomer.Size = new System.Drawing.Size(174, 45);
            this.noRecordCustomer.TabIndex = 468;
            this.noRecordCustomer.Text = "No Record";
            // 
            // dgCustomers
            // 
            this.dgCustomers.AllowUserToAddRows = false;
            this.dgCustomers.AllowUserToDeleteRows = false;
            this.dgCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgCustomers.ColumnHeadersHeight = 30;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCustomers.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgCustomers.EnableHeadersVisualStyles = false;
            this.dgCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgCustomers.Location = new System.Drawing.Point(11, 348);
            this.dgCustomers.MultiSelect = false;
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ReadOnly = true;
            this.dgCustomers.RowHeadersVisible = false;
            this.dgCustomers.RowHeadersWidth = 51;
            this.dgCustomers.RowTemplate.Height = 32;
            this.dgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomers.Size = new System.Drawing.Size(493, 250);
            this.dgCustomers.TabIndex = 459;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 324);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(210, 21);
            this.label16.TabIndex = 444;
            this.label16.Text = "Top High Paying Customers";
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(174, 163);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 467;
            this.notFound_lbl.Text = "No Record";
            // 
            // dgProducts
            // 
            this.dgProducts.AllowUserToAddRows = false;
            this.dgProducts.AllowUserToDeleteRows = false;
            this.dgProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProducts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgProducts.ColumnHeadersHeight = 30;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProducts.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgProducts.EnableHeadersVisualStyles = false;
            this.dgProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgProducts.Location = new System.Drawing.Point(11, 60);
            this.dgProducts.MultiSelect = false;
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.ReadOnly = true;
            this.dgProducts.RowHeadersVisible = false;
            this.dgProducts.RowHeadersWidth = 51;
            this.dgProducts.RowTemplate.Height = 32;
            this.dgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducts.Size = new System.Drawing.Size(493, 251);
            this.dgProducts.TabIndex = 459;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Movement Type";
            // 
            // movement_cb
            // 
            this.movement_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.movement_cb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movement_cb.FormattingEnabled = true;
            this.movement_cb.Items.AddRange(new object[] {
            "Fast Selling Products",
            "Least Selling Products"});
            this.movement_cb.Location = new System.Drawing.Point(11, 31);
            this.movement_cb.Name = "movement_cb";
            this.movement_cb.Size = new System.Drawing.Size(170, 25);
            this.movement_cb.TabIndex = 0;
            this.movement_cb.SelectedIndexChanged += new System.EventHandler(this.movement_cb_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(643, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 21);
            this.label10.TabIndex = 442;
            this.label10.Text = "Product Movement Report";
            // 
            // analyticsChart
            // 
            this.analyticsChart.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.Name = "ChartArea1";
            this.analyticsChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.analyticsChart.Legends.Add(legend3);
            this.analyticsChart.Location = new System.Drawing.Point(14, 19);
            this.analyticsChart.Name = "analyticsChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.analyticsChart.Series.Add(series3);
            this.analyticsChart.Size = new System.Drawing.Size(583, 290);
            this.analyticsChart.TabIndex = 443;
            this.analyticsChart.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.analyticsChart);
            this.groupBox3.Location = new System.Drawing.Point(12, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(608, 315);
            this.groupBox3.TabIndex = 443;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 543;
            this.label6.Text = "View By";
            // 
            // analytics_cb
            // 
            this.analytics_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.analytics_cb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analytics_cb.FormattingEnabled = true;
            this.analytics_cb.Items.AddRange(new object[] {
            "Yearly",
            "Monthy For Current Year"});
            this.analytics_cb.Location = new System.Drawing.Point(15, 340);
            this.analytics_cb.Name = "analytics_cb";
            this.analytics_cb.Size = new System.Drawing.Size(204, 25);
            this.analytics_cb.TabIndex = 542;
            this.analytics_cb.SelectedIndexChanged += new System.EventHandler(this.analytics_cb_SelectedIndexChanged);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1166, 694);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.analytics_cb);
            this.Controls.Add(this.customDatePanel);
            this.Controls.Add(this.reportDate_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.viewByCb);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.customDatePanel.ResumeLayout(false);
            this.customDatePanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyticsChart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDate_dt;
        private System.Windows.Forms.Label totalSales_tx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker endDate_dt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label overAllSales_tx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label paymentToSupplier_tx;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label totalExpenses_tx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label customerCreditTotal_tx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox movement_cb;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.DataVisualization.Charting.Chart analyticsChart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        internal System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox viewByCb;
        private System.Windows.Forms.Panel customDatePanel;
        private System.Windows.Forms.Label reportDate_lbl;
        private System.Windows.Forms.Label notFound_lbl;
        private System.Windows.Forms.Label noRecordCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox analytics_cb;
    }
}