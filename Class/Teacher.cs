using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;

namespace QuanLiNhanSu_YT
{
    public class Teacher : User
    {   private string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=Person;Integrated Security=True";

        private string _mscb;
        private string password;
        //private string _course;
        //private string _education;
        private bool _status=false;
        private string _password;
        //private User _user;

        //public string Education { get => _education; set => _education = value; }
        public string Mscb { get => _mscb; set => _mscb = value; }
        public string Password { get => password; set => password = value; }

        //public string Course { get => _course; set => _course = value; }
        //public User User { get => _user; set => _user = value; }
        //public bool Status { get => _status; set => _status = value; }

        public Teacher(string id,string name, string birth,string mscb,string subject, string edcation, string password):
            base(id, name,birth, mscb, password)
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
                string insertStu = "INSERT INTO Teacher(Id, Mscb, Subject, Education) VALUES (@Id, @Mscb, @Subject,@Education, @Status, @Password)";
                using (SqlCommand insert = new SqlCommand(insertStu, connection))
                {
                    insert.Parameters.AddWithValue("@Id", Id);
                    insert.Parameters.AddWithValue("@Mscb", mscb);
                    insert.Parameters.AddWithValue("@Subject", subject);
                    insert.Parameters.AddWithValue("@Education", education);
                    try
                    {
                        insert.ExecuteNonQuery();
                        //MessageBox.Show("Người dùng đã được thêm thành công.","Success",MessageBoxButtons.OK);
                    }
                    catch (SqlException ex)
                    {
                        // Kiểm tra mã lỗi để xác định loại lỗi
                        if (ex.Number == 2627) // Mã lỗi cho vi phạm unique constraint
                        {
                            MessageBox.Show("Tên người dùng đã tồn tại. Vui lòng chọn tên khác.", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Canh bao", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }
        public override string ToString()
        {
            string str = $"{base.ToString()}\n";
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string query = "SELECT Mscb,Subject, Education FROM Teacher WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            str += $"Mscb:{reader.GetString(0)}\n" +
                                $"Subject :{reader.GetString(1)}\n" +
                                $"Education:{reader.GetString(2)} \n";
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
    }
}
// Nếu môn học không có, nếu môn học có
// Nếu môn học có thì mình thêm điểm
//Nếu môn học không có thì mình thì thêm rồi thêm điểm
