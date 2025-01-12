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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.processedBy_tx = new System.Windows.Forms.Label();
            this.paymentStatus_tx = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.total_tx = new System.Windows.Forms.Label();
            this.creditTerms_tx = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateCredited_tx = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.dgOrderedItems = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dueDate_dt = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supplier_tx = new System.Windows.Forms.Label();
            this.address_tx = new System.Windows.Forms.Label();
            this.contactNumber_tx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pay_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderedItems)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notFound_lbl);
            this.groupBox1.Controls.Add(this.processedBy_tx);
            this.groupBox1.Controls.Add(this.paymentStatus_tx);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.total_tx);
            this.groupBox1.Controls.Add(this.creditTerms_tx);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateCredited_tx);
            this.groupBox1.Controls.Add(this.update_btn);
            this.groupBox1.Controls.Add(this.dgOrderedItems);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dueDate_dt);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1137, 775);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(440, 537);
            this.notFound_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(216, 54);
            this.notFound_lbl.TabIndex = 555;
            this.notFound_lbl.Text = "No Record";
            this.notFound_lbl.Visible = false;
            // 
            // processedBy_tx
            // 
            this.processedBy_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processedBy_tx.ForeColor = System.Drawing.Color.Black;
            this.processedBy_tx.Location = new System.Drawing.Point(959, 102);
            this.processedBy_tx.Name = "processedBy_tx";
            this.processedBy_tx.Size = new System.Drawing.Size(165, 21);
            this.processedBy_tx.TabIndex = 554;
            this.processedBy_tx.Text = "Paid";
            this.processedBy_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paymentStatus_tx
            // 
            this.paymentStatus_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentStatus_tx.ForeColor = System.Drawing.Color.Black;
            this.paymentStatus_tx.Location = new System.Drawing.Point(957, 78);
            this.paymentStatus_tx.Name = "paymentStatus_tx";
            this.paymentStatus_tx.Size = new System.Drawing.Size(165, 21);
            this.paymentStatus_tx.TabIndex = 553;
            this.paymentStatus_tx.Text = "Paid";
            this.paymentStatus_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.paymentStatus_tx.TextChanged += new System.EventHandler(this.paymentStatus_tx_TextChanged);
            this.paymentStatus_tx.Click += new System.EventHandler(this.paymentStatus_tx_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1076, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 23);
            this.label9.TabIndex = 552;
            this.label9.Text = "Total";
            // 
            // total_tx
            // 
            this.total_tx.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_tx.ForeColor = System.Drawing.Color.Blue;
            this.total_tx.Location = new System.Drawing.Point(768, 41);
            this.total_tx.Name = "total_tx";
            this.total_tx.Size = new System.Drawing.Size(363, 34);
            this.total_tx.TabIndex = 551;
            this.total_tx.Text = "0.00";
            this.total_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // creditTerms_tx
            // 
            this.creditTerms_tx.AutoSize = true;
            this.creditTerms_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.creditTerms_tx.ForeColor = System.Drawing.Color.Black;
            this.creditTerms_tx.Location = new System.Drawing.Point(187, 182);
            this.creditTerms_tx.Name = "creditTerms_tx";
            this.creditTerms_tx.Size = new System.Drawing.Size(162, 23);
            this.creditTerms_tx.TabIndex = 535;
            this.creditTerms_tx.Text = "CONTACT NUMBER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 23);
            this.label8.TabIndex = 534;
            this.label8.Text = "CREDIT TERMS :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateCredited_tx
            // 
            this.dateCredited_tx.AutoSize = true;
            this.dateCredited_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dateCredited_tx.ForeColor = System.Drawing.Color.Black;
            this.dateCredited_tx.Location = new System.Drawing.Point(185, 142);
            this.dateCredited_tx.Name = "dateCredited_tx";
            this.dateCredited_tx.Size = new System.Drawing.Size(162, 23);
            this.dateCredited_tx.TabIndex = 533;
            this.dateCredited_tx.Text = "CONTACT NUMBER";
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(775, 134);
            this.update_btn.Margin = new System.Windows.Forms.Padding(4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(171, 33);
            this.update_btn.TabIndex = 532;
            this.update_btn.Text = "Update Due Date";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // dgOrderedItems
            // 
            this.dgOrderedItems.AllowUserToAddRows = false;
            this.dgOrderedItems.AllowUserToDeleteRows = false;
            this.dgOrderedItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgOrderedItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgOrderedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrderedItems.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgOrderedItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgOrderedItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrderedItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgOrderedItems.ColumnHeadersHeight = 30;
            this.dgOrderedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOrderedItems.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgOrderedItems.EnableHeadersVisualStyles = false;
            this.dgOrderedItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgOrderedItems.Location = new System.Drawing.Point(21, 262);
            this.dgOrderedItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgOrderedItems.MultiSelect = false;
            this.dgOrderedItems.Name = "dgOrderedItems";
            this.dgOrderedItems.ReadOnly = true;
            this.dgOrderedItems.RowHeadersVisible = false;
            this.dgOrderedItems.RowHeadersWidth = 51;
            this.dgOrderedItems.RowTemplate.Height = 32;
            this.dgOrderedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderedItems.Size = new System.Drawing.Size(1096, 493);
            this.dgOrderedItems.TabIndex = 498;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 497;
            this.label6.Text = "CREDITED ITEMS";
            // 
            // dueDate_dt
            // 
            this.dueDate_dt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDate_dt.Location = new System.Drawing.Point(496, 138);
            this.dueDate_dt.Margin = new System.Windows.Forms.Padding(4);
            this.dueDate_dt.Name = "dueDate_dt";
            this.dueDate_dt.Size = new System.Drawing.Size(265, 27);
            this.dueDate_dt.TabIndex = 515;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.supplier_tx);
            this.panel2.Controls.Add(this.address_tx);
            this.panel2.Controls.Add(this.contactNumber_tx);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(21, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 100);
            this.panel2.TabIndex = 514;
            // 
            // supplier_tx
            // 
            this.supplier_tx.AutoSize = true;
            this.supplier_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_tx.Location = new System.Drawing.Point(11, 5);
            this.supplier_tx.Name = "supplier_tx";
            this.supplier_tx.Size = new System.Drawing.Size(113, 31);
            this.supplier_tx.TabIndex = 491;
            this.supplier_tx.Text = "SUPPLIER";
            // 
            // address_tx
            // 
            this.address_tx.AutoSize = true;
            this.address_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.address_tx.ForeColor = System.Drawing.Color.Black;
            this.address_tx.Location = new System.Drawing.Point(119, 65);
            this.address_tx.Name = "address_tx";
            this.address_tx.Size = new System.Drawing.Size(83, 23);
            this.address_tx.TabIndex = 493;
            this.address_tx.Text = "ADDRESS";
            // 
            // contactNumber_tx
            // 
            this.contactNumber_tx.AutoSize = true;
            this.contactNumber_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.contactNumber_tx.ForeColor = System.Drawing.Color.Black;
            this.contactNumber_tx.Location = new System.Drawing.Point(117, 41);
            this.contactNumber_tx.Name = "contactNumber_tx";
            this.contactNumber_tx.Size = new System.Drawing.Size(162, 23);
            this.contactNumber_tx.TabIndex = 495;
            this.contactNumber_tx.Text = "CONTACT NUMBER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 497;
            this.label1.Text = "CONTACT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 496;
            this.label3.Text = "ADDRESS  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 505;
            this.label2.Text = "DUE DATE :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 23);
            this.label7.TabIndex = 500;
            this.label7.Text = "DATE CREDITED :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pay_btn
            // 
            this.pay_btn.BackColor = System.Drawing.Color.Green;
            this.pay_btn.FlatAppearance.BorderSize = 0;
            this.pay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.ForeColor = System.Drawing.Color.White;
            this.pay_btn.Location = new System.Drawing.Point(904, 798);
            this.pay_btn.Margin = new System.Windows.Forms.Padding(4);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(229, 42);
            this.pay_btn.TabIndex = 535;
            this.pay_btn.Text = "Pay Supplier Payable";
            this.pay_btn.UseVisualStyleBackColor = false;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // ManageSupplierPayableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1171, 854);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageSupplierPayableForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Supplier Payable";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageSupplierPayableForm_FormClosed);
            this.Load += new System.EventHandler(this.ManageSupplierPayableForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderedItems)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        internal System.Windows.Forms.DataGridView dgOrderedItems;
        public System.Windows.Forms.Label dateCredited_tx;
        private System.Windows.Forms.Button update_btn;
        public System.Windows.Forms.Label creditTerms_tx;
        public System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label total_tx;
        internal System.Windows.Forms.Label paymentStatus_tx;
        internal System.Windows.Forms.Label processedBy_tx;
        private System.Windows.Forms.Label notFound_lbl;
    }
}