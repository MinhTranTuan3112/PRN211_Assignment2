namespace SalesWinApp
{
    partial class frmOrders
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
            dgvOrders = new DataGridView();
            lbOrders = new Label();
            label1 = new Label();
            label2 = new Label();
            dtStartDate = new DateTimePicker();
            dtEndDate = new DateTimePicker();
            btnSearch = new Button();
            cbSort = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(12, 275);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 29;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(855, 257);
            dgvOrders.TabIndex = 0;
            // 
            // lbOrders
            // 
            lbOrders.AutoSize = true;
            lbOrders.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbOrders.ForeColor = Color.FromArgb(255, 128, 0);
            lbOrders.Location = new Point(332, 19);
            lbOrders.Name = "lbOrders";
            lbOrders.Size = new Size(176, 37);
            lbOrders.TabIndex = 1;
            lbOrders.Text = "Order History";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 120);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 2;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 168);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 3;
            label2.Text = "to";
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new Point(78, 115);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(250, 27);
            dtStartDate.TabIndex = 4;
            // 
            // dtEndDate
            // 
            dtEndDate.Location = new Point(78, 163);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(250, 27);
            dtEndDate.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(159, 221);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(169, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbSort
            // 
            cbSort.AutoSize = true;
            cbSort.Location = new Point(22, 224);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(116, 24);
            cbSort.TabIndex = 7;
            cbSort.Text = "Sort By Sales";
            cbSort.UseVisualStyleBackColor = true;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 544);
            Controls.Add(cbSort);
            Controls.Add(btnSearch);
            Controls.Add(dtEndDate);
            Controls.Add(dtStartDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbOrders);
            Controls.Add(dgvOrders);
            Name = "frmOrders";
            Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private Label lbOrders;
        private Label label1;
        private Label label2;
        private DateTimePicker dtStartDate;
        private DateTimePicker dtEndDate;
        private Button btnSearch;
        private CheckBox cbSort;
    }
}