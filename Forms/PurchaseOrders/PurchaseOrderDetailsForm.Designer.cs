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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderDetailsForm));
            this.title_lbl = new System.Windows.Forms.Label();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgTransLogs = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bal_panel = new System.Windows.Forms.Panel();
            this.balStatus_tx = new System.Windows.Forms.Label();
            this.balStat_pb = new System.Windows.Forms.PictureBox();
            this.close_panel = new System.Windows.Forms.Panel();
            this.closeStatus_tx = new System.Windows.Forms.Label();
            this.closeStat_pb = new System.Windows.Forms.PictureBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.openedBy_tx = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.bal_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balStat_pb)).BeginInit();
            this.close_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeStat_pb)).BeginInit();
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
            this.notFound_lbl.Location = new System.Drawing.Point(307, 394);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 464;
            this.notFound_lbl.Text = "No Record";
            this.notFound_lbl.Visible = false;
            // 
            // dgTransLogs
            // 
            this.dgTransLogs.AllowUserToAddRows = false;
            this.dgTransLogs.AllowUserToDeleteRows = false;
            this.dgTransLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgTransLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgTransLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTransLogs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgTransLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTransLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTransLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgTransLogs.ColumnHeadersHeight = 30;
            this.dgTransLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTransLogs.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgTransLogs.EnableHeadersVisualStyles = false;
            this.dgTransLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgTransLogs.Location = new System.Drawing.Point(22, 206);
            this.dgTransLogs.MultiSelect = false;
            this.dgTransLogs.Name = "dgTransLogs";
            this.dgTransLogs.ReadOnly = true;
            this.dgTransLogs.RowHeadersVisible = false;
            this.dgTransLogs.RowHeadersWidth = 51;
            this.dgTransLogs.RowTemplate.Height = 32;
            this.dgTransLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTransLogs.Size = new System.Drawing.Size(747, 424);
            this.dgTransLogs.TabIndex = 463;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(742, 175);
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
            this.search_tx.Location = new System.Drawing.Point(380, 174);
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
            this.panel1.Location = new System.Drawing.Point(16, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 31);
            this.panel1.TabIndex = 519;
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
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Green;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(619, 648);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(154, 34);
            this.save_btn.TabIndex = 520;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close_btn.Location = new System.Drawing.Point(459, 648);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(145, 34);
            this.close_btn.TabIndex = 521;
            this.close_btn.Text = "Close Transaction";
            this.close_btn.UseVisualStyleBackColor = false;
            // 
            // openedBy_tx
            // 
            this.openedBy_tx.AutoSize = true;
            this.openedBy_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openedBy_tx.Location = new System.Drawing.Point(93, 112);
            this.openedBy_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.openedBy_tx.Name = "openedBy_tx";
            this.openedBy_tx.Size = new System.Drawing.Size(191, 20);
            this.openedBy_tx.TabIndex = 523;
            this.openedBy_tx.Text = "Supplier Name And Family";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 522;
            this.label5.Text = "Supplier :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 524;
            this.label1.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 525;
            this.label2.Text = "Contact Person :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 526;
            this.label3.Text = "Contact Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 527;
            this.label4.Text = "Opened By :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 528;
            this.label6.Text = "Opened By :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 529;
            this.label7.Text = "Opened By :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 27);
            this.button1.TabIndex = 530;
            this.button1.Text = "Add Supplier";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(24, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 27);
            this.button2.TabIndex = 531;
            this.button2.Text = "Add Product";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // PurchaseOrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 701);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openedBy_tx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search_tx);
            this.Controls.Add(this.notFound_lbl);
            this.Controls.Add(this.dgTransLogs);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseOrderDetailsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Order Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgTransLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.bal_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.balStat_pb)).EndInit();
            this.close_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeStat_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgTransLogs;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox search_tx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel bal_panel;
        private System.Windows.Forms.Label balStatus_tx;
        private System.Windows.Forms.PictureBox balStat_pb;
        private System.Windows.Forms.Panel close_panel;
        private System.Windows.Forms.Label closeStatus_tx;
        private System.Windows.Forms.PictureBox closeStat_pb;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label openedBy_tx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}