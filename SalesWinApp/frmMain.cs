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
    public partial class frmMain : Form
    {
        //Fields
        public bool IsAdmin { get; set; }
        private readonly IMemberRepository memberRepository = new MemberRepository();

        //Constructor
        public frmMain(bool isAdmin)
        {
            this.IsAdmin = isAdmin;
            InitializeComponent();
            Authentication();
            RaiseEvent();
        }

        private void Authentication()
        {
            if (IsAdmin == false)
            {
                membersToolStripMenuItem.Visible = false;
            }
        }
        private void RaiseEvent()
        {
            membersToolStripMenuItem.Click += membersToolStripMenuItem_Click;
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            viewOrdersToolStripMenuItem.Click += viewOrdersToolStripMenuItem_Click;

            //For member
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsAdmin == true)
            {
                return;
            }
            var member = MemberSession.member;
            var detailsMemberForm = new frmMemberDetails(true, this.IsAdmin)
            {
                CurrentMember = member,
            };
            //detailsMemberForm.MdiParent = this;
            detailsMemberForm.ShowDialog();
        }

        private void viewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orderForm = new frmOrders(this.IsAdmin);
            orderForm.MdiParent = this;
            orderForm.Show();
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
            var ProductForm = new frmProducts(this.IsAdmin);
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
