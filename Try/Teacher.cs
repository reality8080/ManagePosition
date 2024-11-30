using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;

namespace QuanLiNhanSu_YT
{
    public class Teacher 
    {   private static string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=Person;Integrated Security=True";

        private string _mscb;
        private string password;

        private bool _status=false;
        private string _password;

        public string Mscb { get => _mscb; set => _mscb = value; }
        public string Password { get => password; set => password = value; }

        public Teacher(string mscb, string password)
        {
            Mscb = mscb;
            //Course = course;
            //Education = edcation;

            Password = password;
            //User=new User(Mscb, Password, Status);
        }
        //public override string ToString()
        //{
        //    string str = $"{base.ToString()}\n";
        //    using (SqlConnection connection = new SqlConnection(connect))
        //    {
        //        connection.Open();
        //        string query = "SELECT Mscb,Subject, Education , Status, Password FROM Teacher WHERE Id = @Id";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@Id", Id);
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    str += $"Mscb:{reader.GetString(0)}\n" +
        //                        $"Subject :{reader.GetString(1)}\n" +
        //                        $"Education:{reader.GetString(2)} \n" +
        //                        $"Status:{reader.GetBoolean(3)} \n" +
        //                        $"Password:{reader.GetString(4)}\n";
        //                }
        //            }
        //        }
        //        return str ;
        //    }
        //}

        public void addScore(string mssv,string subject,string score)
        {

            Coursecs.addScore(mssv, subject, score);
            //Coursecs.addScourse()
        }

        public void addScore(string mssv, string subject)
        {

            Coursecs.addScore(mssv, subject);
            //Coursecs.addScourse()
        }
        public void deleteScore(string mssv, string subject)
        {
            Coursecs.deleteScore(mssv, subject);
        }

        public void updateScore(string mssv,string subject, string score)
        {
            Coursecs.addScore(mssv, subject, score);
        }

        //public string checkScore(string mssv)
        //{
        //    Coursecs.checkScore()
        //}
        public static DataSet GetDataSet_T()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    string query = "SELECT * FROM Teacher";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}");
            }
            return ds;
        }
    }
}
// Nếu môn học không có, nếu môn học có
// Nếu môn học có thì mình thêm điểm
//Nếu môn học không có thì mình thì thêm rồi thêm điểm
