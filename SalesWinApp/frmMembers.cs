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
    public partial class frmMembers : Form
    {
        private readonly IMemberRepository repository = new MemberRepository();
        private BindingSource source;
        public frmMembers()
        {
            InitializeComponent();
            RaiseEvent();
        }

        private void RaiseEvent()
        {
            this.Load += frmMembers_Load;
            dgvMembers.SelectionChanged += dgvMembers_SelectionChanged;
            dgvMembers.CellDoubleClick += dgvMembers_CellDoubleClick;
            btnDelete.Click += btnDelete_Click;
            btnCreate.Click += btnCreate_Click;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var DetailsMemberForm = new frmMemberDetails()
            {
                IsEdit = false
            };
            if (DetailsMemberForm.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
            }
        }

        private void dgvMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var member = GetMemberFromSelectingRow();
            var DetailsMemberForm = new frmMemberDetails()
            {
                IsEdit = true,
                CurrentMember = member
            };
            if (DetailsMemberForm.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Delete this member?", "Delete member", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteMember();
            }
        }

        private Member GetMemberFromSelectingRow()
        {
            Member member = null;
            if (dgvMembers.SelectedRows.Count > 0)
            {
                var selectedRow = dgvMembers.SelectedRows[0];
                int MemberId = Convert.ToInt32(selectedRow.Cells["MemberId"].Value);
                string Email = selectedRow.Cells["Email"].Value.ToString();
                string CompanyName = selectedRow.Cells["CompanyName"].Value.ToString();
                string Country = selectedRow.Cells["Country"].Value.ToString();
                string City = selectedRow.Cells["City"].Value.ToString();
                string Password = selectedRow.Cells["Password"].Value.ToString();

                member = new Member()
                {
                    MemberId = MemberId,
                    Email = Email,
                    CompanyName = CompanyName,
                    Country = Country,
                    City = City,
                    Password = Password
                };
            }
            return member;
        }

        private void DeleteMember()
        {
            var member = GetMemberFromSelectingRow();
            repository.DeleteMember(member);
            LoadMemberList();
        }

        private void dgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            var member = GetMemberFromSelectingRow();
            if (member is null)
            {
                return;
            }
            UpdateMemberOnTextBoxes(member);
        }

        private void ClearText()
        {
            numMemberId.Value = 0;
            txtEmail.Clear();
            txtCompanyName.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtPassword.Clear();
        }

        private void UpdateMemberOnTextBoxes(Member member)
        {
            if (member is null)
            {
                return;
            }
            numMemberId.Value = member.MemberId;
            txtEmail.Text = member.Email;
            txtCompanyName.Text = member.CompanyName;
            txtCity.Text = member.City;
            txtCountry.Text = member.Country;
            txtPassword.Text = member.Password;
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadMemberList();
        }

        private void LoadMemberList()
        {
            var MemberList = repository.GetAllMembers();
            source = new BindingSource();
            source.DataSource = MemberList;
            numMemberId.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCompanyName.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtPassword.DataBindings.Clear();


            numMemberId.DataBindings.Add("Text", source, "MemberId");
            txtEmail.DataBindings.Add("Text", source, "Email");
            txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
            txtCity.DataBindings.Add("Text", source, "City");
            txtCountry.DataBindings.Add("Text", source, "Country");
            txtPassword.DataBindings.Add("Text", source, "Password");


            dgvMembers.DataSource = null;
            dgvMembers.DataSource = MemberList;

        }
    }
}
