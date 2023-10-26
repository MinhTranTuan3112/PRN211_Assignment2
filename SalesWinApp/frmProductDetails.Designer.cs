namespace SalesWinApp
{
    partial class frmProductDetails
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
            lbTitle = new Label();
            txtUnitsInStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtWeight = new TextBox();
            txtProductName = new TextBox();
            numProductId = new NumericUpDown();
            lbUnitsInStock = new Label();
            lbUnitPrice = new Label();
            lbWeight = new Label();
            label1 = new Label();
            lbProductName = new Label();
            label2 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtCategoryId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numProductId).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.FromArgb(255, 128, 0);
            lbTitle.Location = new Point(400, 19);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(197, 37);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Product Details";
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(683, 206);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(145, 27);
            txtUnitsInStock.TabIndex = 23;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(683, 147);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(145, 27);
            txtUnitPrice.TabIndex = 22;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(683, 101);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(145, 27);
            txtWeight.TabIndex = 21;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(262, 202);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(201, 27);
            txtProductName.TabIndex = 20;
            // 
            // numProductId
            // 
            numProductId.Location = new Point(262, 101);
            numProductId.Name = "numProductId";
            numProductId.Size = new Size(150, 27);
            numProductId.TabIndex = 18;
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(540, 209);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(98, 20);
            lbUnitsInStock.TabIndex = 17;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(540, 147);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(72, 20);
            lbUnitPrice.TabIndex = 16;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(540, 101);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(56, 20);
            lbWeight.TabIndex = 15;
            lbWeight.Text = "Weight";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 147);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 14;
            label1.Text = "Category Id";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(139, 206);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(104, 20);
            lbProductName.TabIndex = 13;
            lbProductName.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 101);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 12;
            label2.Text = "Product Id";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(369, 283);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(540, 283);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(262, 147);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(150, 27);
            txtCategoryId.TabIndex = 26;
            // 
            // frmProductDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 544);
            Controls.Add(txtCategoryId);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtProductName);
            Controls.Add(numProductId);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(label1);
            Controls.Add(lbProductName);
            Controls.Add(label2);
            Controls.Add(lbTitle);
            Name = "frmProductDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Details";
            ((System.ComponentModel.ISupportInitialize)numProductId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
        private TextBox txtWeight;
        private TextBox txtProductName;
        private NumericUpDown numProductId;
        private Label lbUnitsInStock;
        private Label lbUnitPrice;
        private Label lbWeight;
        private Label label1;
        private Label lbProductName;
        private Label label2;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtCategoryId;
    }
}