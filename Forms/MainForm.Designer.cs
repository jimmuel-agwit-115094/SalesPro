namespace SalesPro.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.user_tx = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.content_panel = new System.Windows.Forms.Panel();
            this.logout_lnk = new System.Windows.Forms.LinkLabel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.top_nav = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.store_lbl = new System.Windows.Forms.Label();
            this.payables_btn = new System.Windows.Forms.Button();
            this.expenses_btn = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.orders_btn = new System.Windows.Forms.Button();
            this.po_btn = new System.Windows.Forms.Button();
            this.products_btn = new System.Windows.Forms.Button();
            this.credits_btn = new System.Windows.Forms.Button();
            this.inventory_btn = new System.Windows.Forms.Button();
            this.reports_btn = new System.Windows.Forms.Button();
            this.left_nav = new System.Windows.Forms.Panel();
            this.transactions_btn = new System.Windows.Forms.Button();
            this.serttings_btn = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.top_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.left_nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_tx
            // 
            this.user_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_tx.ForeColor = System.Drawing.Color.Black;
            this.user_tx.Location = new System.Drawing.Point(460, 12);
            this.user_tx.Name = "user_tx";
            this.user_tx.Size = new System.Drawing.Size(207, 25);
            this.user_tx.TabIndex = 0;
            this.user_tx.Text = "JIMMUEL AGWIT";
            this.user_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.content_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(275, 70);
            this.main_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1558, 857);
            this.main_panel.TabIndex = 8;
            // 
            // content_panel
            // 
            this.content_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.content_panel.BackColor = System.Drawing.Color.White;
            this.content_panel.Location = new System.Drawing.Point(1, 2);
            this.content_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(1555, 852);
            this.content_panel.TabIndex = 0;
            // 
            // logout_lnk
            // 
            this.logout_lnk.AutoSize = true;
            this.logout_lnk.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_lnk.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.logout_lnk.Location = new System.Drawing.Point(597, 42);
            this.logout_lnk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logout_lnk.Name = "logout_lnk";
            this.logout_lnk.Size = new System.Drawing.Size(65, 19);
            this.logout_lnk.TabIndex = 2;
            this.logout_lnk.TabStop = true;
            this.logout_lnk.Text = "Sign Out";
            this.logout_lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_lnk_LinkClicked);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Panel1.Controls.Add(this.logout_lnk);
            this.Panel1.Controls.Add(this.pictureBox2);
            this.Panel1.Controls.Add(this.user_tx);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel1.Location = new System.Drawing.Point(877, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(681, 70);
            this.Panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(569, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // top_nav
            // 
            this.top_nav.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.top_nav.Controls.Add(this.Panel1);
            this.top_nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_nav.Location = new System.Drawing.Point(275, 0);
            this.top_nav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.top_nav.Name = "top_nav";
            this.top_nav.Size = new System.Drawing.Size(1558, 70);
            this.top_nav.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(11, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "---------------------------------------------------------------";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(111, 10);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(48, 41);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            // 
            // store_lbl
            // 
            this.store_lbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.store_lbl.Location = new System.Drawing.Point(5, 57);
            this.store_lbl.Name = "store_lbl";
            this.store_lbl.Size = new System.Drawing.Size(263, 41);
            this.store_lbl.TabIndex = 2;
            this.store_lbl.Text = "Kabsat Harware Store";
            this.store_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // payables_btn
            // 
            this.payables_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.payables_btn.FlatAppearance.BorderSize = 0;
            this.payables_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payables_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payables_btn.Image = ((System.Drawing.Image)(resources.GetObject("payables_btn.Image")));
            this.payables_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payables_btn.Location = new System.Drawing.Point(5, 246);
            this.payables_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payables_btn.Name = "payables_btn";
            this.payables_btn.Size = new System.Drawing.Size(252, 39);
            this.payables_btn.TabIndex = 15;
            this.payables_btn.Text = "   Supplier Payables";
            this.payables_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.payables_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.payables_btn.UseVisualStyleBackColor = false;
            // 
            // expenses_btn
            // 
            this.expenses_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.expenses_btn.FlatAppearance.BorderSize = 0;
            this.expenses_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenses_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_btn.Image = ((System.Drawing.Image)(resources.GetObject("expenses_btn.Image")));
            this.expenses_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenses_btn.Location = new System.Drawing.Point(4, 293);
            this.expenses_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expenses_btn.Name = "expenses_btn";
            this.expenses_btn.Size = new System.Drawing.Size(252, 39);
            this.expenses_btn.TabIndex = 14;
            this.expenses_btn.Text = "   Expenses";
            this.expenses_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.expenses_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.expenses_btn.UseVisualStyleBackColor = false;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.payables_btn);
            this.menuPanel.Controls.Add(this.expenses_btn);
            this.menuPanel.Controls.Add(this.orders_btn);
            this.menuPanel.Controls.Add(this.po_btn);
            this.menuPanel.Controls.Add(this.products_btn);
            this.menuPanel.Controls.Add(this.credits_btn);
            this.menuPanel.Controls.Add(this.inventory_btn);
            this.menuPanel.Controls.Add(this.reports_btn);
            this.menuPanel.Enabled = false;
            this.menuPanel.Location = new System.Drawing.Point(5, 175);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(259, 382);
            this.menuPanel.TabIndex = 0;
            // 
            // orders_btn
            // 
            this.orders_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orders_btn.FlatAppearance.BorderSize = 0;
            this.orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_btn.Image = ((System.Drawing.Image)(resources.GetObject("orders_btn.Image")));
            this.orders_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orders_btn.Location = new System.Drawing.Point(4, 10);
            this.orders_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orders_btn.Name = "orders_btn";
            this.orders_btn.Size = new System.Drawing.Size(252, 39);
            this.orders_btn.TabIndex = 3;
            this.orders_btn.Text = "   Orders";
            this.orders_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.orders_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.orders_btn.UseVisualStyleBackColor = false;
            this.orders_btn.Click += new System.EventHandler(this.orders_btn_Click);
            // 
            // po_btn
            // 
            this.po_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.po_btn.FlatAppearance.BorderSize = 0;
            this.po_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.po_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.po_btn.Image = ((System.Drawing.Image)(resources.GetObject("po_btn.Image")));
            this.po_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.po_btn.Location = new System.Drawing.Point(5, 58);
            this.po_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.po_btn.Name = "po_btn";
            this.po_btn.Size = new System.Drawing.Size(252, 39);
            this.po_btn.TabIndex = 4;
            this.po_btn.Text = "   Purchase Orders";
            this.po_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.po_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.po_btn.UseVisualStyleBackColor = false;
            this.po_btn.Click += new System.EventHandler(this.po_btn_Click);
            // 
            // products_btn
            // 
            this.products_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.products_btn.FlatAppearance.BorderSize = 0;
            this.products_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_btn.Image = ((System.Drawing.Image)(resources.GetObject("products_btn.Image")));
            this.products_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.products_btn.Location = new System.Drawing.Point(4, 106);
            this.products_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.products_btn.Name = "products_btn";
            this.products_btn.Size = new System.Drawing.Size(252, 39);
            this.products_btn.TabIndex = 5;
            this.products_btn.Text = "   Products";
            this.products_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.products_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.products_btn.UseVisualStyleBackColor = false;
            // 
            // credits_btn
            // 
            this.credits_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.credits_btn.FlatAppearance.BorderSize = 0;
            this.credits_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.credits_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits_btn.Image = ((System.Drawing.Image)(resources.GetObject("credits_btn.Image")));
            this.credits_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.credits_btn.Location = new System.Drawing.Point(5, 199);
            this.credits_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.credits_btn.Name = "credits_btn";
            this.credits_btn.Size = new System.Drawing.Size(252, 39);
            this.credits_btn.TabIndex = 11;
            this.credits_btn.Text = "   Accounting   ";
            this.credits_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.credits_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.credits_btn.UseVisualStyleBackColor = false;
            // 
            // inventory_btn
            // 
            this.inventory_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inventory_btn.FlatAppearance.BorderSize = 0;
            this.inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_btn.Image = ((System.Drawing.Image)(resources.GetObject("inventory_btn.Image")));
            this.inventory_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory_btn.Location = new System.Drawing.Point(4, 153);
            this.inventory_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(252, 39);
            this.inventory_btn.TabIndex = 7;
            this.inventory_btn.Text = "   Inventory";
            this.inventory_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inventory_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inventory_btn.UseVisualStyleBackColor = false;
            this.inventory_btn.Click += new System.EventHandler(this.inventory_btn_Click);
            // 
            // reports_btn
            // 
            this.reports_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reports_btn.FlatAppearance.BorderSize = 0;
            this.reports_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reports_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports_btn.Image = ((System.Drawing.Image)(resources.GetObject("reports_btn.Image")));
            this.reports_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reports_btn.Location = new System.Drawing.Point(5, 340);
            this.reports_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reports_btn.Name = "reports_btn";
            this.reports_btn.Size = new System.Drawing.Size(252, 39);
            this.reports_btn.TabIndex = 10;
            this.reports_btn.Text = "   Reports";
            this.reports_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reports_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reports_btn.UseVisualStyleBackColor = false;
            // 
            // left_nav
            // 
            this.left_nav.BackColor = System.Drawing.Color.WhiteSmoke;
            this.left_nav.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.left_nav.Controls.Add(this.transactions_btn);
            this.left_nav.Controls.Add(this.menuPanel);
            this.left_nav.Controls.Add(this.label3);
            this.left_nav.Controls.Add(this.PictureBox1);
            this.left_nav.Controls.Add(this.store_lbl);
            this.left_nav.Controls.Add(this.serttings_btn);
            this.left_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_nav.Location = new System.Drawing.Point(0, 0);
            this.left_nav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.left_nav.Name = "left_nav";
            this.left_nav.Size = new System.Drawing.Size(275, 927);
            this.left_nav.TabIndex = 7;
            // 
            // transactions_btn
            // 
            this.transactions_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.transactions_btn.FlatAppearance.BorderSize = 0;
            this.transactions_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactions_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactions_btn.Image = ((System.Drawing.Image)(resources.GetObject("transactions_btn.Image")));
            this.transactions_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactions_btn.Location = new System.Drawing.Point(9, 138);
            this.transactions_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transactions_btn.Name = "transactions_btn";
            this.transactions_btn.Size = new System.Drawing.Size(252, 39);
            this.transactions_btn.TabIndex = 0;
            this.transactions_btn.Text = "   Transactions";
            this.transactions_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transactions_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.transactions_btn.UseVisualStyleBackColor = false;
            this.transactions_btn.Click += new System.EventHandler(this.transactions_btn_Click);
            // 
            // serttings_btn
            // 
            this.serttings_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.serttings_btn.FlatAppearance.BorderSize = 0;
            this.serttings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serttings_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serttings_btn.Image = ((System.Drawing.Image)(resources.GetObject("serttings_btn.Image")));
            this.serttings_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serttings_btn.Location = new System.Drawing.Point(9, 561);
            this.serttings_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serttings_btn.Name = "serttings_btn";
            this.serttings_btn.Size = new System.Drawing.Size(252, 39);
            this.serttings_btn.TabIndex = 9;
            this.serttings_btn.Text = "   Settings";
            this.serttings_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.serttings_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.serttings_btn.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1833, 927);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.top_nav);
            this.Controls.Add(this.left_nav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.main_panel.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.top_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.left_nav.ResumeLayout(false);
            this.left_nav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label user_tx;
        internal System.Windows.Forms.Panel main_panel;
        internal System.Windows.Forms.Panel content_panel;
        internal System.Windows.Forms.LinkLabel logout_lnk;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.Panel top_nav;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label store_lbl;
        internal System.Windows.Forms.Button payables_btn;
        internal System.Windows.Forms.Button expenses_btn;
        public System.Windows.Forms.Panel menuPanel;
        internal System.Windows.Forms.Button orders_btn;
        internal System.Windows.Forms.Button po_btn;
        internal System.Windows.Forms.Button products_btn;
        internal System.Windows.Forms.Button credits_btn;
        internal System.Windows.Forms.Button inventory_btn;
        internal System.Windows.Forms.Button reports_btn;
        internal System.Windows.Forms.Panel left_nav;
        internal System.Windows.Forms.Button transactions_btn;
        internal System.Windows.Forms.Button serttings_btn;
    }
}