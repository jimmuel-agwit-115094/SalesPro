namespace SalesPro.Forms.Orders
{
    partial class EditQuantityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditQuantityForm));
            this.title_lbl = new System.Windows.Forms.Label();
            this.enter_btn = new System.Windows.Forms.Button();
            this.product_tx = new System.Windows.Forms.Label();
            this.availableQty_tx = new System.Windows.Forms.Label();
            this.qty_tx = new System.Windows.Forms.TextBox();
            this.return_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.return_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(17, 88);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(111, 20);
            this.title_lbl.TabIndex = 457;
            this.title_lbl.Text = "New Quantity :";
            // 
            // enter_btn
            // 
            this.enter_btn.BackColor = System.Drawing.Color.Green;
            this.enter_btn.FlatAppearance.BorderSize = 0;
            this.enter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_btn.ForeColor = System.Drawing.Color.White;
            this.enter_btn.Location = new System.Drawing.Point(143, 193);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(164, 41);
            this.enter_btn.TabIndex = 530;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = false;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // product_tx
            // 
            this.product_tx.AutoSize = true;
            this.product_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_tx.Location = new System.Drawing.Point(14, 12);
            this.product_tx.Name = "product_tx";
            this.product_tx.Size = new System.Drawing.Size(139, 30);
            this.product_tx.TabIndex = 532;
            this.product_tx.Text = "Edit Quantity";
            // 
            // availableQty_tx
            // 
            this.availableQty_tx.AutoSize = true;
            this.availableQty_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableQty_tx.Location = new System.Drawing.Point(16, 40);
            this.availableQty_tx.Name = "availableQty_tx";
            this.availableQty_tx.Size = new System.Drawing.Size(98, 20);
            this.availableQty_tx.TabIndex = 533;
            this.availableQty_tx.Text = "Edit Quantity";
            // 
            // qty_tx
            // 
            this.qty_tx.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_tx.Location = new System.Drawing.Point(19, 111);
            this.qty_tx.MaxLength = 7;
            this.qty_tx.Name = "qty_tx";
            this.qty_tx.Size = new System.Drawing.Size(288, 50);
            this.qty_tx.TabIndex = 557;
            this.qty_tx.Text = "0";
            this.qty_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qty_tx.TextChanged += new System.EventHandler(this.qty_tx_TextChanged);
            // 
            // return_pb
            // 
            this.return_pb.Image = ((System.Drawing.Image)(resources.GetObject("return_pb.Image")));
            this.return_pb.Location = new System.Drawing.Point(266, 13);
            this.return_pb.Name = "return_pb";
            this.return_pb.Size = new System.Drawing.Size(40, 40);
            this.return_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.return_pb.TabIndex = 558;
            this.return_pb.TabStop = false;
            // 
            // EditQuantityForm
            // 
            this.AcceptButton = this.enter_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 249);
            this.Controls.Add(this.return_pb);
            this.Controls.Add(this.qty_tx);
            this.Controls.Add(this.availableQty_tx);
            this.Controls.Add(this.product_tx);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditQuantityForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Quantity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditQuantityForm_FormClosing);
            this.Load += new System.EventHandler(this.EditQuantityForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditQuantityForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.return_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button enter_btn;
        internal System.Windows.Forms.Label product_tx;
        internal System.Windows.Forms.Label availableQty_tx;
        private System.Windows.Forms.TextBox qty_tx;
        private System.Windows.Forms.PictureBox return_pb;
    }
}