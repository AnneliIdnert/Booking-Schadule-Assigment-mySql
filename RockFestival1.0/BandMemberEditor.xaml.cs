using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RockFestival1._0
{
    /// <summary>
    /// Interaction logic for BandMemberEditor.xaml
    /// </summary>
    public partial class BandMemberEditor : Window
    {
        public delegate void AddMemberDelegate(object sender, AddMemberEvent e);
        public event AddMemberDelegate NewMemberAdd;
        
        string id;
        string my_name;
        string my_Tel;
        string my_About;

        public BandMemberEditor(string id)
        {
            InitializeComponent();
            this.id = id;
            lbl_MemberEditor_Label.Content = this.id;
            my_About = txt_About.Text;
            my_Tel = txt_Tel.Text;
            my_name = txt_Name.Text;
        }

        public string GetName { get { return my_name; } }
        public string GetTel { get { return my_Tel; } }
        public string GetAbout { get { return my_About; } }
        public string GetBandID { get { return id; } }


        private void btn_Save_Member_Click(object sender, RoutedEventArgs e)
        {
            //Member m = new Member(this.id, my_name, my_Tel, my_About);

            if (NewMemberAdd != null)
                NewMemberAdd(this, new AddMemberEvent(this.id, my_name, my_Tel, my_About));

            //ServerManager.InsertMember(txt_About.Text, txt_Name.Text, txt_Tel.Text, lbl_MemberEditor_Label.Content.ToString());
        //    if (newMemberAdd != null)
        //        newMemberAdd(this, new AddMemberEvent(id, txt_Name.Text, txt_Tel.Text, txt_About.Text));
        


        
        }

        
    }
}
