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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.dgLogs = new System.Windows.Forms.DataGridView();
            this.product_tx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(402, 245);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 464;
            this.notFound_lbl.Text = "No Record";
            this.notFound_lbl.Visible = false;
            // 
            // dgLogs
            // 
            this.dgLogs.AllowUserToAddRows = false;
            this.dgLogs.AllowUserToDeleteRows = false;
            this.dgLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLogs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgLogs.ColumnHeadersHeight = 40;
            this.dgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLogs.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgLogs.EnableHeadersVisualStyles = false;
            this.dgLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgLogs.Location = new System.Drawing.Point(12, 47);
            this.dgLogs.MultiSelect = false;
            this.dgLogs.Name = "dgLogs";
            this.dgLogs.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgLogs.RowHeadersVisible = false;
            this.dgLogs.RowHeadersWidth = 51;
            this.dgLogs.RowTemplate.Height = 32;
            this.dgLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLogs.Size = new System.Drawing.Size(980, 475);
            this.dgLogs.TabIndex = 463;
            // 
            // product_tx
            // 
            this.product_tx.AutoSize = true;
            this.product_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_tx.ForeColor = System.Drawing.Color.Black;
            this.product_tx.Location = new System.Drawing.Point(7, 9);
            this.product_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.product_tx.Name = "product_tx";
            this.product_tx.Size = new System.Drawing.Size(140, 25);
            this.product_tx.TabIndex = 465;
            this.product_tx.Text = "Inventory Logs";
            // 
            // InventoryLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 534);
            this.Controls.Add(this.product_tx);
            this.Controls.Add(this.notFound_lbl);
            this.Controls.Add(this.dgLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

        private System.Windows.Forms.Label notFound_lbl;
        internal System.Windows.Forms.DataGridView dgLogs;
        internal System.Windows.Forms.Label product_tx;
    }
}