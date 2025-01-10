namespace SalesPro.Forms.PaymentsAndBilling
{
    partial class PaymentsAndBillingForm
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.basePanel = new System.Windows.Forms.Panel();
            this.transactionsTabControl = new System.Windows.Forms.TabControl();
            this.cuurent_tab = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.allTransactions_tab = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.basePanel.SuspendLayout();
            this.transactionsTabControl.SuspendLayout();
            this.cuurent_tab.SuspendLayout();
            this.allTransactions_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel1.Controls.Add(this.title_lbl);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1197, 43);
            this.Panel1.TabIndex = 437;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(6, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(193, 25);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Payments And Billing";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1197, 31);
            this.panel3.TabIndex = 438;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(761, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(434, 29);
            this.panel4.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Controls.Add(this.basePanel);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 74);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1197, 535);
            this.panel10.TabIndex = 460;
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.Color.White;
            this.basePanel.Controls.Add(this.transactionsTabControl);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(1197, 535);
            this.basePanel.TabIndex = 439;
            // 
            // transactionsTabControl
            // 
            this.transactionsTabControl.Controls.Add(this.cuurent_tab);
            this.transactionsTabControl.Controls.Add(this.allTransactions_tab);
            this.transactionsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsTabControl.Location = new System.Drawing.Point(0, 0);
            this.transactionsTabControl.Name = "transactionsTabControl";
            this.transactionsTabControl.SelectedIndex = 0;
            this.transactionsTabControl.Size = new System.Drawing.Size(1197, 535);
            this.transactionsTabControl.TabIndex = 6;
            // 
            // cuurent_tab
            // 
            this.cuurent_tab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cuurent_tab.Controls.Add(this.panel6);
            this.cuurent_tab.Location = new System.Drawing.Point(4, 29);
            this.cuurent_tab.Name = "cuurent_tab";
            this.cuurent_tab.Padding = new System.Windows.Forms.Padding(3);
            this.cuurent_tab.Size = new System.Drawing.Size(1189, 502);
            this.cuurent_tab.TabIndex = 0;
            this.cuurent_tab.Text = "    Current Transaction   ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(10, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 5);
            this.panel6.TabIndex = 5;
            // 
            // allTransactions_tab
            // 
            this.allTransactions_tab.Controls.Add(this.panel7);
            this.allTransactions_tab.Location = new System.Drawing.Point(4, 29);
            this.allTransactions_tab.Name = "allTransactions_tab";
            this.allTransactions_tab.Padding = new System.Windows.Forms.Padding(3);
            this.allTransactions_tab.Size = new System.Drawing.Size(1196, 5);
            this.allTransactions_tab.TabIndex = 1;
            this.allTransactions_tab.Text = "     All Transactions    ";
            this.allTransactions_tab.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(182, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 5);
            this.panel7.TabIndex = 6;
            // 
            // PaymentsAndBillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1197, 609);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentsAndBillingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PaymentsAndBillingForm";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.basePanel.ResumeLayout(false);
            this.transactionsTabControl.ResumeLayout(false);
            this.cuurent_tab.ResumeLayout(false);
            this.allTransactions_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.TabControl transactionsTabControl;
        private System.Windows.Forms.TabPage cuurent_tab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage allTransactions_tab;
        private System.Windows.Forms.Panel panel7;
    }
}