namespace SalesPro.Forms.PaymentsAndBilling
{
    partial class ExpensesForm
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
            this.save_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.company_tx = new System.Windows.Forms.TextBox();
            this.particular_cb = new System.Windows.Forms.ComboBox();
            this.dateAdded_dt = new System.Windows.Forms.DateTimePicker();
            this.receipt_tx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amt_tx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Green;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(202, 389);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(140, 34);
            this.save_btn.TabIndex = 571;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.company_tx);
            this.groupBox1.Controls.Add(this.particular_cb);
            this.groupBox1.Controls.Add(this.dateAdded_dt);
            this.groupBox1.Controls.Add(this.receipt_tx);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.amt_tx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 320);
            this.groupBox1.TabIndex = 570;
            this.groupBox1.TabStop = false;
            // 
            // company_tx
            // 
            this.company_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.company_tx.Location = new System.Drawing.Point(14, 216);
            this.company_tx.Name = "company_tx";
            this.company_tx.Size = new System.Drawing.Size(303, 27);
            this.company_tx.TabIndex = 573;
            // 
            // particular_cb
            // 
            this.particular_cb.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.particular_cb.FormattingEnabled = true;
            this.particular_cb.Items.AddRange(new object[] {
            "Meals",
            "Snacks",
            "Supplies",
            "Electricity",
            "Water",
            "Internet",
            "Transportation",
            "Maintenance",
            "Labor",
            "Taxes",
            "Rent"});
            this.particular_cb.Location = new System.Drawing.Point(14, 102);
            this.particular_cb.Name = "particular_cb";
            this.particular_cb.Size = new System.Drawing.Size(303, 28);
            this.particular_cb.TabIndex = 572;
            // 
            // dateAdded_dt
            // 
            this.dateAdded_dt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAdded_dt.Location = new System.Drawing.Point(14, 44);
            this.dateAdded_dt.Name = "dateAdded_dt";
            this.dateAdded_dt.Size = new System.Drawing.Size(303, 25);
            this.dateAdded_dt.TabIndex = 571;
            // 
            // receipt_tx
            // 
            this.receipt_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.receipt_tx.Location = new System.Drawing.Point(14, 273);
            this.receipt_tx.MaxLength = 20;
            this.receipt_tx.Name = "receipt_tx";
            this.receipt_tx.Size = new System.Drawing.Size(303, 27);
            this.receipt_tx.TabIndex = 568;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 567;
            this.label6.Text = "Receipt Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 565;
            this.label2.Text = "Company";
            // 
            // amt_tx
            // 
            this.amt_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.amt_tx.Location = new System.Drawing.Point(14, 159);
            this.amt_tx.MaxLength = 13;
            this.amt_tx.Name = "amt_tx";
            this.amt_tx.Size = new System.Drawing.Size(303, 27);
            this.amt_tx.TabIndex = 564;
            this.amt_tx.Text = "0";
            this.amt_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 563;
            this.label3.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 561;
            this.label1.Text = "Expense Particular";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 559;
            this.label13.Text = "Date Added";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(7, 12);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(128, 25);
            this.title_lbl.TabIndex = 572;
            this.title_lbl.Text = "Expense Data";
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 439);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExpensesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.ExpensesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox receipt_tx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amt_tx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.DateTimePicker dateAdded_dt;
        private System.Windows.Forms.TextBox company_tx;
        private System.Windows.Forms.ComboBox particular_cb;
    }
}