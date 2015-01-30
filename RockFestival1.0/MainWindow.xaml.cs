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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace RockFestival1._0
{
     //<summary>
     //Interaction logic for MainWindow.xaml
     //</summary>
    public partial class MainWindow_Logic : Window
    {
                MemberManager m;
                
                public MainWindow_Logic()
                {
                    InitializeComponent();
                    m = new MemberManager();

                }

                //GUI logic


                private void GetSecuritySchedule()
                {
                    //int days_time_etc = 4;
                    //int index = 0;

                    
                   
                    
                    

                    //array of info
                    //List<String> info = new List<String>();
                    //info[0] = day; //day
                    //info[1] = location; //location
                    //info[2] = startTime; //s time
                    //string endTime; //e time

                    //List<List<string>> myList = new List<List<string>>();
                   // List<List<String>> schedule = new List<List<string>>();

                    //myList.Add(new List<string> { "a", "b" });
                    //for (int i = 0; i < days_time_etc; i++)
                    //{
                    //}
                //     string day = string.Empty;
                //string location = string.Empty;
                //string startTime = string.Empty;
                // string endTime = string.Empty;

                //    if (chk_Thursday_day.IsChecked == true && chk_Thursday_day_LocationA.IsChecked == true)
                //    {
                //        day = lbl_Thurs.ToString();
                //       location = "A";
                //        startTime = "10:00";
                //        endTime = "17:00";
                //    }

                //    if (chk_Thursday_day.IsChecked == true && chk_Thursday_dayLocationB.IsChecked == true)
                //    {
                //        day = lbl_Thurs.ToString();
                //        location = "B";
                //        startTime = "10:00";
                //        endTime = "17:00";
                //    }

                //    if (chk_Thursday_Evening.IsChecked == true && chk_Thursday_Evening_LocationA.IsChecked == true)
                //    {
                //        day = lbl_Thurs.ToString();
                //        location = "A";
                //        startTime = "17:00";
                //        endTime = "24:00";
                //    }

                //    if (chk_Thursday_Evening.IsChecked == true && chk_Thursday_EveningLocationB.IsChecked == true)
                //    {
                //        day = lbl_Thurs.ToString();
                //        location = "B";
                //        startTime = "17:00";
                //        endTime = "24:00";
                //    }

                //    if (chk_Friday_day.IsChecked == true && chk_Friday_day_LocationA.IsChecked == true)
                //    {
                //        day = lbl_Friday.ToString();
                //        location = "A";
                //        startTime = "10:00";
                //        endTime = "17:00";
                //    }

                //    if (chk_Friday_day.IsChecked == true && chk_Friday_dayLocationB.IsChecked == true)
                //    {
                //        day = lbl_Friday.ToString();
                //        location = "B";
                //        startTime = "10:00";
                //        endTime = "17:00";
                //    }

                //    if (chk_Friday_Evening.IsChecked == true && chk_Saturday_Evening_LocationA.IsChecked == true)
                //    {
                //        day = lbl_Friday.ToString();
                //        location = "A";
                //        startTime = "17:00";
                //        endTime = "24:00";
                //    }

                //    if (chk_Friday_Evening.IsChecked == true && chk_Friday_Evening_LocationB.IsChecked == true)
                //    {
                //        day = lbl_Friday.ToString();
                //        location = "B";
                //        startTime = "17:00";
                //        endTime = "24:00";
                //    }

                //    if (chk_Saturday_day.IsChecked == true && chk_Saturday_day_LocationA.IsChecked == true)
                //    {
                //        day = lbl_Saturday.ToString();
                //        location = "A";
                //        startTime = "10:00";
                //        endTime = "17:00";
                //    }
                //    if (chk_Saturday_day.IsChecked == true && chk_Saturday_dayLocationB.IsChecked == true)
                //    {
                //        day = lbl_Saturday.ToString();
                //        location = "B";
                //        startTime = "10:00";
                //        endTime = "17:00";
                //    }
                //    if (chk_Saturday_Evening.IsChecked == true && chk_Saturday_Evening_LocationA.IsChecked == true)
                //    {
                //        day = lbl_Saturday.ToString();
                //        location = "A";
                //        startTime = "17:00";
                //        endTime = "24:00";
                //    }
                //    if (chk_Saturday_Evening.IsChecked == true && chk_Saturday_EveningLocationB.IsChecked == true)
                //    {
                //        day = lbl_Saturday.ToString();
                //        location = "B";
                //        startTime = "17:00";
                //        endTime = "24:00";
                //    }
                }

                //Database Connection handlers
                private void btn_Insert_Worker_Click(object sender, RoutedEventArgs e)
                {
                    string day = string.Empty;
                    string location = string.Empty;
                    string startTime = string.Empty;
                    string endTime = string.Empty;

                    if (chk_Thursday_day.IsChecked == true && chk_Thursday_day_LocationA.IsChecked == true)
                    {
                        day = lbl_Thurs.ToString();
                        location = "A";
                        startTime = "10:00";
                        endTime = "17:00";
                    }

                    if (chk_Thursday_day.IsChecked == true && chk_Thursday_dayLocationB.IsChecked == true)
                    {
                        day = lbl_Thurs.ToString();
                        location = "B";
                        startTime = "10:00";
                        endTime = "17:00";
                    }

                    if (chk_Thursday_Evening.IsChecked == true && chk_Thursday_Evening_LocationA.IsChecked == true)
                    {
                        day = lbl_Thurs.ToString();
                        location = "A";
                        startTime = "17:00";
                        endTime = "24:00";
                    }

                    if (chk_Thursday_Evening.IsChecked == true && chk_Thursday_EveningLocationB.IsChecked == true)
                    {
                        day = lbl_Thurs.ToString();
                        location = "B";
                        startTime = "17:00";
                        endTime = "24:00";
                    }

                    if (chk_Friday_day.IsChecked == true && chk_Friday_day_LocationA.IsChecked == true)
                    {
                        day = lbl_Friday.ToString();
                        location = "A";
                        startTime = "10:00";
                        endTime = "17:00";
                    }

                    if (chk_Friday_day.IsChecked == true && chk_Friday_dayLocationB.IsChecked == true)
                    {
                        day = lbl_Friday.ToString();
                        location = "B";
                        startTime = "10:00";
                        endTime = "17:00";
                    }

                    if (chk_Friday_Evening.IsChecked == true && chk_Saturday_Evening_LocationA.IsChecked == true)
                    {
                        day = lbl_Friday.ToString();
                        location = "A";
                        startTime = "17:00";
                        endTime = "24:00";
                    }

                    if (chk_Friday_Evening.IsChecked == true && chk_Friday_Evening_LocationB.IsChecked == true)
                    {
                        day = lbl_Friday.ToString();
                        location = "B";
                        startTime = "17:00";
                        endTime = "24:00";
                    }

                    if (chk_Saturday_day.IsChecked == true && chk_Saturday_day_LocationA.IsChecked == true)
                    {
                        day = lbl_Saturday.ToString();
                        location = "A";
                        startTime = "10:00";
                        endTime = "17:00";
                    }
                    if (chk_Saturday_day.IsChecked == true && chk_Saturday_dayLocationB.IsChecked == true)
                    {
                        day = lbl_Saturday.ToString();
                        location = "B";
                        startTime = "10:00";
                        endTime = "17:00";
                    }
                    if (chk_Saturday_Evening.IsChecked == true && chk_Saturday_Evening_LocationA.IsChecked == true)
                    {
                        day = lbl_Saturday.ToString();
                        location = "A";
                        startTime = "17:00";
                        endTime = "24:00";
                    }
                    if (chk_Saturday_Evening.IsChecked == true && chk_Saturday_EveningLocationB.IsChecked == true)
                    {
                        day = lbl_Saturday.ToString();
                        location = "B";
                        startTime = "17:00";
                        endTime = "24:00";
                    }

                    if (CheckInputAdd(txt_FirstName.Text, txt_LastName.Text, txt_ID.Text, txt_Tel_Nr.Text ))
                    {

                        ServerManager.InsertWorker(txt_FirstName.Text, txt_LastName.Text, txt_ID.Text, txt_Tel_Nr.Text, txt_Ssn_Worker.Text, day, startTime, endTime, location);
                    }

                    else MessageBox.Show("Please Enter all required fields. \n (Name, ID, Tel.Nr)");
                }

                private void btn_Select_Click(object sender, RoutedEventArgs e)
                {
                    if (CheckInputSearch(txt_FirstName.Text))
                    {
                        ServerManager.Select(txt_FirstName.Text);

                    }
                    else MessageBox.Show("Please Enter all required fields.");
                }

                //Main Window buttons
                private void btn_Search_Click(object sender, RoutedEventArgs e)
                {

                    lstbx_Search_Result.Items.Clear(); //clear search results
                    if (CheckInputSearch(txtSearch.Text))
                    {
                        String result = ServerManager.Find(txtSearch.Text);

                        if (result != null)
                        {
                            lstbx_Search_Result.Items.Add(result);
                        }
                        //else txtSearch.Text = "No match found";
                    }
                    else
                    {
                        String result2 = ServerManager.SearchAllWorkers();
                        lstbx_Search_Result.Items.Add(result2);

                    }

                }

     
        private void btn_Create_Band_Click(object sender, RoutedEventArgs e)
        {
            BandMemberEditor b = new BandMemberEditor(txt_BandID.Text);
            b.Show();
            b.NewMemberAdd += OnNewMemberAdd;

        }
  
        //Input Checkers
        private bool CheckInputSearch(string input)
        {
            if (input == string.Empty)
                return false;
            else return true;
        }
        private bool CheckInputAdd(string name1, string name2, string id, string tel)
        {
            if (name1 == string.Empty || name2 == string.Empty || id == string.Empty || tel == string.Empty)
                return false;
            else return true;
        }


        //private void rbn_security_Checked(object sender, RoutedEventArgs e)
        //{
        //    rbn_security = true;
        //    rbn_B.IsEnabled = true;
        //}

        //private void rbn_Contact_Person_Checked(object sender, RoutedEventArgs e)
        //{
        //    rbn_security = false;
        //    rbn_B.IsEnabled = false;

        //}


        private void UpdateListView()
        {
            list_View_AddMember.Items.Clear();

            foreach (var member in m.GetMemberList())
            {
                list_View_AddMember.Items.Add(member);
            }
        }

        public void OnNewMemberAdd(object sender, AddMemberEvent e)
        {
            m.AddMember(new Member(e.GetBandID, e.GetName, e.GetTel, e.GetAbout));
            UpdateListView();
        }

        private void rbn_security_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rbn_Contact_Person_Checked(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// Inserting a bandmember
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btn_Insert_Member_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (var member in m.GetMemberList())
            {
                ServerManager.InsertMember(member.GetAbout, member.GetName, member.GetTel, member.GetBandID);
            }
          
        }
       
           /// <summary>
           /// Sending information about the bandmember
           /// </summary>
           /// <param name="sender"></param>
           /// <param name="e"></param>

        private void lstbx_Search_SelectedIndex(object sender, SelectionChangedEventArgs e)
        {
            if (CheckInputSearch(lstbx_Search_Result.SelectedItem.ToString()))
            {
                string[] resultArry = ServerManager.Select(lstbx_Search_Result.SelectedItem.ToString());

                txt_ID.Text = resultArry[0];
                txt_Ssn_Worker.Text = resultArry[2];
                txt_FirstName.Text = resultArry[1];
                txt_Tel_Nr.Text = resultArry[3];
            }
            else MessageBox.Show("Please Enter all required fields.");
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

      

        /// <summary>
        /// Saving the band and performance schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBandNew(object sender, RoutedEventArgs e)
        {
            string day = string.Empty;
            string location = string.Empty;
            string startTime = string.Empty;
            string endTime = string.Empty;
            string id_Performance = string.Empty;

            if (day_One_locationA.IsChecked == true && day_One_locationB.IsChecked == false)
            {
                day = dayOne.ToString();
                id_Performance = id_One.ToString();
                startTime = time_dayOne.ToString();
                endTime = time_dayOneEnd.ToString();
                location = "A";

            }
            if (day_One_locationA.IsChecked == false && day_One_locationB.IsChecked == true)
            {
                day = dayOne.ToString();
                id_Performance = id_One.ToString();
                startTime = time_dayOne.ToString();
                endTime = time_dayOneEnd.ToString();
                location = "B";

            }
            if (day_Two_locationA.IsChecked == true && day_Two_locationB.IsChecked == false)
            {
                day = dayTwo.ToString();
                id_Performance = id_Two.ToString();
                startTime = time_DayTwo.ToString();
                endTime = time_DayTwo_End.ToString();
                location = "A";

            }
            if (day_Two_locationA.IsChecked == false && day_Two_locationB.IsChecked == true)
            {
                day = dayTwo.ToString();
                id_Performance = id_Two.ToString();
                startTime = time_DayTwo.ToString();
                endTime = time_DayTwo_End.ToString();
                location = "B";

            }
            if (day_Tree_locationA.IsChecked == true && day_Tree_locationB.IsChecked == false)
            {
                day = dayTree.ToString();
                id_Performance = id_Tree.ToString();
                startTime = time_DayTree.ToString();
                endTime = time_DayTree.ToString();
                location = "A";

            }
            if (day_Tree_locationA.IsChecked == false && day_Tree_locationB.IsChecked == true)
            {
                day = dayTree.ToString();
                id_Performance = id_Tree.ToString();
                startTime = time_DayTree.ToString();
                endTime = time_DayTree_End.ToString();
                location = "B";

            }
        }
     

  

       

       
            
        


    }
}
