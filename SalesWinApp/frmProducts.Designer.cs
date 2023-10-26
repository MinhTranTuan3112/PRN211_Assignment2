namespace SalesWinApp
{
    partial class frmProducts
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
            tcProducts = new TabControl();
            tpMain = new TabPage();
            label8 = new Label();
            btnOrder = new Button();
            txtCategoryId = new TextBox();
            numQuantity = new NumericUpDown();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            txtUnitsInStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtWeight = new TextBox();
            txtProductName = new TextBox();
            numProductId = new NumericUpDown();
            lbUnitsInStock = new Label();
            lbUnitPrice = new Label();
            lbWeight = new Label();
            lbCategoryId = new Label();
            lbProductName = new Label();
            lbProductId = new Label();
            tpFilter = new TabPage();
            label7 = new Label();
            btnClear = new Button();
            btnSearch = new Button();
            label6 = new Label();
            txtMaxUnit = new TextBox();
            txtMinUnit = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtMaxPrice = new TextBox();
            txtMinPrice = new TextBox();
            label2 = new Label();
            txtKeyword = new TextBox();
            label1 = new Label();
            numProductIdFilter = new NumericUpDown();
            tpOrder = new TabPage();
            dgvProducts = new DataGridView();
            tcProducts.SuspendLayout();
            tpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numProductId).BeginInit();
            tpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numProductIdFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tcProducts
            // 
            tcProducts.Controls.Add(tpMain);
            tcProducts.Controls.Add(tpFilter);
            tcProducts.Controls.Add(tpOrder);
            tcProducts.Location = new Point(12, 12);
            tcProducts.Name = "tcProducts";
            tcProducts.SelectedIndex = 0;
            tcProducts.Size = new Size(1044, 247);
            tcProducts.TabIndex = 0;
            // 
            // tpMain
            // 
            tpMain.Controls.Add(label8);
            tpMain.Controls.Add(btnOrder);
            tpMain.Controls.Add(txtCategoryId);
            tpMain.Controls.Add(numQuantity);
            tpMain.Controls.Add(btnDelete);
            tpMain.Controls.Add(btnUpdate);
            tpMain.Controls.Add(btnCreate);
            tpMain.Controls.Add(txtUnitsInStock);
            tpMain.Controls.Add(txtUnitPrice);
            tpMain.Controls.Add(txtWeight);
            tpMain.Controls.Add(txtProductName);
            tpMain.Controls.Add(numProductId);
            tpMain.Controls.Add(lbUnitsInStock);
            tpMain.Controls.Add(lbUnitPrice);
            tpMain.Controls.Add(lbWeight);
            tpMain.Controls.Add(lbCategoryId);
            tpMain.Controls.Add(lbProductName);
            tpMain.Controls.Add(lbProductId);
            tpMain.Location = new Point(4, 29);
            tpMain.Name = "tpMain";
            tpMain.Padding = new Padding(3);
            tpMain.Size = new Size(1036, 214);
            tpMain.TabIndex = 0;
            tpMain.Text = "Main";
            tpMain.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(813, 120);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 18;
            label8.Text = "Quantity";
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(896, 163);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 15;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(142, 58);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.ReadOnly = true;
            txtCategoryId.Size = new Size(150, 27);
            txtCategoryId.TabIndex = 16;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(896, 118);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(94, 27);
            numQuantity.TabIndex = 17;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(420, 163);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(249, 163);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(142, 163);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(563, 117);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.ReadOnly = true;
            txtUnitsInStock.Size = new Size(145, 27);
            txtUnitsInStock.TabIndex = 11;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(563, 58);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(145, 27);
            txtUnitPrice.TabIndex = 10;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(563, 12);
            txtWeight.Name = "txtWeight";
            txtWeight.ReadOnly = true;
            txtWeight.Size = new Size(145, 27);
            txtWeight.TabIndex = 9;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(142, 113);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(201, 27);
            txtProductName.TabIndex = 8;
            // 
            // numProductId
            // 
            numProductId.Location = new Point(142, 12);
            numProductId.Name = "numProductId";
            numProductId.ReadOnly = true;
            numProductId.Size = new Size(150, 27);
            numProductId.TabIndex = 6;
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(420, 120);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(98, 20);
            lbUnitsInStock.TabIndex = 5;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(420, 58);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(72, 20);
            lbUnitPrice.TabIndex = 4;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(420, 12);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(56, 20);
            lbWeight.TabIndex = 3;
            lbWeight.Text = "Weight";
            // 
            // lbCategoryId
            // 
            lbCategoryId.AutoSize = true;
            lbCategoryId.Location = new Point(19, 58);
            lbCategoryId.Name = "lbCategoryId";
            lbCategoryId.Size = new Size(86, 20);
            lbCategoryId.TabIndex = 2;
            lbCategoryId.Text = "Category Id";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(19, 117);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(104, 20);
            lbProductName.TabIndex = 1;
            lbProductName.Text = "Product Name";
            // 
            // lbProductId
            // 
            lbProductId.AutoSize = true;
            lbProductId.Location = new Point(19, 12);
            lbProductId.Name = "lbProductId";
            lbProductId.Size = new Size(77, 20);
            lbProductId.TabIndex = 0;
            lbProductId.Text = "Product Id";
            // 
            // tpFilter
            // 
            tpFilter.Controls.Add(label7);
            tpFilter.Controls.Add(btnClear);
            tpFilter.Controls.Add(btnSearch);
            tpFilter.Controls.Add(label6);
            tpFilter.Controls.Add(txtMaxUnit);
            tpFilter.Controls.Add(txtMinUnit);
            tpFilter.Controls.Add(label5);
            tpFilter.Controls.Add(label4);
            tpFilter.Controls.Add(label3);
            tpFilter.Controls.Add(txtMaxPrice);
            tpFilter.Controls.Add(txtMinPrice);
            tpFilter.Controls.Add(label2);
            tpFilter.Controls.Add(txtKeyword);
            tpFilter.Controls.Add(label1);
            tpFilter.Controls.Add(numProductIdFilter);
            tpFilter.Location = new Point(4, 29);
            tpFilter.Name = "tpFilter";
            tpFilter.Padding = new Padding(3);
            tpFilter.Size = new Size(1036, 214);
            tpFilter.TabIndex = 1;
            tpFilter.Text = "Filter";
            tpFilter.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(383, 13);
            label7.Name = "label7";
            label7.Size = new Size(194, 35);
            label7.TabIndex = 14;
            label7.Text = "Search Products";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(275, 154);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(138, 154);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(879, 115);
            label6.Name = "label6";
            label6.Size = new Size(23, 20);
            label6.TabIndex = 11;
            label6.Text = "to";
            // 
            // txtMaxUnit
            // 
            txtMaxUnit.Location = new Point(904, 115);
            txtMaxUnit.Name = "txtMaxUnit";
            txtMaxUnit.PlaceholderText = "Enter max units";
            txtMaxUnit.Size = new Size(125, 27);
            txtMaxUnit.TabIndex = 10;
            // 
            // txtMinUnit
            // 
            txtMinUnit.Location = new Point(748, 113);
            txtMinUnit.Name = "txtMinUnit";
            txtMinUnit.PlaceholderText = "Enter min units";
            txtMinUnit.Size = new Size(125, 27);
            txtMinUnit.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(601, 116);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 8;
            label5.Text = "Units In Stock from";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(840, 70);
            label4.Name = "label4";
            label4.Size = new Size(23, 20);
            label4.TabIndex = 7;
            label4.Text = "to";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(601, 69);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 6;
            label3.Text = "Price from";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new Point(869, 66);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.PlaceholderText = "Enter max price";
            txtMaxPrice.Size = new Size(160, 27);
            txtMaxPrice.TabIndex = 5;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(684, 65);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.PlaceholderText = "Enter min price";
            txtMinPrice.Size = new Size(150, 27);
            txtMinPrice.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 112);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "Product Name";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(138, 109);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.PlaceholderText = "Enter keyword here";
            txtKeyword.Size = new Size(231, 27);
            txtKeyword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 60);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Product Id";
            // 
            // numProductIdFilter
            // 
            numProductIdFilter.Location = new Point(138, 60);
            numProductIdFilter.Name = "numProductIdFilter";
            numProductIdFilter.Size = new Size(150, 27);
            numProductIdFilter.TabIndex = 0;
            // 
            // tpOrder
            // 
            tpOrder.Location = new Point(4, 29);
            tpOrder.Name = "tpOrder";
            tpOrder.Size = new Size(1036, 214);
            tpOrder.TabIndex = 2;
            tpOrder.Text = "Order";
            tpOrder.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 271);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1040, 260);
            dgvProducts.TabIndex = 1;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 543);
            Controls.Add(dgvProducts);
            Controls.Add(tcProducts);
            Name = "frmProducts";
            Text = "Products Management";
            tcProducts.ResumeLayout(false);
            tpMain.ResumeLayout(false);
            tpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numProductId).EndInit();
            tpFilter.ResumeLayout(false);
            tpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numProductIdFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcProducts;
        private TabPage tpMain;
        private TabPage tpFilter;
        private DataGridView dgvProducts;
        private Label lbUnitsInStock;
        private Label lbUnitPrice;
        private Label lbWeight;
        private Label lbCategoryId;
        private Label lbProductName;
        private Label lbProductId;
        private TextBox txtWeight;
        private TextBox txtProductName;
        private NumericUpDown numProductId;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private Label label2;
        private TextBox txtKeyword;
        private Label label1;
        private NumericUpDown numProductIdFilter;
        private TextBox txtMaxPrice;
        private TextBox txtMinPrice;
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox txtMaxUnit;
        private TextBox txtMinUnit;
        private Label label5;
        private Button btnClear;
        private Button btnSearch;
        private Label label7;
        private Button btnOrder;
        private TextBox txtCategoryId;
        private TabPage tpOrder;
        private Label label8;
        private NumericUpDown numQuantity;
    }
}