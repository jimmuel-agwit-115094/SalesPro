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
            this.panel6 = new System.Windows.Forms.Panel();
            this.transactionLog_tab = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.detailTabControl.SuspendLayout();
            this.transactionData_tab.SuspendLayout();
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
            this.save_btn.Location = new System.Drawing.Point(933, 439);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(128, 34);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            // 
            // detailTabControl
            // 
            this.detailTabControl.Controls.Add(this.transactionData_tab);
            this.detailTabControl.Controls.Add(this.transactionLog_tab);
            this.detailTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailTabControl.Location = new System.Drawing.Point(12, 66);
            this.detailTabControl.Name = "detailTabControl";
            this.detailTabControl.SelectedIndex = 0;
            this.detailTabControl.Size = new System.Drawing.Size(1090, 535);
            this.detailTabControl.TabIndex = 6;
            // 
            // transactionData_tab
            // 
            this.transactionData_tab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transactionData_tab.Controls.Add(this.panel6);
            this.transactionData_tab.Controls.Add(this.save_btn);
            this.transactionData_tab.Location = new System.Drawing.Point(4, 29);
            this.transactionData_tab.Name = "transactionData_tab";
            this.transactionData_tab.Padding = new System.Windows.Forms.Padding(3);
            this.transactionData_tab.Size = new System.Drawing.Size(1082, 502);
            this.transactionData_tab.TabIndex = 0;
            this.transactionData_tab.Text = "    Transaction Data    ";
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
            this.transactionLog_tab.Size = new System.Drawing.Size(1082, 502);
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
            // TransactionDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 613);
            this.Controls.Add(this.detailTabControl);
            this.Controls.Add(this.title_lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionDetailsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Transaction";
            this.detailTabControl.ResumeLayout(false);
            this.transactionData_tab.ResumeLayout(false);
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
    }
}