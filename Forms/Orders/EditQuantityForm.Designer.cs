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
            this.vatRate_tx = new System.Windows.Forms.NumericUpDown();
            this.enter_btn = new System.Windows.Forms.Button();
            this.available_tx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vatRate_tx)).BeginInit();
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
            this.panel5.Location = new System.Drawing.Point(18, 88);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 52);
            this.panel5.TabIndex = 528;
            // 
            // vatRate_tx
            // 
            this.vatRate_tx.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatRate_tx.Location = new System.Drawing.Point(17, 87);
            this.vatRate_tx.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.vatRate_tx.Name = "vatRate_tx";
            this.vatRate_tx.Size = new System.Drawing.Size(290, 54);
            this.vatRate_tx.TabIndex = 527;
            this.vatRate_tx.Tag = "IsNumeric";
            this.vatRate_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vatRate_tx.ThousandsSeparator = true;
            this.vatRate_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // enter_btn
            // 
            this.enter_btn.BackColor = System.Drawing.Color.Green;
            this.enter_btn.FlatAppearance.BorderSize = 0;
            this.enter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_btn.ForeColor = System.Drawing.Color.White;
            this.enter_btn.Location = new System.Drawing.Point(167, 175);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(140, 34);
            this.enter_btn.TabIndex = 530;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = false;
            // 
            // available_tx
            // 
            this.available_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.available_tx.Location = new System.Drawing.Point(184, 20);
            this.available_tx.Name = "available_tx";
            this.available_tx.Size = new System.Drawing.Size(125, 25);
            this.available_tx.TabIndex = 531;
            this.available_tx.Text = "00";
            this.available_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditQuantityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(321, 231);
            this.Controls.Add(this.available_tx);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.vatRate_tx);
            this.Controls.Add(this.title_lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditQuantityForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quantiy";
            ((System.ComponentModel.ISupportInitialize)(this.vatRate_tx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.NumericUpDown vatRate_tx;
        private System.Windows.Forms.Button enter_btn;
        internal System.Windows.Forms.Label available_tx;
    }
}