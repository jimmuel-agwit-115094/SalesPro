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
            this.trialPanel = new System.Windows.Forms.Panel();
            this.remaining_tx = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inactivePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.noTransactionPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.orders_btn = new System.Windows.Forms.Button();
            this.po_btn = new System.Windows.Forms.Button();
            this.products_btn = new System.Windows.Forms.Button();
            this.paymentsAndBilling_btn = new System.Windows.Forms.Button();
            this.inventory_btn = new System.Windows.Forms.Button();
            this.reports_btn = new System.Windows.Forms.Button();
            this.left_nav = new System.Windows.Forms.Panel();
            this.transactions_btn = new System.Windows.Forms.Button();
            this.serttings_btn = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.top_nav.SuspendLayout();
            this.trialPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.inactivePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.noTransactionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.left_nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_tx
            // 
            this.user_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_tx.ForeColor = System.Drawing.Color.Black;
            this.user_tx.Location = new System.Drawing.Point(345, 8);
            this.user_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user_tx.Name = "user_tx";
            this.user_tx.Size = new System.Drawing.Size(155, 20);
            this.user_tx.TabIndex = 0;
            this.user_tx.Text = "JIMMUEL AGWIT";
            this.user_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.content_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(207, 57);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1168, 696);
            this.main_panel.TabIndex = 8;
            // 
            // content_panel
            // 
            this.content_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.content_panel.BackColor = System.Drawing.Color.White;
            this.content_panel.Location = new System.Drawing.Point(1, 2);
            this.content_panel.Margin = new System.Windows.Forms.Padding(2);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(1166, 692);
            this.content_panel.TabIndex = 0;
            // 
            // logout_lnk
            // 
            this.logout_lnk.AutoSize = true;
            this.logout_lnk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_lnk.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.logout_lnk.Location = new System.Drawing.Point(448, 34);
            this.logout_lnk.Name = "logout_lnk";
            this.logout_lnk.Size = new System.Drawing.Size(53, 15);
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
            this.Panel1.Location = new System.Drawing.Point(657, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(511, 57);
            this.Panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(427, 31);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // top_nav
            // 
            this.top_nav.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.top_nav.Controls.Add(this.trialPanel);
            this.top_nav.Controls.Add(this.inactivePanel);
            this.top_nav.Controls.Add(this.Panel1);
            this.top_nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_nav.Location = new System.Drawing.Point(207, 0);
            this.top_nav.Name = "top_nav";
            this.top_nav.Size = new System.Drawing.Size(1168, 57);
            this.top_nav.TabIndex = 9;
            // 
            // trialPanel
            // 
            this.trialPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.trialPanel.Controls.Add(this.remaining_tx);
            this.trialPanel.Controls.Add(this.pictureBox3);
            this.trialPanel.Controls.Add(this.label4);
            this.trialPanel.ForeColor = System.Drawing.Color.Red;
            this.trialPanel.Location = new System.Drawing.Point(5, 4);
            this.trialPanel.Name = "trialPanel";
            this.trialPanel.Size = new System.Drawing.Size(254, 48);
            this.trialPanel.TabIndex = 544;
            // 
            // remaining_tx
            // 
            this.remaining_tx.AutoSize = true;
            this.remaining_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remaining_tx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.remaining_tx.Location = new System.Drawing.Point(40, 23);
            this.remaining_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.remaining_tx.Name = "remaining_tx";
            this.remaining_tx.Size = new System.Drawing.Size(36, 17);
            this.remaining_tx.TabIndex = 544;
            this.remaining_tx.Text = "Days";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 543;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(40, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 539;
            this.label4.Text = "Product on Trial Period";
            // 
            // inactivePanel
            // 
            this.inactivePanel.BackColor = System.Drawing.Color.MistyRose;
            this.inactivePanel.Controls.Add(this.label1);
            this.inactivePanel.Controls.Add(this.pictureBox6);
            this.inactivePanel.Controls.Add(this.label6);
            this.inactivePanel.ForeColor = System.Drawing.Color.Red;
            this.inactivePanel.Location = new System.Drawing.Point(5, 4);
            this.inactivePanel.Name = "inactivePanel";
            this.inactivePanel.Size = new System.Drawing.Size(254, 48);
            this.inactivePanel.TabIndex = 543;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 544;
            this.label1.Text = "Trial Period Ended";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(10, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 543;
            this.pictureBox6.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(51, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 17);
            this.label6.TabIndex = 539;
            this.label6.Text = "Product Needs Activation";
            // 
            // noTransactionPanel
            // 
            this.noTransactionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.noTransactionPanel.Controls.Add(this.label2);
            this.noTransactionPanel.Controls.Add(this.pictureBox4);
            this.noTransactionPanel.Controls.Add(this.label5);
            this.noTransactionPanel.ForeColor = System.Drawing.Color.Red;
            this.noTransactionPanel.Location = new System.Drawing.Point(6, 446);
            this.noTransactionPanel.Name = "noTransactionPanel";
            this.noTransactionPanel.Size = new System.Drawing.Size(193, 68);
            this.noTransactionPanel.TabIndex = 545;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(48, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 34);
            this.label2.TabIndex = 544;
            this.label2.Text = "Please create a \r\nnew transaction";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(9, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 543;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(48, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 539;
            this.label5.Text = "No Daily Transaction ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(8, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "---------------------------------------------------------------";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(57, 4);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(80, 80);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            // 
            // orders_btn
            // 
            this.orders_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orders_btn.FlatAppearance.BorderSize = 0;
            this.orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_btn.Image = ((System.Drawing.Image)(resources.GetObject("orders_btn.Image")));
            this.orders_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orders_btn.Location = new System.Drawing.Point(7, 150);
            this.orders_btn.Name = "orders_btn";
            this.orders_btn.Size = new System.Drawing.Size(189, 32);
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
            this.po_btn.Location = new System.Drawing.Point(8, 189);
            this.po_btn.Name = "po_btn";
            this.po_btn.Size = new System.Drawing.Size(189, 32);
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
            this.products_btn.Location = new System.Drawing.Point(7, 228);
            this.products_btn.Name = "products_btn";
            this.products_btn.Size = new System.Drawing.Size(189, 32);
            this.products_btn.TabIndex = 5;
            this.products_btn.Text = "   Products";
            this.products_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.products_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.products_btn.UseVisualStyleBackColor = false;
            this.products_btn.Click += new System.EventHandler(this.products_btn_Click);
            // 
            // paymentsAndBilling_btn
            // 
            this.paymentsAndBilling_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paymentsAndBilling_btn.FlatAppearance.BorderSize = 0;
            this.paymentsAndBilling_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentsAndBilling_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentsAndBilling_btn.Image = ((System.Drawing.Image)(resources.GetObject("paymentsAndBilling_btn.Image")));
            this.paymentsAndBilling_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentsAndBilling_btn.Location = new System.Drawing.Point(8, 304);
            this.paymentsAndBilling_btn.Name = "paymentsAndBilling_btn";
            this.paymentsAndBilling_btn.Size = new System.Drawing.Size(189, 32);
            this.paymentsAndBilling_btn.TabIndex = 11;
            this.paymentsAndBilling_btn.Text = "   Payments and Billings";
            this.paymentsAndBilling_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.paymentsAndBilling_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.paymentsAndBilling_btn.UseVisualStyleBackColor = false;
            this.paymentsAndBilling_btn.Click += new System.EventHandler(this.paymentsAndBilling_btn_Click);
            // 
            // inventory_btn
            // 
            this.inventory_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inventory_btn.FlatAppearance.BorderSize = 0;
            this.inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_btn.Image = ((System.Drawing.Image)(resources.GetObject("inventory_btn.Image")));
            this.inventory_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory_btn.Location = new System.Drawing.Point(7, 266);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(189, 32);
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
            this.reports_btn.Location = new System.Drawing.Point(8, 341);
            this.reports_btn.Name = "reports_btn";
            this.reports_btn.Size = new System.Drawing.Size(189, 32);
            this.reports_btn.TabIndex = 10;
            this.reports_btn.Text = "   Reports";
            this.reports_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reports_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reports_btn.UseVisualStyleBackColor = false;
            this.reports_btn.Click += new System.EventHandler(this.reports_btn_Click);
            // 
            // left_nav
            // 
            this.left_nav.BackColor = System.Drawing.Color.WhiteSmoke;
            this.left_nav.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.left_nav.Controls.Add(this.orders_btn);
            this.left_nav.Controls.Add(this.po_btn);
            this.left_nav.Controls.Add(this.noTransactionPanel);
            this.left_nav.Controls.Add(this.transactions_btn);
            this.left_nav.Controls.Add(this.reports_btn);
            this.left_nav.Controls.Add(this.label3);
            this.left_nav.Controls.Add(this.products_btn);
            this.left_nav.Controls.Add(this.PictureBox1);
            this.left_nav.Controls.Add(this.inventory_btn);
            this.left_nav.Controls.Add(this.serttings_btn);
            this.left_nav.Controls.Add(this.paymentsAndBilling_btn);
            this.left_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_nav.Location = new System.Drawing.Point(0, 0);
            this.left_nav.Name = "left_nav";
            this.left_nav.Size = new System.Drawing.Size(207, 753);
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
            this.transactions_btn.Location = new System.Drawing.Point(7, 112);
            this.transactions_btn.Name = "transactions_btn";
            this.transactions_btn.Size = new System.Drawing.Size(189, 32);
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
            this.serttings_btn.Location = new System.Drawing.Point(7, 378);
            this.serttings_btn.Name = "serttings_btn";
            this.serttings_btn.Size = new System.Drawing.Size(189, 32);
            this.serttings_btn.TabIndex = 9;
            this.serttings_btn.Text = "   Settings";
            this.serttings_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.serttings_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.serttings_btn.UseVisualStyleBackColor = false;
            this.serttings_btn.Click += new System.EventHandler(this.serttings_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1375, 753);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.top_nav);
            this.Controls.Add(this.left_nav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.trialPanel.ResumeLayout(false);
            this.trialPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.inactivePanel.ResumeLayout(false);
            this.inactivePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.noTransactionPanel.ResumeLayout(false);
            this.noTransactionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
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
        internal System.Windows.Forms.Button orders_btn;
        internal System.Windows.Forms.Button po_btn;
        internal System.Windows.Forms.Button products_btn;
        internal System.Windows.Forms.Button paymentsAndBilling_btn;
        internal System.Windows.Forms.Button inventory_btn;
        internal System.Windows.Forms.Button reports_btn;
        internal System.Windows.Forms.Panel left_nav;
        internal System.Windows.Forms.Button transactions_btn;
        internal System.Windows.Forms.Button serttings_btn;
        private System.Windows.Forms.Panel inactivePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel trialPanel;
        private System.Windows.Forms.Label remaining_tx;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel noTransactionPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
    }
}