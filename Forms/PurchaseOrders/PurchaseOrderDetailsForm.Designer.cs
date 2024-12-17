namespace SalesPro.Forms.PurchaseOrders
{
    partial class PurchaseOrderDetailsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderDetailsForm));
            this.title_lbl = new System.Windows.Forms.Label();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgPoItems = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bal_panel = new System.Windows.Forms.Panel();
            this.processStatus_tx = new System.Windows.Forms.Label();
            this.balStat_pb = new System.Windows.Forms.PictureBox();
            this.close_panel = new System.Windows.Forms.Panel();
            this.paymentStatus_tx = new System.Windows.Forms.Label();
            this.closeStat_pb = new System.Windows.Forms.PictureBox();
            this.total_tx = new System.Windows.Forms.Label();
            this.action_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.supplier_tx = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.address_tx = new System.Windows.Forms.Label();
            this.contactPerson_tx = new System.Windows.Forms.Label();
            this.number_tx = new System.Windows.Forms.Label();
            this.addSupplier_btn = new System.Windows.Forms.Button();
            this.addProduct_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.poId_tx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rowCount_tx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.bal_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balStat_pb)).BeginInit();
            this.close_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeStat_pb)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(11, 6);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(207, 25);
            this.title_lbl.TabIndex = 2;
            this.title_lbl.Text = "Purchase Order Details";
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(344, 362);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 464;
            this.notFound_lbl.Text = "No Record";
            this.notFound_lbl.Visible = false;
            // 
            // dgPoItems
            // 
            this.dgPoItems.AllowUserToAddRows = false;
            this.dgPoItems.AllowUserToDeleteRows = false;
            this.dgPoItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgPoItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgPoItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPoItems.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgPoItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPoItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPoItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgPoItems.ColumnHeadersHeight = 37;
            this.dgPoItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPoItems.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgPoItems.EnableHeadersVisualStyles = false;
            this.dgPoItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgPoItems.Location = new System.Drawing.Point(16, 171);
            this.dgPoItems.MultiSelect = false;
            this.dgPoItems.Name = "dgPoItems";
            this.dgPoItems.ReadOnly = true;
            this.dgPoItems.RowHeadersVisible = false;
            this.dgPoItems.RowHeadersWidth = 51;
            this.dgPoItems.RowTemplate.Height = 32;
            this.dgPoItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPoItems.Size = new System.Drawing.Size(841, 467);
            this.dgPoItems.TabIndex = 463;
            this.dgPoItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPoItems_CellContentClick);
            this.dgPoItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgPo_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(830, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 466;
            this.pictureBox1.TabStop = false;
            // 
            // search_tx
            // 
            this.search_tx.BackColor = System.Drawing.Color.White;
            this.search_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tx.Location = new System.Drawing.Point(468, 139);
            this.search_tx.Margin = new System.Windows.Forms.Padding(2);
            this.search_tx.Name = "search_tx";
            this.search_tx.Size = new System.Drawing.Size(389, 27);
            this.search_tx.TabIndex = 465;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.bal_panel);
            this.panel1.Controls.Add(this.close_panel);
            this.panel1.Controls.Add(this.total_tx);
            this.panel1.Location = new System.Drawing.Point(16, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 31);
            this.panel1.TabIndex = 519;
            // 
            // bal_panel
            // 
            this.bal_panel.Controls.Add(this.processStatus_tx);
            this.bal_panel.Controls.Add(this.balStat_pb);
            this.bal_panel.Location = new System.Drawing.Point(3, 5);
            this.bal_panel.Name = "bal_panel";
            this.bal_panel.Size = new System.Drawing.Size(101, 20);
            this.bal_panel.TabIndex = 516;
            // 
            // processStatus_tx
            // 
            this.processStatus_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processStatus_tx.ForeColor = System.Drawing.Color.Gray;
            this.processStatus_tx.Location = new System.Drawing.Point(19, 1);
            this.processStatus_tx.Name = "processStatus_tx";
            this.processStatus_tx.Size = new System.Drawing.Size(103, 17);
            this.processStatus_tx.TabIndex = 506;
            this.processStatus_tx.Text = "Balanced";
            this.processStatus_tx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // balStat_pb
            // 
            this.balStat_pb.Image = ((System.Drawing.Image)(resources.GetObject("balStat_pb.Image")));
            this.balStat_pb.Location = new System.Drawing.Point(3, 2);
            this.balStat_pb.Name = "balStat_pb";
            this.balStat_pb.Size = new System.Drawing.Size(15, 15);
            this.balStat_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.balStat_pb.TabIndex = 0;
            this.balStat_pb.TabStop = false;
            // 
            // close_panel
            // 
            this.close_panel.Controls.Add(this.paymentStatus_tx);
            this.close_panel.Controls.Add(this.closeStat_pb);
            this.close_panel.Location = new System.Drawing.Point(115, 5);
            this.close_panel.Name = "close_panel";
            this.close_panel.Size = new System.Drawing.Size(159, 20);
            this.close_panel.TabIndex = 517;
            // 
            // paymentStatus_tx
            // 
            this.paymentStatus_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentStatus_tx.ForeColor = System.Drawing.Color.Gray;
            this.paymentStatus_tx.Location = new System.Drawing.Point(22, 1);
            this.paymentStatus_tx.Name = "paymentStatus_tx";
            this.paymentStatus_tx.Size = new System.Drawing.Size(124, 17);
            this.paymentStatus_tx.TabIndex = 514;
            this.paymentStatus_tx.Text = "Closed Transaction";
            this.paymentStatus_tx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeStat_pb
            // 
            this.closeStat_pb.Image = ((System.Drawing.Image)(resources.GetObject("closeStat_pb.Image")));
            this.closeStat_pb.Location = new System.Drawing.Point(3, 2);
            this.closeStat_pb.Name = "closeStat_pb";
            this.closeStat_pb.Size = new System.Drawing.Size(15, 15);
            this.closeStat_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeStat_pb.TabIndex = 515;
            this.closeStat_pb.TabStop = false;
            // 
            // total_tx
            // 
            this.total_tx.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_tx.Location = new System.Drawing.Point(605, 1);
            this.total_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_tx.Name = "total_tx";
            this.total_tx.Size = new System.Drawing.Size(234, 28);
            this.total_tx.TabIndex = 534;
            this.total_tx.Text = "0.00";
            this.total_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // action_btn
            // 
            this.action_btn.BackColor = System.Drawing.Color.Green;
            this.action_btn.FlatAppearance.BorderSize = 0;
            this.action_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_btn.ForeColor = System.Drawing.Color.White;
            this.action_btn.Location = new System.Drawing.Point(700, 651);
            this.action_btn.Name = "action_btn";
            this.action_btn.Size = new System.Drawing.Size(159, 34);
            this.action_btn.TabIndex = 520;
            this.action_btn.Text = "Send To Supplier";
            this.action_btn.UseVisualStyleBackColor = false;
            this.action_btn.Click += new System.EventHandler(this.action_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close_btn.Location = new System.Drawing.Point(547, 651);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(140, 34);
            this.close_btn.TabIndex = 521;
            this.close_btn.Text = "Undo Process";
            this.close_btn.UseVisualStyleBackColor = false;
            // 
            // supplier_tx
            // 
            this.supplier_tx.AutoSize = true;
            this.supplier_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_tx.Location = new System.Drawing.Point(85, 3);
            this.supplier_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplier_tx.Name = "supplier_tx";
            this.supplier_tx.Size = new System.Drawing.Size(13, 17);
            this.supplier_tx.TabIndex = 523;
            this.supplier_tx.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 522;
            this.label5.Text = "Supplier :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 524;
            this.label1.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 525;
            this.label2.Text = "Contact Person :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 526;
            this.label3.Text = "Contact Number :";
            // 
            // address_tx
            // 
            this.address_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_tx.Location = new System.Drawing.Point(85, 19);
            this.address_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address_tx.Name = "address_tx";
            this.address_tx.Size = new System.Drawing.Size(305, 17);
            this.address_tx.TabIndex = 527;
            this.address_tx.Text = "-";
            // 
            // contactPerson_tx
            // 
            this.contactPerson_tx.AutoSize = true;
            this.contactPerson_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactPerson_tx.Location = new System.Drawing.Point(519, 3);
            this.contactPerson_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactPerson_tx.Name = "contactPerson_tx";
            this.contactPerson_tx.Size = new System.Drawing.Size(13, 17);
            this.contactPerson_tx.TabIndex = 528;
            this.contactPerson_tx.Text = "-";
            // 
            // number_tx
            // 
            this.number_tx.AutoSize = true;
            this.number_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_tx.Location = new System.Drawing.Point(520, 19);
            this.number_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.number_tx.Name = "number_tx";
            this.number_tx.Size = new System.Drawing.Size(13, 17);
            this.number_tx.TabIndex = 529;
            this.number_tx.Text = "-";
            // 
            // addSupplier_btn
            // 
            this.addSupplier_btn.BackColor = System.Drawing.Color.Green;
            this.addSupplier_btn.FlatAppearance.BorderSize = 0;
            this.addSupplier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSupplier_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSupplier_btn.ForeColor = System.Drawing.Color.White;
            this.addSupplier_btn.Location = new System.Drawing.Point(16, 83);
            this.addSupplier_btn.Name = "addSupplier_btn";
            this.addSupplier_btn.Size = new System.Drawing.Size(128, 27);
            this.addSupplier_btn.TabIndex = 530;
            this.addSupplier_btn.Text = "Add Supplier";
            this.addSupplier_btn.UseVisualStyleBackColor = false;
            this.addSupplier_btn.Click += new System.EventHandler(this.addSupplier_btn_Click);
            // 
            // addProduct_btn
            // 
            this.addProduct_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addProduct_btn.FlatAppearance.BorderSize = 0;
            this.addProduct_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_btn.ForeColor = System.Drawing.Color.White;
            this.addProduct_btn.Location = new System.Drawing.Point(16, 135);
            this.addProduct_btn.Name = "addProduct_btn";
            this.addProduct_btn.Size = new System.Drawing.Size(128, 27);
            this.addProduct_btn.TabIndex = 531;
            this.addProduct_btn.Text = "Add Product";
            this.addProduct_btn.UseVisualStyleBackColor = false;
            this.addProduct_btn.Click += new System.EventHandler(this.addProduct_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.supplier_tx);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.number_tx);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.contactPerson_tx);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.address_tx);
            this.panel2.Location = new System.Drawing.Point(156, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 40);
            this.panel2.TabIndex = 532;
            // 
            // poId_tx
            // 
            this.poId_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poId_tx.ForeColor = System.Drawing.Color.Navy;
            this.poId_tx.Location = new System.Drawing.Point(16, 665);
            this.poId_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.poId_tx.Name = "poId_tx";
            this.poId_tx.Size = new System.Drawing.Size(263, 20);
            this.poId_tx.TabIndex = 533;
            this.poId_tx.Text = "000000000";
            this.poId_tx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(816, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 535;
            this.label4.Text = "Total";
            // 
            // rowCount_tx
            // 
            this.rowCount_tx.AutoSize = true;
            this.rowCount_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowCount_tx.Location = new System.Drawing.Point(16, 648);
            this.rowCount_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rowCount_tx.Name = "rowCount_tx";
            this.rowCount_tx.Size = new System.Drawing.Size(98, 17);
            this.rowCount_tx.TabIndex = 536;
            this.rowCount_tx.Text = "Product Count :";
            // 
            // PurchaseOrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 703);
            this.Controls.Add(this.rowCount_tx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.poId_tx);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addProduct_btn);
            this.Controls.Add(this.addSupplier_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.action_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search_tx);
            this.Controls.Add(this.notFound_lbl);
            this.Controls.Add(this.dgPoItems);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseOrderDetailsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Order Details";
            this.Load += new System.EventHandler(this.PurchaseOrderDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPoItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.bal_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.balStat_pb)).EndInit();
            this.close_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeStat_pb)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgPoItems;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox search_tx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel bal_panel;
        private System.Windows.Forms.Label processStatus_tx;
        private System.Windows.Forms.PictureBox balStat_pb;
        private System.Windows.Forms.Panel close_panel;
        private System.Windows.Forms.Label paymentStatus_tx;
        private System.Windows.Forms.PictureBox closeStat_pb;
        private System.Windows.Forms.Button action_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label supplier_tx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label address_tx;
        private System.Windows.Forms.Label contactPerson_tx;
        private System.Windows.Forms.Label number_tx;
        private System.Windows.Forms.Button addSupplier_btn;
        private System.Windows.Forms.Button addProduct_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label poId_tx;
        private System.Windows.Forms.Label total_tx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rowCount_tx;
    }
}