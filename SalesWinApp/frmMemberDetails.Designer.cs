namespace SalesWinApp
{
    partial class frmMemberDetails
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
            label1 = new Label();
            txtPassword = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtEmail = new TextBox();
            txtCompanyName = new TextBox();
            label2 = new Label();
            lbEmail = new Label();
            numMemberId = new NumericUpDown();
            lbCompanyName = new Label();
            lbPassword = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numMemberId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(421, 42);
            label1.Name = "label1";
            label1.Size = new Size(205, 37);
            label1.TabIndex = 0;
            label1.Text = "Member Details";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(646, 238);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(197, 27);
            txtPassword.TabIndex = 23;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(646, 184);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(197, 27);
            txtCity.TabIndex = 22;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(646, 134);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(197, 27);
            txtCountry.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(302, 184);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 27);
            txtEmail.TabIndex = 19;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(302, 238);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(204, 27);
            txtCompanyName.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 134);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 12;
            label2.Text = "Member Id";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(153, 191);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 13;
            lbEmail.Text = "Email";
            // 
            // numMemberId
            // 
            numMemberId.Location = new Point(302, 134);
            numMemberId.Name = "numMemberId";
            numMemberId.Size = new Size(119, 27);
            numMemberId.TabIndex = 18;
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(153, 245);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(116, 20);
            lbCompanyName.TabIndex = 14;
            lbCompanyName.Text = "Company Name";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(556, 245);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 17;
            lbPassword.Text = "Password";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(556, 191);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 15;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(556, 134);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 16;
            lbCountry.Text = "Country";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(412, 317);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(556, 317);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 505);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtCity);
            Controls.Add(txtCountry);
            Controls.Add(txtEmail);
            Controls.Add(txtCompanyName);
            Controls.Add(label2);
            Controls.Add(lbEmail);
            Controls.Add(numMemberId);
            Controls.Add(lbCompanyName);
            Controls.Add(lbPassword);
            Controls.Add(lbCity);
            Controls.Add(lbCountry);
            Controls.Add(label1);
            Name = "frmMemberDetails";
            Text = "Member Details";
            ((System.ComponentModel.ISupportInitialize)numMemberId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtEmail;
        private TextBox txtCompanyName;
        private Label label2;
        private Label lbEmail;
        private NumericUpDown numMemberId;
        private Label lbCompanyName;
        private Label lbPassword;
        private Label lbCity;
        private Label lbCountry;
        private Button btnSave;
        private Button btnCancel;
    }
}