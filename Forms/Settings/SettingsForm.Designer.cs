namespace SalesPro.Settings
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.transactionsTabControl = new System.Windows.Forms.TabControl();
            this.cuurent_tab = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.allTransactions_tab = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.restore_btn = new System.Windows.Forms.Button();
            this.backup_btn = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.transactionsTabControl.SuspendLayout();
            this.cuurent_tab.SuspendLayout();
            this.allTransactions_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.Panel1.Size = new System.Drawing.Size(1166, 43);
            this.Panel1.TabIndex = 438;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(6, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(81, 25);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Settings";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1166, 41);
            this.panel3.TabIndex = 439;
            // 
            // transactionsTabControl
            // 
            this.transactionsTabControl.Controls.Add(this.cuurent_tab);
            this.transactionsTabControl.Controls.Add(this.allTransactions_tab);
            this.transactionsTabControl.Controls.Add(this.tabPage1);
            this.transactionsTabControl.Controls.Add(this.tabPage2);
            this.transactionsTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.transactionsTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsTabControl.Location = new System.Drawing.Point(0, 84);
            this.transactionsTabControl.Name = "transactionsTabControl";
            this.transactionsTabControl.SelectedIndex = 0;
            this.transactionsTabControl.Size = new System.Drawing.Size(1166, 607);
            this.transactionsTabControl.TabIndex = 440;
            // 
            // cuurent_tab
            // 
            this.cuurent_tab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cuurent_tab.Controls.Add(this.panel6);
            this.cuurent_tab.Location = new System.Drawing.Point(4, 29);
            this.cuurent_tab.Name = "cuurent_tab";
            this.cuurent_tab.Padding = new System.Windows.Forms.Padding(3);
            this.cuurent_tab.Size = new System.Drawing.Size(1158, 574);
            this.cuurent_tab.TabIndex = 0;
            this.cuurent_tab.Text = "         Users           ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(5, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 5);
            this.panel6.TabIndex = 5;
            // 
            // allTransactions_tab
            // 
            this.allTransactions_tab.Controls.Add(this.panel7);
            this.allTransactions_tab.Location = new System.Drawing.Point(4, 29);
            this.allTransactions_tab.Name = "allTransactions_tab";
            this.allTransactions_tab.Padding = new System.Windows.Forms.Padding(3);
            this.allTransactions_tab.Size = new System.Drawing.Size(1158, 574);
            this.allTransactions_tab.TabIndex = 1;
            this.allTransactions_tab.Text = "          Banks         ";
            this.allTransactions_tab.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(134, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(120, 5);
            this.panel7.TabIndex = 6;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 691);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1166, 3);
            this.panel10.TabIndex = 460;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1158, 574);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "     Unit Of Measures      ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.restore_btn);
            this.tabPage2.Controls.Add(this.backup_btn);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1158, 574);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "    Database Settings   ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(262, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 5);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(438, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 5);
            this.panel4.TabIndex = 7;
            // 
            // restore_btn
            // 
            this.restore_btn.BackColor = System.Drawing.Color.White;
            this.restore_btn.FlatAppearance.BorderSize = 0;
            this.restore_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restore_btn.Image = ((System.Drawing.Image)(resources.GetObject("restore_btn.Image")));
            this.restore_btn.Location = new System.Drawing.Point(167, 19);
            this.restore_btn.Name = "restore_btn";
            this.restore_btn.Size = new System.Drawing.Size(108, 105);
            this.restore_btn.TabIndex = 450;
            this.restore_btn.Text = "Restore";
            this.restore_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.restore_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.restore_btn.UseVisualStyleBackColor = false;
            // 
            // backup_btn
            // 
            this.backup_btn.BackColor = System.Drawing.Color.White;
            this.backup_btn.FlatAppearance.BorderSize = 0;
            this.backup_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backup_btn.Image = ((System.Drawing.Image)(resources.GetObject("backup_btn.Image")));
            this.backup_btn.Location = new System.Drawing.Point(25, 19);
            this.backup_btn.Name = "backup_btn";
            this.backup_btn.Size = new System.Drawing.Size(108, 105);
            this.backup_btn.TabIndex = 449;
            this.backup_btn.Text = "Bakcup";
            this.backup_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backup_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.backup_btn.UseVisualStyleBackColor = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1166, 694);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.transactionsTabControl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.transactionsTabControl.ResumeLayout(false);
            this.cuurent_tab.ResumeLayout(false);
            this.allTransactions_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl transactionsTabControl;
        private System.Windows.Forms.TabPage cuurent_tab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage allTransactions_tab;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button restore_btn;
        private System.Windows.Forms.Button backup_btn;
    }
}