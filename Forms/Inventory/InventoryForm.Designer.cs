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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgInventory = new System.Windows.Forms.DataGridView();
            this.activeTab = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.inventoryTabControl = new System.Windows.Forms.TabControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.outTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.allTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.productName_tx = new System.Windows.Forms.Label();
            this.supplier_tx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateAdded_tx = new System.Windows.Forms.Label();
            this.processedBy_tx = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adjustingQty_tx = new System.Windows.Forms.NumericUpDown();
            this.remakrs_tx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qtyFromPo_tx = new System.Windows.Forms.Label();
            this.qtyOnHand_tx = new System.Windows.Forms.Label();
            this.suppPrice_tx = new System.Windows.Forms.Label();
            this.retailPrice_tx = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.action_tx = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.action_cb = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            this.activeTab.SuspendLayout();
            this.inventoryTabControl.SuspendLayout();
            this.outTab.SuspendLayout();
            this.allTab.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adjustingQty_tx)).BeginInit();
            this.panel13.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
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
            this.notFound_lbl.Location = new System.Drawing.Point(321, 292);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 462;
            this.notFound_lbl.Text = "No Record";
            this.notFound_lbl.Visible = false;
            // 
            // dgInventory
            // 
            this.dgInventory.AllowUserToAddRows = false;
            this.dgInventory.AllowUserToDeleteRows = false;
            this.dgInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInventory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgInventory.ColumnHeadersHeight = 40;
            this.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInventory.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgInventory.EnableHeadersVisualStyles = false;
            this.dgInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgInventory.Location = new System.Drawing.Point(3, 53);
            this.dgInventory.MultiSelect = false;
            this.dgInventory.Name = "dgInventory";
            this.dgInventory.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgInventory.RowHeadersVisible = false;
            this.dgInventory.RowHeadersWidth = 51;
            this.dgInventory.RowTemplate.Height = 32;
            this.dgInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInventory.Size = new System.Drawing.Size(823, 603);
            this.dgInventory.TabIndex = 461;
            // 
            // activeTab
            // 
            this.activeTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activeTab.Controls.Add(this.panel6);
            this.activeTab.Location = new System.Drawing.Point(4, 29);
            this.activeTab.Name = "activeTab";
            this.activeTab.Padding = new System.Windows.Forms.Padding(3);
            this.activeTab.Size = new System.Drawing.Size(801, 4);
            this.activeTab.TabIndex = 0;
            this.activeTab.Text = "   Active Inventory   ";
            this.activeTab.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(-3, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 5);
            this.panel6.TabIndex = 5;
            // 
            // inventoryTabControl
            // 
            this.inventoryTabControl.Controls.Add(this.activeTab);
            this.inventoryTabControl.Controls.Add(this.outTab);
            this.inventoryTabControl.Controls.Add(this.allTab);
            this.inventoryTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTabControl.Location = new System.Drawing.Point(4, 10);
            this.inventoryTabControl.Name = "inventoryTabControl";
            this.inventoryTabControl.SelectedIndex = 0;
            this.inventoryTabControl.Size = new System.Drawing.Size(809, 37);
            this.inventoryTabControl.TabIndex = 439;
            this.inventoryTabControl.SelectedIndexChanged += new System.EventHandler(this.inventoryTabControl_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(152, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 5);
            this.panel7.TabIndex = 6;
            // 
            // outTab
            // 
            this.outTab.Controls.Add(this.panel7);
            this.outTab.Location = new System.Drawing.Point(4, 29);
            this.outTab.Name = "outTab";
            this.outTab.Padding = new System.Windows.Forms.Padding(3);
            this.outTab.Size = new System.Drawing.Size(788, 4);
            this.outTab.TabIndex = 1;
            this.outTab.Text = "     Out of Stock       ";
            this.outTab.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(290, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 5);
            this.panel2.TabIndex = 7;
            // 
            // allTab
            // 
            this.allTab.Controls.Add(this.panel2);
            this.allTab.Location = new System.Drawing.Point(4, 29);
            this.allTab.Name = "allTab";
            this.allTab.Padding = new System.Windows.Forms.Padding(3);
            this.allTab.Size = new System.Drawing.Size(801, 4);
            this.allTab.TabIndex = 2;
            this.allTab.Text = "     All Inventory    ";
            this.allTab.UseVisualStyleBackColor = true;
            this.allTab.Click += new System.EventHandler(this.allTab_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel13);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1208, 661);
            this.panel5.TabIndex = 463;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.notFound_lbl);
            this.panel3.Controls.Add(this.dgInventory);
            this.panel3.Controls.Add(this.inventoryTabControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 659);
            this.panel3.TabIndex = 489;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.action_cb);
            this.groupBox1.Controls.Add(this.remakrs_tx);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.action_tx);
            this.groupBox1.Controls.Add(this.adjustingQty_tx);
            this.groupBox1.Location = new System.Drawing.Point(19, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 316);
            this.groupBox1.TabIndex = 549;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 20);
            this.label8.TabIndex = 530;
            this.label8.Text = "Quantity From Purchase Order :";
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_btn.Location = new System.Drawing.Point(19, 599);
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
            this.add_btn.Location = new System.Drawing.Point(172, 599);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(140, 34);
            this.add_btn.TabIndex = 552;
            this.add_btn.Text = "Add Product";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // productName_tx
            // 
            this.productName_tx.AutoSize = true;
            this.productName_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName_tx.ForeColor = System.Drawing.Color.Black;
            this.productName_tx.Location = new System.Drawing.Point(12, 56);
            this.productName_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productName_tx.Name = "productName_tx";
            this.productName_tx.Size = new System.Drawing.Size(143, 28);
            this.productName_tx.TabIndex = 554;
            this.productName_tx.Text = "Product Name";
            // 
            // supplier_tx
            // 
            this.supplier_tx.AutoSize = true;
            this.supplier_tx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_tx.ForeColor = System.Drawing.Color.Black;
            this.supplier_tx.Location = new System.Drawing.Point(15, 84);
            this.supplier_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplier_tx.Name = "supplier_tx";
            this.supplier_tx.Size = new System.Drawing.Size(114, 21);
            this.supplier_tx.TabIndex = 555;
            this.supplier_tx.Text = "Supplier Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 114);
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
            this.label2.Location = new System.Drawing.Point(16, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 557;
            this.label2.Text = "Date Added :";
            // 
            // dateAdded_tx
            // 
            this.dateAdded_tx.AutoSize = true;
            this.dateAdded_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAdded_tx.ForeColor = System.Drawing.Color.Black;
            this.dateAdded_tx.Location = new System.Drawing.Point(112, 131);
            this.dateAdded_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateAdded_tx.Name = "dateAdded_tx";
            this.dateAdded_tx.Size = new System.Drawing.Size(87, 17);
            this.dateAdded_tx.TabIndex = 559;
            this.dateAdded_tx.Text = "Date Added :";
            // 
            // processedBy_tx
            // 
            this.processedBy_tx.AutoSize = true;
            this.processedBy_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processedBy_tx.ForeColor = System.Drawing.Color.Black;
            this.processedBy_tx.Location = new System.Drawing.Point(112, 114);
            this.processedBy_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.processedBy_tx.Name = "processedBy_tx";
            this.processedBy_tx.Size = new System.Drawing.Size(95, 17);
            this.processedBy_tx.TabIndex = 558;
            this.processedBy_tx.Text = "Processed By :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 544;
            this.label5.Text = "Quantity On Hand :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 548;
            this.label6.Text = "Supplier Price :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 551;
            this.label7.Text = "Retail Price :";
            // 
            // adjustingQty_tx
            // 
            this.adjustingQty_tx.DecimalPlaces = 2;
            this.adjustingQty_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.adjustingQty_tx.Location = new System.Drawing.Point(17, 39);
            this.adjustingQty_tx.Maximum = new decimal(new int[] {
            410065408,
            2,
            0,
            0});
            this.adjustingQty_tx.Name = "adjustingQty_tx";
            this.adjustingQty_tx.Size = new System.Drawing.Size(261, 27);
            this.adjustingQty_tx.TabIndex = 552;
            this.adjustingQty_tx.Tag = "IsNumeric";
            this.adjustingQty_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.adjustingQty_tx.ThousandsSeparator = true;
            this.adjustingQty_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // remakrs_tx
            // 
            this.remakrs_tx.BackColor = System.Drawing.Color.White;
            this.remakrs_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remakrs_tx.Location = new System.Drawing.Point(16, 218);
            this.remakrs_tx.Margin = new System.Windows.Forms.Padding(2);
            this.remakrs_tx.Multiline = true;
            this.remakrs_tx.Name = "remakrs_tx";
            this.remakrs_tx.Size = new System.Drawing.Size(262, 46);
            this.remakrs_tx.TabIndex = 554;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 196);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 555;
            this.label9.Text = "Remarks";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.groupBox2);
            this.panel13.Controls.Add(this.dateAdded_tx);
            this.panel13.Controls.Add(this.productName_tx);
            this.panel13.Controls.Add(this.processedBy_tx);
            this.panel13.Controls.Add(this.groupBox1);
            this.panel13.Controls.Add(this.label2);
            this.panel13.Controls.Add(this.add_btn);
            this.panel13.Controls.Add(this.label1);
            this.panel13.Controls.Add(this.delete_btn);
            this.panel13.Controls.Add(this.supplier_tx);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(831, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(375, 659);
            this.panel13.TabIndex = 560;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.retailPrice_tx);
            this.groupBox2.Controls.Add(this.suppPrice_tx);
            this.groupBox2.Controls.Add(this.qtyOnHand_tx);
            this.groupBox2.Controls.Add(this.qtyFromPo_tx);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(19, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 108);
            this.groupBox2.TabIndex = 560;
            this.groupBox2.TabStop = false;
            // 
            // qtyFromPo_tx
            // 
            this.qtyFromPo_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyFromPo_tx.Location = new System.Drawing.Point(216, 17);
            this.qtyFromPo_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.qtyFromPo_tx.Name = "qtyFromPo_tx";
            this.qtyFromPo_tx.Size = new System.Drawing.Size(71, 20);
            this.qtyFromPo_tx.TabIndex = 552;
            this.qtyFromPo_tx.Text = "99";
            this.qtyFromPo_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qtyOnHand_tx
            // 
            this.qtyOnHand_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyOnHand_tx.Location = new System.Drawing.Point(215, 37);
            this.qtyOnHand_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.qtyOnHand_tx.Name = "qtyOnHand_tx";
            this.qtyOnHand_tx.Size = new System.Drawing.Size(71, 20);
            this.qtyOnHand_tx.TabIndex = 553;
            this.qtyOnHand_tx.Text = "99";
            this.qtyOnHand_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // suppPrice_tx
            // 
            this.suppPrice_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppPrice_tx.Location = new System.Drawing.Point(215, 56);
            this.suppPrice_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.suppPrice_tx.Name = "suppPrice_tx";
            this.suppPrice_tx.Size = new System.Drawing.Size(71, 20);
            this.suppPrice_tx.TabIndex = 554;
            this.suppPrice_tx.Text = "99.00";
            this.suppPrice_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // retailPrice_tx
            // 
            this.retailPrice_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailPrice_tx.Location = new System.Drawing.Point(215, 77);
            this.retailPrice_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.retailPrice_tx.Name = "retailPrice_tx";
            this.retailPrice_tx.Size = new System.Drawing.Size(71, 20);
            this.retailPrice_tx.TabIndex = 555;
            this.retailPrice_tx.Text = "99.00";
            this.retailPrice_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 125);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 557;
            this.label12.Text = "Action Reason";
            // 
            // action_tx
            // 
            this.action_tx.BackColor = System.Drawing.Color.White;
            this.action_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_tx.Location = new System.Drawing.Point(17, 147);
            this.action_tx.Margin = new System.Windows.Forms.Padding(2);
            this.action_tx.Multiline = true;
            this.action_tx.Name = "action_tx";
            this.action_tx.Size = new System.Drawing.Size(262, 46);
            this.action_tx.TabIndex = 556;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 20);
            this.label13.TabIndex = 558;
            this.label13.Text = "Adjusting Quantity";
            // 
            // action_cb
            // 
            this.action_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.action_cb.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.action_cb.FormattingEnabled = true;
            this.action_cb.Location = new System.Drawing.Point(16, 93);
            this.action_cb.Name = "action_cb";
            this.action_cb.Size = new System.Drawing.Size(262, 28);
            this.action_cb.TabIndex = 559;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 71);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 20);
            this.label14.TabIndex = 560;
            this.label14.Text = "Action";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 704);
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
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            this.activeTab.ResumeLayout(false);
            this.inventoryTabControl.ResumeLayout(false);
            this.outTab.ResumeLayout(false);
            this.allTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adjustingQty_tx)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgInventory;
        private System.Windows.Forms.TabPage activeTab;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TabControl inventoryTabControl;
        private System.Windows.Forms.TabPage outTab;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabPage allTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        internal System.Windows.Forms.Label dateAdded_tx;
        internal System.Windows.Forms.Label processedBy_tx;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label productName_tx;
        internal System.Windows.Forms.Label supplier_tx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown adjustingQty_tx;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox remakrs_tx;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label retailPrice_tx;
        private System.Windows.Forms.Label suppPrice_tx;
        private System.Windows.Forms.Label qtyOnHand_tx;
        private System.Windows.Forms.Label qtyFromPo_tx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox action_tx;
        private System.Windows.Forms.ComboBox action_cb;
        private System.Windows.Forms.Label label14;
    }
}