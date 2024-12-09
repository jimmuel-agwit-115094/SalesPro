namespace SalesPro.Forms.Transactions
{
    partial class TransactionDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionDetailsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.title_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.detailTabControl = new System.Windows.Forms.TabControl();
            this.transactionData_tab = new System.Windows.Forms.TabPage();
            this.date_tx = new System.Windows.Forms.Label();
            this.closedBy_tx = new System.Windows.Forms.Label();
            this.openedBy_tx = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bal_panel = new System.Windows.Forms.Panel();
            this.balStatus_tx = new System.Windows.Forms.Label();
            this.balStat_pb = new System.Windows.Forms.PictureBox();
            this.close_panel = new System.Windows.Forms.Panel();
            this.closeStatus_tx = new System.Windows.Forms.Label();
            this.closeStat_pb = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.endingCash_tx = new System.Windows.Forms.NumericUpDown();
            this.expCash_tx = new System.Windows.Forms.NumericUpDown();
            this.totalExp_tx = new System.Windows.Forms.NumericUpDown();
            this.totalSales_tx = new System.Windows.Forms.NumericUpDown();
            this.begBal_tx = new System.Windows.Forms.NumericUpDown();
            this.close_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.transactionLog_tab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.dgTransLogs = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.detailTabControl.SuspendLayout();
            this.transactionData_tab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bal_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balStat_pb)).BeginInit();
            this.close_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeStat_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingCash_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expCash_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalExp_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSales_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.begBal_tx)).BeginInit();
            this.transactionLog_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(11, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(173, 25);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "Transaction Details";
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Green;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(485, 399);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(128, 34);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // detailTabControl
            // 
            this.detailTabControl.Controls.Add(this.transactionData_tab);
            this.detailTabControl.Controls.Add(this.transactionLog_tab);
            this.detailTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailTabControl.Location = new System.Drawing.Point(12, 66);
            this.detailTabControl.Name = "detailTabControl";
            this.detailTabControl.SelectedIndex = 0;
            this.detailTabControl.Size = new System.Drawing.Size(767, 490);
            this.detailTabControl.TabIndex = 6;
            // 
            // transactionData_tab
            // 
            this.transactionData_tab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transactionData_tab.Controls.Add(this.date_tx);
            this.transactionData_tab.Controls.Add(this.closedBy_tx);
            this.transactionData_tab.Controls.Add(this.openedBy_tx);
            this.transactionData_tab.Controls.Add(this.label7);
            this.transactionData_tab.Controls.Add(this.panel1);
            this.transactionData_tab.Controls.Add(this.button1);
            this.transactionData_tab.Controls.Add(this.endingCash_tx);
            this.transactionData_tab.Controls.Add(this.expCash_tx);
            this.transactionData_tab.Controls.Add(this.totalExp_tx);
            this.transactionData_tab.Controls.Add(this.totalSales_tx);
            this.transactionData_tab.Controls.Add(this.begBal_tx);
            this.transactionData_tab.Controls.Add(this.close_btn);
            this.transactionData_tab.Controls.Add(this.label6);
            this.transactionData_tab.Controls.Add(this.label5);
            this.transactionData_tab.Controls.Add(this.label4);
            this.transactionData_tab.Controls.Add(this.label3);
            this.transactionData_tab.Controls.Add(this.label2);
            this.transactionData_tab.Controls.Add(this.label1);
            this.transactionData_tab.Controls.Add(this.label8);
            this.transactionData_tab.Controls.Add(this.panel6);
            this.transactionData_tab.Controls.Add(this.save_btn);
            this.transactionData_tab.Location = new System.Drawing.Point(4, 29);
            this.transactionData_tab.Name = "transactionData_tab";
            this.transactionData_tab.Padding = new System.Windows.Forms.Padding(3);
            this.transactionData_tab.Size = new System.Drawing.Size(759, 457);
            this.transactionData_tab.TabIndex = 0;
            this.transactionData_tab.Text = "    Transaction Data    ";
            this.transactionData_tab.Click += new System.EventHandler(this.transactionData_tab_Click);
            // 
            // date_tx
            // 
            this.date_tx.AutoSize = true;
            this.date_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_tx.Location = new System.Drawing.Point(308, 98);
            this.date_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date_tx.Name = "date_tx";
            this.date_tx.Size = new System.Drawing.Size(15, 20);
            this.date_tx.TabIndex = 523;
            this.date_tx.Text = "-";
            // 
            // closedBy_tx
            // 
            this.closedBy_tx.AutoSize = true;
            this.closedBy_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedBy_tx.Location = new System.Drawing.Point(308, 78);
            this.closedBy_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.closedBy_tx.Name = "closedBy_tx";
            this.closedBy_tx.Size = new System.Drawing.Size(15, 20);
            this.closedBy_tx.TabIndex = 522;
            this.closedBy_tx.Text = "-";
            // 
            // openedBy_tx
            // 
            this.openedBy_tx.AutoSize = true;
            this.openedBy_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openedBy_tx.Location = new System.Drawing.Point(308, 58);
            this.openedBy_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.openedBy_tx.Name = "openedBy_tx";
            this.openedBy_tx.Size = new System.Drawing.Size(92, 20);
            this.openedBy_tx.TabIndex = 521;
            this.openedBy_tx.Text = "Opened By :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 520;
            this.label7.Text = "Date :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.bal_panel);
            this.panel1.Controls.Add(this.close_panel);
            this.panel1.Location = new System.Drawing.Point(6, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 31);
            this.panel1.TabIndex = 518;
            // 
            // bal_panel
            // 
            this.bal_panel.Controls.Add(this.balStatus_tx);
            this.bal_panel.Controls.Add(this.balStat_pb);
            this.bal_panel.Location = new System.Drawing.Point(3, 5);
            this.bal_panel.Name = "bal_panel";
            this.bal_panel.Size = new System.Drawing.Size(101, 20);
            this.bal_panel.TabIndex = 516;
            // 
            // balStatus_tx
            // 
            this.balStatus_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balStatus_tx.ForeColor = System.Drawing.Color.Gray;
            this.balStatus_tx.Location = new System.Drawing.Point(19, 1);
            this.balStatus_tx.Name = "balStatus_tx";
            this.balStatus_tx.Size = new System.Drawing.Size(103, 17);
            this.balStatus_tx.TabIndex = 506;
            this.balStatus_tx.Text = "Balanced";
            this.balStatus_tx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.balStatus_tx.Visible = false;
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
            this.balStat_pb.Visible = false;
            // 
            // close_panel
            // 
            this.close_panel.Controls.Add(this.closeStatus_tx);
            this.close_panel.Controls.Add(this.closeStat_pb);
            this.close_panel.Location = new System.Drawing.Point(115, 5);
            this.close_panel.Name = "close_panel";
            this.close_panel.Size = new System.Drawing.Size(159, 20);
            this.close_panel.TabIndex = 517;
            // 
            // closeStatus_tx
            // 
            this.closeStatus_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeStatus_tx.ForeColor = System.Drawing.Color.Gray;
            this.closeStatus_tx.Location = new System.Drawing.Point(22, 1);
            this.closeStatus_tx.Name = "closeStatus_tx";
            this.closeStatus_tx.Size = new System.Drawing.Size(124, 17);
            this.closeStatus_tx.TabIndex = 514;
            this.closeStatus_tx.Text = "Closed Transaction";
            this.closeStatus_tx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeStatus_tx.Visible = false;
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
            this.closeStat_pb.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(165, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 34);
            this.button1.TabIndex = 513;
            this.button1.Text = "Undo Transaction";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // endingCash_tx
            // 
            this.endingCash_tx.DecimalPlaces = 2;
            this.endingCash_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.endingCash_tx.Location = new System.Drawing.Point(307, 323);
            this.endingCash_tx.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.endingCash_tx.Name = "endingCash_tx";
            this.endingCash_tx.ReadOnly = true;
            this.endingCash_tx.Size = new System.Drawing.Size(261, 27);
            this.endingCash_tx.TabIndex = 512;
            this.endingCash_tx.Tag = "IsNumeric";
            this.endingCash_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.endingCash_tx.ThousandsSeparator = true;
            this.endingCash_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // expCash_tx
            // 
            this.expCash_tx.DecimalPlaces = 2;
            this.expCash_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.expCash_tx.Location = new System.Drawing.Point(307, 281);
            this.expCash_tx.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.expCash_tx.Name = "expCash_tx";
            this.expCash_tx.ReadOnly = true;
            this.expCash_tx.Size = new System.Drawing.Size(261, 27);
            this.expCash_tx.TabIndex = 511;
            this.expCash_tx.Tag = "IsNumeric";
            this.expCash_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.expCash_tx.ThousandsSeparator = true;
            this.expCash_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // totalExp_tx
            // 
            this.totalExp_tx.DecimalPlaces = 2;
            this.totalExp_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.totalExp_tx.Location = new System.Drawing.Point(307, 235);
            this.totalExp_tx.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.totalExp_tx.Name = "totalExp_tx";
            this.totalExp_tx.ReadOnly = true;
            this.totalExp_tx.Size = new System.Drawing.Size(261, 27);
            this.totalExp_tx.TabIndex = 510;
            this.totalExp_tx.Tag = "IsNumeric";
            this.totalExp_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalExp_tx.ThousandsSeparator = true;
            this.totalExp_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // totalSales_tx
            // 
            this.totalSales_tx.DecimalPlaces = 2;
            this.totalSales_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.totalSales_tx.Location = new System.Drawing.Point(307, 191);
            this.totalSales_tx.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.totalSales_tx.Name = "totalSales_tx";
            this.totalSales_tx.ReadOnly = true;
            this.totalSales_tx.Size = new System.Drawing.Size(261, 27);
            this.totalSales_tx.TabIndex = 509;
            this.totalSales_tx.Tag = "IsNumeric";
            this.totalSales_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalSales_tx.ThousandsSeparator = true;
            this.totalSales_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // begBal_tx
            // 
            this.begBal_tx.DecimalPlaces = 2;
            this.begBal_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.begBal_tx.Location = new System.Drawing.Point(307, 147);
            this.begBal_tx.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.begBal_tx.Name = "begBal_tx";
            this.begBal_tx.Size = new System.Drawing.Size(261, 27);
            this.begBal_tx.TabIndex = 508;
            this.begBal_tx.Tag = "IsNumeric";
            this.begBal_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.begBal_tx.ThousandsSeparator = true;
            this.begBal_tx.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(324, 399);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(145, 34);
            this.close_btn.TabIndex = 507;
            this.close_btn.Text = "Close Transaction";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 505;
            this.label6.Text = "Closed By :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 503;
            this.label5.Text = "Opened By :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 501;
            this.label4.Text = "Ending Cash :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 499;
            this.label3.Text = "Expected Cash :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 497;
            this.label2.Text = "Total Expenses :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 495;
            this.label1.Text = "Total Sales :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 493;
            this.label8.Text = "Beginning Balance :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(4, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 5);
            this.panel6.TabIndex = 5;
            // 
            // transactionLog_tab
            // 
            this.transactionLog_tab.Controls.Add(this.pictureBox1);
            this.transactionLog_tab.Controls.Add(this.search_tx);
            this.transactionLog_tab.Controls.Add(this.dgTransLogs);
            this.transactionLog_tab.Controls.Add(this.panel7);
            this.transactionLog_tab.Location = new System.Drawing.Point(4, 29);
            this.transactionLog_tab.Name = "transactionLog_tab";
            this.transactionLog_tab.Padding = new System.Windows.Forms.Padding(3);
            this.transactionLog_tab.Size = new System.Drawing.Size(759, 457);
            this.transactionLog_tab.TabIndex = 1;
            this.transactionLog_tab.Text = "     Transaction Logs   ";
            this.transactionLog_tab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(726, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 460;
            this.pictureBox1.TabStop = false;
            // 
            // search_tx
            // 
            this.search_tx.BackColor = System.Drawing.Color.White;
            this.search_tx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tx.Location = new System.Drawing.Point(364, 20);
            this.search_tx.Margin = new System.Windows.Forms.Padding(2);
            this.search_tx.Name = "search_tx";
            this.search_tx.Size = new System.Drawing.Size(389, 27);
            this.search_tx.TabIndex = 459;
            this.search_tx.TextChanged += new System.EventHandler(this.search_tx_TextChanged);
            // 
            // dgTransLogs
            // 
            this.dgTransLogs.AllowUserToAddRows = false;
            this.dgTransLogs.AllowUserToDeleteRows = false;
            this.dgTransLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgTransLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTransLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTransLogs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgTransLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTransLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTransLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTransLogs.ColumnHeadersHeight = 40;
            this.dgTransLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTransLogs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgTransLogs.EnableHeadersVisualStyles = false;
            this.dgTransLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgTransLogs.Location = new System.Drawing.Point(6, 57);
            this.dgTransLogs.MultiSelect = false;
            this.dgTransLogs.Name = "dgTransLogs";
            this.dgTransLogs.ReadOnly = true;
            this.dgTransLogs.RowHeadersVisible = false;
            this.dgTransLogs.RowHeadersWidth = 51;
            this.dgTransLogs.RowTemplate.Height = 32;
            this.dgTransLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTransLogs.Size = new System.Drawing.Size(747, 394);
            this.dgTransLogs.TabIndex = 458;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(169, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 5);
            this.panel7.TabIndex = 6;
            // 
            // TransactionDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 565);
            this.Controls.Add(this.detailTabControl);
            this.Controls.Add(this.title_lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionDetailsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Transaction";
            this.Load += new System.EventHandler(this.TransactionDetailsForm_Load);
            this.detailTabControl.ResumeLayout(false);
            this.transactionData_tab.ResumeLayout(false);
            this.transactionData_tab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.bal_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.balStat_pb)).EndInit();
            this.close_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeStat_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingCash_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expCash_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalExp_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSales_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.begBal_tx)).EndInit();
            this.transactionLog_tab.ResumeLayout(false);
            this.transactionLog_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TabControl detailTabControl;
        private System.Windows.Forms.TabPage transactionData_tab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage transactionLog_tab;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label balStatus_tx;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.NumericUpDown totalSales_tx;
        private System.Windows.Forms.NumericUpDown endingCash_tx;
        private System.Windows.Forms.NumericUpDown expCash_tx;
        private System.Windows.Forms.NumericUpDown totalExp_tx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label closeStatus_tx;
        private System.Windows.Forms.PictureBox balStat_pb;
        private System.Windows.Forms.PictureBox closeStat_pb;
        private System.Windows.Forms.Panel bal_panel;
        private System.Windows.Forms.Panel close_panel;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.DataGridView dgTransLogs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label closedBy_tx;
        private System.Windows.Forms.Label openedBy_tx;
        private System.Windows.Forms.Label date_tx;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox search_tx;
        public System.Windows.Forms.NumericUpDown begBal_tx;
    }
}