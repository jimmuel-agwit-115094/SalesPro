namespace SalesPro.Forms.Orders
{
    partial class OrderListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderListForm));
            this.title_lbl = new System.Windows.Forms.Label();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.select_lbl = new System.Windows.Forms.Label();
            this.resume_pb = new System.Windows.Forms.PictureBox();
            this.filterPanel = new System.Windows.Forms.GroupBox();
            this.date_cb = new System.Windows.Forms.DateTimePicker();
            this.completedCb = new System.Windows.Forms.CheckBox();
            this.paidPb = new System.Windows.Forms.CheckBox();
            this.creditePb = new System.Windows.Forms.CheckBox();
            this.FindByDateCb = new System.Windows.Forms.CheckBox();
            this.total_tx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resume_pb)).BeginInit();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.title_lbl.Location = new System.Drawing.Point(8, 11);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(95, 25);
            this.title_lbl.TabIndex = 462;
            this.title_lbl.Text = "Order List";
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(416, 299);
            this.notFound_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(272, 45);
            this.notFound_lbl.TabIndex = 460;
            this.notFound_lbl.Text = "No Orders Found";
            // 
            // dgOrders
            // 
            this.dgOrders.AllowUserToAddRows = false;
            this.dgOrders.AllowUserToDeleteRows = false;
            this.dgOrders.AllowUserToResizeColumns = false;
            this.dgOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrders.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgOrders.ColumnHeadersHeight = 40;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOrders.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgOrders.EnableHeadersVisualStyles = false;
            this.dgOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgOrders.Location = new System.Drawing.Point(13, 103);
            this.dgOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgOrders.MultiSelect = false;
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.ReadOnly = true;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgOrders.RowHeadersVisible = false;
            this.dgOrders.RowHeadersWidth = 51;
            this.dgOrders.RowTemplate.Height = 45;
            this.dgOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrders.Size = new System.Drawing.Size(1101, 590);
            this.dgOrders.TabIndex = 461;
            this.dgOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrders_CellContentClick);
            this.dgOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrders_CellDoubleClick);
            this.dgOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgOrders_CellFormatting);
            this.dgOrders.SelectionChanged += new System.EventHandler(this.dgOrders_SelectionChanged);
            this.dgOrders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgOrders_KeyDown);
            // 
            // select_lbl
            // 
            this.select_lbl.AutoSize = true;
            this.select_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_lbl.Location = new System.Drawing.Point(11, 35);
            this.select_lbl.Name = "select_lbl";
            this.select_lbl.Size = new System.Drawing.Size(193, 15);
            this.select_lbl.TabIndex = 463;
            this.select_lbl.Text = "Select an order you want to resume";
            // 
            // resume_pb
            // 
            this.resume_pb.Image = ((System.Drawing.Image)(resources.GetObject("resume_pb.Image")));
            this.resume_pb.Location = new System.Drawing.Point(14, 56);
            this.resume_pb.Name = "resume_pb";
            this.resume_pb.Size = new System.Drawing.Size(40, 40);
            this.resume_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resume_pb.TabIndex = 464;
            this.resume_pb.TabStop = false;
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.label2);
            this.filterPanel.Controls.Add(this.FindByDateCb);
            this.filterPanel.Controls.Add(this.total_tx);
            this.filterPanel.Controls.Add(this.creditePb);
            this.filterPanel.Controls.Add(this.paidPb);
            this.filterPanel.Controls.Add(this.completedCb);
            this.filterPanel.Controls.Add(this.date_cb);
            this.filterPanel.Location = new System.Drawing.Point(482, 6);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(633, 90);
            this.filterPanel.TabIndex = 467;
            this.filterPanel.TabStop = false;
            // 
            // date_cb
            // 
            this.date_cb.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.date_cb.CustomFormat = "MMMM dd, yyyy";
            this.date_cb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_cb.Location = new System.Drawing.Point(113, 58);
            this.date_cb.Name = "date_cb";
            this.date_cb.Size = new System.Drawing.Size(249, 25);
            this.date_cb.TabIndex = 489;
            this.date_cb.Visible = false;
            this.date_cb.ValueChanged += new System.EventHandler(this.date_cb_ValueChanged);
            // 
            // completedCb
            // 
            this.completedCb.AutoSize = true;
            this.completedCb.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.completedCb.Location = new System.Drawing.Point(8, 17);
            this.completedCb.Name = "completedCb";
            this.completedCb.Size = new System.Drawing.Size(91, 21);
            this.completedCb.TabIndex = 491;
            this.completedCb.Text = "Completed";
            this.completedCb.UseVisualStyleBackColor = true;
            this.completedCb.CheckedChanged += new System.EventHandler(this.completedCb_CheckedChanged);
            // 
            // paidPb
            // 
            this.paidPb.AutoSize = true;
            this.paidPb.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.paidPb.Location = new System.Drawing.Point(108, 17);
            this.paidPb.Name = "paidPb";
            this.paidPb.Size = new System.Drawing.Size(52, 21);
            this.paidPb.TabIndex = 492;
            this.paidPb.Text = "Paid";
            this.paidPb.UseVisualStyleBackColor = true;
            this.paidPb.CheckedChanged += new System.EventHandler(this.paidPb_CheckedChanged);
            // 
            // creditePb
            // 
            this.creditePb.AutoSize = true;
            this.creditePb.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.creditePb.Location = new System.Drawing.Point(174, 17);
            this.creditePb.Name = "creditePb";
            this.creditePb.Size = new System.Drawing.Size(77, 21);
            this.creditePb.TabIndex = 493;
            this.creditePb.Text = "Credited";
            this.creditePb.UseVisualStyleBackColor = true;
            this.creditePb.CheckedChanged += new System.EventHandler(this.creditePb_CheckedChanged);
            // 
            // FindByDateCb
            // 
            this.FindByDateCb.AutoSize = true;
            this.FindByDateCb.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FindByDateCb.Location = new System.Drawing.Point(8, 60);
            this.FindByDateCb.Name = "FindByDateCb";
            this.FindByDateCb.Size = new System.Drawing.Size(99, 21);
            this.FindByDateCb.TabIndex = 494;
            this.FindByDateCb.Text = "Find by date";
            this.FindByDateCb.UseVisualStyleBackColor = true;
            this.FindByDateCb.CheckedChanged += new System.EventHandler(this.FindByDateCb_CheckedChanged);
            // 
            // total_tx
            // 
            this.total_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_tx.Location = new System.Drawing.Point(464, 57);
            this.total_tx.Name = "total_tx";
            this.total_tx.Size = new System.Drawing.Size(163, 25);
            this.total_tx.TabIndex = 468;
            this.total_tx.Text = "Order List";
            this.total_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 469;
            this.label2.Text = "Total";
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 706);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.resume_pb);
            this.Controls.Add(this.select_lbl);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.notFound_lbl);
            this.Controls.Add(this.dgOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resume_pb)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgOrders;
        internal System.Windows.Forms.Label select_lbl;
        private System.Windows.Forms.PictureBox resume_pb;
        private System.Windows.Forms.GroupBox filterPanel;
        private System.Windows.Forms.DateTimePicker date_cb;
        private System.Windows.Forms.CheckBox FindByDateCb;
        private System.Windows.Forms.CheckBox creditePb;
        private System.Windows.Forms.CheckBox paidPb;
        private System.Windows.Forms.CheckBox completedCb;
        internal System.Windows.Forms.Label total_tx;
        internal System.Windows.Forms.Label label2;
    }
}