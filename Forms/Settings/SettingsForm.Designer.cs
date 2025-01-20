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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.transactionsTabControl = new System.Windows.Forms.TabControl();
            this.userTab = new System.Windows.Forms.TabPage();
            this.noRecordUser = new System.Windows.Forms.Label();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bankTab = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.unitOfMeasureTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.databaseTab = new System.Windows.Forms.TabPage();
            this.restore_btn = new System.Windows.Forms.Button();
            this.backup_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.Panel1.SuspendLayout();
            this.transactionsTabControl.SuspendLayout();
            this.userTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.bankTab.SuspendLayout();
            this.unitOfMeasureTab.SuspendLayout();
            this.databaseTab.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.transactionsTabControl.Controls.Add(this.userTab);
            this.transactionsTabControl.Controls.Add(this.bankTab);
            this.transactionsTabControl.Controls.Add(this.unitOfMeasureTab);
            this.transactionsTabControl.Controls.Add(this.databaseTab);
            this.transactionsTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.transactionsTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsTabControl.Location = new System.Drawing.Point(0, 84);
            this.transactionsTabControl.Name = "transactionsTabControl";
            this.transactionsTabControl.SelectedIndex = 0;
            this.transactionsTabControl.Size = new System.Drawing.Size(1166, 607);
            this.transactionsTabControl.TabIndex = 440;
            // 
            // userTab
            // 
            this.userTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userTab.Controls.Add(this.panel5);
            this.userTab.Controls.Add(this.noRecordUser);
            this.userTab.Controls.Add(this.dgUsers);
            this.userTab.Controls.Add(this.panel6);
            this.userTab.Location = new System.Drawing.Point(4, 29);
            this.userTab.Name = "userTab";
            this.userTab.Padding = new System.Windows.Forms.Padding(3);
            this.userTab.Size = new System.Drawing.Size(1158, 574);
            this.userTab.TabIndex = 0;
            this.userTab.Text = "         Users           ";
            // 
            // noRecordUser
            // 
            this.noRecordUser.AutoSize = true;
            this.noRecordUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.noRecordUser.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRecordUser.ForeColor = System.Drawing.Color.IndianRed;
            this.noRecordUser.Location = new System.Drawing.Point(475, 260);
            this.noRecordUser.Name = "noRecordUser";
            this.noRecordUser.Size = new System.Drawing.Size(174, 45);
            this.noRecordUser.TabIndex = 459;
            this.noRecordUser.Text = "No Record";
            this.noRecordUser.Visible = false;
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.AllowUserToDeleteRows = false;
            this.dgUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgUsers.ColumnHeadersHeight = 30;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgUsers.EnableHeadersVisualStyles = false;
            this.dgUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgUsers.Location = new System.Drawing.Point(3, 55);
            this.dgUsers.MultiSelect = false;
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.ReadOnly = true;
            this.dgUsers.RowHeadersVisible = false;
            this.dgUsers.RowHeadersWidth = 51;
            this.dgUsers.RowTemplate.Height = 32;
            this.dgUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsers.Size = new System.Drawing.Size(1149, 513);
            this.dgUsers.TabIndex = 458;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(5, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 5);
            this.panel6.TabIndex = 5;
            // 
            // bankTab
            // 
            this.bankTab.Controls.Add(this.panel7);
            this.bankTab.Location = new System.Drawing.Point(4, 29);
            this.bankTab.Name = "bankTab";
            this.bankTab.Padding = new System.Windows.Forms.Padding(3);
            this.bankTab.Size = new System.Drawing.Size(1158, 574);
            this.bankTab.TabIndex = 1;
            this.bankTab.Text = "          Banks         ";
            this.bankTab.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(132, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(120, 5);
            this.panel7.TabIndex = 6;
            // 
            // unitOfMeasureTab
            // 
            this.unitOfMeasureTab.Controls.Add(this.panel2);
            this.unitOfMeasureTab.Location = new System.Drawing.Point(4, 29);
            this.unitOfMeasureTab.Name = "unitOfMeasureTab";
            this.unitOfMeasureTab.Padding = new System.Windows.Forms.Padding(3);
            this.unitOfMeasureTab.Size = new System.Drawing.Size(1158, 574);
            this.unitOfMeasureTab.TabIndex = 2;
            this.unitOfMeasureTab.Text = "     Unit Of Measures      ";
            this.unitOfMeasureTab.UseVisualStyleBackColor = true;
            this.unitOfMeasureTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(262, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 5);
            this.panel2.TabIndex = 7;
            // 
            // databaseTab
            // 
            this.databaseTab.Controls.Add(this.restore_btn);
            this.databaseTab.Controls.Add(this.backup_btn);
            this.databaseTab.Controls.Add(this.panel4);
            this.databaseTab.Location = new System.Drawing.Point(4, 29);
            this.databaseTab.Name = "databaseTab";
            this.databaseTab.Padding = new System.Windows.Forms.Padding(3);
            this.databaseTab.Size = new System.Drawing.Size(1158, 574);
            this.databaseTab.TabIndex = 3;
            this.databaseTab.Text = "    Database Settings   ";
            this.databaseTab.UseVisualStyleBackColor = true;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(438, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 5);
            this.panel4.TabIndex = 7;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.search_tx);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1152, 46);
            this.panel5.TabIndex = 460;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1123, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 435;
            this.pictureBox1.TabStop = false;
            // 
            // search_tx
            // 
            this.search_tx.BackColor = System.Drawing.Color.White;
            this.search_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tx.Location = new System.Drawing.Point(761, 10);
            this.search_tx.Margin = new System.Windows.Forms.Padding(2);
            this.search_tx.Name = "search_tx";
            this.search_tx.Size = new System.Drawing.Size(389, 27);
            this.search_tx.TabIndex = 434;
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
            this.userTab.ResumeLayout(false);
            this.userTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.bankTab.ResumeLayout(false);
            this.unitOfMeasureTab.ResumeLayout(false);
            this.databaseTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl transactionsTabControl;
        private System.Windows.Forms.TabPage userTab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage bankTab;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TabPage unitOfMeasureTab;
        private System.Windows.Forms.TabPage databaseTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button restore_btn;
        private System.Windows.Forms.Button backup_btn;
        internal System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Label noRecordUser;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox search_tx;
    }
}