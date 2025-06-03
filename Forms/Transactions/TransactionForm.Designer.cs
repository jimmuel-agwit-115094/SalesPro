namespace SalesPro.Forms.Transactions
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.find_btn = new System.Windows.Forms.Button();
            this.date_cb = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.new_btn = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.noRecordDate_lbl = new System.Windows.Forms.Label();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgTrans = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.transactionDate_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.noTransactionPanel = new System.Windows.Forms.Panel();
            this.notifHeader_lbl = new System.Windows.Forms.Label();
            this.unclosed_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrans)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.noTransactionPanel.SuspendLayout();
            this.unclosed_panel.SuspendLayout();
            this.SuspendLayout();
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
            this.find_btn.Location = new System.Drawing.Point(312, 17);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(110, 25);
            this.find_btn.TabIndex = 485;
            this.find_btn.Text = "  Find";
            this.find_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.find_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.find_btn.UseVisualStyleBackColor = false;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // date_cb
            // 
            this.date_cb.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.date_cb.CustomFormat = "MMMM dd, yyyy";
            this.date_cb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_cb.Location = new System.Drawing.Point(64, 17);
            this.date_cb.Name = "date_cb";
            this.date_cb.Size = new System.Drawing.Size(235, 25);
            this.date_cb.TabIndex = 488;
            this.date_cb.ValueChanged += new System.EventHandler(this.date_cb_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.unclosed_panel);
            this.panel3.Controls.Add(this.new_btn);
            this.panel3.Controls.Add(this.noTransactionPanel);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1208, 57);
            this.panel3.TabIndex = 436;
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
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(6, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(117, 25);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Transactions";
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
            this.Panel1.TabIndex = 435;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1204, 505);
            this.panel8.TabIndex = 438;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Controls.Add(this.noRecordDate_lbl);
            this.panel10.Controls.Add(this.notFound_lbl);
            this.panel10.Controls.Add(this.dgTrans);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 40);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1204, 465);
            this.panel10.TabIndex = 459;
            // 
            // noRecordDate_lbl
            // 
            this.noRecordDate_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.noRecordDate_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRecordDate_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.noRecordDate_lbl.Location = new System.Drawing.Point(348, 294);
            this.noRecordDate_lbl.Name = "noRecordDate_lbl";
            this.noRecordDate_lbl.Size = new System.Drawing.Size(437, 26);
            this.noRecordDate_lbl.TabIndex = 459;
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
            this.notFound_lbl.Location = new System.Drawing.Point(481, 256);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 458;
            this.notFound_lbl.Text = "No Record";
            this.notFound_lbl.Visible = false;
            // 
            // dgTrans
            // 
            this.dgTrans.AllowUserToAddRows = false;
            this.dgTrans.AllowUserToDeleteRows = false;
            this.dgTrans.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgTrans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTrans.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgTrans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgTrans.ColumnHeadersHeight = 30;
            this.dgTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTrans.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTrans.EnableHeadersVisualStyles = false;
            this.dgTrans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgTrans.Location = new System.Drawing.Point(0, 0);
            this.dgTrans.MultiSelect = false;
            this.dgTrans.Name = "dgTrans";
            this.dgTrans.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTrans.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgTrans.RowHeadersVisible = false;
            this.dgTrans.RowHeadersWidth = 51;
            this.dgTrans.RowTemplate.Height = 32;
            this.dgTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTrans.Size = new System.Drawing.Size(1204, 465);
            this.dgTrans.TabIndex = 457;
            this.dgTrans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTrans_CellContentClick);
            this.dgTrans.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgTrans_CellFormatting);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Controls.Add(this.refresh_btn);
            this.panel9.Controls.Add(this.transactionDate_lbl);
            this.panel9.Controls.Add(this.pictureBox1);
            this.panel9.Controls.Add(this.search_tx);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1204, 40);
            this.panel9.TabIndex = 458;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btn.Image")));
            this.refresh_btn.Location = new System.Drawing.Point(631, 5);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(120, 30);
            this.refresh_btn.TabIndex = 435;
            this.refresh_btn.Text = " Refresh";
            this.refresh_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refresh_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // transactionDate_lbl
            // 
            this.transactionDate_lbl.AutoSize = true;
            this.transactionDate_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDate_lbl.ForeColor = System.Drawing.Color.Black;
            this.transactionDate_lbl.Location = new System.Drawing.Point(9, 11);
            this.transactionDate_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.transactionDate_lbl.Name = "transactionDate_lbl";
            this.transactionDate_lbl.Size = new System.Drawing.Size(83, 17);
            this.transactionDate_lbl.TabIndex = 434;
            this.transactionDate_lbl.Text = "Transactions";
            this.transactionDate_lbl.Visible = false;
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
            this.search_tx.TextChanged += new System.EventHandler(this.search_tx_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 100);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(2);
            this.panel5.Size = new System.Drawing.Size(1208, 509);
            this.panel5.TabIndex = 437;
            // 
            // noTransactionPanel
            // 
            this.noTransactionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.noTransactionPanel.Controls.Add(this.label3);
            this.noTransactionPanel.Controls.Add(this.notifHeader_lbl);
            this.noTransactionPanel.ForeColor = System.Drawing.Color.Red;
            this.noTransactionPanel.Location = new System.Drawing.Point(153, 4);
            this.noTransactionPanel.Name = "noTransactionPanel";
            this.noTransactionPanel.Size = new System.Drawing.Size(218, 47);
            this.noTransactionPanel.TabIndex = 546;
            // 
            // notifHeader_lbl
            // 
            this.notifHeader_lbl.AutoSize = true;
            this.notifHeader_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.notifHeader_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.notifHeader_lbl.Location = new System.Drawing.Point(11, 6);
            this.notifHeader_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.notifHeader_lbl.Name = "notifHeader_lbl";
            this.notifHeader_lbl.Size = new System.Drawing.Size(141, 17);
            this.notifHeader_lbl.TabIndex = 539;
            this.notifHeader_lbl.Text = "No Daily Transaction ";
            // 
            // unclosed_panel
            // 
            this.unclosed_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.unclosed_panel.Controls.Add(this.label1);
            this.unclosed_panel.Controls.Add(this.label2);
            this.unclosed_panel.ForeColor = System.Drawing.Color.Red;
            this.unclosed_panel.Location = new System.Drawing.Point(153, 4);
            this.unclosed_panel.Name = "unclosed_panel";
            this.unclosed_panel.Size = new System.Drawing.Size(533, 47);
            this.unclosed_panel.TabIndex = 547;
            this.unclosed_panel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 17);
            this.label1.TabIndex = 495;
            this.label1.Text = "A previous transaction is still open. Please close it before starting a new one f" +
    "or today.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 539;
            this.label2.Text = "Unclosed Transaction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(11, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 17);
            this.label3.TabIndex = 545;
            this.label3.Text = "Please create a new transaction";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1208, 609);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrans)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.noTransactionPanel.ResumeLayout(false);
            this.noTransactionPanel.PerformLayout();
            this.unclosed_panel.ResumeLayout(false);
            this.unclosed_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button new_btn;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.DateTimePicker date_cb;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label noRecordDate_lbl;
        private System.Windows.Forms.Label notFound_lbl;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox search_tx;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.DataGridView dgTrans;
        internal System.Windows.Forms.Label transactionDate_lbl;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Panel noTransactionPanel;
        private System.Windows.Forms.Label notifHeader_lbl;
        private System.Windows.Forms.Panel unclosed_panel;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}