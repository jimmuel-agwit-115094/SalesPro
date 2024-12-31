namespace SalesPro.Forms.Orders
{
    partial class PayForm
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
            this.availableQty_tx = new System.Windows.Forms.Label();
            this.product_tx = new System.Windows.Forms.Label();
            this.pay_btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cash_tx = new System.Windows.Forms.NumericUpDown();
            this.title_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cash_tx)).BeginInit();
            this.SuspendLayout();
            // 
            // availableQty_tx
            // 
            this.availableQty_tx.AutoSize = true;
            this.availableQty_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableQty_tx.Location = new System.Drawing.Point(26, 95);
            this.availableQty_tx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.availableQty_tx.Name = "availableQty_tx";
            this.availableQty_tx.Size = new System.Drawing.Size(110, 23);
            this.availableQty_tx.TabIndex = 539;
            this.availableQty_tx.Text = "Edit Quantity";
            // 
            // product_tx
            // 
            this.product_tx.AutoSize = true;
            this.product_tx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_tx.Location = new System.Drawing.Point(24, 68);
            this.product_tx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.product_tx.Name = "product_tx";
            this.product_tx.Size = new System.Drawing.Size(127, 28);
            this.product_tx.TabIndex = 538;
            this.product_tx.Text = "Edit Quantity";
            // 
            // pay_btn
            // 
            this.pay_btn.BackColor = System.Drawing.Color.Green;
            this.pay_btn.FlatAppearance.BorderSize = 0;
            this.pay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.ForeColor = System.Drawing.Color.White;
            this.pay_btn.Location = new System.Drawing.Point(230, 281);
            this.pay_btn.Margin = new System.Windows.Forms.Padding(4);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(187, 42);
            this.pay_btn.TabIndex = 537;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(31, 153);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 63);
            this.panel5.TabIndex = 536;
            // 
            // cash_tx
            // 
            this.cash_tx.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_tx.Location = new System.Drawing.Point(30, 150);
            this.cash_tx.Margin = new System.Windows.Forms.Padding(4);
            this.cash_tx.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cash_tx.Name = "cash_tx";
            this.cash_tx.Size = new System.Drawing.Size(387, 66);
            this.cash_tx.TabIndex = 535;
            this.cash_tx.Tag = "IsNumeric";
            this.cash_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cash_tx.ThousandsSeparator = true;
            this.cash_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.title_lbl.Location = new System.Drawing.Point(23, 22);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(147, 32);
            this.title_lbl.TabIndex = 534;
            this.title_lbl.Text = "Pay Amount";
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 345);
            this.Controls.Add(this.availableQty_tx);
            this.Controls.Add(this.product_tx);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.cash_tx);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PayForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayForm";
            ((System.ComponentModel.ISupportInitialize)(this.cash_tx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label availableQty_tx;
        internal System.Windows.Forms.Label product_tx;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.NumericUpDown cash_tx;
        internal System.Windows.Forms.Label title_lbl;
    }
}