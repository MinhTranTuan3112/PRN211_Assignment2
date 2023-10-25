using BusinessObject.Models;
using DataAccess.Repository;
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
        private readonly IMemberRepository repository = new MemberRepository();
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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void PerformLogin()
        {
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            var member = repository.Login(Email, Password);
            if (member is not null)
            {
                frmMain mainForm = new frmMain();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong email or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


    }
}
