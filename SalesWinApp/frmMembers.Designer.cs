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
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMemberId).BeginInit();
            SuspendLayout();
            // 
            // dgvMembers
            // 
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(12, 239);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.RowTemplate.Height = 29;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(930, 294);
            dgvMembers.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(477, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(197, 27);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(477, 111);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(197, 27);
            txtCity.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(477, 61);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(197, 27);
            txtCountry.TabIndex = 9;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(161, 165);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.ReadOnly = true;
            txtCompanyName.Size = new Size(204, 27);
            txtCompanyName.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(161, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(204, 27);
            txtEmail.TabIndex = 7;
            // 
            // numMemberId
            // 
            numMemberId.Location = new Point(161, 61);
            numMemberId.Name = "numMemberId";
            numMemberId.ReadOnly = true;
            numMemberId.Size = new Size(119, 27);
            numMemberId.TabIndex = 6;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(387, 172);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 5;
            lbPassword.Text = "Password";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(387, 61);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 4;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(387, 118);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 3;
            lbCity.Text = "City";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(12, 172);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(116, 20);
            lbCompanyName.TabIndex = 2;
            lbCompanyName.Text = "Company Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(12, 118);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(12, 61);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(82, 20);
            lbMemberId.TabIndex = 0;
            lbMemberId.Text = "Member Id";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(973, 300);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(973, 357);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 545);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(txtPassword);
            Controls.Add(txtCity);
            Controls.Add(dgvMembers);
            Controls.Add(txtCountry);
            Controls.Add(txtEmail);
            Controls.Add(txtCompanyName);
            Controls.Add(lbMemberId);
            Controls.Add(lbEmail);
            Controls.Add(numMemberId);
            Controls.Add(lbCompanyName);
            Controls.Add(lbPassword);
            Controls.Add(lbCity);
            Controls.Add(lbCountry);
            Name = "frmMembers";
            Text = "Members Management";
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMemberId).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}