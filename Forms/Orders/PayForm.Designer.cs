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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cash_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_tx
            // 
            this.customer_tx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_tx.Location = new System.Drawing.Point(29, 197);
            this.customer_tx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customer_tx.Name = "customer_tx";
            this.customer_tx.Size = new System.Drawing.Size(387, 23);
            this.customer_tx.TabIndex = 539;
            this.customer_tx.Text = "Generic";
            this.customer_tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amtDue_tx
            // 
            this.amtDue_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtDue_tx.Location = new System.Drawing.Point(29, 133);
            this.amtDue_tx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amtDue_tx.Name = "amtDue_tx";
            this.amtDue_tx.Size = new System.Drawing.Size(387, 70);
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
            this.pay_btn.Location = new System.Drawing.Point(229, 627);
            this.pay_btn.Margin = new System.Windows.Forms.Padding(4);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(187, 42);
            this.pay_btn.TabIndex = 537;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = false;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(31, 277);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(27, 63);
            this.panel5.TabIndex = 536;
            // 
            // cash_tx
            // 
            this.cash_tx.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_tx.Location = new System.Drawing.Point(29, 275);
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
            this.cash_tx.ValueChanged += new System.EventHandler(this.cash_tx_ValueChanged);
            // 
            // title_lbl
            // 
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(29, 108);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(387, 35);
            this.title_lbl.TabIndex = 534;
            this.title_lbl.Text = "Total Amount";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product_tx
            // 
            this.product_tx.AutoSize = true;
            this.product_tx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_tx.Location = new System.Drawing.Point(26, 245);
            this.product_tx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.product_tx.Name = "product_tx";
            this.product_tx.Size = new System.Drawing.Size(138, 28);
            this.product_tx.TabIndex = 540;
            this.product_tx.Text = "Cash Tendered";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 541;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 370);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 544;
            this.label1.Text = "Discount Rate";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(29, 392);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(387, 43);
            this.numericUpDown1.TabIndex = 542;
            this.numericUpDown1.Tag = "IsNumeric";
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 447);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 547;
            this.label2.Text = "Discount Amount";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(29, 469);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(387, 43);
            this.numericUpDown2.TabIndex = 545;
            this.numericUpDown2.Tag = "IsNumeric";
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.ThousandsSeparator = true;
            this.numericUpDown2.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.White;
            this.numericUpDown3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(29, 542);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.ReadOnly = true;
            this.numericUpDown3.Size = new System.Drawing.Size(387, 43);
            this.numericUpDown3.TabIndex = 548;
            this.numericUpDown3.Tag = "IsNumeric";
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown3.ThousandsSeparator = true;
            this.numericUpDown3.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 520);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 549;
            this.label3.Text = "Change";
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 695);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.product_tx);
            this.Controls.Add(this.customer_tx);
            this.Controls.Add(this.amtDue_tx);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.cash_tx);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayForm";
            this.Load += new System.EventHandler(this.PayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cash_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
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
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        internal System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown numericUpDown2;
        public System.Windows.Forms.NumericUpDown numericUpDown3;
        internal System.Windows.Forms.Label label3;
    }
}