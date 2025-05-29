namespace SalesPro.Forms.Inventory
{
    partial class InventoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgInventory = new System.Windows.Forms.DataGridView();
            this.inventoryTabControl = new System.Windows.Forms.TabControl();
            this.activeTab = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.print_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.customDatePanel = new System.Windows.Forms.Panel();
            this.dateAdded_dt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            this.inventoryTabControl.SuspendLayout();
            this.activeTab.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customDatePanel.SuspendLayout();
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
            this.Panel1.Size = new System.Drawing.Size(1160, 43);
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
            this.title_lbl.Size = new System.Drawing.Size(96, 25);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Inventory";
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(467, 347);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 462;
            this.notFound_lbl.Text = "No Record";
            // 
            // dgInventory
            // 
            this.dgInventory.AllowUserToAddRows = false;
            this.dgInventory.AllowUserToDeleteRows = false;
            this.dgInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInventory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgInventory.ColumnHeadersHeight = 40;
            this.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInventory.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgInventory.EnableHeadersVisualStyles = false;
            this.dgInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgInventory.Location = new System.Drawing.Point(3, 129);
            this.dgInventory.MultiSelect = false;
            this.dgInventory.Name = "dgInventory";
            this.dgInventory.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgInventory.RowHeadersVisible = false;
            this.dgInventory.RowHeadersWidth = 51;
            this.dgInventory.RowTemplate.Height = 32;
            this.dgInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInventory.Size = new System.Drawing.Size(1152, 513);
            this.dgInventory.TabIndex = 461;
            this.dgInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInventory_CellClick);
            this.dgInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInventory_CellContentClick);
            // 
            // inventoryTabControl
            // 
            this.inventoryTabControl.Controls.Add(this.activeTab);
            this.inventoryTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTabControl.Location = new System.Drawing.Point(4, 10);
            this.inventoryTabControl.Name = "inventoryTabControl";
            this.inventoryTabControl.SelectedIndex = 0;
            this.inventoryTabControl.Size = new System.Drawing.Size(1151, 37);
            this.inventoryTabControl.TabIndex = 439;
            // 
            // activeTab
            // 
            this.activeTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activeTab.Controls.Add(this.panel6);
            this.activeTab.Location = new System.Drawing.Point(4, 29);
            this.activeTab.Name = "activeTab";
            this.activeTab.Padding = new System.Windows.Forms.Padding(3);
            this.activeTab.Size = new System.Drawing.Size(1143, 4);
            this.activeTab.TabIndex = 0;
            this.activeTab.Text = "   Active Inventory   ";
            this.activeTab.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(-3, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 5);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1160, 661);
            this.panel5.TabIndex = 463;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.refresh_btn);
            this.panel3.Controls.Add(this.customDatePanel);
            this.panel3.Controls.Add(this.print_btn);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.notFound_lbl);
            this.panel3.Controls.Add(this.dgInventory);
            this.panel3.Controls.Add(this.search_tx);
            this.panel3.Controls.Add(this.inventoryTabControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1158, 659);
            this.panel3.TabIndex = 489;
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.print_btn.FlatAppearance.BorderSize = 0;
            this.print_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.Image = ((System.Drawing.Image)(resources.GetObject("print_btn.Image")));
            this.print_btn.Location = new System.Drawing.Point(1032, 61);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(121, 31);
            this.print_btn.TabIndex = 563;
            this.print_btn.Text = "  Print";
            this.print_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.print_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1127, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 468;
            this.pictureBox1.TabStop = false;
            // 
            // search_tx
            // 
            this.search_tx.BackColor = System.Drawing.Color.White;
            this.search_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tx.Location = new System.Drawing.Point(766, 97);
            this.search_tx.Margin = new System.Windows.Forms.Padding(2);
            this.search_tx.Name = "search_tx";
            this.search_tx.Size = new System.Drawing.Size(389, 27);
            this.search_tx.TabIndex = 467;
            this.search_tx.TextChanged += new System.EventHandler(this.search_tx_TextChanged);
            // 
            // customDatePanel
            // 
            this.customDatePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customDatePanel.Controls.Add(this.dateAdded_dt);
            this.customDatePanel.Controls.Add(this.label3);
            this.customDatePanel.Controls.Add(this.findBtn);
            this.customDatePanel.Location = new System.Drawing.Point(11, 53);
            this.customDatePanel.Name = "customDatePanel";
            this.customDatePanel.Size = new System.Drawing.Size(387, 41);
            this.customDatePanel.TabIndex = 564;
            // 
            // dateAdded_dt
            // 
            this.dateAdded_dt.CustomFormat = "MMMM dd,  yyyy";
            this.dateAdded_dt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAdded_dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAdded_dt.Location = new System.Drawing.Point(86, 8);
            this.dateAdded_dt.Name = "dateAdded_dt";
            this.dateAdded_dt.Size = new System.Drawing.Size(161, 23);
            this.dateAdded_dt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Added :";
            // 
            // findBtn
            // 
            this.findBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.findBtn.FlatAppearance.BorderSize = 0;
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.ForeColor = System.Drawing.Color.White;
            this.findBtn.Location = new System.Drawing.Point(263, 6);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(112, 27);
            this.findBtn.TabIndex = 533;
            this.findBtn.Text = "Find ";
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btn.Image")));
            this.refresh_btn.Location = new System.Drawing.Point(416, 59);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(120, 29);
            this.refresh_btn.TabIndex = 565;
            this.refresh_btn.Text = " Refresh";
            this.refresh_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refresh_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.refresh_btn.UseVisualStyleBackColor = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 704);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            this.inventoryTabControl.ResumeLayout(false);
            this.activeTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customDatePanel.ResumeLayout(false);
            this.customDatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgInventory;
        public System.Windows.Forms.TabControl inventoryTabControl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox search_tx;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.TabPage activeTab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel customDatePanel;
        private System.Windows.Forms.DateTimePicker dateAdded_dt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button refresh_btn;
    }
}