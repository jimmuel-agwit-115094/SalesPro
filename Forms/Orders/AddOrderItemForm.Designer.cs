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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrderItemForm));
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.title_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(518, 367);
            this.notFound_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(301, 45);
            this.notFound_lbl.TabIndex = 454;
            this.notFound_lbl.Text = "Product Not Found";
            // 
            // search_tx
            // 
            this.search_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.search_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tx.Location = new System.Drawing.Point(18, 60);
            this.search_tx.Margin = new System.Windows.Forms.Padding(4);
            this.search_tx.Name = "search_tx";
            this.search_tx.Size = new System.Drawing.Size(1111, 43);
            this.search_tx.TabIndex = 451;
            // 
            // dgProduct
            // 
            this.dgProduct.AllowUserToAddRows = false;
            this.dgProduct.AllowUserToDeleteRows = false;
            this.dgProduct.AllowUserToResizeColumns = false;
            this.dgProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProduct.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProduct.ColumnHeadersHeight = 40;
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgProduct.EnableHeadersVisualStyles = false;
            this.dgProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgProduct.Location = new System.Drawing.Point(18, 122);
            this.dgProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgProduct.MultiSelect = false;
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgProduct.RowHeadersVisible = false;
            this.dgProduct.RowHeadersWidth = 51;
            this.dgProduct.RowTemplate.Height = 45;
            this.dgProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProduct.Size = new System.Drawing.Size(1384, 627);
            this.dgProduct.TabIndex = 455;
            this.dgProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduct_CellContentClick);
            this.dgProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduct_CellDoubleClick);
            this.dgProduct.SelectionChanged += new System.EventHandler(this.dgProduct_SelectionChanged);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.title_lbl.Location = new System.Drawing.Point(21, 16);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(135, 25);
            this.title_lbl.TabIndex = 456;
            this.title_lbl.Text = "Select Product";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1128, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 458;
            this.pictureBox1.TabStop = false;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(1191, 60);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(211, 43);
            this.search_btn.TabIndex = 457;
            this.search_btn.Text = "Enter";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // AddOrderItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1415, 762);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.notFound_lbl);
            this.Controls.Add(this.search_tx);
            this.Controls.Add(this.dgProduct);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrderItemForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Order";
            this.Load += new System.EventHandler(this.AddOrderItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label notFound_lbl;
        private System.Windows.Forms.TextBox search_tx;
        internal System.Windows.Forms.DataGridView dgProduct;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button search_btn;
    }
}