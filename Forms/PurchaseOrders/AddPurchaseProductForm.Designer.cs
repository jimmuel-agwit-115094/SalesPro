namespace SalesPro.Forms.PurchaseOrders
{
    partial class AddPurchaseProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPurchaseProductForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.retailPrice_tx = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.productName_tx = new System.Windows.Forms.Label();
            this.unitOfMeasure_tx = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.markUpPrice_tx = new System.Windows.Forms.TextBox();
            this.supplierPrice_tx = new System.Windows.Forms.TextBox();
            this.qty_tx = new System.Windows.Forms.TextBox();
            this.total_tx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.supPrice_tx = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.poPb = new System.Windows.Forms.PictureBox();
            this.prodTitel_tx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailPrice_tx)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poPb)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(378, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 473;
            this.pictureBox1.TabStop = false;
            // 
            // search_tx
            // 
            this.search_tx.BackColor = System.Drawing.Color.White;
            this.search_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tx.Location = new System.Drawing.Point(16, 43);
            this.search_tx.Margin = new System.Windows.Forms.Padding(2);
            this.search_tx.Name = "search_tx";
            this.search_tx.Size = new System.Drawing.Size(389, 27);
            this.search_tx.TabIndex = 472;
            this.search_tx.TextChanged += new System.EventHandler(this.search_tx_TextChanged);
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(123, 238);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 471;
            this.notFound_lbl.Text = "No Record";
            this.notFound_lbl.Visible = false;
            // 
            // dgProducts
            // 
            this.dgProducts.AllowUserToAddRows = false;
            this.dgProducts.AllowUserToDeleteRows = false;
            this.dgProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProducts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProducts.ColumnHeadersHeight = 30;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgProducts.EnableHeadersVisualStyles = false;
            this.dgProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgProducts.Location = new System.Drawing.Point(16, 78);
            this.dgProducts.MultiSelect = false;
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.ReadOnly = true;
            this.dgProducts.RowHeadersVisible = false;
            this.dgProducts.RowHeadersWidth = 51;
            this.dgProducts.RowTemplate.Height = 32;
            this.dgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducts.Size = new System.Drawing.Size(388, 386);
            this.dgProducts.TabIndex = 470;
            this.dgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducts_CellClick);
            this.dgProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducts_CellContentClick);
            this.dgProducts.SelectionChanged += new System.EventHandler(this.dgProducts_SelectionChanged);
            // 
            // retailPrice_tx
            // 
            this.retailPrice_tx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.retailPrice_tx.DecimalPlaces = 2;
            this.retailPrice_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.retailPrice_tx.Location = new System.Drawing.Point(16, 208);
            this.retailPrice_tx.Maximum = new decimal(new int[] {
            410065408,
            2,
            0,
            0});
            this.retailPrice_tx.Name = "retailPrice_tx";
            this.retailPrice_tx.ReadOnly = true;
            this.retailPrice_tx.Size = new System.Drawing.Size(261, 27);
            this.retailPrice_tx.TabIndex = 539;
            this.retailPrice_tx.Tag = "IsNumeric";
            this.retailPrice_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.retailPrice_tx.ThousandsSeparator = true;
            this.retailPrice_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 533;
            this.label3.Text = "Retail Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 532;
            this.label2.Text = "Mark Up Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 531;
            this.label1.Text = "Supplier Price :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 530;
            this.label8.Text = "Quantity :";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Green;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(574, 430);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(140, 34);
            this.add_btn.TabIndex = 529;
            this.add_btn.Text = "Add Product";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // productName_tx
            // 
            this.productName_tx.AutoSize = true;
            this.productName_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName_tx.ForeColor = System.Drawing.Color.Black;
            this.productName_tx.Location = new System.Drawing.Point(416, 42);
            this.productName_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productName_tx.Name = "productName_tx";
            this.productName_tx.Size = new System.Drawing.Size(119, 25);
            this.productName_tx.TabIndex = 546;
            this.productName_tx.Text = "Add Product";
            // 
            // unitOfMeasure_tx
            // 
            this.unitOfMeasure_tx.AutoSize = true;
            this.unitOfMeasure_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitOfMeasure_tx.ForeColor = System.Drawing.Color.Black;
            this.unitOfMeasure_tx.Location = new System.Drawing.Point(533, 70);
            this.unitOfMeasure_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unitOfMeasure_tx.Name = "unitOfMeasure_tx";
            this.unitOfMeasure_tx.Size = new System.Drawing.Size(39, 17);
            this.unitOfMeasure_tx.TabIndex = 547;
            this.unitOfMeasure_tx.Text = "UOM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.markUpPrice_tx);
            this.groupBox1.Controls.Add(this.supplierPrice_tx);
            this.groupBox1.Controls.Add(this.qty_tx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.retailPrice_tx);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(417, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 252);
            this.groupBox1.TabIndex = 548;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(17, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 25);
            this.panel1.TabIndex = 554;
            // 
            // markUpPrice_tx
            // 
            this.markUpPrice_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.markUpPrice_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.markUpPrice_tx.Location = new System.Drawing.Point(16, 151);
            this.markUpPrice_tx.MaxLength = 10;
            this.markUpPrice_tx.Name = "markUpPrice_tx";
            this.markUpPrice_tx.Size = new System.Drawing.Size(260, 27);
            this.markUpPrice_tx.TabIndex = 563;
            this.markUpPrice_tx.Text = "0.00";
            this.markUpPrice_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.markUpPrice_tx.Click += new System.EventHandler(this.markUpPrice_tx_Click);
            this.markUpPrice_tx.TextChanged += new System.EventHandler(this.markUpPrice_tx_TextChanged);
            // 
            // supplierPrice_tx
            // 
            this.supplierPrice_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.supplierPrice_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.supplierPrice_tx.Location = new System.Drawing.Point(16, 93);
            this.supplierPrice_tx.MaxLength = 10;
            this.supplierPrice_tx.Name = "supplierPrice_tx";
            this.supplierPrice_tx.Size = new System.Drawing.Size(260, 27);
            this.supplierPrice_tx.TabIndex = 562;
            this.supplierPrice_tx.Text = "0.00";
            this.supplierPrice_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.supplierPrice_tx.Click += new System.EventHandler(this.supplierPrice_tx_Click);
            this.supplierPrice_tx.TextChanged += new System.EventHandler(this.supplierPrice_tx_TextChanged);
            // 
            // qty_tx
            // 
            this.qty_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.qty_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.qty_tx.Location = new System.Drawing.Point(17, 37);
            this.qty_tx.MaxLength = 7;
            this.qty_tx.Name = "qty_tx";
            this.qty_tx.Size = new System.Drawing.Size(260, 27);
            this.qty_tx.TabIndex = 561;
            this.qty_tx.Text = "0";
            this.qty_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qty_tx.Click += new System.EventHandler(this.qty_tx_Click);
            this.qty_tx.TextChanged += new System.EventHandler(this.qty_tx_TextChanged);
            // 
            // total_tx
            // 
            this.total_tx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_tx.ForeColor = System.Drawing.Color.Blue;
            this.total_tx.Location = new System.Drawing.Point(430, 383);
            this.total_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_tx.Name = "total_tx";
            this.total_tx.Size = new System.Drawing.Size(280, 28);
            this.total_tx.TabIndex = 549;
            this.total_tx.Text = "0.00";
            this.total_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(669, 370);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 550;
            this.label4.Text = "Total";
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_btn.Location = new System.Drawing.Point(421, 430);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(140, 34);
            this.delete_btn.TabIndex = 551;
            this.delete_btn.Text = "Delete Product";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(418, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 552;
            this.label5.Text = "Sup. Latest Price :";
            // 
            // supPrice_tx
            // 
            this.supPrice_tx.AutoSize = true;
            this.supPrice_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supPrice_tx.ForeColor = System.Drawing.Color.Black;
            this.supPrice_tx.Location = new System.Drawing.Point(531, 87);
            this.supPrice_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supPrice_tx.Name = "supPrice_tx";
            this.supPrice_tx.Size = new System.Drawing.Size(137, 17);
            this.supPrice_tx.TabIndex = 553;
            this.supPrice_tx.Text = "Supplier Latest Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(418, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 554;
            this.label6.Text = "Unit of Measure :";
            // 
            // poPb
            // 
            this.poPb.Location = new System.Drawing.Point(16, 8);
            this.poPb.Name = "poPb";
            this.poPb.Size = new System.Drawing.Size(30, 30);
            this.poPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poPb.TabIndex = 555;
            this.poPb.TabStop = false;
            // 
            // prodTitel_tx
            // 
            this.prodTitel_tx.AutoSize = true;
            this.prodTitel_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodTitel_tx.Location = new System.Drawing.Point(48, 13);
            this.prodTitel_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prodTitel_tx.Name = "prodTitel_tx";
            this.prodTitel_tx.Size = new System.Drawing.Size(76, 20);
            this.prodTitel_tx.TabIndex = 556;
            this.prodTitel_tx.Text = "Quantity :";
            // 
            // AddPurchaseProductForm
            // 
            this.AcceptButton = this.add_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 480);
            this.Controls.Add(this.prodTitel_tx);
            this.Controls.Add(this.poPb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.supPrice_tx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.total_tx);
            this.Controls.Add(this.productName_tx);
            this.Controls.Add(this.unitOfMeasure_tx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search_tx);
            this.Controls.Add(this.notFound_lbl);
            this.Controls.Add(this.dgProducts);
            this.Controls.Add(this.add_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPurchaseProductForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.AddPurchaseProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailPrice_tx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox search_tx;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.NumericUpDown retailPrice_tx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add_btn;
        internal System.Windows.Forms.Label unitOfMeasure_tx;
        internal System.Windows.Forms.Label productName_tx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label total_tx;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete_btn;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label supPrice_tx;
        private System.Windows.Forms.TextBox qty_tx;
        private System.Windows.Forms.TextBox markUpPrice_tx;
        private System.Windows.Forms.TextBox supplierPrice_tx;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox poPb;
        private System.Windows.Forms.Label prodTitel_tx;
    }
}