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
            this.user_tx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_tx
            // 
            this.user_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_tx.ForeColor = System.Drawing.Color.Black;
            this.user_tx.Location = new System.Drawing.Point(634, 9);
            this.user_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user_tx.Name = "user_tx";
            this.user_tx.Size = new System.Drawing.Size(155, 20);
            this.user_tx.TabIndex = 1;
            this.user_tx.Text = "JIMMUEL AGWIT";
            this.user_tx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.user_tx);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label user_tx;
    }
}