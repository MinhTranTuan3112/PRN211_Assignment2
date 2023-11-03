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
    public partial class frmMemberDetails : Form
    {
        private readonly IMemberRepository repository = new MemberRepository();
        public Member CurrentMember;
        public bool IsEdit { get; set; }
        public bool IsAdmin { get; set; }

        public frmMemberDetails(bool isEdit, bool isAdmin)
        {
            this.IsEdit = isEdit;
            InitializeComponent();
            Authenticate();
            RaiseEvent();
        }

        private void Authenticate()
        {
            if (IsEdit == true)
            {
                numMemberId.ReadOnly = true;
            }
            else
            {
                numMemberId.ReadOnly = false;
            }
        }

        private void RaiseEvent()
        {
            this.Load += frmMemberDetails_Load;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += delegate
            {
                this.Close();
            };
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            try
            {  
                LoadMemberData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Load Member Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Caption = (IsEdit) ? "Update member" : "Create member";
                var Result = MessageBox.Show("Save this member?", Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    SaveMember();
                    MessageBox.Show((IsEdit) ? "Updated this member" : "Added this member", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, (IsEdit) ? "Update Member Error" : "Add Member Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Member GetMemberData()
        {
            int MemberId = Convert.ToInt32(numMemberId.Value);
            string Email = txtEmail.Text;
            string CompanyName = txtCompanyName.Text;
            string City = txtCity.Text;
            string Country = txtCountry.Text;
            string Password = txtPassword.Text;
            var member = new Member()
            {
                MemberId = MemberId,
                Email = Email,
                CompanyName = CompanyName,
                City = City,
                Country = Country,
                Password = Password
            };
            return member;
        }

        private void SaveMember()
        {
            try
            {
                var member = GetMemberData();
                if (IsEdit)
                {
                    if (MemberSession.member.MemberId == member.MemberId)
                    {
                        MemberSession.member = member;
                    }
                    repository.UpdateMember(member);
                }
                else
                {
                    repository.AddMember(member);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, (IsEdit) ? "Update Member Error" : "Add Member Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMemberData()
        {
            if (CurrentMember is null || !IsEdit)
            {
                return;
            }
            numMemberId.Value = CurrentMember.MemberId;
            txtEmail.Text = CurrentMember.Email;
            txtCompanyName.Text = CurrentMember.CompanyName;
            txtCountry.Text = CurrentMember.Country;
            txtCity.Text = CurrentMember.City;
            txtPassword.Text = CurrentMember.Password;
        }
    }
}
