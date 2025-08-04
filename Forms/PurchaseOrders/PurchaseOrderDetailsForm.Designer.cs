﻿namespace SalesPro.Forms.PurchaseOrders
{
    partial class PurchaseOrderDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderDetailsForm));
            this.title_lbl = new System.Windows.Forms.Label();
            this.dgPoItems = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.poPanel = new System.Windows.Forms.Panel();
            this.print_btn = new System.Windows.Forms.Button();
            this.process_panel = new System.Windows.Forms.Panel();
            this.processStatus_tx = new System.Windows.Forms.Label();
            this.balStat_pb = new System.Windows.Forms.PictureBox();
            this.payment_panel = new System.Windows.Forms.Panel();
            this.paymentStatus_tx = new System.Windows.Forms.Label();
            this.closeStat_pb = new System.Windows.Forms.PictureBox();
            this.poId_tx = new System.Windows.Forms.Label();
            this.total_tx = new System.Windows.Forms.Label();
            this.action_btn = new System.Windows.Forms.Button();
            this.undo_btn = new System.Windows.Forms.Button();
            this.supplier_tx = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.address_tx = new System.Windows.Forms.Label();
            this.contactPerson_tx = new System.Windows.Forms.Label();
            this.number_tx = new System.Windows.Forms.Label();
            this.addSupplier_btn = new System.Windows.Forms.Button();
            this.addProduct_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rowCount_tx = new System.Windows.Forms.Label();
            this.creditTerms_tx = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.creditTermsPanel = new System.Windows.Forms.Panel();
            this.showLogs_link = new System.Windows.Forms.LinkLabel();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dueDate_tx = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateCreated_tx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.poPanel.SuspendLayout();
            this.process_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balStat_pb)).BeginInit();
            this.payment_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeStat_pb)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditTerms_tx)).BeginInit();
            this.creditTermsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(7, 12);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(207, 25);
            this.title_lbl.TabIndex = 2;
            this.title_lbl.Text = "Purchase Order Details";
            // 
            // dgPoItems
            // 
            this.dgPoItems.AllowUserToAddRows = false;
            this.dgPoItems.AllowUserToDeleteRows = false;
            this.dgPoItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgPoItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgPoItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPoItems.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgPoItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPoItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPoItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgPoItems.ColumnHeadersHeight = 37;
            this.dgPoItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPoItems.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgPoItems.EnableHeadersVisualStyles = false;
            this.dgPoItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgPoItems.Location = new System.Drawing.Point(10, 201);
            this.dgPoItems.MultiSelect = false;
            this.dgPoItems.Name = "dgPoItems";
            this.dgPoItems.ReadOnly = true;
            this.dgPoItems.RowHeadersVisible = false;
            this.dgPoItems.RowHeadersWidth = 51;
            this.dgPoItems.RowTemplate.Height = 32;
            this.dgPoItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPoItems.Size = new System.Drawing.Size(1109, 479);
            this.dgPoItems.TabIndex = 463;
            this.dgPoItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPoItems_CellContentClick);
            this.dgPoItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgPo_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 466;
            this.pictureBox1.TabStop = false;
            // 
            // search_tx
            // 
            this.search_tx.BackColor = System.Drawing.Color.White;
            this.search_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tx.Location = new System.Drawing.Point(156, 168);
            this.search_tx.Margin = new System.Windows.Forms.Padding(2);
            this.search_tx.Name = "search_tx";
            this.search_tx.Size = new System.Drawing.Size(389, 27);
            this.search_tx.TabIndex = 465;
            this.search_tx.TextChanged += new System.EventHandler(this.search_tx_TextChanged);
            // 
            // poPanel
            // 
            this.poPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.poPanel.Controls.Add(this.print_btn);
            this.poPanel.Controls.Add(this.process_panel);
            this.poPanel.Controls.Add(this.payment_panel);
            this.poPanel.Location = new System.Drawing.Point(290, 11);
            this.poPanel.Name = "poPanel";
            this.poPanel.Size = new System.Drawing.Size(829, 31);
            this.poPanel.TabIndex = 519;
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.print_btn.FlatAppearance.BorderSize = 0;
            this.print_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.Image = ((System.Drawing.Image)(resources.GetObject("print_btn.Image")));
            this.print_btn.Location = new System.Drawing.Point(703, 0);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(121, 31);
            this.print_btn.TabIndex = 548;
            this.print_btn.Text = "  Print";
            this.print_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.print_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // process_panel
            // 
            this.process_panel.Controls.Add(this.processStatus_tx);
            this.process_panel.Controls.Add(this.balStat_pb);
            this.process_panel.Location = new System.Drawing.Point(3, 5);
            this.process_panel.Name = "process_panel";
            this.process_panel.Size = new System.Drawing.Size(101, 20);
            this.process_panel.TabIndex = 516;
            // 
            // processStatus_tx
            // 
            this.processStatus_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processStatus_tx.ForeColor = System.Drawing.Color.Black;
            this.processStatus_tx.Location = new System.Drawing.Point(19, 1);
            this.processStatus_tx.Name = "processStatus_tx";
            this.processStatus_tx.Size = new System.Drawing.Size(103, 17);
            this.processStatus_tx.TabIndex = 506;
            this.processStatus_tx.Text = "Process";
            this.processStatus_tx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // balStat_pb
            // 
            this.balStat_pb.Image = ((System.Drawing.Image)(resources.GetObject("balStat_pb.Image")));
            this.balStat_pb.Location = new System.Drawing.Point(3, 2);
            this.balStat_pb.Name = "balStat_pb";
            this.balStat_pb.Size = new System.Drawing.Size(15, 15);
            this.balStat_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.balStat_pb.TabIndex = 0;
            this.balStat_pb.TabStop = false;
            // 
            // payment_panel
            // 
            this.payment_panel.Controls.Add(this.paymentStatus_tx);
            this.payment_panel.Controls.Add(this.closeStat_pb);
            this.payment_panel.Location = new System.Drawing.Point(115, 5);
            this.payment_panel.Name = "payment_panel";
            this.payment_panel.Size = new System.Drawing.Size(159, 20);
            this.payment_panel.TabIndex = 517;
            // 
            // paymentStatus_tx
            // 
            this.paymentStatus_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentStatus_tx.ForeColor = System.Drawing.Color.Black;
            this.paymentStatus_tx.Location = new System.Drawing.Point(22, 1);
            this.paymentStatus_tx.Name = "paymentStatus_tx";
            this.paymentStatus_tx.Size = new System.Drawing.Size(124, 17);
            this.paymentStatus_tx.TabIndex = 514;
            this.paymentStatus_tx.Text = "Payment";
            this.paymentStatus_tx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeStat_pb
            // 
            this.closeStat_pb.Image = ((System.Drawing.Image)(resources.GetObject("closeStat_pb.Image")));
            this.closeStat_pb.Location = new System.Drawing.Point(3, 2);
            this.closeStat_pb.Name = "closeStat_pb";
            this.closeStat_pb.Size = new System.Drawing.Size(15, 15);
            this.closeStat_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeStat_pb.TabIndex = 515;
            this.closeStat_pb.TabStop = false;
            // 
            // poId_tx
            // 
            this.poId_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poId_tx.ForeColor = System.Drawing.Color.Black;
            this.poId_tx.Location = new System.Drawing.Point(138, 1);
            this.poId_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.poId_tx.Name = "poId_tx";
            this.poId_tx.Size = new System.Drawing.Size(263, 20);
            this.poId_tx.TabIndex = 533;
            this.poId_tx.Text = "000000000";
            this.poId_tx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // total_tx
            // 
            this.total_tx.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_tx.ForeColor = System.Drawing.Color.Blue;
            this.total_tx.Location = new System.Drawing.Point(803, 163);
            this.total_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_tx.Name = "total_tx";
            this.total_tx.Size = new System.Drawing.Size(318, 41);
            this.total_tx.TabIndex = 534;
            this.total_tx.Text = "0.00";
            this.total_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // action_btn
            // 
            this.action_btn.BackColor = System.Drawing.Color.Green;
            this.action_btn.FlatAppearance.BorderSize = 0;
            this.action_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_btn.ForeColor = System.Drawing.Color.White;
            this.action_btn.Location = new System.Drawing.Point(957, 696);
            this.action_btn.Name = "action_btn";
            this.action_btn.Size = new System.Drawing.Size(159, 34);
            this.action_btn.TabIndex = 520;
            this.action_btn.Text = "Send To Supplier";
            this.action_btn.UseVisualStyleBackColor = false;
            this.action_btn.Click += new System.EventHandler(this.action_btn_Click);
            // 
            // undo_btn
            // 
            this.undo_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.undo_btn.FlatAppearance.BorderSize = 0;
            this.undo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undo_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undo_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.undo_btn.Location = new System.Drawing.Point(775, 696);
            this.undo_btn.Name = "undo_btn";
            this.undo_btn.Size = new System.Drawing.Size(169, 34);
            this.undo_btn.TabIndex = 521;
            this.undo_btn.Text = "Undo Process";
            this.undo_btn.UseVisualStyleBackColor = false;
            this.undo_btn.Click += new System.EventHandler(this.undo_btn_Click);
            // 
            // supplier_tx
            // 
            this.supplier_tx.AutoSize = true;
            this.supplier_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_tx.Location = new System.Drawing.Point(261, 2);
            this.supplier_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplier_tx.Name = "supplier_tx";
            this.supplier_tx.Size = new System.Drawing.Size(13, 17);
            this.supplier_tx.TabIndex = 523;
            this.supplier_tx.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 522;
            this.label5.Text = "Supplier :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 524;
            this.label1.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(653, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 525;
            this.label2.Text = "Contact Person :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 526;
            this.label3.Text = "Contact Number :";
            // 
            // address_tx
            // 
            this.address_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_tx.Location = new System.Drawing.Point(261, 18);
            this.address_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address_tx.Name = "address_tx";
            this.address_tx.Size = new System.Drawing.Size(305, 17);
            this.address_tx.TabIndex = 527;
            this.address_tx.Text = "-";
            // 
            // contactPerson_tx
            // 
            this.contactPerson_tx.AutoSize = true;
            this.contactPerson_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactPerson_tx.Location = new System.Drawing.Point(770, 2);
            this.contactPerson_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactPerson_tx.Name = "contactPerson_tx";
            this.contactPerson_tx.Size = new System.Drawing.Size(13, 17);
            this.contactPerson_tx.TabIndex = 528;
            this.contactPerson_tx.Text = "-";
            // 
            // number_tx
            // 
            this.number_tx.AutoSize = true;
            this.number_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_tx.Location = new System.Drawing.Point(771, 18);
            this.number_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.number_tx.Name = "number_tx";
            this.number_tx.Size = new System.Drawing.Size(13, 17);
            this.number_tx.TabIndex = 529;
            this.number_tx.Text = "-";
            // 
            // addSupplier_btn
            // 
            this.addSupplier_btn.BackColor = System.Drawing.Color.Green;
            this.addSupplier_btn.FlatAppearance.BorderSize = 0;
            this.addSupplier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSupplier_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSupplier_btn.ForeColor = System.Drawing.Color.White;
            this.addSupplier_btn.Location = new System.Drawing.Point(7, 6);
            this.addSupplier_btn.Name = "addSupplier_btn";
            this.addSupplier_btn.Size = new System.Drawing.Size(128, 27);
            this.addSupplier_btn.TabIndex = 530;
            this.addSupplier_btn.Text = "Select Supplier";
            this.addSupplier_btn.UseVisualStyleBackColor = false;
            this.addSupplier_btn.Click += new System.EventHandler(this.addSupplier_btn_Click);
            // 
            // addProduct_btn
            // 
            this.addProduct_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addProduct_btn.FlatAppearance.BorderSize = 0;
            this.addProduct_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_btn.ForeColor = System.Drawing.Color.White;
            this.addProduct_btn.Location = new System.Drawing.Point(16, 168);
            this.addProduct_btn.Name = "addProduct_btn";
            this.addProduct_btn.Size = new System.Drawing.Size(128, 27);
            this.addProduct_btn.TabIndex = 531;
            this.addProduct_btn.Text = "Add Product";
            this.addProduct_btn.UseVisualStyleBackColor = false;
            this.addProduct_btn.Click += new System.EventHandler(this.addProduct_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.supplier_tx);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.number_tx);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.contactPerson_tx);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.address_tx);
            this.panel2.Controls.Add(this.addSupplier_btn);
            this.panel2.Location = new System.Drawing.Point(10, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 40);
            this.panel2.TabIndex = 532;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1031, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 535;
            this.label4.Text = "Total Payable";
            // 
            // rowCount_tx
            // 
            this.rowCount_tx.AutoSize = true;
            this.rowCount_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowCount_tx.Location = new System.Drawing.Point(138, 21);
            this.rowCount_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rowCount_tx.Name = "rowCount_tx";
            this.rowCount_tx.Size = new System.Drawing.Size(104, 17);
            this.rowCount_tx.TabIndex = 536;
            this.rowCount_tx.Text = "Product Count :";
            // 
            // creditTerms_tx
            // 
            this.creditTerms_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.creditTerms_tx.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.creditTerms_tx.Location = new System.Drawing.Point(185, 2);
            this.creditTerms_tx.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.creditTerms_tx.Name = "creditTerms_tx";
            this.creditTerms_tx.Size = new System.Drawing.Size(114, 27);
            this.creditTerms_tx.TabIndex = 543;
            this.creditTerms_tx.Tag = "IsNumeric";
            this.creditTerms_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.creditTerms_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.creditTerms_tx.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.creditTerms_tx.ValueChanged += new System.EventHandler(this.creditTerms_tx_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 17);
            this.label6.TabIndex = 544;
            this.label6.Text = "Credit Terms (No. Of Days) :";
            // 
            // creditTermsPanel
            // 
            this.creditTermsPanel.Controls.Add(this.creditTerms_tx);
            this.creditTermsPanel.Controls.Add(this.label6);
            this.creditTermsPanel.Location = new System.Drawing.Point(457, 698);
            this.creditTermsPanel.Name = "creditTermsPanel";
            this.creditTermsPanel.Size = new System.Drawing.Size(304, 31);
            this.creditTermsPanel.TabIndex = 545;
            // 
            // showLogs_link
            // 
            this.showLogs_link.AutoSize = true;
            this.showLogs_link.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLogs_link.Location = new System.Drawing.Point(10, 704);
            this.showLogs_link.Name = "showLogs_link";
            this.showLogs_link.Size = new System.Drawing.Size(93, 15);
            this.showLogs_link.TabIndex = 546;
            this.showLogs_link.TabStop = true;
            this.showLogs_link.Text = "View Order Logs";
            this.showLogs_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showLogs_link_LinkClicked);
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(317, 403);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(477, 45);
            this.notFound_lbl.TabIndex = 547;
            this.notFound_lbl.Text = "No Purchase Order Item Added";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.poId_tx);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dueDate_tx);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateCreated_tx);
            this.panel1.Controls.Add(this.rowCount_tx);
            this.panel1.Location = new System.Drawing.Point(10, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 43);
            this.panel1.TabIndex = 548;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 17);
            this.label12.TabIndex = 538;
            this.label12.Text = "Purchase Order No :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 17);
            this.label11.TabIndex = 537;
            this.label11.Text = "Product Count :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(806, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 531;
            this.label9.Text = "Due Date :";
            // 
            // dueDate_tx
            // 
            this.dueDate_tx.AutoSize = true;
            this.dueDate_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDate_tx.Location = new System.Drawing.Point(911, 22);
            this.dueDate_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dueDate_tx.Name = "dueDate_tx";
            this.dueDate_tx.Size = new System.Drawing.Size(13, 17);
            this.dueDate_tx.TabIndex = 532;
            this.dueDate_tx.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(806, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 529;
            this.label7.Text = "Date Create :";
            // 
            // dateCreated_tx
            // 
            this.dateCreated_tx.AutoSize = true;
            this.dateCreated_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreated_tx.Location = new System.Drawing.Point(911, 3);
            this.dateCreated_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateCreated_tx.Name = "dateCreated_tx";
            this.dateCreated_tx.Size = new System.Drawing.Size(13, 17);
            this.dateCreated_tx.TabIndex = 530;
            this.dateCreated_tx.Text = "-";
            // 
            // PurchaseOrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 743);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notFound_lbl);
            this.Controls.Add(this.showLogs_link);
            this.Controls.Add(this.creditTermsPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addProduct_btn);
            this.Controls.Add(this.undo_btn);
            this.Controls.Add(this.action_btn);
            this.Controls.Add(this.poPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search_tx);
            this.Controls.Add(this.dgPoItems);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.total_tx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseOrderDetailsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Order Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PurchaseOrderDetailsForm_FormClosed);
            this.Load += new System.EventHandler(this.PurchaseOrderDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPoItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.poPanel.ResumeLayout(false);
            this.process_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.balStat_pb)).EndInit();
            this.payment_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeStat_pb)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditTerms_tx)).EndInit();
            this.creditTermsPanel.ResumeLayout(false);
            this.creditTermsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label title_lbl;
        internal System.Windows.Forms.DataGridView dgPoItems;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox search_tx;
        private System.Windows.Forms.Panel poPanel;
        private System.Windows.Forms.Panel process_panel;
        private System.Windows.Forms.Label processStatus_tx;
        private System.Windows.Forms.PictureBox balStat_pb;
        private System.Windows.Forms.Panel payment_panel;
        private System.Windows.Forms.Label paymentStatus_tx;
        private System.Windows.Forms.PictureBox closeStat_pb;
        private System.Windows.Forms.Button action_btn;
        private System.Windows.Forms.Button undo_btn;
        private System.Windows.Forms.Label supplier_tx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label address_tx;
        private System.Windows.Forms.Label contactPerson_tx;
        private System.Windows.Forms.Label number_tx;
        private System.Windows.Forms.Button addSupplier_btn;
        private System.Windows.Forms.Button addProduct_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label poId_tx;
        private System.Windows.Forms.Label total_tx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rowCount_tx;
        public System.Windows.Forms.NumericUpDown creditTerms_tx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel creditTermsPanel;
        private System.Windows.Forms.LinkLabel showLogs_link;
        private System.Windows.Forms.Label notFound_lbl;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dueDate_tx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dateCreated_tx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}