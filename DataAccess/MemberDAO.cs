using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        //Fields
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        //Constructor
        private MemberDAO()
        {

        }

        //Methods
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance is null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public Member Login(string Email, string Password)
        {
            using var _context = new SalesManagementDbContext();
            return _context.Members.FirstOrDefault(member => member.Email.Equals(Email) && member.Password.Equals(Password));
        }

        public List<Member> GetAllMembers()
        {
            using var _context = new SalesManagementDbContext();
            return _context.Members.ToList();
        }

        public void UpdateMember(Member member)
        {
            using var _context = new SalesManagementDbContext();
            _context.Members.Update(member);
            _context.SaveChanges();
        }

        public void AddMember(Member member)
        {
            using var _context = new SalesManagementDbContext();
            _context.Members.Add(member);
            _context.SaveChanges();
        }

        public void DeleteMember(Member member)
        {
            using var _context = new SalesManagementDbContext();
            _context.Remove(member);
            _context.SaveChanges();
        }
    }
}
