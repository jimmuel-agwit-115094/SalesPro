namespace SalesPro.Forms.Inventory
{
    partial class ManageInventoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInventoryForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.processedBy_tx = new System.Windows.Forms.Label();
            this.supAddress_tx = new System.Windows.Forms.Label();
            this.supplier_tx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateAdded_tx = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgLogs = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.actionPb = new System.Windows.Forms.PictureBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.action_cb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.adjustingQty_tx = new System.Windows.Forms.NumericUpDown();
            this.reason_tx = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.qtyOnHand_tx = new System.Windows.Forms.Label();
            this.stock_lbl = new System.Windows.Forms.Label();
            this.productName_tx = new System.Windows.Forms.Label();
            this.stockPanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.qtyFromPo_txt = new System.Windows.Forms.TextBox();
            this.subQty_tx = new System.Windows.Forms.TextBox();
            this.suppPrice_txt = new System.Windows.Forms.TextBox();
            this.retailPrice_txt = new System.Windows.Forms.TextBox();
            this.subQtyMeasure_tx = new System.Windows.Forms.TextBox();
            this.fromPoMeasure_tx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustingQty_tx)).BeginInit();
            this.stockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.notFound_lbl);
            this.groupBox1.Controls.Add(this.dgLogs);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(9, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1130, 558);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.processedBy_tx);
            this.panel1.Controls.Add(this.supAddress_tx);
            this.panel1.Controls.Add(this.supplier_tx);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateAdded_tx);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(13, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 50);
            this.panel1.TabIndex = 568;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(526, 26);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 20);
            this.label15.TabIndex = 580;
            this.label15.Text = "Supplier Address :";
            // 
            // processedBy_tx
            // 
            this.processedBy_tx.AutoSize = true;
            this.processedBy_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.processedBy_tx.ForeColor = System.Drawing.Color.Black;
            this.processedBy_tx.Location = new System.Drawing.Point(120, 3);
            this.processedBy_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.processedBy_tx.Name = "processedBy_tx";
            this.processedBy_tx.Size = new System.Drawing.Size(75, 20);
            this.processedBy_tx.TabIndex = 570;
            this.processedBy_tx.Text = "Processed";
            // 
            // supAddress_tx
            // 
            this.supAddress_tx.AutoSize = true;
            this.supAddress_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.supAddress_tx.ForeColor = System.Drawing.Color.Black;
            this.supAddress_tx.Location = new System.Drawing.Point(661, 26);
            this.supAddress_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supAddress_tx.Name = "supAddress_tx";
            this.supAddress_tx.Size = new System.Drawing.Size(64, 20);
            this.supAddress_tx.TabIndex = 579;
            this.supAddress_tx.Text = "Supplier";
            // 
            // supplier_tx
            // 
            this.supplier_tx.AutoSize = true;
            this.supplier_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.supplier_tx.ForeColor = System.Drawing.Color.Black;
            this.supplier_tx.Location = new System.Drawing.Point(661, 3);
            this.supplier_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplier_tx.Name = "supplier_tx";
            this.supplier_tx.Size = new System.Drawing.Size(64, 20);
            this.supplier_tx.TabIndex = 567;
            this.supplier_tx.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 568;
            this.label1.Text = "Processed By :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 569;
            this.label2.Text = "Date Added :";
            // 
            // dateAdded_tx
            // 
            this.dateAdded_tx.AutoSize = true;
            this.dateAdded_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dateAdded_tx.ForeColor = System.Drawing.Color.Black;
            this.dateAdded_tx.Location = new System.Drawing.Point(120, 26);
            this.dateAdded_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateAdded_tx.Name = "dateAdded_tx";
            this.dateAdded_tx.Size = new System.Drawing.Size(41, 20);
            this.dateAdded_tx.TabIndex = 571;
            this.dateAdded_tx.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(526, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 574;
            this.label9.Text = "Supplier :";
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(481, 409);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 578;
            this.notFound_lbl.Text = "No Record";
            // 
            // dgLogs
            // 
            this.dgLogs.AllowUserToAddRows = false;
            this.dgLogs.AllowUserToDeleteRows = false;
            this.dgLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLogs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgLogs.ColumnHeadersHeight = 30;
            this.dgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLogs.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgLogs.EnableHeadersVisualStyles = false;
            this.dgLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgLogs.Location = new System.Drawing.Point(13, 300);
            this.dgLogs.MultiSelect = false;
            this.dgLogs.Name = "dgLogs";
            this.dgLogs.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgLogs.RowHeadersVisible = false;
            this.dgLogs.RowHeadersWidth = 51;
            this.dgLogs.RowTemplate.Height = 32;
            this.dgLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLogs.Size = new System.Drawing.Size(1112, 253);
            this.dgLogs.TabIndex = 577;
            this.dgLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLogs_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 279);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 576;
            this.label11.Text = "Inventory Logs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(14, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 575;
            this.label10.Text = "Quantity Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(510, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 573;
            this.label4.Text = "Adjustment ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.subQtyMeasure_tx);
            this.groupBox2.Controls.Add(this.fromPoMeasure_tx);
            this.groupBox2.Controls.Add(this.retailPrice_txt);
            this.groupBox2.Controls.Add(this.suppPrice_txt);
            this.groupBox2.Controls.Add(this.subQty_tx);
            this.groupBox2.Controls.Add(this.qtyFromPo_txt);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 156);
            this.groupBox2.TabIndex = 572;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label8.Location = new System.Drawing.Point(15, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 20);
            this.label8.TabIndex = 530;
            this.label8.Text = "Qty. From Purchase Order :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label7.Location = new System.Drawing.Point(110, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 551;
            this.label7.Text = "Retail Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label6.Location = new System.Drawing.Point(93, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 548;
            this.label6.Text = "Supplier Price :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.actionPb);
            this.groupBox3.Controls.Add(this.update_btn);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.action_cb);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.adjustingQty_tx);
            this.groupBox3.Controls.Add(this.reason_tx);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(508, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 156);
            this.groupBox3.TabIndex = 564;
            this.groupBox3.TabStop = false;
            // 
            // actionPb
            // 
            this.actionPb.Image = ((System.Drawing.Image)(resources.GetObject("actionPb.Image")));
            this.actionPb.Location = new System.Drawing.Point(165, 59);
            this.actionPb.Name = "actionPb";
            this.actionPb.Size = new System.Drawing.Size(22, 22);
            this.actionPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.actionPb.TabIndex = 561;
            this.actionPb.TabStop = false;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Green;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(473, 109);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(139, 34);
            this.update_btn.TabIndex = 552;
            this.update_btn.Text = "Adjust Quantity";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label14.Location = new System.Drawing.Point(89, 61);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 560;
            this.label14.Text = "Action :";
            // 
            // action_cb
            // 
            this.action_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.action_cb.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.action_cb.FormattingEnabled = true;
            this.action_cb.Location = new System.Drawing.Point(189, 56);
            this.action_cb.Name = "action_cb";
            this.action_cb.Size = new System.Drawing.Size(278, 28);
            this.action_cb.TabIndex = 559;
            this.action_cb.SelectedIndexChanged += new System.EventHandler(this.action_cb_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label13.Location = new System.Drawing.Point(9, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 20);
            this.label13.TabIndex = 558;
            this.label13.Text = "Adjusting Quantity :";
            // 
            // adjustingQty_tx
            // 
            this.adjustingQty_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.adjustingQty_tx.Location = new System.Drawing.Point(160, 19);
            this.adjustingQty_tx.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.adjustingQty_tx.Name = "adjustingQty_tx";
            this.adjustingQty_tx.Size = new System.Drawing.Size(307, 27);
            this.adjustingQty_tx.TabIndex = 552;
            this.adjustingQty_tx.Tag = "IsNumeric";
            this.adjustingQty_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.adjustingQty_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // reason_tx
            // 
            this.reason_tx.BackColor = System.Drawing.Color.White;
            this.reason_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reason_tx.Location = new System.Drawing.Point(161, 93);
            this.reason_tx.Margin = new System.Windows.Forms.Padding(2);
            this.reason_tx.Multiline = true;
            this.reason_tx.Name = "reason_tx";
            this.reason_tx.Size = new System.Drawing.Size(306, 50);
            this.reason_tx.TabIndex = 556;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label12.Location = new System.Drawing.Point(36, 97);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 20);
            this.label12.TabIndex = 557;
            this.label12.Text = "Action Reason :";
            // 
            // qtyOnHand_tx
            // 
            this.qtyOnHand_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyOnHand_tx.Location = new System.Drawing.Point(5, 8);
            this.qtyOnHand_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.qtyOnHand_tx.Name = "qtyOnHand_tx";
            this.qtyOnHand_tx.Size = new System.Drawing.Size(252, 39);
            this.qtyOnHand_tx.TabIndex = 565;
            this.qtyOnHand_tx.Text = "0";
            this.qtyOnHand_tx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stock_lbl
            // 
            this.stock_lbl.AutoSize = true;
            this.stock_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_lbl.Location = new System.Drawing.Point(808, 22);
            this.stock_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stock_lbl.Name = "stock_lbl";
            this.stock_lbl.Size = new System.Drawing.Size(54, 20);
            this.stock_lbl.TabIndex = 563;
            this.stock_lbl.Text = "Stock :";
            // 
            // productName_tx
            // 
            this.productName_tx.AutoSize = true;
            this.productName_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName_tx.ForeColor = System.Drawing.Color.Black;
            this.productName_tx.Location = new System.Drawing.Point(9, 15);
            this.productName_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productName_tx.Name = "productName_tx";
            this.productName_tx.Size = new System.Drawing.Size(143, 28);
            this.productName_tx.TabIndex = 566;
            this.productName_tx.Text = "Product Name";
            // 
            // stockPanel
            // 
            this.stockPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.stockPanel.Controls.Add(this.qtyOnHand_tx);
            this.stockPanel.Location = new System.Drawing.Point(878, 2);
            this.stockPanel.Name = "stockPanel";
            this.stockPanel.Size = new System.Drawing.Size(261, 57);
            this.stockPanel.TabIndex = 568;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label17.Location = new System.Drawing.Point(99, 54);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 20);
            this.label17.TabIndex = 556;
            this.label17.Text = "Sub Quantity :";
            // 
            // qtyFromPo_txt
            // 
            this.qtyFromPo_txt.BackColor = System.Drawing.Color.White;
            this.qtyFromPo_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.qtyFromPo_txt.Location = new System.Drawing.Point(203, 17);
            this.qtyFromPo_txt.MaxLength = 8;
            this.qtyFromPo_txt.Name = "qtyFromPo_txt";
            this.qtyFromPo_txt.ReadOnly = true;
            this.qtyFromPo_txt.Size = new System.Drawing.Size(134, 27);
            this.qtyFromPo_txt.TabIndex = 559;
            this.qtyFromPo_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subQty_tx
            // 
            this.subQty_tx.BackColor = System.Drawing.Color.White;
            this.subQty_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.subQty_tx.Location = new System.Drawing.Point(203, 50);
            this.subQty_tx.MaxLength = 8;
            this.subQty_tx.Name = "subQty_tx";
            this.subQty_tx.ReadOnly = true;
            this.subQty_tx.Size = new System.Drawing.Size(134, 27);
            this.subQty_tx.TabIndex = 560;
            this.subQty_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // suppPrice_txt
            // 
            this.suppPrice_txt.BackColor = System.Drawing.Color.White;
            this.suppPrice_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.suppPrice_txt.Location = new System.Drawing.Point(203, 83);
            this.suppPrice_txt.MaxLength = 8;
            this.suppPrice_txt.Name = "suppPrice_txt";
            this.suppPrice_txt.ReadOnly = true;
            this.suppPrice_txt.Size = new System.Drawing.Size(249, 27);
            this.suppPrice_txt.TabIndex = 561;
            this.suppPrice_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // retailPrice_txt
            // 
            this.retailPrice_txt.BackColor = System.Drawing.Color.White;
            this.retailPrice_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.retailPrice_txt.Location = new System.Drawing.Point(203, 116);
            this.retailPrice_txt.MaxLength = 8;
            this.retailPrice_txt.Name = "retailPrice_txt";
            this.retailPrice_txt.ReadOnly = true;
            this.retailPrice_txt.Size = new System.Drawing.Size(249, 27);
            this.retailPrice_txt.TabIndex = 562;
            this.retailPrice_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subQtyMeasure_tx
            // 
            this.subQtyMeasure_tx.BackColor = System.Drawing.Color.White;
            this.subQtyMeasure_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.subQtyMeasure_tx.Location = new System.Drawing.Point(343, 50);
            this.subQtyMeasure_tx.MaxLength = 8;
            this.subQtyMeasure_tx.Name = "subQtyMeasure_tx";
            this.subQtyMeasure_tx.ReadOnly = true;
            this.subQtyMeasure_tx.Size = new System.Drawing.Size(109, 27);
            this.subQtyMeasure_tx.TabIndex = 566;
            // 
            // fromPoMeasure_tx
            // 
            this.fromPoMeasure_tx.BackColor = System.Drawing.Color.White;
            this.fromPoMeasure_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.fromPoMeasure_tx.Location = new System.Drawing.Point(343, 17);
            this.fromPoMeasure_tx.MaxLength = 8;
            this.fromPoMeasure_tx.Name = "fromPoMeasure_tx";
            this.fromPoMeasure_tx.ReadOnly = true;
            this.fromPoMeasure_tx.Size = new System.Drawing.Size(109, 27);
            this.fromPoMeasure_tx.TabIndex = 565;
            // 
            // ManageInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1151, 625);
            this.Controls.Add(this.stockPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stock_lbl);
            this.Controls.Add(this.productName_tx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageInventoryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Inventory";
            this.Load += new System.EventHandler(this.ManageInventoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustingQty_tx)).EndInit();
            this.stockPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label qtyOnHand_tx;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label stock_lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label dateAdded_tx;
        internal System.Windows.Forms.Label productName_tx;
        internal System.Windows.Forms.Label processedBy_tx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox action_cb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox reason_tx;
        private System.Windows.Forms.NumericUpDown adjustingQty_tx;
        private System.Windows.Forms.Button update_btn;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label supplier_tx;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgLogs;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label supAddress_tx;
        private System.Windows.Forms.PictureBox actionPb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel stockPanel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox qtyFromPo_txt;
        private System.Windows.Forms.TextBox retailPrice_txt;
        private System.Windows.Forms.TextBox suppPrice_txt;
        private System.Windows.Forms.TextBox subQty_tx;
        private System.Windows.Forms.TextBox subQtyMeasure_tx;
        private System.Windows.Forms.TextBox fromPoMeasure_tx;
    }
}