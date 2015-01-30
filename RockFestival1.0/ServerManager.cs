using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RockFestival1._0
{
    public class ServerManager
    {
        private static String host = "195.178.235.60";
        private static String user = "ac9583";
        private static String pass = "frogseatFrogs";
        private static String db = "ac9583";
        private static String connStr = "server=" + host + ";uid=" + user + ";pwd=" + pass + ";database=" + db + ";";




        public static void InsertWorker(string f_Name, string l_Name, string i_d, string tel_Nr, string p_Nr, string location, string startTime, string endTime, string day)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                string name = f_Name + " " + l_Name;

                MySqlCommand cmd = new MySqlCommand("INSERT INTO Worker(PK_WorkerID, Name, Tel_Nr, Peronal_Nr, StartTime, EndTime, Day) VALUES (@id, @name, @tel, @perNr, @startTime, @endTime, @day )", conn);
               // @location , Personal_Nr, Day, StarTime, EndTime )  , @per_Nr, )", conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", i_d);
                cmd.Parameters.AddWithValue("@tel", tel_Nr);
                cmd.Parameters.AddWithValue("@day", day);
                cmd.Parameters.AddWithValue("@startTime", startTime);
                cmd.Parameters.AddWithValue("@endTime", endTime);
              //cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@perNr", p_Nr);

                MySqlDataReader reader = cmd.ExecuteReader();

                MessageBox.Show("The Worker " + name + " was inserted successfully.");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
        /// <summary>
        /// Ej klar
        /// </summary>
        /// <param name="f_Name"></param>
        /// <param name="l_Name"></param>
        /// <param name="i_d"></param>
        /// <param name="tel_Nr"></param>
        /// <param name="p_Nr"></param>
        public static void InsertBand(string f_Name, string l_Name, string i_d, string tel_Nr, string p_Nr/*, string day, string id_Performance, string startTime, string endTime, string location*/)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                string name = f_Name + " " + l_Name;

                MySqlCommand cmd = new MySqlCommand("INSERT INTO Band(PK_BandID, Name, Description, Peronal_Nr) VALUES (@id, @name, @tel, @perNr)", conn);
                //@location

                // , Personal_Nr, Day, StarTime, EndTime )  , @per_Nr, )", conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", i_d);
                cmd.Parameters.AddWithValue("@tel", tel_Nr);
                //cmd.Parameters.AddWithValue("@day", day);
                //cmd.Parameters.AddWithValue("@id_Performance", id_Performance);
                //cmd.Parameters.AddWithValue("@sTime", startTime);
                //cmd.Parameters.AddWithValue("@eTime", endTime);
                //cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@perNr", p_Nr);

                MySqlDataReader reader = cmd.ExecuteReader();

                MessageBox.Show("The Worker " + name + " was inserted successfully.");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public static void InsertMember(string about, string name, string tel, string id)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO BandMember(Description, Name, Tel_Nr, FK_Band) VALUES (@name, @desc, @tel, @id)", conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@about", about);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();

                MessageBox.Show("The Member " + name + " was inserted successfully.");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public static string[] Select(string name)
        {
            MySqlConnection conn = null;
            try
            {
                string sqlName = name + "%";
                conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT PK_WorkerID, Name, Peronal_Nr, Tel_Nr  FROM Worker WHERE Name LIKE @Name", conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Name", sqlName);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] strArry = new string[8];
                    strArry[0] = reader.GetString("PK_WorkerID");
                    strArry[1] = reader.GetString("Name");
                    strArry[2] = reader.GetString("Peronal_Nr");
                    strArry[3] = reader.GetString("Tel_Nr");

                    return strArry;
                }
                return null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public static string Find(string input)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                string nameSQL = input.ToString() + "%";

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Worker WHERE Name LIKE @name", conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", nameSQL);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string worker_Name = reader.GetString("Name");
                    return worker_Name;
                }
                return null;

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public static string SearchAllWorkers()
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                //string wNames = "Name";
                //string wID = "PK_WorkerID";
                //string tNum = "Tel_Nr";

                MySqlCommand cmd = new MySqlCommand("SELECT Name, PK_WorkerID, Tel_Nr FROM Worker ORDER BY Name", conn);
                cmd.Prepare();
                //cmd.Parameters.AddWithValue("@workerNames", wNames);
                //cmd.Parameters.AddWithValue("@wID", wID);
                //cmd.Parameters.AddWithValue("@tNum", tNum);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader["PK_WorkerID"] != null)
                        {
                            //for (int i = 0; i < reader.FieldCount; i++)
                            //{
                            //    string worker = reader.GetString("Name");
                            //    return worker;
                            //}


                            //{
                            //    string worker = reader.GetString("PK_WorkerID");
                            //    //string [] worker_Name = reader.GetString("Name");
                            //    //string worker_ID = reader.GetString("PK_WorkerID");
                            //    //string worker_Num = reader.GetString("Tel_Nr");
                            //    //string worker_Id = reader.GetString("PK_WorkerID");
                            //    //string worker_Tel = reader.GetString("Tel_Nr");
                            //    return worker;


                        }
                        else MessageBox.Show("null exception");
                    }
                }

                else
                {
                    return null;
                }

                return null;
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }
    }
}
