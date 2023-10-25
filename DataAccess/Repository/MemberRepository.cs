using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddMember(Member member)
        {
            MemberDAO.Instance.AddMember(member);
        }

        public void DeleteMember(Member member)
        {
            MemberDAO.Instance.DeleteMember(member);
        }

        public List<Member> GetAllMembers()
        {
            return MemberDAO.Instance.GetAllMembers();
        }

        public Member Login(string Email, string Password)
        {
            return MemberDAO.Instance.Login(Email, Password);
        }

        public void UpdateMember(Member member)
        {
            MemberDAO.Instance.UpdateMember(member);
        }
    }
}
