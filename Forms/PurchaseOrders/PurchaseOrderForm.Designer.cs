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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cancelledTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cancelledPb = new System.Windows.Forms.PictureBox();
            this.completedPb = new System.Windows.Forms.PictureBox();
            this.sentPb = new System.Windows.Forms.PictureBox();
            this.createdPb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.statusProgress = new System.Windows.Forms.ProgressBar();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgPo = new System.Windows.Forms.DataGridView();
            this.Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.transactionsTabControl.SuspendLayout();
            this.created_tab.SuspendLayout();
            this.sent_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cancelledTab.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancelledPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPo)).BeginInit();
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
            this.find_btn.Location = new System.Drawing.Point(286, 15);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(142, 28);
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
            this.date_cb.Location = new System.Drawing.Point(44, 16);
            this.date_cb.Name = "date_cb";
            this.date_cb.Size = new System.Drawing.Size(236, 25);
            this.date_cb.TabIndex = 488;
            // 
            // transactionsTabControl
            // 
            this.transactionsTabControl.Controls.Add(this.created_tab);
            this.transactionsTabControl.Controls.Add(this.sent_tab);
            this.transactionsTabControl.Controls.Add(this.tabPage1);
            this.transactionsTabControl.Controls.Add(this.cancelledTab);
            this.transactionsTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.transactionsTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsTabControl.Location = new System.Drawing.Point(0, 100);
            this.transactionsTabControl.Name = "transactionsTabControl";
            this.transactionsTabControl.SelectedIndex = 0;
            this.transactionsTabControl.Size = new System.Drawing.Size(1208, 38);
            this.transactionsTabControl.TabIndex = 438;
            this.transactionsTabControl.SelectedIndexChanged += new System.EventHandler(this.transactionsTabControl_SelectedIndexChanged);
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
            // cancelledTab
            // 
            this.cancelledTab.Controls.Add(this.panel5);
            this.cancelledTab.Location = new System.Drawing.Point(4, 29);
            this.cancelledTab.Name = "cancelledTab";
            this.cancelledTab.Padding = new System.Windows.Forms.Padding(3);
            this.cancelledTab.Size = new System.Drawing.Size(1200, 5);
            this.cancelledTab.TabIndex = 3;
            this.cancelledTab.Text = "        Cancelled       ";
            this.cancelledTab.UseVisualStyleBackColor = true;
            this.cancelledTab.Click += new System.EventHandler(this.cancelledTab_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(435, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(140, 5);
            this.panel5.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Controls.Add(this.cancelledPb);
            this.panel9.Controls.Add(this.completedPb);
            this.panel9.Controls.Add(this.sentPb);
            this.panel9.Controls.Add(this.createdPb);
            this.panel9.Controls.Add(this.pictureBox1);
            this.panel9.Controls.Add(this.search_tx);
            this.panel9.Controls.Add(this.statusProgress);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 138);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1208, 40);
            this.panel9.TabIndex = 459;
            // 
            // cancelledPb
            // 
            this.cancelledPb.Image = ((System.Drawing.Image)(resources.GetObject("cancelledPb.Image")));
            this.cancelledPb.Location = new System.Drawing.Point(501, 8);
            this.cancelledPb.Name = "cancelledPb";
            this.cancelledPb.Size = new System.Drawing.Size(20, 20);
            this.cancelledPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cancelledPb.TabIndex = 461;
            this.cancelledPb.TabStop = false;
            // 
            // completedPb
            // 
            this.completedPb.Image = ((System.Drawing.Image)(resources.GetObject("completedPb.Image")));
            this.completedPb.Location = new System.Drawing.Point(357, 8);
            this.completedPb.Name = "completedPb";
            this.completedPb.Size = new System.Drawing.Size(20, 20);
            this.completedPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.completedPb.TabIndex = 460;
            this.completedPb.TabStop = false;
            // 
            // sentPb
            // 
            this.sentPb.Image = ((System.Drawing.Image)(resources.GetObject("sentPb.Image")));
            this.sentPb.Location = new System.Drawing.Point(218, 8);
            this.sentPb.Name = "sentPb";
            this.sentPb.Size = new System.Drawing.Size(20, 20);
            this.sentPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sentPb.TabIndex = 459;
            this.sentPb.TabStop = false;
            // 
            // createdPb
            // 
            this.createdPb.Image = ((System.Drawing.Image)(resources.GetObject("createdPb.Image")));
            this.createdPb.Location = new System.Drawing.Point(73, 8);
            this.createdPb.Name = "createdPb";
            this.createdPb.Size = new System.Drawing.Size(20, 20);
            this.createdPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.createdPb.TabIndex = 458;
            this.createdPb.TabStop = false;
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
            // statusProgress
            // 
            this.statusProgress.Location = new System.Drawing.Point(78, 16);
            this.statusProgress.MarqueeAnimationSpeed = 10;
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(438, 3);
            this.statusProgress.TabIndex = 437;
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(479, 385);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 461;
            this.notFound_lbl.Text = "No Record";
            this.notFound_lbl.Visible = false;
            // 
            // dgPo
            // 
            this.dgPo.AllowUserToAddRows = false;
            this.dgPo.AllowUserToDeleteRows = false;
            this.dgPo.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgPo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dgPo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgPo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgPo.ColumnHeadersHeight = 30;
            this.dgPo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPo.DefaultCellStyle = dataGridViewCellStyle31;
            this.dgPo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPo.EnableHeadersVisualStyles = false;
            this.dgPo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgPo.Location = new System.Drawing.Point(0, 178);
            this.dgPo.MultiSelect = false;
            this.dgPo.Name = "dgPo";
            this.dgPo.ReadOnly = true;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPo.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgPo.RowHeadersVisible = false;
            this.dgPo.RowHeadersWidth = 51;
            this.dgPo.RowTemplate.Height = 32;
            this.dgPo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPo.Size = new System.Drawing.Size(1208, 431);
            this.dgPo.TabIndex = 460;
            this.dgPo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPo_CellContentClick);
            // 
            // PurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 609);
            this.Controls.Add(this.notFound_lbl);
            this.Controls.Add(this.dgPo);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.transactionsTabControl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrderForm";
            this.Load += new System.EventHandler(this.PurchaseOrderForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.transactionsTabControl.ResumeLayout(false);
            this.created_tab.ResumeLayout(false);
            this.sent_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.cancelledTab.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancelledPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPo)).EndInit();
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
        private System.Windows.Forms.TabPage created_tab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage sent_tab;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox search_tx;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgPo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage cancelledTab;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TabControl transactionsTabControl;
        private System.Windows.Forms.PictureBox completedPb;
        private System.Windows.Forms.PictureBox sentPb;
        private System.Windows.Forms.PictureBox createdPb;
        private System.Windows.Forms.ProgressBar statusProgress;
        private System.Windows.Forms.PictureBox cancelledPb;
    }
}