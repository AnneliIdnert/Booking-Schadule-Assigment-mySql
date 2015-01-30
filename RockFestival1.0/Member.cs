using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RockFestival1._0
{
    class Member
    {
        string my_bandID;
        string my_name;
        string my_Tel;
        string my_About;

        public Member(string id, string name, string tel, string about)
        {
            this.my_bandID = id;
            this.my_name = name;
            this.my_Tel = tel;
            this.my_About = about;
        }

        public string GetName { get { return my_name; } }
        public string GetTel { get { return my_Tel; } }
        public string GetAbout { get { return my_About; } }
        public string GetBandID { get { return my_bandID; } }
    }
}
