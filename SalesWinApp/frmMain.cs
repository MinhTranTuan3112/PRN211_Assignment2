using BusinessObject.Models;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            RaiseEvent();
        }

        private void RaiseEvent()
        {
            membersToolStripMenuItem.Click += membersToolStripMenuItem_Click;
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Good bye!");
                Application.Exit();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PerformLogOut();
            }
        }

        private void PerformLogOut()
        {
            MemberSession.member = null;
            this.Close();
            var LoginForm = new frmLogin();
            LoginForm.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ProductForm = new frmProducts();
            ProductForm.MdiParent = this;
            gbContent.Visible = false;
            ProductForm.Show();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var MemberManagementForm = new frmMembers();
            MemberManagementForm.MdiParent = this;
            gbContent.Visible = false;
            MemberManagementForm.Show();
        }
    }
}
