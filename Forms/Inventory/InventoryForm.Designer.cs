namespace SalesPro.Forms.Inventory
{
    partial class InventoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgPo = new System.Windows.Forms.DataGridView();
            this.all_tab = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.inventoryTabControl = new System.Windows.Forms.TabControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.sent_tab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.qty_tx = new System.Windows.Forms.NumericUpDown();
            this.panel10 = new System.Windows.Forms.Panel();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.productName_tx = new System.Windows.Forms.Label();
            this.unitOfMeasure_tx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.markUpPrice_tx = new System.Windows.Forms.NumericUpDown();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPo)).BeginInit();
            this.all_tab.SuspendLayout();
            this.inventoryTabControl.SuspendLayout();
            this.sent_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qty_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markUpPrice_tx)).BeginInit();
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
            this.Panel1.Size = new System.Drawing.Size(1208, 43);
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
            this.title_lbl.Size = new System.Drawing.Size(96, 25);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Inventory";
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(298, 266);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 462;
            this.notFound_lbl.Text = "No Record";
            this.notFound_lbl.Visible = false;
            // 
            // dgPo
            // 
            this.dgPo.AllowUserToAddRows = false;
            this.dgPo.AllowUserToDeleteRows = false;
            this.dgPo.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgPo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgPo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgPo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgPo.ColumnHeadersHeight = 30;
            this.dgPo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPo.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgPo.EnableHeadersVisualStyles = false;
            this.dgPo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgPo.Location = new System.Drawing.Point(3, 69);
            this.dgPo.MultiSelect = false;
            this.dgPo.Name = "dgPo";
            this.dgPo.ReadOnly = true;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPo.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgPo.RowHeadersVisible = false;
            this.dgPo.RowHeadersWidth = 51;
            this.dgPo.RowTemplate.Height = 32;
            this.dgPo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPo.Size = new System.Drawing.Size(797, 472);
            this.dgPo.TabIndex = 461;
            // 
            // all_tab
            // 
            this.all_tab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.all_tab.Controls.Add(this.panel6);
            this.all_tab.Location = new System.Drawing.Point(4, 29);
            this.all_tab.Name = "all_tab";
            this.all_tab.Padding = new System.Windows.Forms.Padding(3);
            this.all_tab.Size = new System.Drawing.Size(589, 20);
            this.all_tab.TabIndex = 0;
            this.all_tab.Text = "     All Inventory     ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(-1, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 5);
            this.panel6.TabIndex = 5;
            // 
            // inventoryTabControl
            // 
            this.inventoryTabControl.Controls.Add(this.all_tab);
            this.inventoryTabControl.Controls.Add(this.sent_tab);
            this.inventoryTabControl.Controls.Add(this.tabPage1);
            this.inventoryTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTabControl.Location = new System.Drawing.Point(4, 10);
            this.inventoryTabControl.Name = "inventoryTabControl";
            this.inventoryTabControl.SelectedIndex = 0;
            this.inventoryTabControl.Size = new System.Drawing.Size(597, 53);
            this.inventoryTabControl.TabIndex = 439;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(152, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 5);
            this.panel7.TabIndex = 6;
            // 
            // sent_tab
            // 
            this.sent_tab.Controls.Add(this.panel7);
            this.sent_tab.Location = new System.Drawing.Point(4, 29);
            this.sent_tab.Name = "sent_tab";
            this.sent_tab.Padding = new System.Windows.Forms.Padding(3);
            this.sent_tab.Size = new System.Drawing.Size(589, 20);
            this.sent_tab.TabIndex = 1;
            this.sent_tab.Text = "   Low Produc";
            this.sent_tab.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(295, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 5);
            this.panel2.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1200, 5);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "       Completed       ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.productName_tx);
            this.panel5.Controls.Add(this.unitOfMeasure_tx);
            this.panel5.Controls.Add(this.delete_btn);
            this.panel5.Controls.Add(this.add_btn);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1208, 566);
            this.panel5.TabIndex = 463;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.notFound_lbl);
            this.panel3.Controls.Add(this.dgPo);
            this.panel3.Controls.Add(this.inventoryTabControl);
            this.panel3.Location = new System.Drawing.Point(11, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 544);
            this.panel3.TabIndex = 489;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel11);
            this.groupBox1.Controls.Add(this.markUpPrice_tx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.qty_tx);
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Location = new System.Drawing.Point(853, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 252);
            this.groupBox1.TabIndex = 549;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 20);
            this.label8.TabIndex = 530;
            this.label8.Text = "Quantity From Purchase Order";
            // 
            // qty_tx
            // 
            this.qty_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.qty_tx.Location = new System.Drawing.Point(15, 36);
            this.qty_tx.Maximum = new decimal(new int[] {
            410065408,
            2,
            0,
            0});
            this.qty_tx.Name = "qty_tx";
            this.qty_tx.Size = new System.Drawing.Size(261, 27);
            this.qty_tx.TabIndex = 536;
            this.qty_tx.Tag = "IsNumeric";
            this.qty_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qty_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(16, 38);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(18, 23);
            this.panel10.TabIndex = 542;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_btn.Location = new System.Drawing.Point(853, 466);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(140, 34);
            this.delete_btn.TabIndex = 553;
            this.delete_btn.Text = "Delete Product";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Green;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(1006, 466);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(140, 34);
            this.add_btn.TabIndex = 552;
            this.add_btn.Text = "Add Product";
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(17, 38);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(18, 23);
            this.panel9.TabIndex = 543;
            // 
            // productName_tx
            // 
            this.productName_tx.AutoSize = true;
            this.productName_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName_tx.ForeColor = System.Drawing.Color.Black;
            this.productName_tx.Location = new System.Drawing.Point(848, 78);
            this.productName_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productName_tx.Name = "productName_tx";
            this.productName_tx.Size = new System.Drawing.Size(143, 28);
            this.productName_tx.TabIndex = 554;
            this.productName_tx.Text = "Product Name";
            // 
            // unitOfMeasure_tx
            // 
            this.unitOfMeasure_tx.AutoSize = true;
            this.unitOfMeasure_tx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitOfMeasure_tx.ForeColor = System.Drawing.Color.Black;
            this.unitOfMeasure_tx.Location = new System.Drawing.Point(851, 106);
            this.unitOfMeasure_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unitOfMeasure_tx.Name = "unitOfMeasure_tx";
            this.unitOfMeasure_tx.Size = new System.Drawing.Size(114, 21);
            this.unitOfMeasure_tx.TabIndex = 555;
            this.unitOfMeasure_tx.Text = "Supplier Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(852, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 556;
            this.label1.Text = "Processed By :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(852, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 557;
            this.label2.Text = "Date Added :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(948, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 559;
            this.label3.Text = "Date Added :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(948, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 558;
            this.label4.Text = "Processed By :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 544;
            this.label5.Text = "Quantity On Hand";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(19, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(18, 23);
            this.panel4.TabIndex = 547;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.numericUpDown1.Location = new System.Drawing.Point(17, 99);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            410065408,
            2,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(261, 27);
            this.numericUpDown1.TabIndex = 545;
            this.numericUpDown1.Tag = "IsNumeric";
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(18, 101);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(18, 23);
            this.panel8.TabIndex = 546;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 548;
            this.label6.Text = "Mark Up Price :";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(19, 157);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(18, 23);
            this.panel11.TabIndex = 550;
            // 
            // markUpPrice_tx
            // 
            this.markUpPrice_tx.DecimalPlaces = 2;
            this.markUpPrice_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.markUpPrice_tx.Location = new System.Drawing.Point(18, 155);
            this.markUpPrice_tx.Maximum = new decimal(new int[] {
            410065408,
            2,
            0,
            0});
            this.markUpPrice_tx.Name = "markUpPrice_tx";
            this.markUpPrice_tx.Size = new System.Drawing.Size(261, 27);
            this.markUpPrice_tx.TabIndex = 549;
            this.markUpPrice_tx.Tag = "IsNumeric";
            this.markUpPrice_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.markUpPrice_tx.ThousandsSeparator = true;
            this.markUpPrice_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 609);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPo)).EndInit();
            this.all_tab.ResumeLayout(false);
            this.inventoryTabControl.ResumeLayout(false);
            this.sent_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qty_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markUpPrice_tx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgPo;
        private System.Windows.Forms.TabPage all_tab;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TabControl inventoryTabControl;
        private System.Windows.Forms.TabPage sent_tab;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown qty_tx;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel panel9;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label productName_tx;
        internal System.Windows.Forms.Label unitOfMeasure_tx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.NumericUpDown markUpPrice_tx;
    }
}