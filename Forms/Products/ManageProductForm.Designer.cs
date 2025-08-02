namespace SalesPro.Forms.Products
{
    partial class ManageProductForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unit_cb = new System.Windows.Forms.ComboBox();
            this.reorder_tx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.desc_tx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.barCode_tx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productName_tx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.logs_link = new System.Windows.Forms.LinkLabel();
            this.subUnit_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subUnit_cb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.unit_cb);
            this.groupBox1.Controls.Add(this.reorder_tx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.desc_tx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.barCode_tx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.productName_tx);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(16, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 292);
            this.groupBox1.TabIndex = 549;
            this.groupBox1.TabStop = false;
            // 
            // unit_cb
            // 
            this.unit_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unit_cb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_cb.FormattingEnabled = true;
            this.unit_cb.Location = new System.Drawing.Point(128, 86);
            this.unit_cb.Name = "unit_cb";
            this.unit_cb.Size = new System.Drawing.Size(277, 25);
            this.unit_cb.TabIndex = 540;
            // 
            // reorder_tx
            // 
            this.reorder_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorder_tx.Location = new System.Drawing.Point(128, 249);
            this.reorder_tx.MaxLength = 8;
            this.reorder_tx.Name = "reorder_tx";
            this.reorder_tx.Size = new System.Drawing.Size(277, 25);
            this.reorder_tx.TabIndex = 539;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 538;
            this.label4.Text = "Reorder Level :";
            // 
            // desc_tx
            // 
            this.desc_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_tx.Location = new System.Drawing.Point(128, 155);
            this.desc_tx.Multiline = true;
            this.desc_tx.Name = "desc_tx";
            this.desc_tx.Size = new System.Drawing.Size(277, 88);
            this.desc_tx.TabIndex = 537;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 536;
            this.label3.Text = "Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 534;
            this.label2.Text = "Unit Of Measure :";
            // 
            // barCode_tx
            // 
            this.barCode_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.barCode_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barCode_tx.Location = new System.Drawing.Point(128, 53);
            this.barCode_tx.MaxLength = 15;
            this.barCode_tx.Name = "barCode_tx";
            this.barCode_tx.Size = new System.Drawing.Size(277, 25);
            this.barCode_tx.TabIndex = 533;
            this.barCode_tx.TextChanged += new System.EventHandler(this.barCode_tx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 532;
            this.label1.Text = "Bar Code :";
            // 
            // productName_tx
            // 
            this.productName_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName_tx.Location = new System.Drawing.Point(128, 20);
            this.productName_tx.Name = "productName_tx";
            this.productName_tx.Size = new System.Drawing.Size(277, 25);
            this.productName_tx.TabIndex = 531;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 530;
            this.label8.Text = "Product Name :";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(11, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(126, 28);
            this.title_lbl.TabIndex = 550;
            this.title_lbl.Text = "Add Product";
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Green;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(297, 360);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(140, 34);
            this.save_btn.TabIndex = 551;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // logs_link
            // 
            this.logs_link.AutoSize = true;
            this.logs_link.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs_link.Location = new System.Drawing.Point(294, 16);
            this.logs_link.Name = "logs_link";
            this.logs_link.Size = new System.Drawing.Size(146, 17);
            this.logs_link.TabIndex = 552;
            this.logs_link.TabStop = true;
            this.logs_link.Text = "Product Change History";
            this.logs_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logs_link_LinkClicked);
            // 
            // subUnit_cb
            // 
            this.subUnit_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subUnit_cb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subUnit_cb.FormattingEnabled = true;
            this.subUnit_cb.Location = new System.Drawing.Point(128, 121);
            this.subUnit_cb.Name = "subUnit_cb";
            this.subUnit_cb.Size = new System.Drawing.Size(277, 25);
            this.subUnit_cb.TabIndex = 542;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 541;
            this.label5.Text = "Sub Unit :";
            // 
            // ManageProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 407);
            this.Controls.Add(this.logs_link);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageProductForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Product";
            this.Load += new System.EventHandler(this.ManageProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox productName_tx;
        private System.Windows.Forms.ComboBox unit_cb;
        private System.Windows.Forms.TextBox reorder_tx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barCode_tx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox desc_tx;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.LinkLabel logs_link;
        private System.Windows.Forms.ComboBox subUnit_cb;
        private System.Windows.Forms.Label label5;
    }
}