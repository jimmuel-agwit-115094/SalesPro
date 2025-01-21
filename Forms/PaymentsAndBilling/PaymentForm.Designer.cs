namespace SalesPro.Forms.PaymentsAndBilling
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paymentPhoto = new System.Windows.Forms.PictureBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.total_tx = new System.Windows.Forms.Label();
            this.pay_btn = new System.Windows.Forms.Button();
            this.paymentMethod_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orNunber_tx = new System.Windows.Forms.TextBox();
            this.reference_tx = new System.Windows.Forms.TextBox();
            this.bank_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentTitle_tx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notes_tx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paymentPhoto);
            this.groupBox1.Controls.Add(this.title_lbl);
            this.groupBox1.Controls.Add(this.total_tx);
            this.groupBox1.Location = new System.Drawing.Point(23, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 140);
            this.groupBox1.TabIndex = 581;
            this.groupBox1.TabStop = false;
            // 
            // paymentPhoto
            // 
            this.paymentPhoto.BackColor = System.Drawing.Color.White;
            this.paymentPhoto.Image = ((System.Drawing.Image)(resources.GetObject("paymentPhoto.Image")));
            this.paymentPhoto.Location = new System.Drawing.Point(126, 18);
            this.paymentPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.paymentPhoto.Name = "paymentPhoto";
            this.paymentPhoto.Size = new System.Drawing.Size(40, 40);
            this.paymentPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paymentPhoto.TabIndex = 541;
            this.paymentPhoto.TabStop = false;
            // 
            // title_lbl
            // 
            this.title_lbl.BackColor = System.Drawing.Color.White;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(1, 53);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(290, 28);
            this.title_lbl.TabIndex = 534;
            this.title_lbl.Text = "Total Amount";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total_tx
            // 
            this.total_tx.BackColor = System.Drawing.Color.White;
            this.total_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_tx.Location = new System.Drawing.Point(1, 73);
            this.total_tx.Name = "total_tx";
            this.total_tx.Size = new System.Drawing.Size(290, 57);
            this.total_tx.TabIndex = 538;
            this.total_tx.Text = "0.00";
            this.total_tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pay_btn
            // 
            this.pay_btn.BackColor = System.Drawing.Color.Green;
            this.pay_btn.FlatAppearance.BorderSize = 0;
            this.pay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.ForeColor = System.Drawing.Color.White;
            this.pay_btn.Location = new System.Drawing.Point(173, 558);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(140, 34);
            this.pay_btn.TabIndex = 564;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = false;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // paymentMethod_cb
            // 
            this.paymentMethod_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethod_cb.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.paymentMethod_cb.FormattingEnabled = true;
            this.paymentMethod_cb.Location = new System.Drawing.Point(22, 216);
            this.paymentMethod_cb.Margin = new System.Windows.Forms.Padding(2);
            this.paymentMethod_cb.Name = "paymentMethod_cb";
            this.paymentMethod_cb.Size = new System.Drawing.Size(294, 29);
            this.paymentMethod_cb.TabIndex = 573;
            this.paymentMethod_cb.SelectedIndexChanged += new System.EventHandler(this.paymentMethod_cb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 574;
            this.label4.Text = "Payment Method";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 319);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 591;
            this.label11.Text = "Or Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 587;
            this.label5.Text = "Reference Number";
            // 
            // orNunber_tx
            // 
            this.orNunber_tx.BackColor = System.Drawing.Color.White;
            this.orNunber_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.orNunber_tx.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.orNunber_tx.Location = new System.Drawing.Point(22, 339);
            this.orNunber_tx.Margin = new System.Windows.Forms.Padding(2);
            this.orNunber_tx.MaxLength = 20;
            this.orNunber_tx.Name = "orNunber_tx";
            this.orNunber_tx.Size = new System.Drawing.Size(293, 29);
            this.orNunber_tx.TabIndex = 590;
            // 
            // reference_tx
            // 
            this.reference_tx.BackColor = System.Drawing.Color.White;
            this.reference_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.reference_tx.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reference_tx.Location = new System.Drawing.Point(22, 278);
            this.reference_tx.Margin = new System.Windows.Forms.Padding(2);
            this.reference_tx.MaxLength = 20;
            this.reference_tx.Name = "reference_tx";
            this.reference_tx.Size = new System.Drawing.Size(294, 29);
            this.reference_tx.TabIndex = 586;
            // 
            // bank_cb
            // 
            this.bank_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bank_cb.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bank_cb.FormattingEnabled = true;
            this.bank_cb.Items.AddRange(new object[] {
            "CASH",
            "CHECK",
            "BANK TRANSFER",
            "E-PAYMENT"});
            this.bank_cb.Location = new System.Drawing.Point(22, 399);
            this.bank_cb.Name = "bank_cb";
            this.bank_cb.Size = new System.Drawing.Size(293, 29);
            this.bank_cb.TabIndex = 584;
            this.bank_cb.SelectedIndexChanged += new System.EventHandler(this.bank_cb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 585;
            this.label2.Text = "Bank";
            // 
            // paymentTitle_tx
            // 
            this.paymentTitle_tx.BackColor = System.Drawing.Color.White;
            this.paymentTitle_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTitle_tx.Location = new System.Drawing.Point(22, 7);
            this.paymentTitle_tx.Name = "paymentTitle_tx";
            this.paymentTitle_tx.Size = new System.Drawing.Size(292, 34);
            this.paymentTitle_tx.TabIndex = 592;
            this.paymentTitle_tx.Text = "Payment";
            this.paymentTitle_tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 438);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 594;
            this.label1.Text = "Notes";
            // 
            // notes_tx
            // 
            this.notes_tx.BackColor = System.Drawing.Color.White;
            this.notes_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.notes_tx.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_tx.Location = new System.Drawing.Point(20, 457);
            this.notes_tx.Margin = new System.Windows.Forms.Padding(2);
            this.notes_tx.MaxLength = 100;
            this.notes_tx.Multiline = true;
            this.notes_tx.Name = "notes_tx";
            this.notes_tx.Size = new System.Drawing.Size(294, 72);
            this.notes_tx.TabIndex = 593;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(336, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notes_tx);
            this.Controls.Add(this.paymentTitle_tx);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orNunber_tx);
            this.Controls.Add(this.reference_tx);
            this.Controls.Add(this.bank_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.paymentMethod_cb);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.PaymentCreditForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox paymentPhoto;
        internal System.Windows.Forms.Label title_lbl;
        internal System.Windows.Forms.Label total_tx;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.ComboBox paymentMethod_cb;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox orNunber_tx;
        public System.Windows.Forms.TextBox reference_tx;
        public System.Windows.Forms.ComboBox bank_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox notes_tx;
        internal System.Windows.Forms.Label paymentTitle_tx;
    }
}