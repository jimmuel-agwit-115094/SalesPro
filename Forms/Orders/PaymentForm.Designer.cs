namespace SalesPro.Forms.Orders
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
            this.customer_tx = new System.Windows.Forms.Label();
            this.pay_btn = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            this.product_tx = new System.Windows.Forms.Label();
            this.paymentPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discountAmount_lbl = new System.Windows.Forms.Label();
            this.paymentMethod_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cash_tx = new System.Windows.Forms.TextBox();
            this.discRate_tx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalAmountDue_tx = new System.Windows.Forms.Label();
            this.total_tx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.change_tx = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reference_tx = new System.Windows.Forms.TextBox();
            this.bank_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_tx
            // 
            this.customer_tx.AutoSize = true;
            this.customer_tx.BackColor = System.Drawing.Color.White;
            this.customer_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.customer_tx.Location = new System.Drawing.Point(23, 18);
            this.customer_tx.Name = "customer_tx";
            this.customer_tx.Size = new System.Drawing.Size(66, 21);
            this.customer_tx.TabIndex = 539;
            this.customer_tx.Text = "Generic";
            this.customer_tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pay_btn
            // 
            this.pay_btn.BackColor = System.Drawing.Color.Green;
            this.pay_btn.FlatAppearance.BorderSize = 0;
            this.pay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.ForeColor = System.Drawing.Color.White;
            this.pay_btn.Location = new System.Drawing.Point(424, 462);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(388, 55);
            this.pay_btn.TabIndex = 537;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = false;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.Color.White;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.title_lbl.Location = new System.Drawing.Point(23, 49);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(116, 21);
            this.title_lbl.TabIndex = 534;
            this.title_lbl.Text = "Total Amount :";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product_tx
            // 
            this.product_tx.AutoSize = true;
            this.product_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_tx.Location = new System.Drawing.Point(18, 237);
            this.product_tx.Name = "product_tx";
            this.product_tx.Size = new System.Drawing.Size(117, 21);
            this.product_tx.TabIndex = 540;
            this.product_tx.Text = "Cash Tendered";
            // 
            // paymentPhoto
            // 
            this.paymentPhoto.BackColor = System.Drawing.Color.White;
            this.paymentPhoto.Image = ((System.Drawing.Image)(resources.GetObject("paymentPhoto.Image")));
            this.paymentPhoto.Location = new System.Drawing.Point(16, 11);
            this.paymentPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.paymentPhoto.Name = "paymentPhoto";
            this.paymentPhoto.Size = new System.Drawing.Size(40, 40);
            this.paymentPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paymentPhoto.TabIndex = 541;
            this.paymentPhoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 544;
            this.label1.Text = "Discount Rate (%)";
            // 
            // discountAmount_lbl
            // 
            this.discountAmount_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountAmount_lbl.Location = new System.Drawing.Point(191, 71);
            this.discountAmount_lbl.Name = "discountAmount_lbl";
            this.discountAmount_lbl.Size = new System.Drawing.Size(173, 26);
            this.discountAmount_lbl.TabIndex = 547;
            this.discountAmount_lbl.Text = "0.00";
            this.discountAmount_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paymentMethod_cb
            // 
            this.paymentMethod_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethod_cb.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethod_cb.FormattingEnabled = true;
            this.paymentMethod_cb.Location = new System.Drawing.Point(22, 47);
            this.paymentMethod_cb.Margin = new System.Windows.Forms.Padding(2);
            this.paymentMethod_cb.Name = "paymentMethod_cb";
            this.paymentMethod_cb.Size = new System.Drawing.Size(343, 33);
            this.paymentMethod_cb.TabIndex = 553;
            this.paymentMethod_cb.SelectedIndexChanged += new System.EventHandler(this.paymentMethod_cb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 554;
            this.label4.Text = "Payment Method";
            // 
            // cash_tx
            // 
            this.cash_tx.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold);
            this.cash_tx.Location = new System.Drawing.Point(22, 263);
            this.cash_tx.MaxLength = 8;
            this.cash_tx.Name = "cash_tx";
            this.cash_tx.Size = new System.Drawing.Size(343, 65);
            this.cash_tx.TabIndex = 556;
            this.cash_tx.Text = "0";
            this.cash_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cash_tx.Click += new System.EventHandler(this.cash_tx_Click);
            this.cash_tx.TextChanged += new System.EventHandler(this.c_TextChanged);
            // 
            // discRate_tx
            // 
            this.discRate_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discRate_tx.Location = new System.Drawing.Point(22, 131);
            this.discRate_tx.MaxLength = 3;
            this.discRate_tx.Name = "discRate_tx";
            this.discRate_tx.Size = new System.Drawing.Size(340, 33);
            this.discRate_tx.TabIndex = 557;
            this.discRate_tx.Text = "0";
            this.discRate_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discRate_tx.Click += new System.EventHandler(this.discRate_tx_Click);
            this.discRate_tx.TextChanged += new System.EventHandler(this.discRate_tx_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.change_tx);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.customer_tx);
            this.groupBox1.Controls.Add(this.totalAmountDue_tx);
            this.groupBox1.Controls.Add(this.total_tx);
            this.groupBox1.Controls.Add(this.title_lbl);
            this.groupBox1.Controls.Add(this.discountAmount_lbl);
            this.groupBox1.Location = new System.Drawing.Point(16, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 290);
            this.groupBox1.TabIndex = 562;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 564;
            this.label7.Text = "Pay Order";
            // 
            // totalAmountDue_tx
            // 
            this.totalAmountDue_tx.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountDue_tx.Location = new System.Drawing.Point(78, 114);
            this.totalAmountDue_tx.Name = "totalAmountDue_tx";
            this.totalAmountDue_tx.Size = new System.Drawing.Size(296, 60);
            this.totalAmountDue_tx.TabIndex = 561;
            this.totalAmountDue_tx.Text = "0.00";
            this.totalAmountDue_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // total_tx
            // 
            this.total_tx.BackColor = System.Drawing.Color.White;
            this.total_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_tx.Location = new System.Drawing.Point(182, 45);
            this.total_tx.Name = "total_tx";
            this.total_tx.Size = new System.Drawing.Size(182, 31);
            this.total_tx.TabIndex = 538;
            this.total_tx.Text = "0.00";
            this.total_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 563;
            this.label2.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(23, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 21);
            this.label8.TabIndex = 562;
            this.label8.Text = "Less Discount Amt :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(22, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 4);
            this.panel1.TabIndex = 564;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(22, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 4);
            this.panel2.TabIndex = 567;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.paymentMethod_cb);
            this.groupBox2.Controls.Add(this.product_tx);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.discRate_tx);
            this.groupBox2.Controls.Add(this.cash_tx);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(424, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 361);
            this.groupBox2.TabIndex = 565;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 569;
            this.label6.Text = "Change";
            // 
            // change_tx
            // 
            this.change_tx.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold);
            this.change_tx.Location = new System.Drawing.Point(107, 196);
            this.change_tx.Name = "change_tx";
            this.change_tx.Size = new System.Drawing.Size(269, 54);
            this.change_tx.TabIndex = 568;
            this.change_tx.Text = "0.00";
            this.change_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 591;
            this.label5.Text = "Reference Number";
            // 
            // reference_tx
            // 
            this.reference_tx.BackColor = System.Drawing.Color.White;
            this.reference_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.reference_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.reference_tx.Location = new System.Drawing.Point(22, 45);
            this.reference_tx.Margin = new System.Windows.Forms.Padding(2);
            this.reference_tx.MaxLength = 20;
            this.reference_tx.Name = "reference_tx";
            this.reference_tx.Size = new System.Drawing.Size(340, 33);
            this.reference_tx.TabIndex = 590;
            // 
            // bank_cb
            // 
            this.bank_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bank_cb.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.bank_cb.FormattingEnabled = true;
            this.bank_cb.Items.AddRange(new object[] {
            "CASH",
            "CHECK",
            "BANK TRANSFER",
            "E-PAYMENT"});
            this.bank_cb.Location = new System.Drawing.Point(22, 111);
            this.bank_cb.Name = "bank_cb";
            this.bank_cb.Size = new System.Drawing.Size(340, 33);
            this.bank_cb.TabIndex = 588;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(25, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 589;
            this.label3.Text = "Bank";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(21, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 21);
            this.label9.TabIndex = 593;
            this.label9.Text = "Bank";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.reference_tx);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.bank_cb);
            this.groupBox3.Location = new System.Drawing.Point(16, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 164);
            this.groupBox3.TabIndex = 570;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // PaymentForm
            // 
            this.AcceptButton = this.pay_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 531);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paymentPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaymentForm_FormClosed);
            this.Load += new System.EventHandler(this.PayForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaymentForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.paymentPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label customer_tx;
        private System.Windows.Forms.Button pay_btn;
        internal System.Windows.Forms.Label title_lbl;
        internal System.Windows.Forms.Label product_tx;
        private System.Windows.Forms.PictureBox paymentPhoto;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label discountAmount_lbl;
        private System.Windows.Forms.ComboBox paymentMethod_cb;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cash_tx;
        private System.Windows.Forms.TextBox discRate_tx;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label totalAmountDue_tx;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label total_tx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label change_tx;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox reference_tx;
        public System.Windows.Forms.ComboBox bank_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}