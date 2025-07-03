﻿namespace SalesPro.Forms.PurchaseOrders
{
    partial class AddSupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplierForm));
            this.title_lbl = new System.Windows.Forms.Label();
            this.dgSupplier = new System.Windows.Forms.DataGridView();
            this.notFound_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(12, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(116, 25);
            this.title_lbl.TabIndex = 2;
            this.title_lbl.Text = "Supplier List";
            // 
            // dgSupplier
            // 
            this.dgSupplier.AllowUserToAddRows = false;
            this.dgSupplier.AllowUserToDeleteRows = false;
            this.dgSupplier.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSupplier.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSupplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSupplier.ColumnHeadersHeight = 30;
            this.dgSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSupplier.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgSupplier.EnableHeadersVisualStyles = false;
            this.dgSupplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgSupplier.Location = new System.Drawing.Point(14, 80);
            this.dgSupplier.MultiSelect = false;
            this.dgSupplier.Name = "dgSupplier";
            this.dgSupplier.ReadOnly = true;
            this.dgSupplier.RowHeadersVisible = false;
            this.dgSupplier.RowHeadersWidth = 51;
            this.dgSupplier.RowTemplate.Height = 32;
            this.dgSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSupplier.Size = new System.Drawing.Size(860, 459);
            this.dgSupplier.TabIndex = 464;
            this.dgSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSupplier_CellContentClick);
            this.dgSupplier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSupplier_CellDoubleClick);
            this.dgSupplier.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgSupplier_RowHeaderMouseDoubleClick);
            this.dgSupplier.SelectionChanged += new System.EventHandler(this.dgSupplier_SelectionChanged);
            this.dgSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgSupplier_KeyDown);
            // 
            // notFound_lbl
            // 
            this.notFound_lbl.AutoSize = true;
            this.notFound_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notFound_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.notFound_lbl.Location = new System.Drawing.Point(357, 274);
            this.notFound_lbl.Name = "notFound_lbl";
            this.notFound_lbl.Size = new System.Drawing.Size(174, 45);
            this.notFound_lbl.TabIndex = 465;
            this.notFound_lbl.Text = "No Record";
            this.notFound_lbl.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(847, 47);
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
            this.search_tx.Location = new System.Drawing.Point(485, 46);
            this.search_tx.Margin = new System.Windows.Forms.Padding(2);
            this.search_tx.Name = "search_tx";
            this.search_tx.Size = new System.Drawing.Size(389, 27);
            this.search_tx.TabIndex = 467;
            this.search_tx.TextChanged += new System.EventHandler(this.search_tx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 15);
            this.label1.TabIndex = 469;
            this.label1.Text = "Note : Changing supplier automatically updates data.";
            // 
            // AddSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search_tx);
            this.Controls.Add(this.notFound_lbl);
            this.Controls.Add(this.dgSupplier);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSupplierForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Supplier";
            this.Load += new System.EventHandler(this.AddSupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label title_lbl;
        internal System.Windows.Forms.DataGridView dgSupplier;
        private System.Windows.Forms.Label notFound_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox search_tx;
        private System.Windows.Forms.Label label1;
    }
}