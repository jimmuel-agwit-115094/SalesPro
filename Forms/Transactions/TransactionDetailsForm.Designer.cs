namespace SalesPro.Forms.Transactions
{
    partial class TransactionDetailsForm
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
            this.title_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.detailTabControl = new System.Windows.Forms.TabControl();
            this.transactionData_tab = new System.Windows.Forms.TabPage();
            this.endingCash_tx = new System.Windows.Forms.NumericUpDown();
            this.expCash_tx = new System.Windows.Forms.NumericUpDown();
            this.totalExp_tx = new System.Windows.Forms.NumericUpDown();
            this.totalSales_tx = new System.Windows.Forms.NumericUpDown();
            this.begBal_tx = new System.Windows.Forms.NumericUpDown();
            this.close_btn = new System.Windows.Forms.Button();
            this.balStatus_tx = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.closedBy_tx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openedBy_tx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.transactionLog_tab = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.detailTabControl.SuspendLayout();
            this.transactionData_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endingCash_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expCash_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalExp_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSales_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.begBal_tx)).BeginInit();
            this.transactionLog_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(11, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(173, 25);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "Transaction Details";
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Green;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(414, 407);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(128, 34);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // detailTabControl
            // 
            this.detailTabControl.Controls.Add(this.transactionData_tab);
            this.detailTabControl.Controls.Add(this.transactionLog_tab);
            this.detailTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailTabControl.Location = new System.Drawing.Point(12, 66);
            this.detailTabControl.Name = "detailTabControl";
            this.detailTabControl.SelectedIndex = 0;
            this.detailTabControl.Size = new System.Drawing.Size(667, 490);
            this.detailTabControl.TabIndex = 6;
            // 
            // transactionData_tab
            // 
            this.transactionData_tab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transactionData_tab.Controls.Add(this.button1);
            this.transactionData_tab.Controls.Add(this.endingCash_tx);
            this.transactionData_tab.Controls.Add(this.expCash_tx);
            this.transactionData_tab.Controls.Add(this.totalExp_tx);
            this.transactionData_tab.Controls.Add(this.totalSales_tx);
            this.transactionData_tab.Controls.Add(this.begBal_tx);
            this.transactionData_tab.Controls.Add(this.close_btn);
            this.transactionData_tab.Controls.Add(this.balStatus_tx);
            this.transactionData_tab.Controls.Add(this.label6);
            this.transactionData_tab.Controls.Add(this.closedBy_tx);
            this.transactionData_tab.Controls.Add(this.label5);
            this.transactionData_tab.Controls.Add(this.openedBy_tx);
            this.transactionData_tab.Controls.Add(this.label4);
            this.transactionData_tab.Controls.Add(this.label3);
            this.transactionData_tab.Controls.Add(this.label2);
            this.transactionData_tab.Controls.Add(this.label1);
            this.transactionData_tab.Controls.Add(this.label8);
            this.transactionData_tab.Controls.Add(this.panel6);
            this.transactionData_tab.Controls.Add(this.save_btn);
            this.transactionData_tab.Location = new System.Drawing.Point(4, 29);
            this.transactionData_tab.Name = "transactionData_tab";
            this.transactionData_tab.Padding = new System.Windows.Forms.Padding(3);
            this.transactionData_tab.Size = new System.Drawing.Size(659, 457);
            this.transactionData_tab.TabIndex = 0;
            this.transactionData_tab.Text = "    Transaction Data    ";
            this.transactionData_tab.Click += new System.EventHandler(this.transactionData_tab_Click);
            // 
            // endingCash_tx
            // 
            this.endingCash_tx.DecimalPlaces = 2;
            this.endingCash_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.endingCash_tx.Location = new System.Drawing.Point(217, 351);
            this.endingCash_tx.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.endingCash_tx.Name = "endingCash_tx";
            this.endingCash_tx.ReadOnly = true;
            this.endingCash_tx.Size = new System.Drawing.Size(308, 27);
            this.endingCash_tx.TabIndex = 512;
            this.endingCash_tx.Tag = "IsNumeric";
            this.endingCash_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.endingCash_tx.ThousandsSeparator = true;
            this.endingCash_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // expCash_tx
            // 
            this.expCash_tx.DecimalPlaces = 2;
            this.expCash_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.expCash_tx.Location = new System.Drawing.Point(217, 309);
            this.expCash_tx.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.expCash_tx.Name = "expCash_tx";
            this.expCash_tx.ReadOnly = true;
            this.expCash_tx.Size = new System.Drawing.Size(308, 27);
            this.expCash_tx.TabIndex = 511;
            this.expCash_tx.Tag = "IsNumeric";
            this.expCash_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.expCash_tx.ThousandsSeparator = true;
            this.expCash_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // totalExp_tx
            // 
            this.totalExp_tx.DecimalPlaces = 2;
            this.totalExp_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.totalExp_tx.Location = new System.Drawing.Point(217, 263);
            this.totalExp_tx.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.totalExp_tx.Name = "totalExp_tx";
            this.totalExp_tx.ReadOnly = true;
            this.totalExp_tx.Size = new System.Drawing.Size(308, 27);
            this.totalExp_tx.TabIndex = 510;
            this.totalExp_tx.Tag = "IsNumeric";
            this.totalExp_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalExp_tx.ThousandsSeparator = true;
            this.totalExp_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // totalSales_tx
            // 
            this.totalSales_tx.DecimalPlaces = 2;
            this.totalSales_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.totalSales_tx.Location = new System.Drawing.Point(217, 219);
            this.totalSales_tx.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.totalSales_tx.Name = "totalSales_tx";
            this.totalSales_tx.ReadOnly = true;
            this.totalSales_tx.Size = new System.Drawing.Size(308, 27);
            this.totalSales_tx.TabIndex = 509;
            this.totalSales_tx.Tag = "IsNumeric";
            this.totalSales_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalSales_tx.ThousandsSeparator = true;
            this.totalSales_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // begBal_tx
            // 
            this.begBal_tx.DecimalPlaces = 2;
            this.begBal_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.begBal_tx.Location = new System.Drawing.Point(217, 175);
            this.begBal_tx.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.begBal_tx.Name = "begBal_tx";
            this.begBal_tx.Size = new System.Drawing.Size(308, 27);
            this.begBal_tx.TabIndex = 508;
            this.begBal_tx.Tag = "IsNumeric";
            this.begBal_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.begBal_tx.ThousandsSeparator = true;
            this.begBal_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(253, 407);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(145, 34);
            this.close_btn.TabIndex = 507;
            this.close_btn.Text = "Close Transaction";
            this.close_btn.UseVisualStyleBackColor = false;
            // 
            // balStatus_tx
            // 
            this.balStatus_tx.Location = new System.Drawing.Point(397, 18);
            this.balStatus_tx.Name = "balStatus_tx";
            this.balStatus_tx.Size = new System.Drawing.Size(128, 20);
            this.balStatus_tx.TabIndex = 506;
            this.balStatus_tx.Text = "Balance Status";
            this.balStatus_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 505;
            this.label6.Text = "Closed By :";
            // 
            // closedBy_tx
            // 
            this.closedBy_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.closedBy_tx.Location = new System.Drawing.Point(217, 119);
            this.closedBy_tx.Name = "closedBy_tx";
            this.closedBy_tx.ReadOnly = true;
            this.closedBy_tx.Size = new System.Drawing.Size(308, 27);
            this.closedBy_tx.TabIndex = 504;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 503;
            this.label5.Text = "Opened By :";
            // 
            // openedBy_tx
            // 
            this.openedBy_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.openedBy_tx.Location = new System.Drawing.Point(217, 74);
            this.openedBy_tx.Name = "openedBy_tx";
            this.openedBy_tx.ReadOnly = true;
            this.openedBy_tx.Size = new System.Drawing.Size(308, 27);
            this.openedBy_tx.TabIndex = 502;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 501;
            this.label4.Text = "Ending Cash :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 499;
            this.label3.Text = "Expected Cash :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 497;
            this.label2.Text = "Total Expenses :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 495;
            this.label1.Text = "Total Sales :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 493;
            this.label8.Text = "Beginning Balance :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(4, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 5);
            this.panel6.TabIndex = 5;
            // 
            // transactionLog_tab
            // 
            this.transactionLog_tab.Controls.Add(this.panel7);
            this.transactionLog_tab.Location = new System.Drawing.Point(4, 29);
            this.transactionLog_tab.Name = "transactionLog_tab";
            this.transactionLog_tab.Padding = new System.Windows.Forms.Padding(3);
            this.transactionLog_tab.Size = new System.Drawing.Size(659, 457);
            this.transactionLog_tab.TabIndex = 1;
            this.transactionLog_tab.Text = "     Transaction Logs   ";
            this.transactionLog_tab.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(169, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 5);
            this.panel7.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(96, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 34);
            this.button1.TabIndex = 513;
            this.button1.Text = "Undo Transaction";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TransactionDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 565);
            this.Controls.Add(this.detailTabControl);
            this.Controls.Add(this.title_lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionDetailsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Transaction";
            this.Load += new System.EventHandler(this.TransactionDetailsForm_Load);
            this.detailTabControl.ResumeLayout(false);
            this.transactionData_tab.ResumeLayout(false);
            this.transactionData_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endingCash_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expCash_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalExp_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSales_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.begBal_tx)).EndInit();
            this.transactionLog_tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TabControl detailTabControl;
        private System.Windows.Forms.TabPage transactionData_tab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage transactionLog_tab;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox openedBy_tx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox closedBy_tx;
        private System.Windows.Forms.Label balStatus_tx;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.NumericUpDown begBal_tx;
        private System.Windows.Forms.NumericUpDown totalSales_tx;
        private System.Windows.Forms.NumericUpDown endingCash_tx;
        private System.Windows.Forms.NumericUpDown expCash_tx;
        private System.Windows.Forms.NumericUpDown totalExp_tx;
        private System.Windows.Forms.Button button1;
    }
}