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
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var MemberManagementForm = new frmMembers();
            MemberManagementForm.MdiParent = this;
            MemberManagementForm.Show();
        }
    }
}
