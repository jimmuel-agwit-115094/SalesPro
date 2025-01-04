namespace SalesPro.Forms.Orders
{
    partial class ChargeOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChargeOrderForm));
            this.customer_tx = new System.Windows.Forms.Label();
            this.amtDue_tx = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.paymentPhoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invoice_tx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.notes_tx = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.charge_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.credTerms_tx = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credTerms_tx)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_tx
            // 
            this.customer_tx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_tx.Location = new System.Drawing.Point(28, 134);
            this.customer_tx.Name = "customer_tx";
            this.customer_tx.Size = new System.Drawing.Size(290, 19);
            this.customer_tx.TabIndex = 542;
            this.customer_tx.Text = "Generic";
            this.customer_tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amtDue_tx
            // 
            this.amtDue_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtDue_tx.Location = new System.Drawing.Point(28, 82);
            this.amtDue_tx.Name = "amtDue_tx";
            this.amtDue_tx.Size = new System.Drawing.Size(290, 57);
            this.amtDue_tx.TabIndex = 541;
            this.amtDue_tx.Text = "0.00";
            this.amtDue_tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title_lbl
            // 
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(28, 62);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(290, 28);
            this.title_lbl.TabIndex = 540;
            this.title_lbl.Text = "Total Amount";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentPhoto
            // 
            this.paymentPhoto.Image = ((System.Drawing.Image)(resources.GetObject("paymentPhoto.Image")));
            this.paymentPhoto.Location = new System.Drawing.Point(149, 4);
            this.paymentPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.paymentPhoto.Name = "paymentPhoto";
            this.paymentPhoto.Size = new System.Drawing.Size(52, 57);
            this.paymentPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paymentPhoto.TabIndex = 543;
            this.paymentPhoto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 556;
            this.label4.Text = "Credit Terms (No. of days)";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 557;
            this.label1.Text = "Date Credited :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 558;
            this.label2.Text = "Due Date :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoice_tx
            // 
            this.invoice_tx.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.invoice_tx.Location = new System.Drawing.Point(28, 335);
            this.invoice_tx.Name = "invoice_tx";
            this.invoice_tx.Size = new System.Drawing.Size(291, 36);
            this.invoice_tx.TabIndex = 560;
            this.invoice_tx.Text = "0";
            this.invoice_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 559;
            this.label3.Text = "Invoice No.";
            // 
            // notes_tx
            // 
            this.notes_tx.Location = new System.Drawing.Point(27, 408);
            this.notes_tx.Name = "notes_tx";
            this.notes_tx.Size = new System.Drawing.Size(292, 78);
            this.notes_tx.TabIndex = 561;
            this.notes_tx.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 562;
            this.label5.Text = "Notes";
            // 
            // charge_btn
            // 
            this.charge_btn.BackColor = System.Drawing.Color.Green;
            this.charge_btn.FlatAppearance.BorderSize = 0;
            this.charge_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.charge_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charge_btn.ForeColor = System.Drawing.Color.White;
            this.charge_btn.Location = new System.Drawing.Point(178, 510);
            this.charge_btn.Name = "charge_btn";
            this.charge_btn.Size = new System.Drawing.Size(140, 34);
            this.charge_btn.TabIndex = 563;
            this.charge_btn.Text = "Charge";
            this.charge_btn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 19);
            this.label6.TabIndex = 565;
            this.label6.Text = "Due Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 19);
            this.label7.TabIndex = 564;
            this.label7.Text = "Date Credited";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // credTerms_tx
            // 
            this.credTerms_tx.BackColor = System.Drawing.Color.White;
            this.credTerms_tx.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credTerms_tx.Location = new System.Drawing.Point(27, 273);
            this.credTerms_tx.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.credTerms_tx.Name = "credTerms_tx";
            this.credTerms_tx.ReadOnly = true;
            this.credTerms_tx.Size = new System.Drawing.Size(290, 36);
            this.credTerms_tx.TabIndex = 566;
            this.credTerms_tx.Tag = "IsNumeric";
            this.credTerms_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.credTerms_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // ChargeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 561);
            this.Controls.Add(this.credTerms_tx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.charge_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.notes_tx);
            this.Controls.Add(this.invoice_tx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paymentPhoto);
            this.Controls.Add(this.customer_tx);
            this.Controls.Add(this.amtDue_tx);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChargeOrderForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charge Order";
            this.Load += new System.EventHandler(this.ChargeOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credTerms_tx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label customer_tx;
        internal System.Windows.Forms.Label amtDue_tx;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.PictureBox paymentPhoto;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox invoice_tx;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox notes_tx;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button charge_btn;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        public System.Windows.Forms.NumericUpDown credTerms_tx;
    }
}