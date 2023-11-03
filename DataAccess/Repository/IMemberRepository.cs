using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public Member Login(string Email, string Password);
        public List<Member> GetAllMembers(string keyword = "", string CompanyName="");
        public void UpdateMember(Member member);
        public void AddMember(Member member);
        public void DeleteMember(Member member);
    }
}
