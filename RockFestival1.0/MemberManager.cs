using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockFestival1._0
{
    class MemberManager
    {

        private readonly List<Member> memberList;

        public MemberManager()
        {
            memberList = new List<Member>();
        }

        public void AddMember(Member member)
        {
            memberList.Add(member);
        }

        public List<Member> GetMemberList()
        {
            return memberList;
        }
    }
}
