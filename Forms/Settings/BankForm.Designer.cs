namespace SalesPro.Forms.Settings
{
    partial class BankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankForm));
            this.save_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bankType_cb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bankName_tx = new System.Windows.Forms.TextBox();
            this.address_tx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contact_tx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Green;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(207, 342);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(140, 34);
            this.save_btn.TabIndex = 574;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contact_tx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.address_tx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bankType_cb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bankName_tx);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(17, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 265);
            this.groupBox1.TabIndex = 573;
            this.groupBox1.TabStop = false;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(14, 12);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(100, 25);
            this.title_lbl.TabIndex = 575;
            this.title_lbl.Text = "Bank Data";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(317, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 576;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 567;
            this.label6.Text = "Bank Type";
            // 
            // bankType_cb
            // 
            this.bankType_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankType_cb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankType_cb.FormattingEnabled = true;
            this.bankType_cb.Location = new System.Drawing.Point(14, 99);
            this.bankType_cb.Name = "bankType_cb";
            this.bankType_cb.Size = new System.Drawing.Size(303, 28);
            this.bankType_cb.TabIndex = 573;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 17);
            this.label13.TabIndex = 559;
            this.label13.Text = "Bank Name";
            // 
            // bankName_tx
            // 
            this.bankName_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bankName_tx.Location = new System.Drawing.Point(14, 39);
            this.bankName_tx.MaxLength = 25;
            this.bankName_tx.Name = "bankName_tx";
            this.bankName_tx.Size = new System.Drawing.Size(303, 27);
            this.bankName_tx.TabIndex = 560;
            // 
            // address_tx
            // 
            this.address_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.address_tx.Location = new System.Drawing.Point(14, 156);
            this.address_tx.MaxLength = 25;
            this.address_tx.Name = "address_tx";
            this.address_tx.Size = new System.Drawing.Size(303, 27);
            this.address_tx.TabIndex = 575;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 574;
            this.label1.Text = "Address";
            // 
            // contact_tx
            // 
            this.contact_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.contact_tx.Location = new System.Drawing.Point(14, 213);
            this.contact_tx.MaxLength = 25;
            this.contact_tx.Name = "contact_tx";
            this.contact_tx.Size = new System.Drawing.Size(303, 27);
            this.contact_tx.TabIndex = 577;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 576;
            this.label2.Text = "Contact";
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 391);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox bankType_cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contact_tx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address_tx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bankName_tx;
        private System.Windows.Forms.Label label13;
    }
}