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
            this.save_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.access_cb = new System.Windows.Forms.ComboBox();
            this.pin_tx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.password_tx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username_tx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fullname_tx = new System.Windows.Forms.TextBox();
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
            this.save_btn.Location = new System.Drawing.Point(206, 399);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(140, 34);
            this.save_btn.TabIndex = 571;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.access_cb);
            this.groupBox1.Controls.Add(this.pin_tx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.password_tx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.username_tx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fullname_tx);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(16, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 332);
            this.groupBox1.TabIndex = 570;
            this.groupBox1.TabStop = false;
            // 
            // access_cb
            // 
            this.access_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.access_cb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.access_cb.FormattingEnabled = true;
            this.access_cb.Location = new System.Drawing.Point(14, 289);
            this.access_cb.Name = "access_cb";
            this.access_cb.Size = new System.Drawing.Size(303, 28);
            this.access_cb.TabIndex = 573;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 567;
            this.label6.Text = "User Access";
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
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(13, 11);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(96, 25);
            this.title_lbl.TabIndex = 572;
            this.title_lbl.Text = "User Data";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 451);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_lbl);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password_tx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_tx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullname_tx;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.ComboBox access_cb;
        private System.Windows.Forms.TextBox pin_tx;
        private System.Windows.Forms.Label label2;
    }
}