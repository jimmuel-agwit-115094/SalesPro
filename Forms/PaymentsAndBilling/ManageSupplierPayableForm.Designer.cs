namespace SalesPro.Forms.PaymentsAndBilling
{
    partial class ManageSupplierPayableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pay_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.supplier_tx = new System.Windows.Forms.Label();
            this.address_tx = new System.Windows.Forms.Label();
            this.contactNumber_tx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dueDate_dt = new System.Windows.Forms.DateTimePicker();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.update_btn = new System.Windows.Forms.Button();
            this.dateCredited_tx = new System.Windows.Forms.Label();
            this.creditTerms_tx = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.total_tx = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.total_tx);
            this.groupBox1.Controls.Add(this.creditTerms_tx);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateCredited_tx);
            this.groupBox1.Controls.Add(this.update_btn);
            this.groupBox1.Controls.Add(this.dgProducts);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dueDate_dt);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 630);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pay_btn
            // 
            this.pay_btn.BackColor = System.Drawing.Color.Green;
            this.pay_btn.FlatAppearance.BorderSize = 0;
            this.pay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.ForeColor = System.Drawing.Color.White;
            this.pay_btn.Location = new System.Drawing.Point(726, 651);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(140, 34);
            this.pay_btn.TabIndex = 535;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.supplier_tx);
            this.panel2.Controls.Add(this.address_tx);
            this.panel2.Controls.Add(this.contactNumber_tx);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(16, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 81);
            this.panel2.TabIndex = 514;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 505;
            this.label2.Text = "DUE DATE :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 497;
            this.label6.Text = "CREDITED ITEMS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 500;
            this.label7.Text = "DATE CREDITED :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // supplier_tx
            // 
            this.supplier_tx.AutoSize = true;
            this.supplier_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_tx.Location = new System.Drawing.Point(8, 4);
            this.supplier_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplier_tx.Name = "supplier_tx";
            this.supplier_tx.Size = new System.Drawing.Size(94, 25);
            this.supplier_tx.TabIndex = 491;
            this.supplier_tx.Text = "SUPPLIER";
            // 
            // address_tx
            // 
            this.address_tx.AutoSize = true;
            this.address_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.address_tx.ForeColor = System.Drawing.Color.Black;
            this.address_tx.Location = new System.Drawing.Point(122, 53);
            this.address_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address_tx.Name = "address_tx";
            this.address_tx.Size = new System.Drawing.Size(64, 17);
            this.address_tx.TabIndex = 493;
            this.address_tx.Text = "ADDRESS";
            // 
            // contactNumber_tx
            // 
            this.contactNumber_tx.AutoSize = true;
            this.contactNumber_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.contactNumber_tx.ForeColor = System.Drawing.Color.Black;
            this.contactNumber_tx.Location = new System.Drawing.Point(121, 33);
            this.contactNumber_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactNumber_tx.Name = "contactNumber_tx";
            this.contactNumber_tx.Size = new System.Drawing.Size(124, 17);
            this.contactNumber_tx.TabIndex = 495;
            this.contactNumber_tx.Text = "CONTACT NUMBER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 497;
            this.label1.Text = "CONTACT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 496;
            this.label3.Text = "ADDRESS  :";
            // 
            // dueDate_dt
            // 
            this.dueDate_dt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDate_dt.Location = new System.Drawing.Point(107, 165);
            this.dueDate_dt.Name = "dueDate_dt";
            this.dueDate_dt.Size = new System.Drawing.Size(200, 23);
            this.dueDate_dt.TabIndex = 515;
            // 
            // dgProducts
            // 
            this.dgProducts.AllowUserToAddRows = false;
            this.dgProducts.AllowUserToDeleteRows = false;
            this.dgProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProducts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgProducts.ColumnHeadersHeight = 30;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProducts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgProducts.EnableHeadersVisualStyles = false;
            this.dgProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgProducts.Location = new System.Drawing.Point(16, 236);
            this.dgProducts.MultiSelect = false;
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.ReadOnly = true;
            this.dgProducts.RowHeadersVisible = false;
            this.dgProducts.RowHeadersWidth = 51;
            this.dgProducts.RowTemplate.Height = 32;
            this.dgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducts.Size = new System.Drawing.Size(822, 378);
            this.dgProducts.TabIndex = 498;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(325, 163);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(128, 27);
            this.update_btn.TabIndex = 532;
            this.update_btn.Text = "Update Due Date";
            this.update_btn.UseVisualStyleBackColor = false;
            // 
            // dateCredited_tx
            // 
            this.dateCredited_tx.AutoSize = true;
            this.dateCredited_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dateCredited_tx.ForeColor = System.Drawing.Color.Black;
            this.dateCredited_tx.Location = new System.Drawing.Point(139, 115);
            this.dateCredited_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateCredited_tx.Name = "dateCredited_tx";
            this.dateCredited_tx.Size = new System.Drawing.Size(124, 17);
            this.dateCredited_tx.TabIndex = 533;
            this.dateCredited_tx.Text = "CONTACT NUMBER";
            // 
            // creditTerms_tx
            // 
            this.creditTerms_tx.AutoSize = true;
            this.creditTerms_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.creditTerms_tx.ForeColor = System.Drawing.Color.Black;
            this.creditTerms_tx.Location = new System.Drawing.Point(140, 141);
            this.creditTerms_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditTerms_tx.Name = "creditTerms_tx";
            this.creditTerms_tx.Size = new System.Drawing.Size(124, 17);
            this.creditTerms_tx.TabIndex = 535;
            this.creditTerms_tx.Text = "CONTACT NUMBER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 534;
            this.label8.Text = "CREDIT TERMS :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(807, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 552;
            this.label9.Text = "Total";
            // 
            // total_tx
            // 
            this.total_tx.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_tx.ForeColor = System.Drawing.Color.Blue;
            this.total_tx.Location = new System.Drawing.Point(516, 35);
            this.total_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_tx.Name = "total_tx";
            this.total_tx.Size = new System.Drawing.Size(332, 28);
            this.total_tx.TabIndex = 551;
            this.total_tx.Text = "0.00";
            this.total_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(718, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 553;
            this.label10.Text = "Paid";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(719, 87);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 17);
            this.label11.TabIndex = 554;
            this.label11.Text = "Paid";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManageSupplierPayableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 694);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageSupplierPayableForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Supplier Payable";
            this.Load += new System.EventHandler(this.ManageSupplierPayableForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label supplier_tx;
        public System.Windows.Forms.Label address_tx;
        public System.Windows.Forms.Label contactNumber_tx;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dueDate_dt;
        internal System.Windows.Forms.DataGridView dgProducts;
        public System.Windows.Forms.Label dateCredited_tx;
        private System.Windows.Forms.Button update_btn;
        public System.Windows.Forms.Label creditTerms_tx;
        public System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label total_tx;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
    }
}