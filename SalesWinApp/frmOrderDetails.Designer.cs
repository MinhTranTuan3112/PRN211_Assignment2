namespace SalesWinApp
{
    partial class frmOrderDetails
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
            dgvOrderProducts = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderProducts
            // 
            dgvOrderProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderProducts.Location = new Point(12, 203);
            dgvOrderProducts.Name = "dgvOrderProducts";
            dgvOrderProducts.ReadOnly = true;
            dgvOrderProducts.RowHeadersWidth = 51;
            dgvOrderProducts.RowTemplate.Height = 29;
            dgvOrderProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderProducts.Size = new Size(926, 306);
            dgvOrderProducts.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(364, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 37);
            label1.TabIndex = 1;
            label1.Text = "Order Details";
            // 
            // frmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 521);
            Controls.Add(label1);
            Controls.Add(dgvOrderProducts);
            Name = "frmOrderDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Details";
            ((System.ComponentModel.ISupportInitialize)dgvOrderProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderProducts;
        private Label label1;
    }
}