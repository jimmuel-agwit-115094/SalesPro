namespace SalesPro.Forms.Inventory
{
    partial class InventoryLogsForm
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
            this.dgLogs = new System.Windows.Forms.DataGridView();
            this.product_tx = new System.Windows.Forms.Label();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.total_tx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLogs
            // 
            this.dgLogs.AllowUserToAddRows = false;
            this.dgLogs.AllowUserToDeleteRows = false;
            this.dgLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLogs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgLogs.ColumnHeadersHeight = 40;
            this.dgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLogs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgLogs.EnableHeadersVisualStyles = false;
            this.dgLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgLogs.Location = new System.Drawing.Point(16, 58);
            this.dgLogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgLogs.MultiSelect = false;
            this.dgLogs.Name = "dgLogs";
            this.dgLogs.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgLogs.RowHeadersVisible = false;
            this.dgLogs.RowHeadersWidth = 51;
            this.dgLogs.RowTemplate.Height = 32;
            this.dgLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLogs.Size = new System.Drawing.Size(1577, 658);
            this.dgLogs.TabIndex = 463;
            this.dgLogs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgLogs_CellFormatting);
            // 
            // product_tx
            // 
            this.product_tx.AutoSize = true;
            this.product_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_tx.ForeColor = System.Drawing.Color.Black;
            this.product_tx.Location = new System.Drawing.Point(9, 11);
            this.product_tx.Name = "product_tx";
            this.product_tx.Size = new System.Drawing.Size(176, 32);
            this.product_tx.TabIndex = 465;
            this.product_tx.Text = "Inventory Logs";
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(680, 342);
            this.notFound_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(216, 54);
            this.notFound_lbl.TabIndex = 466;
            this.notFound_lbl.Text = "No Record";
            // 
            // total_tx
            // 
            this.total_tx.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_tx.Location = new System.Drawing.Point(1281, 22);
            this.total_tx.Name = "total_tx";
            this.total_tx.Size = new System.Drawing.Size(312, 34);
            this.total_tx.TabIndex = 535;
            this.total_tx.Text = "0.00";
            this.total_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1369, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 23);
            this.label4.TabIndex = 536;
            this.label4.Text = "Available Quantity On Hand";
            // 
            // InventoryLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1609, 731);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.total_tx);
            this.Controls.Add(this.notFound_lbl);
            this.Controls.Add(this.product_tx);
            this.Controls.Add(this.dgLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryLogsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Log";
            this.Load += new System.EventHandler(this.InventoryLogsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.DataGridView dgLogs;
        internal System.Windows.Forms.Label product_tx;
        private System.Windows.Forms.Label notFound_lbl;
        public System.Windows.Forms.Label total_tx;
        private System.Windows.Forms.Label label4;
    }
}