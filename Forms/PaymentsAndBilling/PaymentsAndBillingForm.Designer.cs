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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.basePanel = new System.Windows.Forms.Panel();
            this.paymentTabControl = new System.Windows.Forms.TabControl();
            this.supplierPayable_tab = new System.Windows.Forms.TabPage();
            this.paid_panel = new System.Windows.Forms.Panel();
            this.unpaid_panel = new System.Windows.Forms.Panel();
            this.showPastDue_cb = new System.Windows.Forms.CheckBox();
            this.paid_lbl = new System.Windows.Forms.Label();
            this.po_title = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.paid_rd = new System.Windows.Forms.RadioButton();
            this.unpaid_rd = new System.Windows.Forms.RadioButton();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgSupplierPayables = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.customerCredit_tab = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.paidCustomer_rd = new System.Windows.Forms.RadioButton();
            this.unpaidCustomer_rd = new System.Windows.Forms.RadioButton();
            this.notFound_cust = new System.Windows.Forms.Label();
            this.dgCustomerCredits = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.expesnse_tab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.basePanel.SuspendLayout();
            this.paymentTabControl.SuspendLayout();
            this.supplierPayable_tab.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierPayables)).BeginInit();
            this.customerCredit_tab.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerCredits)).BeginInit();
            this.expesnse_tab.SuspendLayout();
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
            this.paymentTabControl.Controls.Add(this.customerCredit_tab);
            this.paymentTabControl.Controls.Add(this.expesnse_tab);
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
            this.supplierPayable_tab.Controls.Add(this.paid_panel);
            this.supplierPayable_tab.Controls.Add(this.unpaid_panel);
            this.supplierPayable_tab.Controls.Add(this.showPastDue_cb);
            this.supplierPayable_tab.Controls.Add(this.paid_lbl);
            this.supplierPayable_tab.Controls.Add(this.po_title);
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
            // paid_panel
            // 
            this.paid_panel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.paid_panel.Location = new System.Drawing.Point(198, 57);
            this.paid_panel.Name = "paid_panel";
            this.paid_panel.Size = new System.Drawing.Size(130, 5);
            this.paid_panel.TabIndex = 612;
            this.paid_panel.Visible = false;
            // 
            // unpaid_panel
            // 
            this.unpaid_panel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.unpaid_panel.Location = new System.Drawing.Point(16, 57);
            this.unpaid_panel.Name = "unpaid_panel";
            this.unpaid_panel.Size = new System.Drawing.Size(150, 5);
            this.unpaid_panel.TabIndex = 611;
            this.unpaid_panel.Visible = false;
            // 
            // showPastDue_cb
            // 
            this.showPastDue_cb.AutoSize = true;
            this.showPastDue_cb.Location = new System.Drawing.Point(1024, 70);
            this.showPastDue_cb.Name = "showPastDue_cb";
            this.showPastDue_cb.Size = new System.Drawing.Size(129, 24);
            this.showPastDue_cb.TabIndex = 610;
            this.showPastDue_cb.Text = "Show Past Due";
            this.showPastDue_cb.UseVisualStyleBackColor = true;
            this.showPastDue_cb.Visible = false;
            this.showPastDue_cb.CheckedChanged += new System.EventHandler(this.showPastDue_cb_CheckedChanged);
            // 
            // paid_lbl
            // 
            this.paid_lbl.AutoSize = true;
            this.paid_lbl.BackColor = System.Drawing.Color.Green;
            this.paid_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_lbl.ForeColor = System.Drawing.Color.White;
            this.paid_lbl.Location = new System.Drawing.Point(1091, 70);
            this.paid_lbl.Name = "paid_lbl";
            this.paid_lbl.Size = new System.Drawing.Size(57, 22);
            this.paid_lbl.TabIndex = 609;
            this.paid_lbl.Text = "PAID";
            // 
            // po_title
            // 
            this.po_title.AutoSize = true;
            this.po_title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.po_title.ForeColor = System.Drawing.Color.Black;
            this.po_title.Location = new System.Drawing.Point(9, 70);
            this.po_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.po_title.Name = "po_title";
            this.po_title.Size = new System.Drawing.Size(151, 25);
            this.po_title.TabIndex = 469;
            this.po_title.Text = "Purchase Orders";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.paid_rd);
            this.panel5.Controls.Add(this.unpaid_rd);
            this.panel5.Location = new System.Drawing.Point(10, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1138, 35);
            this.panel5.TabIndex = 468;
            // 
            // paid_rd
            // 
            this.paid_rd.AutoSize = true;
            this.paid_rd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paid_rd.Location = new System.Drawing.Point(193, 6);
            this.paid_rd.Name = "paid_rd";
            this.paid_rd.Size = new System.Drawing.Size(122, 24);
            this.paid_rd.TabIndex = 467;
            this.paid_rd.TabStop = true;
            this.paid_rd.Text = "Paid P. Orders";
            this.paid_rd.UseVisualStyleBackColor = false;
            this.paid_rd.CheckedChanged += new System.EventHandler(this.paid_rd_CheckedChanged);
            // 
            // unpaid_rd
            // 
            this.unpaid_rd.AutoSize = true;
            this.unpaid_rd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.unpaid_rd.Location = new System.Drawing.Point(8, 6);
            this.unpaid_rd.Name = "unpaid_rd";
            this.unpaid_rd.Size = new System.Drawing.Size(142, 24);
            this.unpaid_rd.TabIndex = 466;
            this.unpaid_rd.TabStop = true;
            this.unpaid_rd.Text = "Unpaid P. Orders";
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
            this.dgSupplierPayables.Location = new System.Drawing.Point(10, 98);
            this.dgSupplierPayables.MultiSelect = false;
            this.dgSupplierPayables.Name = "dgSupplierPayables";
            this.dgSupplierPayables.ReadOnly = true;
            this.dgSupplierPayables.RowHeadersVisible = false;
            this.dgSupplierPayables.RowHeadersWidth = 51;
            this.dgSupplierPayables.RowTemplate.Height = 32;
            this.dgSupplierPayables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSupplierPayables.Size = new System.Drawing.Size(1138, 483);
            this.dgSupplierPayables.TabIndex = 463;
            this.dgSupplierPayables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSupplierPayables_CellContentClick);
            this.dgSupplierPayables.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgSupplierPayables_CellFormatting);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(3, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 5);
            this.panel6.TabIndex = 5;
            // 
            // customerCredit_tab
            // 
            this.customerCredit_tab.BackColor = System.Drawing.Color.White;
            this.customerCredit_tab.Controls.Add(this.panel8);
            this.customerCredit_tab.Controls.Add(this.panel9);
            this.customerCredit_tab.Controls.Add(this.checkBox1);
            this.customerCredit_tab.Controls.Add(this.label1);
            this.customerCredit_tab.Controls.Add(this.label2);
            this.customerCredit_tab.Controls.Add(this.panel11);
            this.customerCredit_tab.Controls.Add(this.notFound_cust);
            this.customerCredit_tab.Controls.Add(this.dgCustomerCredits);
            this.customerCredit_tab.Controls.Add(this.panel7);
            this.customerCredit_tab.Location = new System.Drawing.Point(4, 29);
            this.customerCredit_tab.Name = "customerCredit_tab";
            this.customerCredit_tab.Padding = new System.Windows.Forms.Padding(3);
            this.customerCredit_tab.Size = new System.Drawing.Size(1158, 587);
            this.customerCredit_tab.TabIndex = 1;
            this.customerCredit_tab.Text = "   Customer Credits  ";
            this.customerCredit_tab.Click += new System.EventHandler(this.allTransactions_tab_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel8.Location = new System.Drawing.Point(116, 57);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(80, 5);
            this.panel8.TabIndex = 620;
            this.panel8.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel9.Location = new System.Drawing.Point(17, 57);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(80, 5);
            this.panel9.TabIndex = 619;
            this.panel9.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1024, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 24);
            this.checkBox1.TabIndex = 618;
            this.checkBox1.Text = "Show Past Due";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1091, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 617;
            this.label1.Text = "PAID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 616;
            this.label2.Text = "Credits";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Controls.Add(this.paidCustomer_rd);
            this.panel11.Controls.Add(this.unpaidCustomer_rd);
            this.panel11.Location = new System.Drawing.Point(10, 21);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1138, 35);
            this.panel11.TabIndex = 615;
            // 
            // paidCustomer_rd
            // 
            this.paidCustomer_rd.AutoSize = true;
            this.paidCustomer_rd.Location = new System.Drawing.Point(116, 6);
            this.paidCustomer_rd.Name = "paidCustomer_rd";
            this.paidCustomer_rd.Size = new System.Drawing.Size(57, 24);
            this.paidCustomer_rd.TabIndex = 467;
            this.paidCustomer_rd.TabStop = true;
            this.paidCustomer_rd.Text = "Paid";
            this.paidCustomer_rd.UseVisualStyleBackColor = true;
            this.paidCustomer_rd.CheckedChanged += new System.EventHandler(this.paidCustomer_rd_CheckedChanged);
            // 
            // unpaidCustomer_rd
            // 
            this.unpaidCustomer_rd.AutoSize = true;
            this.unpaidCustomer_rd.Location = new System.Drawing.Point(8, 6);
            this.unpaidCustomer_rd.Name = "unpaidCustomer_rd";
            this.unpaidCustomer_rd.Size = new System.Drawing.Size(77, 24);
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
            this.dgCustomerCredits.Location = new System.Drawing.Point(10, 98);
            this.dgCustomerCredits.MultiSelect = false;
            this.dgCustomerCredits.Name = "dgCustomerCredits";
            this.dgCustomerCredits.ReadOnly = true;
            this.dgCustomerCredits.RowHeadersVisible = false;
            this.dgCustomerCredits.RowHeadersWidth = 51;
            this.dgCustomerCredits.RowTemplate.Height = 32;
            this.dgCustomerCredits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomerCredits.Size = new System.Drawing.Size(1138, 483);
            this.dgCustomerCredits.TabIndex = 613;
            this.dgCustomerCredits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomerCredits_CellContentClick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(155, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 5);
            this.panel7.TabIndex = 6;
            // 
            // expesnse_tab
            // 
            this.expesnse_tab.Controls.Add(this.panel2);
            this.expesnse_tab.Location = new System.Drawing.Point(4, 29);
            this.expesnse_tab.Name = "expesnse_tab";
            this.expesnse_tab.Padding = new System.Windows.Forms.Padding(3);
            this.expesnse_tab.Size = new System.Drawing.Size(1158, 587);
            this.expesnse_tab.TabIndex = 2;
            this.expesnse_tab.Text = "        Expenses       ";
            this.expesnse_tab.UseVisualStyleBackColor = true;
            this.expesnse_tab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(302, -1);
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
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierPayables)).EndInit();
            this.customerCredit_tab.ResumeLayout(false);
            this.customerCredit_tab.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerCredits)).EndInit();
            this.expesnse_tab.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage customerCredit_tab;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabPage expesnse_tab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgSupplierPayables;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Label po_title;
        public System.Windows.Forms.RadioButton unpaid_rd;
        public System.Windows.Forms.RadioButton paid_rd;
        internal System.Windows.Forms.Label paid_lbl;
        private System.Windows.Forms.CheckBox showPastDue_cb;
        private System.Windows.Forms.Panel paid_panel;
        private System.Windows.Forms.Panel unpaid_panel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.CheckBox checkBox1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel11;
        public System.Windows.Forms.RadioButton paidCustomer_rd;
        public System.Windows.Forms.RadioButton unpaidCustomer_rd;
        private System.Windows.Forms.Label notFound_cust;
        internal System.Windows.Forms.DataGridView dgCustomerCredits;
    }
}