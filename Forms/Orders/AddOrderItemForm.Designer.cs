namespace SalesPro.Forms.Orders
{
    partial class AddOrderItemForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrderItemForm));
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.title_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.return_pb = new System.Windows.Forms.PictureBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.searchByCode_cb = new System.Windows.Forms.CheckBox();
            this.showOutOfStock_cb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(395, 362);
            this.notFound_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(301, 45);
            this.notFound_lbl.TabIndex = 454;
            this.notFound_lbl.Text = "Product Not Found";
            // 
            // search_tx
            // 
            this.search_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.search_tx.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tx.Location = new System.Drawing.Point(13, 61);
            this.search_tx.Margin = new System.Windows.Forms.Padding(4);
            this.search_tx.Name = "search_tx";
            this.search_tx.Size = new System.Drawing.Size(916, 43);
            this.search_tx.TabIndex = 451;
            this.search_tx.TextChanged += new System.EventHandler(this.search_tx_TextChanged);
            this.search_tx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_tx_KeyDown);
            // 
            // dgProduct
            // 
            this.dgProduct.AllowUserToAddRows = false;
            this.dgProduct.AllowUserToDeleteRows = false;
            this.dgProduct.AllowUserToResizeColumns = false;
            this.dgProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProduct.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgProduct.ColumnHeadersHeight = 40;
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProduct.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgProduct.EnableHeadersVisualStyles = false;
            this.dgProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgProduct.Location = new System.Drawing.Point(15, 111);
            this.dgProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgProduct.MultiSelect = false;
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgProduct.RowHeadersVisible = false;
            this.dgProduct.RowHeadersWidth = 51;
            this.dgProduct.RowTemplate.Height = 45;
            this.dgProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProduct.Size = new System.Drawing.Size(1101, 557);
            this.dgProduct.TabIndex = 455;
            this.dgProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduct_CellContentClick);
            this.dgProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduct_CellDoubleClick);
            this.dgProduct.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgProduct_CellFormatting);
            this.dgProduct.SelectionChanged += new System.EventHandler(this.dgProduct_SelectionChanged);
            this.dgProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgProduct_KeyDown);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(12, 13);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(143, 32);
            this.title_lbl.TabIndex = 456;
            this.title_lbl.Text = "Return item";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(928, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 458;
            this.pictureBox1.TabStop = false;
            // 
            // return_pb
            // 
            this.return_pb.Image = ((System.Drawing.Image)(resources.GetObject("return_pb.Image")));
            this.return_pb.Location = new System.Drawing.Point(163, 15);
            this.return_pb.Name = "return_pb";
            this.return_pb.Size = new System.Drawing.Size(33, 33);
            this.return_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.return_pb.TabIndex = 459;
            this.return_pb.TabStop = false;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(976, 61);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(140, 43);
            this.search_btn.TabIndex = 460;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // searchByCode_cb
            // 
            this.searchByCode_cb.AutoSize = true;
            this.searchByCode_cb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByCode_cb.Location = new System.Drawing.Point(778, 22);
            this.searchByCode_cb.Margin = new System.Windows.Forms.Padding(2);
            this.searchByCode_cb.Name = "searchByCode_cb";
            this.searchByCode_cb.Size = new System.Drawing.Size(151, 24);
            this.searchByCode_cb.TabIndex = 461;
            this.searchByCode_cb.Text = "Search By Barcode";
            this.searchByCode_cb.UseVisualStyleBackColor = true;
            this.searchByCode_cb.CheckedChanged += new System.EventHandler(this.searchByCode_cb_CheckedChanged);
            // 
            // showOutOfStock_cb
            // 
            this.showOutOfStock_cb.AutoSize = true;
            this.showOutOfStock_cb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showOutOfStock_cb.Location = new System.Drawing.Point(958, 22);
            this.showOutOfStock_cb.Margin = new System.Windows.Forms.Padding(2);
            this.showOutOfStock_cb.Name = "showOutOfStock_cb";
            this.showOutOfStock_cb.Size = new System.Drawing.Size(152, 24);
            this.showOutOfStock_cb.TabIndex = 462;
            this.showOutOfStock_cb.Text = "Show Out Of Stock";
            this.showOutOfStock_cb.UseVisualStyleBackColor = true;
            this.showOutOfStock_cb.CheckedChanged += new System.EventHandler(this.showOutOfStock_cb_CheckedChanged);
            // 
            // AddOrderItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 681);
            this.Controls.Add(this.showOutOfStock_cb);
            this.Controls.Add(this.searchByCode_cb);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.return_pb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.notFound_lbl);
            this.Controls.Add(this.search_tx);
            this.Controls.Add(this.dgProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrderItemForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddOrderItemForm_FormClosed);
            this.Load += new System.EventHandler(this.AddOrderItemForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddOrderItemForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label notFound_lbl;
        private System.Windows.Forms.TextBox search_tx;
        internal System.Windows.Forms.DataGridView dgProduct;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox return_pb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.CheckBox searchByCode_cb;
        private System.Windows.Forms.CheckBox showOutOfStock_cb;
    }
}