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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.title_lbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.qty_tx = new System.Windows.Forms.NumericUpDown();
            this.supplierPrice_tx = new System.Windows.Forms.NumericUpDown();
            this.markUpPrice_tx = new System.Windows.Forms.NumericUpDown();
            this.retailPrice_tx = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierPrice_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markUpPrice_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailPrice_tx)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(378, 54);
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
            this.search_tx.Location = new System.Drawing.Point(16, 53);
            this.search_tx.Margin = new System.Windows.Forms.Padding(2);
            this.search_tx.Name = "search_tx";
            this.search_tx.Size = new System.Drawing.Size(389, 27);
            this.search_tx.TabIndex = 472;
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(141, 233);
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProducts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgProducts.ColumnHeadersHeight = 30;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProducts.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgProducts.EnableHeadersVisualStyles = false;
            this.dgProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgProducts.Location = new System.Drawing.Point(16, 97);
            this.dgProducts.MultiSelect = false;
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.ReadOnly = true;
            this.dgProducts.RowHeadersVisible = false;
            this.dgProducts.RowHeadersWidth = 51;
            this.dgProducts.RowTemplate.Height = 32;
            this.dgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducts.Size = new System.Drawing.Size(435, 372);
            this.dgProducts.TabIndex = 470;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(11, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(119, 25);
            this.title_lbl.TabIndex = 469;
            this.title_lbl.Text = "Add Product";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(17, 280);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 23);
            this.panel5.TabIndex = 545;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(17, 222);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(18, 23);
            this.panel4.TabIndex = 544;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(17, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 23);
            this.panel3.TabIndex = 543;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(17, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 23);
            this.panel2.TabIndex = 542;
            // 
            // qty_tx
            // 
            this.qty_tx.DecimalPlaces = 2;
            this.qty_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.qty_tx.Location = new System.Drawing.Point(16, 106);
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
            this.qty_tx.ThousandsSeparator = true;
            this.qty_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // supplierPrice_tx
            // 
            this.supplierPrice_tx.DecimalPlaces = 2;
            this.supplierPrice_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.supplierPrice_tx.Location = new System.Drawing.Point(16, 162);
            this.supplierPrice_tx.Maximum = new decimal(new int[] {
            410065408,
            2,
            0,
            0});
            this.supplierPrice_tx.Name = "supplierPrice_tx";
            this.supplierPrice_tx.Size = new System.Drawing.Size(261, 27);
            this.supplierPrice_tx.TabIndex = 537;
            this.supplierPrice_tx.Tag = "IsNumeric";
            this.supplierPrice_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.supplierPrice_tx.ThousandsSeparator = true;
            this.supplierPrice_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // markUpPrice_tx
            // 
            this.markUpPrice_tx.DecimalPlaces = 2;
            this.markUpPrice_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.markUpPrice_tx.Location = new System.Drawing.Point(16, 220);
            this.markUpPrice_tx.Maximum = new decimal(new int[] {
            410065408,
            2,
            0,
            0});
            this.markUpPrice_tx.Name = "markUpPrice_tx";
            this.markUpPrice_tx.Size = new System.Drawing.Size(261, 27);
            this.markUpPrice_tx.TabIndex = 538;
            this.markUpPrice_tx.Tag = "IsNumeric";
            this.markUpPrice_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.markUpPrice_tx.ThousandsSeparator = true;
            this.markUpPrice_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // retailPrice_tx
            // 
            this.retailPrice_tx.DecimalPlaces = 2;
            this.retailPrice_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.retailPrice_tx.Location = new System.Drawing.Point(16, 278);
            this.retailPrice_tx.Maximum = new decimal(new int[] {
            410065408,
            2,
            0,
            0});
            this.retailPrice_tx.Name = "retailPrice_tx";
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
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 533;
            this.label3.Text = "Retail Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 532;
            this.label2.Text = "Mark Up Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 531;
            this.label1.Text = "Supplier Price :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
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
            this.add_btn.Location = new System.Drawing.Point(618, 435);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(140, 34);
            this.add_btn.TabIndex = 529;
            this.add_btn.Text = "Add Product";
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 546;
            this.label4.Text = "Add Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 547;
            this.label5.Text = "Add Product";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.retailPrice_tx);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.markUpPrice_tx);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.supplierPrice_tx);
            this.groupBox1.Controls.Add(this.qty_tx);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(465, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 324);
            this.groupBox1.TabIndex = 548;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(17, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 23);
            this.panel1.TabIndex = 548;
            // 
            // AddPurchaseProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 486);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search_tx);
            this.Controls.Add(this.notFound_lbl);
            this.Controls.Add(this.dgProducts);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.add_btn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPurchaseProductForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Product";
            this.Load += new System.EventHandler(this.AddPurchaseProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierPrice_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markUpPrice_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailPrice_tx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox search_tx;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgProducts;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.NumericUpDown qty_tx;
        private System.Windows.Forms.NumericUpDown supplierPrice_tx;
        private System.Windows.Forms.NumericUpDown markUpPrice_tx;
        private System.Windows.Forms.NumericUpDown retailPrice_tx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add_btn;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}