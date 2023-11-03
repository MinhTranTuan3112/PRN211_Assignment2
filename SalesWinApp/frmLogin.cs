using BusinessObject.Models;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        //Fields
        private readonly IMemberRepository repository = new MemberRepository();
        
        string Email
        {
            get => txtEmail.Text;
            set => txtEmail.Text = value;
        }

        string Password
        {
            get => txtPassword.Text;
            set => txtPassword.Text = value;
        }

        //Constructor
        public frmLogin()
        {
            InitializeComponent();
            RaiseEvent();
        }

        private void RaiseEvent()
        {
            this.Load += frmLogin_Load;
            btnLogin.Click += btnLogin_Click;
            txtPassword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    PerformLogin();
                }
            };
            btnClose.Click += btnClose_Click;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Good bye");
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        struct AdminAccount {
            public string AdminEmail { get; set; }
            public string AdminPassword { get; set; }
        }
        
        private AdminAccount GetAdminAccount()
        {
            IConfiguration config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", true, true)
                 .Build();
            string adminEmail = config["AdminAccount:Email"] ?? string.Empty;
            string adminPassword = config["AdminAccount:Password"] ?? string.Empty;
            return new AdminAccount { AdminEmail = adminEmail, AdminPassword = adminPassword };
        }

        private void PerformLogin()
        {
            try
            {
                //Check login as admin
                var adminAccount = GetAdminAccount();
                if (Email.Equals(adminAccount.AdminEmail) && Password.Equals(adminAccount.AdminPassword))
                {
                    frmMain mainForm = new frmMain(true)
                    {
                    };
                    this.Hide();
                    mainForm.Show();
                    return;
                }


                //Check login for members
                var member = repository.Login(Email, Password);
                if (member is not null)
                {
                    MemberSession.member = member;
                    frmMain mainForm = new frmMain(false);
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Wrong email or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


    }
}
