namespace SalesPro.Forms.PaymentsAndBilling
{
    partial class UpdatePaymentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.notes_tx = new System.Windows.Forms.TextBox();
            this.orNunber_tx = new System.Windows.Forms.TextBox();
            this.reference_tx = new System.Windows.Forms.TextBox();
            this.bank_cb = new System.Windows.Forms.ComboBox();
            this.paymentMethod_cb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(11, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(154, 25);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "Update Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 599;
            this.label1.Text = "Notes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 598;
            this.label11.Text = "Or Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 597;
            this.label5.Text = "Reference Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 596;
            this.label2.Text = "Bank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 595;
            this.label4.Text = "Payment Method";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notes_tx);
            this.groupBox1.Controls.Add(this.orNunber_tx);
            this.groupBox1.Controls.Add(this.reference_tx);
            this.groupBox1.Controls.Add(this.bank_cb);
            this.groupBox1.Controls.Add(this.paymentMethod_cb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 363);
            this.groupBox1.TabIndex = 605;
            this.groupBox1.TabStop = false;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(163, 421);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(172, 34);
            this.update_btn.TabIndex = 606;
            this.update_btn.Text = "Update Payment";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // notes_tx
            // 
            this.notes_tx.BackColor = System.Drawing.Color.White;
            this.notes_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.notes_tx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_tx.Location = new System.Drawing.Point(12, 277);
            this.notes_tx.Margin = new System.Windows.Forms.Padding(2);
            this.notes_tx.Multiline = true;
            this.notes_tx.Name = "notes_tx";
            this.notes_tx.Size = new System.Drawing.Size(296, 72);
            this.notes_tx.TabIndex = 604;
            // 
            // orNunber_tx
            // 
            this.orNunber_tx.BackColor = System.Drawing.Color.White;
            this.orNunber_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.orNunber_tx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orNunber_tx.Location = new System.Drawing.Point(14, 159);
            this.orNunber_tx.Margin = new System.Windows.Forms.Padding(2);
            this.orNunber_tx.Name = "orNunber_tx";
            this.orNunber_tx.Size = new System.Drawing.Size(294, 29);
            this.orNunber_tx.TabIndex = 603;
            // 
            // reference_tx
            // 
            this.reference_tx.BackColor = System.Drawing.Color.White;
            this.reference_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.reference_tx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reference_tx.Location = new System.Drawing.Point(14, 98);
            this.reference_tx.Margin = new System.Windows.Forms.Padding(2);
            this.reference_tx.Name = "reference_tx";
            this.reference_tx.Size = new System.Drawing.Size(294, 29);
            this.reference_tx.TabIndex = 602;
            // 
            // bank_cb
            // 
            this.bank_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bank_cb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank_cb.FormattingEnabled = true;
            this.bank_cb.Items.AddRange(new object[] {
            "CASH",
            "CHECK",
            "BANK TRANSFER",
            "E-PAYMENT"});
            this.bank_cb.Location = new System.Drawing.Point(14, 219);
            this.bank_cb.Name = "bank_cb";
            this.bank_cb.Size = new System.Drawing.Size(294, 29);
            this.bank_cb.TabIndex = 601;
            // 
            // paymentMethod_cb
            // 
            this.paymentMethod_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethod_cb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethod_cb.FormattingEnabled = true;
            this.paymentMethod_cb.Location = new System.Drawing.Point(14, 36);
            this.paymentMethod_cb.Margin = new System.Windows.Forms.Padding(2);
            this.paymentMethod_cb.Name = "paymentMethod_cb";
            this.paymentMethod_cb.Size = new System.Drawing.Size(294, 29);
            this.paymentMethod_cb.TabIndex = 600;
            // 
            // UpdatePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 474);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdatePaymentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.ViewPaymentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button update_btn;
        public System.Windows.Forms.TextBox notes_tx;
        public System.Windows.Forms.TextBox orNunber_tx;
        public System.Windows.Forms.TextBox reference_tx;
        public System.Windows.Forms.ComboBox bank_cb;
        private System.Windows.Forms.ComboBox paymentMethod_cb;
    }
}