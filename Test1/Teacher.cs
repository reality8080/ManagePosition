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
    public class Teacher : Human
    {   private static string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=Person;Integrated Security=True";

        private string _mscb;
        private string password;

        private bool _status=false;
        private string _password;

        public string Mscb { get => _mscb; set => _mscb = value; }
        public string Password { get => password; set => password = value; }

        public Teacher(string id,string name, string birth,string mscb,string subject, string edcation, string password):
            base(id, name,birth)
        {
            Mscb = mscb;
            //Course = course;
            //Education = edcation;
            Password = password;
            //User=new User(Mscb, Password, Status);
            CreateTeacherTableIfNotExists();
            if (!CheckTeac())
            {
                InsertTeacherRecord(id,mscb,subject, edcation , password);
            }
        }

        private void CreateTeacherTableIfNotExists()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string checkTable = @"
            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Teacher')
            BEGIN
                CREATE TABLE Teacher(
                    Id NVARCHAR(50) PRIMARY KEY,
                    Mscb NVARCHAR(50) UNIQUE,
                    Subject NVARCHAR(50),
                    Education NVARCHAR(50),
                    Status bit,
                    Password NVARCHAR(100),
                    FOREIGN KEY (Id) REFERENCES Human(Id)
                )
            END
        ";

                using (SqlCommand check = new SqlCommand(checkTable, connection))
                {
                    check.ExecuteNonQuery();
                }
            }
        }

        public bool CheckTeac()
        {
            using (SqlConnection connection=new SqlConnection(connect))
            {
                connection.Open();
                string checkIdQuery = "SELECT COUNT(1) FROM Teacher WHERE Mscb = @Mscb";
                using (SqlCommand checkIdCommand=new SqlCommand(checkIdQuery, connection))
                {
                    checkIdCommand.Parameters.AddWithValue(@"Mscb",Mscb);
                    int count=(int)checkIdCommand.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void InsertTeacherRecord(string id, string mscb, string subject, string education, string password)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string insertStu = "INSERT INTO Teacher(Id, Mscb, Subject, Education, Status, Password) VALUES (@Id, @Mscb, @Subject,@Education, @Status, @Password)";
                using (SqlCommand insert = new SqlCommand(insertStu, connection))
                {
                    insert.Parameters.AddWithValue("@Id", Id);
                    insert.Parameters.AddWithValue("@Mscb", mscb);
                    insert.Parameters.AddWithValue("@Subject", subject);
                    insert.Parameters.AddWithValue("@Education", education);
                    insert.Parameters.AddWithValue("@Status", _status);
                    insert.Parameters.AddWithValue("@Password", password);
                    insert.ExecuteNonQuery();
                }
            }
        }
        public override string ToString()
        {
            string str = $"{base.ToString()}\n";
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string query = "SELECT Mscb,Subject, Education , Status, Password FROM Teacher WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            str += $"Mscb:{reader.GetString(0)}\n" +
                                $"Subject :{reader.GetString(1)}\n" +
                                $"Education:{reader.GetString(2)} \n" +
                                $"Status:{reader.GetBoolean(3)} \n" +
                                $"Password:{reader.GetString(4)}\n";
                        }
                    }
                }
                return str ;
            }
        }

        public void addScore(string mssv,string score)
        {
            using (SqlConnection connection=new SqlConnection(connect))
            {
                connection.Open();
                string query = @"
                            SELECT h.Name, t.Subject
                            FROM Human h
                            JOIN Teacher t ON  h.Id = t.Id";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Coursecs.addScore(mssv, reader.GetString(0), reader.GetString(1),score);
                        }
                    }
                }
            }
            //Coursecs.addScourse()
        }

        public void deleteScore(string mssv)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string query = @"
                            SELECT h.Name, t.Subject
                            FROM Human h
                            JOIN Teacher t ON  h.Id = t.Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Coursecs.deleteScore(mssv, reader.GetString(0), reader.GetString(1));
                        }
                    }
                }
            }
        }

        public void updateScore(string mssv, string score)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string query = @"
                            SELECT h.Name, t.Subject
                            FROM Human h
                            JOIN Teacher t ON  h.Id = t.Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Coursecs.addScore(mssv, reader.GetString(0), reader.GetString(1), score);
                        }
                    }
                }
            } 
        }
    
        public void ChangPassword()
        {

        }

        public string checkScore(string mssv)
        {
            using(SqlConnection connection = new SqlConnection(connect))
            {
                string str = "";
                connection.Open(); 
                string query = @"
                            SELECT h.Name, t.Subject
                            FROM Human h
                            JOIN Teacher t ON  h.Id = t.Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                           str+=Coursecs.checkScore (mssv, reader.GetString(0), reader.GetString(1));
                        }
                    }
                }
                return str;
            }
        }
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
