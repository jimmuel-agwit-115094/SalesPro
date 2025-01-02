namespace SalesPro.Forms.Orders
{
    partial class Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            this.customer_tx = new System.Windows.Forms.Label();
            this.amtDue_tx = new System.Windows.Forms.Label();
            this.pay_btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cash_tx = new System.Windows.Forms.NumericUpDown();
            this.title_lbl = new System.Windows.Forms.Label();
            this.product_tx = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discRate_tx = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.discAmt_tx = new System.Windows.Forms.NumericUpDown();
            this.change_tx = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.paymentMethod_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cash_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discRate_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discAmt_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.change_tx)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_tx
            // 
            this.customer_tx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_tx.Location = new System.Drawing.Point(22, 132);
            this.customer_tx.Name = "customer_tx";
            this.customer_tx.Size = new System.Drawing.Size(290, 19);
            this.customer_tx.TabIndex = 539;
            this.customer_tx.Text = "Generic";
            this.customer_tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amtDue_tx
            // 
            this.amtDue_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtDue_tx.Location = new System.Drawing.Point(22, 80);
            this.amtDue_tx.Name = "amtDue_tx";
            this.amtDue_tx.Size = new System.Drawing.Size(290, 57);
            this.amtDue_tx.TabIndex = 538;
            this.amtDue_tx.Text = "0.00";
            this.amtDue_tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pay_btn
            // 
            this.pay_btn.BackColor = System.Drawing.Color.Green;
            this.pay_btn.FlatAppearance.BorderSize = 0;
            this.pay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.ForeColor = System.Drawing.Color.White;
            this.pay_btn.Location = new System.Drawing.Point(172, 535);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(140, 34);
            this.pay_btn.TabIndex = 537;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = false;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(23, 198);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 51);
            this.panel5.TabIndex = 536;
            // 
            // cash_tx
            // 
            this.cash_tx.DecimalPlaces = 2;
            this.cash_tx.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_tx.Location = new System.Drawing.Point(22, 196);
            this.cash_tx.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cash_tx.Name = "cash_tx";
            this.cash_tx.Size = new System.Drawing.Size(290, 54);
            this.cash_tx.TabIndex = 535;
            this.cash_tx.Tag = "IsNumeric";
            this.cash_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cash_tx.ThousandsSeparator = true;
            this.cash_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.cash_tx.ValueChanged += new System.EventHandler(this.cash_tx_ValueChanged);
            this.cash_tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cash_tx_KeyPress);
            // 
            // title_lbl
            // 
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(22, 60);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(290, 28);
            this.title_lbl.TabIndex = 534;
            this.title_lbl.Text = "Total Amount";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product_tx
            // 
            this.product_tx.AutoSize = true;
            this.product_tx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_tx.Location = new System.Drawing.Point(20, 172);
            this.product_tx.Name = "product_tx";
            this.product_tx.Size = new System.Drawing.Size(111, 21);
            this.product_tx.TabIndex = 540;
            this.product_tx.Text = "Cash Tendered";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 541;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 544;
            this.label1.Text = "Discount Rate";
            // 
            // discRate_tx
            // 
            this.discRate_tx.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discRate_tx.Location = new System.Drawing.Point(22, 352);
            this.discRate_tx.Name = "discRate_tx";
            this.discRate_tx.Size = new System.Drawing.Size(290, 36);
            this.discRate_tx.TabIndex = 542;
            this.discRate_tx.Tag = "IsNumeric";
            this.discRate_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discRate_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.discRate_tx.ValueChanged += new System.EventHandler(this.discRate_tx_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 547;
            this.label2.Text = "Discount Amount";
            // 
            // discAmt_tx
            // 
            this.discAmt_tx.BackColor = System.Drawing.Color.White;
            this.discAmt_tx.DecimalPlaces = 2;
            this.discAmt_tx.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discAmt_tx.Location = new System.Drawing.Point(22, 414);
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
            this.discAmt_tx.Size = new System.Drawing.Size(290, 36);
            this.discAmt_tx.TabIndex = 545;
            this.discAmt_tx.Tag = "IsNumeric";
            this.discAmt_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discAmt_tx.ThousandsSeparator = true;
            this.discAmt_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.discAmt_tx.ValueChanged += new System.EventHandler(this.discAmt_tx_ValueChanged);
            // 
            // change_tx
            // 
            this.change_tx.BackColor = System.Drawing.Color.White;
            this.change_tx.DecimalPlaces = 2;
            this.change_tx.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_tx.Location = new System.Drawing.Point(22, 474);
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
            this.change_tx.Size = new System.Drawing.Size(290, 36);
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
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 549;
            this.label3.Text = "Change";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(24, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 32);
            this.panel1.TabIndex = 550;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(23, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 32);
            this.panel2.TabIndex = 551;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(23, 476);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 32);
            this.panel3.TabIndex = 552;
            // 
            // paymentMethod_cb
            // 
            this.paymentMethod_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethod_cb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethod_cb.FormattingEnabled = true;
            this.paymentMethod_cb.Location = new System.Drawing.Point(22, 287);
            this.paymentMethod_cb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paymentMethod_cb.Name = "paymentMethod_cb";
            this.paymentMethod_cb.Size = new System.Drawing.Size(291, 33);
            this.paymentMethod_cb.TabIndex = 553;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 554;
            this.label4.Text = "Payment Method";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 28);
            this.label5.TabIndex = 555;
            this.label5.Text = "%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 588);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paymentMethod_cb);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customer_tx);
            this.Controls.Add(this.amtDue_tx);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.change_tx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discAmt_tx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discRate_tx);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.product_tx);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.cash_tx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.PayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cash_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discRate_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discAmt_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.change_tx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label customer_tx;
        internal System.Windows.Forms.Label amtDue_tx;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.NumericUpDown cash_tx;
        internal System.Windows.Forms.Label title_lbl;
        internal System.Windows.Forms.Label product_tx;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown discRate_tx;
        internal System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown discAmt_tx;
        public System.Windows.Forms.NumericUpDown change_tx;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox paymentMethod_cb;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
    }
}