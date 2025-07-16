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
            this.dueDate_tx = new System.Windows.Forms.Label();
            this.dateCredited_tx = new System.Windows.Forms.Label();
            this.credTerms_tx = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credTerms_tx)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_tx
            // 
            this.customer_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.customer_tx.Location = new System.Drawing.Point(2, 26);
            this.customer_tx.Name = "customer_tx";
            this.customer_tx.Size = new System.Drawing.Size(351, 36);
            this.customer_tx.TabIndex = 542;
            this.customer_tx.Text = "Generic";
            this.customer_tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amtDue_tx
            // 
            this.amtDue_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtDue_tx.Location = new System.Drawing.Point(3, 27);
            this.amtDue_tx.Name = "amtDue_tx";
            this.amtDue_tx.Size = new System.Drawing.Size(353, 57);
            this.amtDue_tx.TabIndex = 541;
            this.amtDue_tx.Text = "0.00";
            this.amtDue_tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title_lbl
            // 
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.title_lbl.Location = new System.Drawing.Point(41, 8);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(290, 34);
            this.title_lbl.TabIndex = 540;
            this.title_lbl.Text = "Total Amount to Charge";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentPhoto
            // 
            this.paymentPhoto.Image = ((System.Drawing.Image)(resources.GetObject("paymentPhoto.Image")));
            this.paymentPhoto.Location = new System.Drawing.Point(20, 7);
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
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 21);
            this.label4.TabIndex = 556;
            this.label4.Text = "Credit Terms (No. of days)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 557;
            this.label1.Text = "Date Credited :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 558;
            this.label2.Text = "Due Date :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoice_tx
            // 
            this.invoice_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.invoice_tx.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.invoice_tx.Location = new System.Drawing.Point(23, 128);
            this.invoice_tx.Name = "invoice_tx";
            this.invoice_tx.Size = new System.Drawing.Size(355, 36);
            this.invoice_tx.TabIndex = 560;
            this.invoice_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 559;
            this.label3.Text = "Invoice No.";
            // 
            // notes_tx
            // 
            this.notes_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_tx.Location = new System.Drawing.Point(22, 198);
            this.notes_tx.Name = "notes_tx";
            this.notes_tx.Size = new System.Drawing.Size(356, 78);
            this.notes_tx.TabIndex = 561;
            this.notes_tx.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 562;
            this.label5.Text = "Notes";
            // 
            // charge_btn
            // 
            this.charge_btn.BackColor = System.Drawing.Color.Green;
            this.charge_btn.FlatAppearance.BorderSize = 0;
            this.charge_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.charge_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.charge_btn.ForeColor = System.Drawing.Color.White;
            this.charge_btn.Location = new System.Drawing.Point(394, 392);
            this.charge_btn.Name = "charge_btn";
            this.charge_btn.Size = new System.Drawing.Size(399, 57);
            this.charge_btn.TabIndex = 563;
            this.charge_btn.Text = "Charge";
            this.charge_btn.UseVisualStyleBackColor = false;
            this.charge_btn.Click += new System.EventHandler(this.charge_btn_Click);
            // 
            // dueDate_tx
            // 
            this.dueDate_tx.AutoSize = true;
            this.dueDate_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDate_tx.Location = new System.Drawing.Point(16, 302);
            this.dueDate_tx.Name = "dueDate_tx";
            this.dueDate_tx.Size = new System.Drawing.Size(77, 21);
            this.dueDate_tx.TabIndex = 565;
            this.dueDate_tx.Text = "Due Date";
            this.dueDate_tx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateCredited_tx
            // 
            this.dateCredited_tx.AutoSize = true;
            this.dateCredited_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCredited_tx.Location = new System.Drawing.Point(16, 260);
            this.dateCredited_tx.Name = "dateCredited_tx";
            this.dateCredited_tx.Size = new System.Drawing.Size(112, 21);
            this.dateCredited_tx.TabIndex = 564;
            this.dateCredited_tx.Text = "Date Credited";
            this.dateCredited_tx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // credTerms_tx
            // 
            this.credTerms_tx.BackColor = System.Drawing.Color.White;
            this.credTerms_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credTerms_tx.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.credTerms_tx.Location = new System.Drawing.Point(20, 41);
            this.credTerms_tx.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.credTerms_tx.Name = "credTerms_tx";
            this.credTerms_tx.Size = new System.Drawing.Size(358, 50);
            this.credTerms_tx.TabIndex = 566;
            this.credTerms_tx.Tag = "IsNumeric";
            this.credTerms_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.credTerms_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.credTerms_tx.ValueChanged += new System.EventHandler(this.credTerms_tx_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.customer_tx);
            this.groupBox1.Location = new System.Drawing.Point(20, 159);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(358, 74);
            this.groupBox1.TabIndex = 567;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 19);
            this.label6.TabIndex = 566;
            this.label6.Text = "Charge To";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 568;
            this.label7.Text = "Charge Order";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.title_lbl);
            this.groupBox2.Controls.Add(this.amtDue_tx);
            this.groupBox2.Location = new System.Drawing.Point(18, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(360, 86);
            this.groupBox2.TabIndex = 569;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.credTerms_tx);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.invoice_tx);
            this.groupBox3.Controls.Add(this.notes_tx);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(394, 69);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(399, 304);
            this.groupBox3.TabIndex = 570;
            this.groupBox3.TabStop = false;
            // 
            // ChargeOrderForm
            // 
            this.AcceptButton = this.charge_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 467);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dueDate_tx);
            this.Controls.Add(this.charge_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateCredited_tx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paymentPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChargeOrderForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charge Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChargeOrderForm_FormClosing);
            this.Load += new System.EventHandler(this.ChargeOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credTerms_tx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        internal System.Windows.Forms.Label dueDate_tx;
        internal System.Windows.Forms.Label dateCredited_tx;
        public System.Windows.Forms.NumericUpDown credTerms_tx;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}