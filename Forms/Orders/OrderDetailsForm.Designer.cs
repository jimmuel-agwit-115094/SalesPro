namespace SalesPro.Forms.Orders
{
    partial class OrderDetailsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailsForm));
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.product_tx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.amtDue_tx = new System.Windows.Forms.Label();
            this.netAmt_tx = new System.Windows.Forms.Label();
            this.vatAmt_tx = new System.Windows.Forms.Label();
            this.totalAmt_tx = new System.Windows.Forms.Label();
            this.discRate_tx = new System.Windows.Forms.Label();
            this.discAmt_tx = new System.Windows.Forms.Label();
            this.vat_tx = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.change_tx = new System.Windows.Forms.Label();
            this.amtPaid_tx = new System.Windows.Forms.Label();
            this.datePaid_tx = new System.Windows.Forms.Label();
            this.paymentStatus_tx = new System.Windows.Forms.Label();
            this.paymentMethod_tx = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.isCredited_tx = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.orderStatus_tx = new System.Windows.Forms.Label();
            this.orderId_tx = new System.Windows.Forms.Label();
            this.userId_tx = new System.Windows.Forms.Label();
            this.customer_tx = new System.Windows.Forms.Label();
            this.dateTaken_tx = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total_tx = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paidPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.isCreditedPanel = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paidPanel.SuspendLayout();
            this.isCreditedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgItems.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgItems.ColumnHeadersHeight = 40;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgItems.EnableHeadersVisualStyles = false;
            this.dgItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgItems.Location = new System.Drawing.Point(16, 60);
            this.dgItems.MultiSelect = false;
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgItems.RowHeadersVisible = false;
            this.dgItems.RowHeadersWidth = 51;
            this.dgItems.RowTemplate.Height = 32;
            this.dgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItems.Size = new System.Drawing.Size(631, 537);
            this.dgItems.TabIndex = 464;
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(268, 320);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(139, 45);
            this.notFound_lbl.TabIndex = 468;
            this.notFound_lbl.Text = "No Item";
            // 
            // product_tx
            // 
            this.product_tx.AutoSize = true;
            this.product_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_tx.ForeColor = System.Drawing.Color.Black;
            this.product_tx.Location = new System.Drawing.Point(11, 6);
            this.product_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.product_tx.Name = "product_tx";
            this.product_tx.Size = new System.Drawing.Size(125, 25);
            this.product_tx.TabIndex = 467;
            this.product_tx.Text = "Order Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 469;
            this.label1.Text = "Products Ordered";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(663, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 568);
            this.groupBox1.TabIndex = 568;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(12, 368);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 578;
            this.label12.Text = "Totals ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.amtDue_tx);
            this.panel3.Controls.Add(this.netAmt_tx);
            this.panel3.Controls.Add(this.vatAmt_tx);
            this.panel3.Controls.Add(this.totalAmt_tx);
            this.panel3.Controls.Add(this.discRate_tx);
            this.panel3.Controls.Add(this.discAmt_tx);
            this.panel3.Controls.Add(this.vat_tx);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(12, 388);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 171);
            this.panel3.TabIndex = 577;
            // 
            // amtDue_tx
            // 
            this.amtDue_tx.AutoSize = true;
            this.amtDue_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtDue_tx.Location = new System.Drawing.Point(131, 145);
            this.amtDue_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amtDue_tx.Name = "amtDue_tx";
            this.amtDue_tx.Size = new System.Drawing.Size(77, 15);
            this.amtDue_tx.TabIndex = 572;
            this.amtDue_tx.Text = "Amt. Due :";
            // 
            // netAmt_tx
            // 
            this.netAmt_tx.AutoSize = true;
            this.netAmt_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netAmt_tx.Location = new System.Drawing.Point(131, 124);
            this.netAmt_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.netAmt_tx.Name = "netAmt_tx";
            this.netAmt_tx.Size = new System.Drawing.Size(70, 15);
            this.netAmt_tx.TabIndex = 571;
            this.netAmt_tx.Text = "Net Amt :";
            // 
            // vatAmt_tx
            // 
            this.vatAmt_tx.AutoSize = true;
            this.vatAmt_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatAmt_tx.Location = new System.Drawing.Point(130, 102);
            this.vatAmt_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vatAmt_tx.Name = "vatAmt_tx";
            this.vatAmt_tx.Size = new System.Drawing.Size(70, 15);
            this.vatAmt_tx.TabIndex = 570;
            this.vatAmt_tx.Text = "Vat Amt :";
            // 
            // totalAmt_tx
            // 
            this.totalAmt_tx.AutoSize = true;
            this.totalAmt_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmt_tx.Location = new System.Drawing.Point(129, 13);
            this.totalAmt_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalAmt_tx.Name = "totalAmt_tx";
            this.totalAmt_tx.Size = new System.Drawing.Size(56, 15);
            this.totalAmt_tx.TabIndex = 566;
            this.totalAmt_tx.Text = "Total :";
            // 
            // discRate_tx
            // 
            this.discRate_tx.AutoSize = true;
            this.discRate_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discRate_tx.Location = new System.Drawing.Point(130, 35);
            this.discRate_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discRate_tx.Name = "discRate_tx";
            this.discRate_tx.Size = new System.Drawing.Size(112, 15);
            this.discRate_tx.TabIndex = 567;
            this.discRate_tx.Text = "Discount Rate :";
            // 
            // discAmt_tx
            // 
            this.discAmt_tx.AutoSize = true;
            this.discAmt_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discAmt_tx.Location = new System.Drawing.Point(130, 58);
            this.discAmt_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discAmt_tx.Name = "discAmt_tx";
            this.discAmt_tx.Size = new System.Drawing.Size(105, 15);
            this.discAmt_tx.TabIndex = 568;
            this.discAmt_tx.Text = "Discount Amt :";
            // 
            // vat_tx
            // 
            this.vat_tx.AutoSize = true;
            this.vat_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vat_tx.Location = new System.Drawing.Point(131, 80);
            this.vat_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vat_tx.Name = "vat_tx";
            this.vat_tx.Size = new System.Drawing.Size(42, 15);
            this.vat_tx.TabIndex = 569;
            this.vat_tx.Text = "Vat :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(51, 143);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 17);
            this.label20.TabIndex = 565;
            this.label20.Text = "Amt. Due :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(56, 122);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 17);
            this.label19.TabIndex = 564;
            this.label19.Text = "Net Amt :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(59, 100);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 17);
            this.label14.TabIndex = 563;
            this.label14.Text = "Vat Amt :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(75, 11);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 17);
            this.label15.TabIndex = 559;
            this.label15.Text = "Total :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 33);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 17);
            this.label16.TabIndex = 560;
            this.label16.Text = "Discount Rate :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(26, 56);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 17);
            this.label17.TabIndex = 561;
            this.label17.Text = "Discount Amt :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(86, 78);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 17);
            this.label18.TabIndex = 562;
            this.label18.Text = "Vat :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 206);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 576;
            this.label9.Text = "Payment Info";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.change_tx);
            this.panel2.Controls.Add(this.amtPaid_tx);
            this.panel2.Controls.Add(this.datePaid_tx);
            this.panel2.Controls.Add(this.paymentStatus_tx);
            this.panel2.Controls.Add(this.paymentMethod_tx);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 135);
            this.panel2.TabIndex = 575;
            // 
            // change_tx
            // 
            this.change_tx.AutoSize = true;
            this.change_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_tx.Location = new System.Drawing.Point(124, 106);
            this.change_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.change_tx.Name = "change_tx";
            this.change_tx.Size = new System.Drawing.Size(63, 15);
            this.change_tx.TabIndex = 580;
            this.change_tx.Text = "Change :";
            // 
            // amtPaid_tx
            // 
            this.amtPaid_tx.AutoSize = true;
            this.amtPaid_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtPaid_tx.Location = new System.Drawing.Point(125, 83);
            this.amtPaid_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amtPaid_tx.Name = "amtPaid_tx";
            this.amtPaid_tx.Size = new System.Drawing.Size(84, 15);
            this.amtPaid_tx.TabIndex = 579;
            this.amtPaid_tx.Text = "Amt. Paid :";
            // 
            // datePaid_tx
            // 
            this.datePaid_tx.AutoSize = true;
            this.datePaid_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePaid_tx.Location = new System.Drawing.Point(123, 59);
            this.datePaid_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datePaid_tx.Name = "datePaid_tx";
            this.datePaid_tx.Size = new System.Drawing.Size(84, 15);
            this.datePaid_tx.TabIndex = 578;
            this.datePaid_tx.Text = "Date Paid :";
            // 
            // paymentStatus_tx
            // 
            this.paymentStatus_tx.AutoSize = true;
            this.paymentStatus_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentStatus_tx.Location = new System.Drawing.Point(123, 12);
            this.paymentStatus_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paymentStatus_tx.Name = "paymentStatus_tx";
            this.paymentStatus_tx.Size = new System.Drawing.Size(126, 15);
            this.paymentStatus_tx.TabIndex = 576;
            this.paymentStatus_tx.Text = "Payment Status : ";
            // 
            // paymentMethod_tx
            // 
            this.paymentMethod_tx.AutoSize = true;
            this.paymentMethod_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethod_tx.Location = new System.Drawing.Point(122, 36);
            this.paymentMethod_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paymentMethod_tx.Name = "paymentMethod_tx";
            this.paymentMethod_tx.Size = new System.Drawing.Size(119, 15);
            this.paymentMethod_tx.TabIndex = 577;
            this.paymentMethod_tx.Text = "Payment Method :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(58, 104);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 17);
            this.label22.TabIndex = 575;
            this.label22.Text = "Change :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(49, 81);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 17);
            this.label21.TabIndex = 574;
            this.label21.Text = "Amt. Paid :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 573;
            this.label11.Text = "Date Paid :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 571;
            this.label6.Text = "Payment Status : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 572;
            this.label7.Text = "Payment Method :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 574;
            this.label8.Text = "Order Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.isCredited_tx);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.orderStatus_tx);
            this.panel1.Controls.Add(this.orderId_tx);
            this.panel1.Controls.Add(this.userId_tx);
            this.panel1.Controls.Add(this.customer_tx);
            this.panel1.Controls.Add(this.dateTaken_tx);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 162);
            this.panel1.TabIndex = 573;
            // 
            // isCredited_tx
            // 
            this.isCredited_tx.AutoSize = true;
            this.isCredited_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isCredited_tx.Location = new System.Drawing.Point(122, 132);
            this.isCredited_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isCredited_tx.Name = "isCredited_tx";
            this.isCredited_tx.Size = new System.Drawing.Size(70, 15);
            this.isCredited_tx.TabIndex = 570;
            this.isCredited_tx.Text = "Credited ";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(40, 130);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(78, 17);
            this.label41.TabIndex = 569;
            this.label41.Text = "Is Credited :";
            // 
            // orderStatus_tx
            // 
            this.orderStatus_tx.AutoSize = true;
            this.orderStatus_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderStatus_tx.Location = new System.Drawing.Point(121, 108);
            this.orderStatus_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderStatus_tx.Name = "orderStatus_tx";
            this.orderStatus_tx.Size = new System.Drawing.Size(105, 15);
            this.orderStatus_tx.TabIndex = 568;
            this.orderStatus_tx.Text = "Order Status :";
            // 
            // orderId_tx
            // 
            this.orderId_tx.AutoSize = true;
            this.orderId_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderId_tx.Location = new System.Drawing.Point(121, 7);
            this.orderId_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderId_tx.Name = "orderId_tx";
            this.orderId_tx.Size = new System.Drawing.Size(119, 15);
            this.orderId_tx.TabIndex = 564;
            this.orderId_tx.Text = "Transaction Id :";
            // 
            // userId_tx
            // 
            this.userId_tx.AutoSize = true;
            this.userId_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userId_tx.Location = new System.Drawing.Point(121, 27);
            this.userId_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userId_tx.Name = "userId_tx";
            this.userId_tx.Size = new System.Drawing.Size(91, 15);
            this.userId_tx.TabIndex = 565;
            this.userId_tx.Text = "Managed By :";
            // 
            // customer_tx
            // 
            this.customer_tx.AutoSize = true;
            this.customer_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_tx.Location = new System.Drawing.Point(121, 60);
            this.customer_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customer_tx.Name = "customer_tx";
            this.customer_tx.Size = new System.Drawing.Size(77, 15);
            this.customer_tx.TabIndex = 566;
            this.customer_tx.Text = "Customer :";
            // 
            // dateTaken_tx
            // 
            this.dateTaken_tx.AutoSize = true;
            this.dateTaken_tx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTaken_tx.Location = new System.Drawing.Point(121, 84);
            this.dateTaken_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateTaken_tx.Name = "dateTaken_tx";
            this.dateTaken_tx.Size = new System.Drawing.Size(91, 15);
            this.dateTaken_tx.TabIndex = 567;
            this.dateTaken_tx.Text = "Date Taken :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 563;
            this.label10.Text = "Order Status :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(55, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 559;
            this.label13.Text = "Order Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 560;
            this.label2.Text = "Processed By :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 561;
            this.label3.Text = "Customer :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 562;
            this.label4.Text = "Date Taken :";
            // 
            // total_tx
            // 
            this.total_tx.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_tx.Location = new System.Drawing.Point(413, 600);
            this.total_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_tx.Name = "total_tx";
            this.total_tx.Size = new System.Drawing.Size(234, 28);
            this.total_tx.TabIndex = 569;
            this.total_tx.Text = "0.00";
            this.total_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 570;
            this.pictureBox1.TabStop = false;
            // 
            // paidPanel
            // 
            this.paidPanel.Controls.Add(this.label5);
            this.paidPanel.Controls.Add(this.pictureBox1);
            this.paidPanel.Location = new System.Drawing.Point(663, 28);
            this.paidPanel.Name = "paidPanel";
            this.paidPanel.Size = new System.Drawing.Size(67, 29);
            this.paidPanel.TabIndex = 571;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(26, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 571;
            this.label5.Text = "Paid";
            // 
            // isCreditedPanel
            // 
            this.isCreditedPanel.Controls.Add(this.label23);
            this.isCreditedPanel.Controls.Add(this.pictureBox2);
            this.isCreditedPanel.Location = new System.Drawing.Point(734, 28);
            this.isCreditedPanel.Name = "isCreditedPanel";
            this.isCreditedPanel.Size = new System.Drawing.Size(90, 29);
            this.isCreditedPanel.TabIndex = 572;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label23.Location = new System.Drawing.Point(26, 6);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 17);
            this.label23.TabIndex = 571;
            this.label23.Text = "Credited";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 570;
            this.pictureBox2.TabStop = false;
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 651);
            this.Controls.Add(this.isCreditedPanel);
            this.Controls.Add(this.paidPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notFound_lbl);
            this.Controls.Add(this.product_tx);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.total_tx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderDetailsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paidPanel.ResumeLayout(false);
            this.paidPanel.PerformLayout();
            this.isCreditedPanel.ResumeLayout(false);
            this.isCreditedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.Label product_tx;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label total_tx;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label amtDue_tx;
        private System.Windows.Forms.Label netAmt_tx;
        private System.Windows.Forms.Label vatAmt_tx;
        private System.Windows.Forms.Label totalAmt_tx;
        private System.Windows.Forms.Label discRate_tx;
        private System.Windows.Forms.Label discAmt_tx;
        private System.Windows.Forms.Label vat_tx;
        private System.Windows.Forms.Label change_tx;
        private System.Windows.Forms.Label amtPaid_tx;
        private System.Windows.Forms.Label datePaid_tx;
        private System.Windows.Forms.Label paymentStatus_tx;
        private System.Windows.Forms.Label paymentMethod_tx;
        private System.Windows.Forms.Label orderStatus_tx;
        private System.Windows.Forms.Label orderId_tx;
        private System.Windows.Forms.Label userId_tx;
        private System.Windows.Forms.Label customer_tx;
        private System.Windows.Forms.Label dateTaken_tx;
        private System.Windows.Forms.Label isCredited_tx;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel paidPanel;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel isCreditedPanel;
        internal System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}