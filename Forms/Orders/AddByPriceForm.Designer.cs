namespace SalesPro.Forms.Orders
{
    partial class AddByPriceForm
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
            this.amt_tx = new System.Windows.Forms.TextBox();
            this.product_tx = new System.Windows.Forms.Label();
            this.enter_btn = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            this.unit_tx = new System.Windows.Forms.Label();
            this.qtyToGive_tx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amt_tx
            // 
            this.amt_tx.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt_tx.Location = new System.Drawing.Point(56, 108);
            this.amt_tx.MaxLength = 7;
            this.amt_tx.Name = "amt_tx";
            this.amt_tx.Size = new System.Drawing.Size(300, 50);
            this.amt_tx.TabIndex = 563;
            this.amt_tx.Text = "0";
            this.amt_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amt_tx.TextChanged += new System.EventHandler(this.amt_tx_TextChanged);
            // 
            // product_tx
            // 
            this.product_tx.AutoSize = true;
            this.product_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_tx.Location = new System.Drawing.Point(12, 9);
            this.product_tx.Name = "product_tx";
            this.product_tx.Size = new System.Drawing.Size(59, 30);
            this.product_tx.TabIndex = 561;
            this.product_tx.Text = "Nails";
            // 
            // enter_btn
            // 
            this.enter_btn.BackColor = System.Drawing.Color.Green;
            this.enter_btn.FlatAppearance.BorderSize = 0;
            this.enter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_btn.ForeColor = System.Drawing.Color.White;
            this.enter_btn.Location = new System.Drawing.Point(192, 321);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(164, 41);
            this.enter_btn.TabIndex = 560;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = false;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(52, 83);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(72, 20);
            this.title_lbl.TabIndex = 559;
            this.title_lbl.Text = "Amount :";
            // 
            // unit_tx
            // 
            this.unit_tx.AutoSize = true;
            this.unit_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_tx.Location = new System.Drawing.Point(65, 40);
            this.unit_tx.Name = "unit_tx";
            this.unit_tx.Size = new System.Drawing.Size(134, 20);
            this.unit_tx.TabIndex = 562;
            this.unit_tx.Text = "Stock: 2 kilograms";
            // 
            // qtyToGive_tx
            // 
            this.qtyToGive_tx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.qtyToGive_tx.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyToGive_tx.Location = new System.Drawing.Point(25, 236);
            this.qtyToGive_tx.MaxLength = 7;
            this.qtyToGive_tx.Name = "qtyToGive_tx";
            this.qtyToGive_tx.Size = new System.Drawing.Size(331, 50);
            this.qtyToGive_tx.TabIndex = 565;
            this.qtyToGive_tx.Text = "1";
            this.qtyToGive_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 564;
            this.label1.Text = "Quantity to Give :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 566;
            this.label2.Text = "Stock :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 54);
            this.label3.TabIndex = 567;
            this.label3.Text = "₱";
            // 
            // AddByPriceForm
            // 
            this.AcceptButton = this.enter_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qtyToGive_tx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amt_tx);
            this.Controls.Add(this.unit_tx);
            this.Controls.Add(this.product_tx);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddByPriceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add By Price";
            this.Load += new System.EventHandler(this.AddByPriceForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddByPriceForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox amt_tx;
        internal System.Windows.Forms.Label product_tx;
        private System.Windows.Forms.Button enter_btn;
        internal System.Windows.Forms.Label title_lbl;
        internal System.Windows.Forms.Label unit_tx;
        private System.Windows.Forms.TextBox qtyToGive_tx;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
    }
}