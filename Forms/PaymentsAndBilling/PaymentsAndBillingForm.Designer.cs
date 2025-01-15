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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.basePanel = new System.Windows.Forms.Panel();
            this.transactionsTabControl = new System.Windows.Forms.TabControl();
            this.cuurent_tab = new System.Windows.Forms.TabPage();
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
            this.allTransactions_tab = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.basePanel.Controls.Add(this.transactionsTabControl);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(1166, 620);
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
            this.transactionsTabControl.Name = "transactionsTabControl";
            this.transactionsTabControl.SelectedIndex = 0;
            this.transactionsTabControl.Size = new System.Drawing.Size(1166, 620);
            this.transactionsTabControl.TabIndex = 6;
            // 
            // cuurent_tab
            // 
            this.cuurent_tab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cuurent_tab.Controls.Add(this.paid_panel);
            this.cuurent_tab.Controls.Add(this.unpaid_panel);
            this.cuurent_tab.Controls.Add(this.showPastDue_cb);
            this.cuurent_tab.Controls.Add(this.paid_lbl);
            this.cuurent_tab.Controls.Add(this.po_title);
            this.cuurent_tab.Controls.Add(this.panel5);
            this.cuurent_tab.Controls.Add(this.notFound_lbl);
            this.cuurent_tab.Controls.Add(this.dgSupplierPayables);
            this.cuurent_tab.Controls.Add(this.panel6);
            this.cuurent_tab.Location = new System.Drawing.Point(4, 29);
            this.cuurent_tab.Name = "cuurent_tab";
            this.cuurent_tab.Padding = new System.Windows.Forms.Padding(3);
            this.cuurent_tab.Size = new System.Drawing.Size(1158, 587);
            this.cuurent_tab.TabIndex = 0;
            this.cuurent_tab.Text = "  Supplier Payables   ";
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
            this.paid_rd.BackColor = System.Drawing.Color.White;
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
            this.unpaid_rd.BackColor = System.Drawing.Color.White;
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
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgSupplierPayables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgSupplierPayables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSupplierPayables.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgSupplierPayables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSupplierPayables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSupplierPayables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgSupplierPayables.ColumnHeadersHeight = 35;
            this.dgSupplierPayables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSupplierPayables.DefaultCellStyle = dataGridViewCellStyle18;
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
            // allTransactions_tab
            // 
            this.allTransactions_tab.BackColor = System.Drawing.Color.White;
            this.allTransactions_tab.Controls.Add(this.panel8);
            this.allTransactions_tab.Controls.Add(this.panel9);
            this.allTransactions_tab.Controls.Add(this.checkBox1);
            this.allTransactions_tab.Controls.Add(this.label1);
            this.allTransactions_tab.Controls.Add(this.label2);
            this.allTransactions_tab.Controls.Add(this.panel11);
            this.allTransactions_tab.Controls.Add(this.label3);
            this.allTransactions_tab.Controls.Add(this.dataGridView1);
            this.allTransactions_tab.Controls.Add(this.panel7);
            this.allTransactions_tab.Location = new System.Drawing.Point(4, 29);
            this.allTransactions_tab.Name = "allTransactions_tab";
            this.allTransactions_tab.Padding = new System.Windows.Forms.Padding(3);
            this.allTransactions_tab.Size = new System.Drawing.Size(1158, 587);
            this.allTransactions_tab.TabIndex = 1;
            this.allTransactions_tab.Text = "   Customer Credits  ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(155, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 5);
            this.panel7.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1158, 587);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "        Expenses       ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(302, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 5);
            this.panel2.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel8.Location = new System.Drawing.Point(114, 57);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(80, 5);
            this.panel8.TabIndex = 620;
            this.panel8.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel9.Location = new System.Drawing.Point(19, 57);
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
            this.panel11.Controls.Add(this.radioButton1);
            this.panel11.Controls.Add(this.radioButton2);
            this.panel11.Location = new System.Drawing.Point(10, 21);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1138, 35);
            this.panel11.TabIndex = 615;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(113, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 24);
            this.radioButton1.TabIndex = 467;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Paid";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 24);
            this.radioButton2.TabIndex = 466;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Unpaid";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(486, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 45);
            this.label3.TabIndex = 614;
            this.label3.Text = "No Record";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(10, 98);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1138, 483);
            this.dataGridView1.TabIndex = 613;
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
            this.transactionsTabControl.ResumeLayout(false);
            this.cuurent_tab.ResumeLayout(false);
            this.cuurent_tab.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierPayables)).EndInit();
            this.allTransactions_tab.ResumeLayout(false);
            this.allTransactions_tab.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DataGridView dataGridView1;
    }
}