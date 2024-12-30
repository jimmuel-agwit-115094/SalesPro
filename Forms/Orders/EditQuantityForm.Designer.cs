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
            this.title_lbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.qty_tx = new System.Windows.Forms.NumericUpDown();
            this.enter_btn = new System.Windows.Forms.Button();
            this.product_tx = new System.Windows.Forms.Label();
            this.availableQty_tx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qty_tx)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.title_lbl.Location = new System.Drawing.Point(12, 19);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(125, 25);
            this.title_lbl.TabIndex = 457;
            this.title_lbl.Text = "Edit Quantity";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(18, 114);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 52);
            this.panel5.TabIndex = 528;
            // 
            // qty_tx
            // 
            this.qty_tx.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_tx.Location = new System.Drawing.Point(17, 113);
            this.qty_tx.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.qty_tx.Name = "qty_tx";
            this.qty_tx.Size = new System.Drawing.Size(290, 54);
            this.qty_tx.TabIndex = 527;
            this.qty_tx.Tag = "IsNumeric";
            this.qty_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qty_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // enter_btn
            // 
            this.enter_btn.BackColor = System.Drawing.Color.Green;
            this.enter_btn.FlatAppearance.BorderSize = 0;
            this.enter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_btn.ForeColor = System.Drawing.Color.White;
            this.enter_btn.Location = new System.Drawing.Point(167, 201);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(140, 34);
            this.enter_btn.TabIndex = 530;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = false;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // product_tx
            // 
            this.product_tx.AutoSize = true;
            this.product_tx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_tx.Location = new System.Drawing.Point(13, 44);
            this.product_tx.Name = "product_tx";
            this.product_tx.Size = new System.Drawing.Size(100, 21);
            this.product_tx.TabIndex = 532;
            this.product_tx.Text = "Edit Quantity";
            // 
            // availableQty_tx
            // 
            this.availableQty_tx.AutoSize = true;
            this.availableQty_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableQty_tx.Location = new System.Drawing.Point(14, 66);
            this.availableQty_tx.Name = "availableQty_tx";
            this.availableQty_tx.Size = new System.Drawing.Size(95, 20);
            this.availableQty_tx.TabIndex = 533;
            this.availableQty_tx.Text = "Edit Quantity";
            // 
            // EditQuantityForm
            // 
            this.AcceptButton = this.enter_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(321, 253);
            this.Controls.Add(this.availableQty_tx);
            this.Controls.Add(this.product_tx);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.qty_tx);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditQuantityForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quantiy";
            this.Load += new System.EventHandler(this.EditQuantityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qty_tx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.NumericUpDown qty_tx;
        private System.Windows.Forms.Button enter_btn;
        internal System.Windows.Forms.Label product_tx;
        internal System.Windows.Forms.Label availableQty_tx;
    }
}