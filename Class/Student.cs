using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLiNhanSu_YT
{
    public class Student : User
    {
        private static string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=Person;Integrated Security=True;";
        private string _mssv;
        private string password;
        private bool _statusAcc = false;

        public string Mssv { get => _mssv; private set => _mssv = value; }
        public string Password { get => password; private set => password = value; }

        public Student(string id, string name, string date, string mssv, string grade, string password) : base(id,name,date, mssv,password)
        {
            Mssv = mssv;
            Password=password;
            CreateStudentTableIfNotExists();
            if (!CheckStu())
            {
                InsertStudentRecord(Id, mssv, grade, password);
            }
        }

        private void CreateStudentTableIfNotExists()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string checkTable = @"
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Student')
                BEGIN
                    CREATE TABLE Student (
                        Id NVARCHAR(50) PRIMARY KEY,
                        Mssv NVARCHAR(50) UNIQUE,
                        Grade NVARCHAR(50),
                        FOREIGN KEY (Id) REFERENCES Human(Id)
                    )
                END";

                using (SqlCommand check = new SqlCommand(checkTable, connection))
                {
                    check.ExecuteNonQuery();
                }
            }
        }

        private void InsertStudentRecord(string id, string mssv, string grade, string password)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                
                string insertStu = "INSERT INTO Student(Id, Mssv, Grade, Status, Password) VALUES (@Id, @Mssv, @Grade, @Status, @Password)";
                using (SqlCommand insert = new SqlCommand(insertStu, connection))
                {
                    insert.Parameters.AddWithValue("@Id", Id);
                    insert.Parameters.AddWithValue("@Mssv", mssv);
                    insert.Parameters.AddWithValue("@Grade", grade);
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

        private bool CheckStu()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string checkIdQuery = "SELECT COUNT(1) FROM Student WHERE Mssv = @Mssv";
                using (SqlCommand checkIdCommand = new SqlCommand(checkIdQuery,connection ))
                {
                    checkIdCommand.Parameters.AddWithValue("@Mssv", Mssv);
                    int count = (int)checkIdCommand.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void addCourse( string teacher, string subject)
        {
            Coursecs.addScore(Mssv,teacher,subject);
        }

        public override string ToString()
        {
            string str = $"{base.ToString()}\n";
            //try
            //{
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string query = "SELECT Mssv, Grade FROM Student WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            str += $"Mssv: {reader.GetString(0)}\n" +
                                   $"Grade: {reader.GetString(1)}\n";
                        }
                    }
                }

                query = "SELECT Teacher, Subject, Score FROM Score WHERE Mssv=@Mssv";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Mssv", Mssv);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            str += $"Teacher: {reader.GetString(0)}\n" +
                                $"Subject: {reader.GetString(1)}\n" +
                                $"Score: {(reader.IsDBNull(2)? "" : reader.GetString(2))}\n";
                        }
                    }
                }
                return str;
            }
        }

        public static void ASCSort()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                string str = "";
                connection.Open();
                string query = @"
            SELECT h.Id, h.Name, h.Birth, s.Id, s.Mssv, sc.Teacher, sc.Subject, sc.Score
            FROM Human h
            JOIN Student s ON h.Id = s.Id
            LEFT JOIN Score sc ON s.Mssv = sc.Mssv
            ORDER BY  h.Name ASC";
//h.Id ASC,, s.Id ASC
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lấy dữ liệu từ reader
                            string Id = reader["Id"].ToString();
                            string Name = reader["Name"].ToString();
                            string Birth = reader["Birth"].ToString();
                            string mssv = reader["Mssv"].ToString();
                            string teacher = reader["Teacher"]?.ToString() ?? "N/A";
                            string subject = reader["Subject"]?.ToString() ?? "N/A";
                            decimal score = reader["Score"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("Score")) : 0;

                            // Thực hiện hành động với dữ liệu (ví dụ: in ra)
                            str += $"HumanId: {Id}, Name: {Name}, StudentId: {Birth}, Mssv: {mssv}, Teacher: {teacher}, Subject: {subject}, Score: {score}\n\n";
                        }
                    }
                }
                MessageBox.Show(str);
            }
        }
    } 
}// Them class score