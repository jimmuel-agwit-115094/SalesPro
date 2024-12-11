namespace SalesPro.Forms.PurchaseOrders
{
    partial class PurchaseOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.new_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.find_btn = new System.Windows.Forms.Button();
            this.date_cb = new System.Windows.Forms.DateTimePicker();
            this.transactionsTabControl = new System.Windows.Forms.TabControl();
            this.created_tab = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.sent_tab = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.all_tab = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.noRecordDate_lbl = new System.Windows.Forms.Label();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgTrans = new System.Windows.Forms.DataGridView();
            this.Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.transactionsTabControl.SuspendLayout();
            this.created_tab.SuspendLayout();
            this.sent_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.all_tab.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrans)).BeginInit();
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
            this.Panel1.Size = new System.Drawing.Size(1208, 43);
            this.Panel1.TabIndex = 436;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(6, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(151, 25);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Purchase Orders";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.new_btn);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1208, 57);
            this.panel3.TabIndex = 437;
            // 
            // new_btn
            // 
            this.new_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.new_btn.FlatAppearance.BorderSize = 0;
            this.new_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_btn.ForeColor = System.Drawing.Color.White;
            this.new_btn.Location = new System.Drawing.Point(9, 13);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(128, 33);
            this.new_btn.TabIndex = 494;
            this.new_btn.Text = "New ";
            this.new_btn.UseVisualStyleBackColor = false;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.find_btn);
            this.panel4.Controls.Add(this.date_cb);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(772, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(434, 55);
            this.panel4.TabIndex = 0;
            // 
            // find_btn
            // 
            this.find_btn.BackColor = System.Drawing.Color.Green;
            this.find_btn.FlatAppearance.BorderSize = 0;
            this.find_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_btn.ForeColor = System.Drawing.Color.White;
            this.find_btn.Image = ((System.Drawing.Image)(resources.GetObject("find_btn.Image")));
            this.find_btn.Location = new System.Drawing.Point(286, 19);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(142, 28);
            this.find_btn.TabIndex = 485;
            this.find_btn.Text = "  Find";
            this.find_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.find_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.find_btn.UseVisualStyleBackColor = false;
            // 
            // date_cb
            // 
            this.date_cb.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.date_cb.CustomFormat = "MMMM dd, yyyy";
            this.date_cb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_cb.Location = new System.Drawing.Point(45, 20);
            this.date_cb.Name = "date_cb";
            this.date_cb.Size = new System.Drawing.Size(235, 27);
            this.date_cb.TabIndex = 488;
            // 
            // transactionsTabControl
            // 
            this.transactionsTabControl.Controls.Add(this.created_tab);
            this.transactionsTabControl.Controls.Add(this.sent_tab);
            this.transactionsTabControl.Controls.Add(this.tabPage1);
            this.transactionsTabControl.Controls.Add(this.tabPage2);
            this.transactionsTabControl.Controls.Add(this.all_tab);
            this.transactionsTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.transactionsTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsTabControl.Location = new System.Drawing.Point(0, 100);
            this.transactionsTabControl.Name = "transactionsTabControl";
            this.transactionsTabControl.SelectedIndex = 0;
            this.transactionsTabControl.Size = new System.Drawing.Size(1208, 38);
            this.transactionsTabControl.TabIndex = 438;
            // 
            // created_tab
            // 
            this.created_tab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.created_tab.Controls.Add(this.panel6);
            this.created_tab.Location = new System.Drawing.Point(4, 29);
            this.created_tab.Name = "created_tab";
            this.created_tab.Padding = new System.Windows.Forms.Padding(3);
            this.created_tab.Size = new System.Drawing.Size(1200, 5);
            this.created_tab.TabIndex = 0;
            this.created_tab.Text = "            Created          ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(-1, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 5);
            this.panel6.TabIndex = 5;
            // 
            // sent_tab
            // 
            this.sent_tab.Controls.Add(this.panel7);
            this.sent_tab.Location = new System.Drawing.Point(4, 29);
            this.sent_tab.Name = "sent_tab";
            this.sent_tab.Padding = new System.Windows.Forms.Padding(3);
            this.sent_tab.Size = new System.Drawing.Size(1200, 5);
            this.sent_tab.TabIndex = 1;
            this.sent_tab.Text = "   Sent To Supplier  ";
            this.sent_tab.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(152, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 5);
            this.panel7.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1200, 5);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "       Completed       ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(295, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 5);
            this.panel2.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1200, 5);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "        Cancelled       ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(435, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(140, 5);
            this.panel5.TabIndex = 8;
            // 
            // all_tab
            // 
            this.all_tab.Controls.Add(this.panel8);
            this.all_tab.Location = new System.Drawing.Point(4, 29);
            this.all_tab.Name = "all_tab";
            this.all_tab.Padding = new System.Windows.Forms.Padding(3);
            this.all_tab.Size = new System.Drawing.Size(1200, 5);
            this.all_tab.TabIndex = 4;
            this.all_tab.Text = "All Purchase Order";
            this.all_tab.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Green;
            this.panel8.Location = new System.Drawing.Point(574, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(140, 5);
            this.panel8.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Controls.Add(this.pictureBox1);
            this.panel9.Controls.Add(this.search_tx);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 138);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1208, 40);
            this.panel9.TabIndex = 459;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1134, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 433;
            this.pictureBox1.TabStop = false;
            // 
            // search_tx
            // 
            this.search_tx.BackColor = System.Drawing.Color.White;
            this.search_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tx.Location = new System.Drawing.Point(772, 7);
            this.search_tx.Margin = new System.Windows.Forms.Padding(2);
            this.search_tx.Name = "search_tx";
            this.search_tx.Size = new System.Drawing.Size(389, 27);
            this.search_tx.TabIndex = 386;
            // 
            // noRecordDate_lbl
            // 
            this.noRecordDate_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.noRecordDate_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRecordDate_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.noRecordDate_lbl.Location = new System.Drawing.Point(333, 408);
            this.noRecordDate_lbl.Name = "noRecordDate_lbl";
            this.noRecordDate_lbl.Size = new System.Drawing.Size(437, 26);
            this.noRecordDate_lbl.TabIndex = 462;
            this.noRecordDate_lbl.Text = "No Record";
            this.noRecordDate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noRecordDate_lbl.Visible = false;
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(466, 370);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 461;
            this.notFound_lbl.Text = "No Record";
            this.notFound_lbl.Visible = false;
            // 
            // dgTrans
            // 
            this.dgTrans.AllowUserToAddRows = false;
            this.dgTrans.AllowUserToDeleteRows = false;
            this.dgTrans.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgTrans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTrans.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgTrans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTrans.ColumnHeadersHeight = 30;
            this.dgTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTrans.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTrans.EnableHeadersVisualStyles = false;
            this.dgTrans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgTrans.Location = new System.Drawing.Point(0, 178);
            this.dgTrans.MultiSelect = false;
            this.dgTrans.Name = "dgTrans";
            this.dgTrans.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTrans.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgTrans.RowHeadersVisible = false;
            this.dgTrans.RowHeadersWidth = 51;
            this.dgTrans.RowTemplate.Height = 32;
            this.dgTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTrans.Size = new System.Drawing.Size(1208, 431);
            this.dgTrans.TabIndex = 460;
            // 
            // PurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 609);
            this.Controls.Add(this.noRecordDate_lbl);
            this.Controls.Add(this.notFound_lbl);
            this.Controls.Add(this.dgTrans);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.transactionsTabControl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrderForm";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.transactionsTabControl.ResumeLayout(false);
            this.created_tab.ResumeLayout(false);
            this.sent_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.all_tab.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.DateTimePicker date_cb;
        private System.Windows.Forms.TabControl transactionsTabControl;
        private System.Windows.Forms.TabPage created_tab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage sent_tab;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox search_tx;
        private System.Windows.Forms.Label noRecordDate_lbl;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgTrans;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabPage all_tab;
        private System.Windows.Forms.Panel panel8;
    }
}