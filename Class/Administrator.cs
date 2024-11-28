using QuanLiNhanSu_YT;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace QuanLiNhanSu_YT
{
    public class Administrator : Human
    {
        private static string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=Person;Integrated Security=True;";
        private /*readonly*/ String _username;
        private /*readonly*/ String _password;
        private bool _status = true;
        public String Username { get => _username; private set => _username = value; }
        public string Password { get => _password; private set => _password = value; }

        public Administrator(string id, string name, string birth, string username, string password) :
            base(id, name, birth)
        {
            Username = username;
            Password = password;

            createTableAdmin();
            if (!CheckAdmin())
            {
                InsertAdmin();
            }
        }

        public void InsertAdmin()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string insert = @"INSERT INTO Admin(Id, USER,PASSWORD)
                VALUES(@Id,@USER,@PASSWORD)";
                using (SqlCommand command = new SqlCommand(insert, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@USER", Username);
                    command.Parameters.AddWithValue("@PASSWORD", Password);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void createTableAdmin()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string query = @"
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLE WHERE TABLE_NAME='Admin')
                BEGIN
                    CREATE TABLE Admin(
                        Id NVARCHAR(50) PRIMARY KEY,
                        USER VARCHAR(100),
                        PASSWORD VARCHAR(100),
                END";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private bool CheckAdmin()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Admin Where Id=@Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        // them danh sach sinh vien nhu the nao, o dau?
        // them vao sql duoi dang nao
        //public Student addStudent(string id, string name, int age, string date, string sick, bool status, string mssv, string grade)
        //{
        //    return new Student(id, name, age,  date, mssv,  grade);
        //}

        //public Student addStudent(string id, string name, int age, string date, string mssv, string grade)
        //{
        //    return new Student(id,name, age, date, mssv,grade);
        //}
        //public Teacher addTeacher(string id, string name, int age, string birth, string mscb, string course, string edcation)
        //{
        //    return new Teacher(id, name, age, birth,mscb, course,edcation);
        //}
        public override string ToString()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string str = $"{base.ToString()}\n";
                string query = @"SELECT USER, PASSWORD FROM Admin WHERE Id=@Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            str += $"User {reader.GetString(0)}, Password {reader.GetString(1)}";
                        }
                    }
                }
            }
            return base.ToString();
        }
        public Student addStudent(string id, string name, string date, string mssv, string grade, string password)
        {
            return new Student(id, name, date, mssv, grade, password);
        }

        public Teacher addTeacher(string id, string name, string birth, string mscb, string subject, string edcation, string password)
        {
            return new Teacher(id, name, birth, mscb, subject, edcation, password);
        }

        //public void addCourse(string NameTeacher, string subject)// Thêm Môn học cho giảng viên
        //{
        //    Coursecs.addCourse(NameTeacher, subject);
        //}
        public void addCourse(string mssv, string NameTeacher, string Subject)// Thêm môn học cho sinh viên
        {
            Coursecs.addScore(mssv, NameTeacher, Subject);
        }
        public void addScore(string mssv, string NameTeacher, string Subject, string score)//Thêm điểm cho sinh viên
        {
            Coursecs.addScore(mssv, NameTeacher, Subject, score);
        }
        public void Delete(string mssv, string NameTeacher, string Subject)
        {
            Coursecs.deleteScore(mssv, NameTeacher, Subject);
        }
        public void FindScore(string mssv, string NameTeacher, string Subject)
        {
            Coursecs.checkScore(mssv, NameTeacher, Subject);
        }

    }
}// Teacher chi co 1 mon