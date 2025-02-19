namespace SalesPro.Forms.Settings
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.save_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pin_tx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password_tx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username_tx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fullname_tx = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userTabControl = new System.Windows.Forms.TabControl();
            this.userTab = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rolesTab = new System.Windows.Forms.TabPage();
            this.updateRole_btn = new System.Windows.Forms.Button();
            this.noRecordlbl = new System.Windows.Forms.Label();
            this.dgRoles = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.userTabControl.SuspendLayout();
            this.userTab.SuspendLayout();
            this.rolesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Green;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(287, 384);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(140, 34);
            this.save_btn.TabIndex = 571;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pin_tx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.password_tx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.username_tx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fullname_tx);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(97, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 268);
            this.groupBox1.TabIndex = 570;
            this.groupBox1.TabStop = false;
            // 
            // pin_tx
            // 
            this.pin_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.pin_tx.Location = new System.Drawing.Point(14, 224);
            this.pin_tx.MaxLength = 4;
            this.pin_tx.Name = "pin_tx";
            this.pin_tx.Size = new System.Drawing.Size(303, 27);
            this.pin_tx.TabIndex = 572;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 571;
            this.label2.Text = "PIN";
            // 
            // password_tx
            // 
            this.password_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.password_tx.Location = new System.Drawing.Point(14, 162);
            this.password_tx.MaxLength = 25;
            this.password_tx.Name = "password_tx";
            this.password_tx.Size = new System.Drawing.Size(303, 27);
            this.password_tx.TabIndex = 564;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 563;
            this.label3.Text = "Password";
            // 
            // username_tx
            // 
            this.username_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.username_tx.Location = new System.Drawing.Point(14, 100);
            this.username_tx.MaxLength = 25;
            this.username_tx.Name = "username_tx";
            this.username_tx.Size = new System.Drawing.Size(303, 27);
            this.username_tx.TabIndex = 562;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 561;
            this.label1.Text = "Username";
            // 
            // fullname_tx
            // 
            this.fullname_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.fullname_tx.Location = new System.Drawing.Point(14, 39);
            this.fullname_tx.MaxLength = 25;
            this.fullname_tx.Name = "fullname_tx";
            this.fullname_tx.Size = new System.Drawing.Size(303, 27);
            this.fullname_tx.TabIndex = 560;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 559;
            this.label13.Text = "Fullname";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 577;
            this.pictureBox1.TabStop = false;
            // 
            // userTabControl
            // 
            this.userTabControl.Controls.Add(this.userTab);
            this.userTabControl.Controls.Add(this.rolesTab);
            this.userTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTabControl.Location = new System.Drawing.Point(16, 42);
            this.userTabControl.Name = "userTabControl";
            this.userTabControl.SelectedIndex = 0;
            this.userTabControl.Size = new System.Drawing.Size(529, 627);
            this.userTabControl.TabIndex = 578;
            // 
            // userTab
            // 
            this.userTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userTab.Controls.Add(this.panel6);
            this.userTab.Controls.Add(this.save_btn);
            this.userTab.Controls.Add(this.pictureBox1);
            this.userTab.Controls.Add(this.groupBox1);
            this.userTab.Location = new System.Drawing.Point(4, 29);
            this.userTab.Name = "userTab";
            this.userTab.Padding = new System.Windows.Forms.Padding(3);
            this.userTab.Size = new System.Drawing.Size(521, 594);
            this.userTab.TabIndex = 0;
            this.userTab.Text = "      Users Data     ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(5, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 5);
            this.panel6.TabIndex = 5;
            // 
            // rolesTab
            // 
            this.rolesTab.Controls.Add(this.pictureBox2);
            this.rolesTab.Controls.Add(this.search_tx);
            this.rolesTab.Controls.Add(this.updateRole_btn);
            this.rolesTab.Controls.Add(this.noRecordlbl);
            this.rolesTab.Controls.Add(this.dgRoles);
            this.rolesTab.Controls.Add(this.panel7);
            this.rolesTab.Location = new System.Drawing.Point(4, 29);
            this.rolesTab.Name = "rolesTab";
            this.rolesTab.Padding = new System.Windows.Forms.Padding(3);
            this.rolesTab.Size = new System.Drawing.Size(521, 594);
            this.rolesTab.TabIndex = 1;
            this.rolesTab.Text = "           Roles         ";
            this.rolesTab.UseVisualStyleBackColor = true;
            // 
            // updateRole_btn
            // 
            this.updateRole_btn.BackColor = System.Drawing.Color.Green;
            this.updateRole_btn.FlatAppearance.BorderSize = 0;
            this.updateRole_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateRole_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRole_btn.ForeColor = System.Drawing.Color.White;
            this.updateRole_btn.Location = new System.Drawing.Point(375, 554);
            this.updateRole_btn.Name = "updateRole_btn";
            this.updateRole_btn.Size = new System.Drawing.Size(140, 34);
            this.updateRole_btn.TabIndex = 572;
            this.updateRole_btn.Text = "Update Roles";
            this.updateRole_btn.UseVisualStyleBackColor = false;
            this.updateRole_btn.Click += new System.EventHandler(this.updateRole_btn_Click);
            // 
            // noRecordlbl
            // 
            this.noRecordlbl.AutoSize = true;
            this.noRecordlbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.noRecordlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRecordlbl.ForeColor = System.Drawing.Color.IndianRed;
            this.noRecordlbl.Location = new System.Drawing.Point(134, 279);
            this.noRecordlbl.Name = "noRecordlbl";
            this.noRecordlbl.Size = new System.Drawing.Size(174, 45);
            this.noRecordlbl.TabIndex = 463;
            this.noRecordlbl.Text = "No Record";
            this.noRecordlbl.Visible = false;
            // 
            // dgRoles
            // 
            this.dgRoles.AllowUserToAddRows = false;
            this.dgRoles.AllowUserToDeleteRows = false;
            this.dgRoles.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRoles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgRoles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgRoles.ColumnHeadersHeight = 30;
            this.dgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRoles.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgRoles.EnableHeadersVisualStyles = false;
            this.dgRoles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgRoles.Location = new System.Drawing.Point(6, 46);
            this.dgRoles.MultiSelect = false;
            this.dgRoles.Name = "dgRoles";
            this.dgRoles.ReadOnly = true;
            this.dgRoles.RowHeadersVisible = false;
            this.dgRoles.RowHeadersWidth = 51;
            this.dgRoles.RowTemplate.Height = 32;
            this.dgRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRoles.Size = new System.Drawing.Size(509, 488);
            this.dgRoles.TabIndex = 462;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(127, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(130, 5);
            this.panel7.TabIndex = 6;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(11, 6);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(81, 25);
            this.title_lbl.TabIndex = 579;
            this.title_lbl.Text = "Settings";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(487, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 574;
            this.pictureBox2.TabStop = false;
            // 
            // search_tx
            // 
            this.search_tx.BackColor = System.Drawing.Color.White;
            this.search_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tx.Location = new System.Drawing.Point(203, 14);
            this.search_tx.Margin = new System.Windows.Forms.Padding(2);
            this.search_tx.Name = "search_tx";
            this.search_tx.Size = new System.Drawing.Size(312, 27);
            this.search_tx.TabIndex = 573;
            this.search_tx.TextChanged += new System.EventHandler(this.search_tx_TextChanged);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 675);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.userTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.userTabControl.ResumeLayout(false);
            this.userTab.ResumeLayout(false);
            this.rolesTab.ResumeLayout(false);
            this.rolesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox password_tx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_tx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullname_tx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox pin_tx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl userTabControl;
        private System.Windows.Forms.TabPage userTab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage rolesTab;
        private System.Windows.Forms.Label noRecordlbl;
        private System.Windows.Forms.Panel panel7;
        internal System.Windows.Forms.Label title_lbl;
        internal System.Windows.Forms.DataGridView dgRoles;
        private System.Windows.Forms.Button updateRole_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.TextBox search_tx;
    }
}