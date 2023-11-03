namespace SalesWinApp
{
    partial class frmMembers
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
            dgvMembers = new DataGridView();
            txtPassword = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtCompanyName = new TextBox();
            txtEmail = new TextBox();
            numMemberId = new NumericUpDown();
            lbPassword = new Label();
            lbCountry = new Label();
            lbCity = new Label();
            lbCompanyName = new Label();
            lbEmail = new Label();
            lbMemberId = new Label();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnRefresh = new Button();
            tcMembers = new TabControl();
            tpMain = new TabPage();
            tpFilter = new TabPage();
            btnSearch = new Button();
            label2 = new Label();
            cbCompanyName = new ComboBox();
            txtKeyword = new TextBox();
            label1 = new Label();
            btnResetFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMemberId).BeginInit();
            tcMembers.SuspendLayout();
            tpMain.SuspendLayout();
            tpFilter.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMembers
            // 
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(16, 319);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.RowTemplate.Height = 29;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(1067, 214);
            dgvMembers.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(487, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(197, 27);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(487, 69);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(197, 27);
            txtCity.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(487, 19);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(197, 27);
            txtCountry.TabIndex = 9;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(171, 123);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.ReadOnly = true;
            txtCompanyName.Size = new Size(204, 27);
            txtCompanyName.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(171, 69);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(204, 27);
            txtEmail.TabIndex = 7;
            // 
            // numMemberId
            // 
            numMemberId.Location = new Point(171, 19);
            numMemberId.Name = "numMemberId";
            numMemberId.ReadOnly = true;
            numMemberId.Size = new Size(119, 27);
            numMemberId.TabIndex = 6;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(397, 130);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 5;
            lbPassword.Text = "Password";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(397, 19);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 4;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(397, 76);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 3;
            lbCity.Text = "City";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(22, 130);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(116, 20);
            lbCompanyName.TabIndex = 2;
            lbCompanyName.Text = "Company Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(22, 76);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(22, 19);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(82, 20);
            lbMemberId.TabIndex = 0;
            lbMemberId.Text = "Member Id";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(397, 186);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(590, 186);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(171, 186);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(22, 186);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // tcMembers
            // 
            tcMembers.Controls.Add(tpMain);
            tcMembers.Controls.Add(tpFilter);
            tcMembers.Location = new Point(12, 25);
            tcMembers.Name = "tcMembers";
            tcMembers.SelectedIndex = 0;
            tcMembers.Size = new Size(1075, 273);
            tcMembers.TabIndex = 17;
            // 
            // tpMain
            // 
            tpMain.Controls.Add(lbEmail);
            tpMain.Controls.Add(lbCountry);
            tpMain.Controls.Add(btnDelete);
            tpMain.Controls.Add(btnUpdate);
            tpMain.Controls.Add(btnCreate);
            tpMain.Controls.Add(btnRefresh);
            tpMain.Controls.Add(lbCity);
            tpMain.Controls.Add(lbPassword);
            tpMain.Controls.Add(txtPassword);
            tpMain.Controls.Add(lbCompanyName);
            tpMain.Controls.Add(txtCity);
            tpMain.Controls.Add(numMemberId);
            tpMain.Controls.Add(txtCountry);
            tpMain.Controls.Add(lbMemberId);
            tpMain.Controls.Add(txtEmail);
            tpMain.Controls.Add(txtCompanyName);
            tpMain.Location = new Point(4, 29);
            tpMain.Name = "tpMain";
            tpMain.Padding = new Padding(3);
            tpMain.Size = new Size(1067, 240);
            tpMain.TabIndex = 0;
            tpMain.Text = "Main";
            tpMain.UseVisualStyleBackColor = true;
            // 
            // tpFilter
            // 
            tpFilter.Controls.Add(btnResetFilter);
            tpFilter.Controls.Add(btnSearch);
            tpFilter.Controls.Add(label2);
            tpFilter.Controls.Add(cbCompanyName);
            tpFilter.Controls.Add(txtKeyword);
            tpFilter.Controls.Add(label1);
            tpFilter.Location = new Point(4, 29);
            tpFilter.Name = "tpFilter";
            tpFilter.Padding = new Padding(3);
            tpFilter.Size = new Size(1067, 240);
            tpFilter.TabIndex = 1;
            tpFilter.Text = "Filter";
            tpFilter.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(166, 186);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(178, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 139);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Company Name";
            // 
            // cbCompanyName
            // 
            cbCompanyName.FormattingEnabled = true;
            cbCompanyName.Location = new Point(166, 136);
            cbCompanyName.Name = "cbCompanyName";
            cbCompanyName.Size = new Size(178, 28);
            cbCompanyName.TabIndex = 2;
            cbCompanyName.Text = "Select Company Name";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(33, 77);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.PlaceholderText = "Enter member email";
            txtKeyword.Size = new Size(311, 27);
            txtKeyword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(406, 12);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 0;
            label1.Text = "Search Members";
            // 
            // btnResetFilter
            // 
            btnResetFilter.Location = new Point(33, 186);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(94, 29);
            btnResetFilter.TabIndex = 5;
            btnResetFilter.Text = "Reset Filter";
            btnResetFilter.UseVisualStyleBackColor = true;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 545);
            Controls.Add(dgvMembers);
            Controls.Add(tcMembers);
            Name = "frmMembers";
            Text = "Members Management";
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMemberId).EndInit();
            tcMembers.ResumeLayout(false);
            tpMain.ResumeLayout(false);
            tpMain.PerformLayout();
            tpFilter.ResumeLayout(false);
            tpFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMembers;
        private Label lbEmail;
        private Label lbMemberId;
        private TextBox txtCompanyName;
        private TextBox txtEmail;
        private NumericUpDown numMemberId;
        private Label lbPassword;
        private Label lbCountry;
        private Label lbCity;
        private Label lbCompanyName;
        private TextBox txtPassword;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRefresh;
        private TabControl tcMembers;
        private TabPage tpMain;
        private TabPage tpFilter;
        private Label label1;
        private TextBox txtKeyword;
        private Label label2;
        private ComboBox cbCompanyName;
        private Button btnSearch;
        private Button btnResetFilter;
    }
}