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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.processedBy_tx = new System.Windows.Forms.Label();
            this.pastDue_tx = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.pastDue_tx);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 630);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(338, 406);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 555;
            this.notFound_lbl.Text = "No Record";
            this.notFound_lbl.Visible = false;
            // 
            // processedBy_tx
            // 
            this.processedBy_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processedBy_tx.ForeColor = System.Drawing.Color.Black;
            this.processedBy_tx.Location = new System.Drawing.Point(719, 61);
            this.processedBy_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.processedBy_tx.Name = "processedBy_tx";
            this.processedBy_tx.Size = new System.Drawing.Size(124, 17);
            this.processedBy_tx.TabIndex = 554;
            this.processedBy_tx.Text = "Paid";
            this.processedBy_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pastDue_tx
            // 
            this.pastDue_tx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pastDue_tx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastDue_tx.ForeColor = System.Drawing.Color.White;
            this.pastDue_tx.Location = new System.Drawing.Point(770, 79);
            this.pastDue_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pastDue_tx.Name = "pastDue_tx";
            this.pastDue_tx.Size = new System.Drawing.Size(75, 22);
            this.pastDue_tx.TabIndex = 553;
            this.pastDue_tx.Text = "Past Due";
            this.pastDue_tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pastDue_tx.Visible = false;
            this.pastDue_tx.TextChanged += new System.EventHandler(this.paymentStatus_tx_TextChanged);
            this.pastDue_tx.Click += new System.EventHandler(this.paymentStatus_tx_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(807, 17);
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
            this.total_tx.Location = new System.Drawing.Point(576, 33);
            this.total_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_tx.Name = "total_tx";
            this.total_tx.Size = new System.Drawing.Size(272, 28);
            this.total_tx.TabIndex = 551;
            this.total_tx.Text = "0.00";
            this.total_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // creditTerms_tx
            // 
            this.creditTerms_tx.AutoSize = true;
            this.creditTerms_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.creditTerms_tx.ForeColor = System.Drawing.Color.Black;
            this.creditTerms_tx.Location = new System.Drawing.Point(140, 148);
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
            this.label8.Location = new System.Drawing.Point(28, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 534;
            this.label8.Text = "CREDIT TERMS :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(444, 144);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(128, 27);
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
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgOrderedItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgOrderedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrderedItems.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgOrderedItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgOrderedItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrderedItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgOrderedItems.ColumnHeadersHeight = 30;
            this.dgOrderedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOrderedItems.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgOrderedItems.EnableHeadersVisualStyles = false;
            this.dgOrderedItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgOrderedItems.Location = new System.Drawing.Point(16, 213);
            this.dgOrderedItems.MultiSelect = false;
            this.dgOrderedItems.Name = "dgOrderedItems";
            this.dgOrderedItems.ReadOnly = true;
            this.dgOrderedItems.RowHeadersVisible = false;
            this.dgOrderedItems.RowHeadersWidth = 51;
            this.dgOrderedItems.RowTemplate.Height = 32;
            this.dgOrderedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderedItems.Size = new System.Drawing.Size(822, 401);
            this.dgOrderedItems.TabIndex = 498;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 497;
            this.label6.Text = "CREDITED ITEMS";
            // 
            // dueDate_dt
            // 
            this.dueDate_dt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDate_dt.Location = new System.Drawing.Point(372, 112);
            this.dueDate_dt.Name = "dueDate_dt";
            this.dueDate_dt.Size = new System.Drawing.Size(200, 23);
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
            this.panel2.Location = new System.Drawing.Point(16, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 81);
            this.panel2.TabIndex = 514;
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
            this.address_tx.Location = new System.Drawing.Point(89, 53);
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
            this.contactNumber_tx.Location = new System.Drawing.Point(88, 33);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 505;
            this.label2.Text = "DUE DATE :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // pay_btn
            // 
            this.pay_btn.BackColor = System.Drawing.Color.Green;
            this.pay_btn.FlatAppearance.BorderSize = 0;
            this.pay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.ForeColor = System.Drawing.Color.White;
            this.pay_btn.Location = new System.Drawing.Point(694, 651);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(172, 34);
            this.pay_btn.TabIndex = 535;
            this.pay_btn.Text = "Pay Supplier";
            this.pay_btn.UseVisualStyleBackColor = false;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
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
        internal System.Windows.Forms.Label pastDue_tx;
        internal System.Windows.Forms.Label processedBy_tx;
        private System.Windows.Forms.Label notFound_lbl;
    }
}