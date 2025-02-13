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
            this.total_tx = new System.Windows.Forms.Label();
            this.pay_btn = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            this.product_tx = new System.Windows.Forms.Label();
            this.paymentPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.discAmt_tx = new System.Windows.Forms.NumericUpDown();
            this.change_tx = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.paymentMethod_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cash_tx = new System.Windows.Forms.TextBox();
            this.discRate_tx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.totalAmtDue_tx = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discAmt_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.change_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAmtDue_tx)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_tx
            // 
            this.customer_tx.BackColor = System.Drawing.Color.White;
            this.customer_tx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_tx.Location = new System.Drawing.Point(1, 125);
            this.customer_tx.Name = "customer_tx";
            this.customer_tx.Size = new System.Drawing.Size(290, 19);
            this.customer_tx.TabIndex = 539;
            this.customer_tx.Text = "Generic";
            this.customer_tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pay_btn.Location = new System.Drawing.Point(25, 622);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(292, 40);
            this.pay_btn.TabIndex = 537;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = false;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
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
            // product_tx
            // 
            this.product_tx.AutoSize = true;
            this.product_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_tx.Location = new System.Drawing.Point(24, 194);
            this.product_tx.Name = "product_tx";
            this.product_tx.Size = new System.Drawing.Size(117, 21);
            this.product_tx.TabIndex = 540;
            this.product_tx.Text = "Cash Tendered";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 544;
            this.label1.Text = "Discount Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 547;
            this.label2.Text = "Discount Amount";
            // 
            // discAmt_tx
            // 
            this.discAmt_tx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.discAmt_tx.DecimalPlaces = 2;
            this.discAmt_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discAmt_tx.Location = new System.Drawing.Point(26, 426);
            this.discAmt_tx.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.discAmt_tx.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.discAmt_tx.Name = "discAmt_tx";
            this.discAmt_tx.ReadOnly = true;
            this.discAmt_tx.Size = new System.Drawing.Size(290, 30);
            this.discAmt_tx.TabIndex = 545;
            this.discAmt_tx.Tag = "IsNumeric";
            this.discAmt_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discAmt_tx.ThousandsSeparator = true;
            this.discAmt_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // change_tx
            // 
            this.change_tx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.change_tx.DecimalPlaces = 2;
            this.change_tx.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_tx.Location = new System.Drawing.Point(26, 545);
            this.change_tx.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.change_tx.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.change_tx.Name = "change_tx";
            this.change_tx.ReadOnly = true;
            this.change_tx.Size = new System.Drawing.Size(290, 48);
            this.change_tx.TabIndex = 548;
            this.change_tx.Tag = "IsNumeric";
            this.change_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.change_tx.ThousandsSeparator = true;
            this.change_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.change_tx.ValueChanged += new System.EventHandler(this.change_tx_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 549;
            this.label3.Text = "Change";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(27, 546);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 46);
            this.panel3.TabIndex = 552;
            // 
            // paymentMethod_cb
            // 
            this.paymentMethod_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethod_cb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethod_cb.FormattingEnabled = true;
            this.paymentMethod_cb.Location = new System.Drawing.Point(26, 303);
            this.paymentMethod_cb.Margin = new System.Windows.Forms.Padding(2);
            this.paymentMethod_cb.Name = "paymentMethod_cb";
            this.paymentMethod_cb.Size = new System.Drawing.Size(291, 33);
            this.paymentMethod_cb.TabIndex = 553;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 554;
            this.label4.Text = "Payment Method";
            // 
            // cash_tx
            // 
            this.cash_tx.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_tx.Location = new System.Drawing.Point(28, 218);
            this.cash_tx.Name = "cash_tx";
            this.cash_tx.Size = new System.Drawing.Size(288, 50);
            this.cash_tx.TabIndex = 556;
            this.cash_tx.Text = "0";
            this.cash_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cash_tx.Click += new System.EventHandler(this.cash_tx_Click);
            this.cash_tx.TextChanged += new System.EventHandler(this.c_TextChanged);
            // 
            // discRate_tx
            // 
            this.discRate_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discRate_tx.Location = new System.Drawing.Point(201, 367);
            this.discRate_tx.Name = "discRate_tx";
            this.discRate_tx.Size = new System.Drawing.Size(115, 30);
            this.discRate_tx.TabIndex = 557;
            this.discRate_tx.Text = "0";
            this.discRate_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discRate_tx.Click += new System.EventHandler(this.discRate_tx_Click);
            this.discRate_tx.TextChanged += new System.EventHandler(this.discRate_tx_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 21);
            this.label5.TabIndex = 558;
            this.label5.Text = "%";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(27, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 27);
            this.panel1.TabIndex = 561;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 560;
            this.label6.Text = "Total Amount Due";
            // 
            // totalAmtDue_tx
            // 
            this.totalAmtDue_tx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalAmtDue_tx.DecimalPlaces = 2;
            this.totalAmtDue_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmtDue_tx.Location = new System.Drawing.Point(26, 481);
            this.totalAmtDue_tx.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.totalAmtDue_tx.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.totalAmtDue_tx.Name = "totalAmtDue_tx";
            this.totalAmtDue_tx.ReadOnly = true;
            this.totalAmtDue_tx.Size = new System.Drawing.Size(290, 30);
            this.totalAmtDue_tx.TabIndex = 559;
            this.totalAmtDue_tx.Tag = "IsNumeric";
            this.totalAmtDue_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalAmtDue_tx.ThousandsSeparator = true;
            this.totalAmtDue_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paymentPhoto);
            this.groupBox1.Controls.Add(this.title_lbl);
            this.groupBox1.Controls.Add(this.total_tx);
            this.groupBox1.Controls.Add(this.customer_tx);
            this.groupBox1.Location = new System.Drawing.Point(25, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 155);
            this.groupBox1.TabIndex = 562;
            this.groupBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(27, 427);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 28);
            this.panel4.TabIndex = 563;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 564;
            this.label7.Text = "Pay Order";
            // 
            // PaymentForm
            // 
            this.AcceptButton = this.pay_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 674);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.cash_tx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.product_tx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalAmtDue_tx);
            this.Controls.Add(this.discAmt_tx);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paymentMethod_cb);
            this.Controls.Add(this.discRate_tx);
            this.Controls.Add(this.change_tx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
            ((System.ComponentModel.ISupportInitialize)(this.discAmt_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.change_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAmtDue_tx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label customer_tx;
        internal System.Windows.Forms.Label total_tx;
        private System.Windows.Forms.Button pay_btn;
        internal System.Windows.Forms.Label title_lbl;
        internal System.Windows.Forms.Label product_tx;
        private System.Windows.Forms.PictureBox paymentPhoto;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown discAmt_tx;
        public System.Windows.Forms.NumericUpDown change_tx;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox paymentMethod_cb;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cash_tx;
        private System.Windows.Forms.TextBox discRate_tx;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown totalAmtDue_tx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Label label7;
    }
}