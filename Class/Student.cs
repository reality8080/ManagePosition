using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLiNhanSu_YT
{
    public class Student : Human
    {
        private static string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=Person;Integrated Security=True;";
        private string _mssv;
        private string password;
        private bool _statusAcc = false;

        public  string Mssv { get => _mssv; private set => _mssv = value; }
        public string Password { get => password; private set => password = value; }

        public Student(string id, string name, string date, string mssv, string grade, string password) : base(id, name, date)
        {
            Mssv = mssv;
            Password=password;
            CreateStudentTableIfNotExists();
            //if (!CheckStu())
            //{
                InsertStudentRecord(Id, name,date,mssv, grade, password);
            //}
        }

        public static void CreateStudentTableIfNotExists()
        {
            CreateTableIfNotExists();
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
                        Password NVARCHAR(100),
                        FOREIGN KEY (Id) REFERENCES Human(Id) ON DELETE CASCADE,
                    )
                END";

                using (SqlCommand check = new SqlCommand(checkTable, connection))
                {
                    check.ExecuteNonQuery();
                }
            }
        }

        private void InsertStudentRecord(string id, string name,string birth,string mssv, string grade, string password)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();

                //string insertStu = "INSERT INTO Student(Id, Mssv, Grade, Password) VALUES (@Id, @Mssv, @Grade, @Password)";
                //using (SqlCommand insert = new SqlCommand(insertStu, connection))
                //{
                //    insert.Parameters.AddWithValue("@Id", Id);
                //    insert.Parameters.AddWithValue("@Mssv", mssv);
                //    insert.Parameters.AddWithValue("@Grade", grade);
                //    insert.Parameters.AddWithValue("@Password", password);
                //    insert.ExecuteNonQuery();
                //}
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string queryStu = @"
                        MERGE INTO Student AS target
                        USING(VALUES (@Id,@Mssv,@Grade,@Password)) AS Source (Id,Mssv,Grade,Password)
                        ON target.Id = source.Id
                        WHEN MATCHED THEN
                            UPDATE SET Id = source.Id,
                            Mssv =source.Mssv,
                            Grade= source.Grade,
                            Password =source.Password
                        WHEN NOT MATCHED THEN
                            INSERT (Id,Mssv,Grade,Password) 
                            VALUES (source.Id,source.Mssv,source.Grade,source.Password);
";
                    using (SqlCommand command = new SqlCommand(queryStu, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Mssv", Mssv);
                        command.Parameters.AddWithValue("@Grade", grade);
                        command.Parameters.AddWithValue("@Password", password);
                        command.ExecuteNonQuery();
                    }
//                    string queryScore = @"
//                        MERGE INTO Score AS target
//                        USING(VALUES (@Mssv,@Grade,@) AS Source (Id,Name,Birth))
//                        ON target.Id = source.Id
//                        WHEN MATCHED THEN
//                            UPDATE SET Name = source.Name, Birth = source.Birth
//                        WHEN NOT MATCHED THEN
//                            INSERT (Mssv, Name, BirthDate) 
//                            VALUES (source.Mssv, source.Name, source.BirthDate);
//";
//                    using (SqlCommand command = new SqlCommand(queryScore, connection, transaction))
//                    {
//                        command.Parameters.AddWithValue("@Id", id);
//                        command.Parameters.AddWithValue("@Name", name);
//                        command.Parameters.AddWithValue("@Birth", birth);
//                        command.ExecuteNonQuery();
//                    }
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback(); // Rollback nếu có lỗi
                    throw;
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

        public static void addCourse(string mssv, string subject)
        {
            Coursecs.addScore(mssv, subject);
        }


        //public override string ToString()
        //{
        //    string str = $"{base.ToString()}\n";
        //    //try
        //    //{
        //    using (SqlConnection connection = new SqlConnection(connect))
        //    {
        //        connection.Open();
        //        string query = "SELECT Mssv, Grade FROM Student WHERE Id = @Id";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@Id", Id);
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    str += $"Mssv: {reader.GetString(0)}\n" +
        //                           $"Grade: {reader.GetString(1)}\n";
        //                }
        //            }
        //        }

        //        query = "SELECT Subject, Score FROM Score WHERE Mssv=@Mssv";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@Mssv", Mssv);
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    str +=$"Subject: {reader.GetString(1)}\n" +
        //                        $"Score: {(reader.IsDBNull(2)? "" : reader.GetString(2))}\n";
        //                }
        //            }
        //        }
        //        return str;
        //    }
        //}

        //        public static void ASCSort()
        //        {
        //            using (SqlConnection connection = new SqlConnection(connect))
        //            {
        //                string str = "";
        //                connection.Open();
        //                string query = @"
        //            SELECT h.Id, h.Name, h.Birth, s.Id, s.Mssv, sc.Subject, sc.Score
        //            FROM Human h
        //            JOIN Student s ON h.Id = s.Id
        //            LEFT JOIN Score sc ON s.Mssv = sc.Mssv
        //            ORDER BY  h.Name ASC";
        ////h.Id ASC,, s.Id ASC
        //                using (SqlCommand command = new SqlCommand(query, connection))
        //                {
        //                    using (SqlDataReader reader = command.ExecuteReader())
        //                    {
        //                        while (reader.Read())
        //                        {
        //                            // Lấy dữ liệu từ reader
        //                            string Id = reader["Id"].ToString();
        //                            string Name = reader["Name"].ToString();
        //                            string Birth = reader["Birth"].ToString();
        //                            string mssv = reader["Mssv"].ToString();
        //                            string subject = reader["Subject"]?.ToString() ?? "N/A";
        //                            decimal score = reader["Score"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("Score")) : 0;

        //                            // Thực hiện hành động với dữ liệu (ví dụ: in ra)
        //                            str += $"HumanId: {Id}, Name: {Name}, StudentId: {Birth}, Mssv: {mssv}, Subject: {subject}, Score: {score}\n\n";
        //                        }
        //                    }
        //                }
        //                MessageBox.Show(str);
        //            }
        //        }

        public static DataSet Get(string mssv)
        {
            DataSet ds = new DataSet();
            using(SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string query = @"
            SELECT DISTINCT h.Id, h.Name, h.Birth, s.Mssv, s.Grade, sc.Subject, sc.Score, s.Password
            FROM Human h
            JOIN Student s ON h.Id = s.Id
            LEFT JOIN Score sc ON s.Mssv = sc.Mssv
            WHERE s.Mssv LIKE @Mssv
            ORDER BY h.Name ASC";
                using(SqlDataAdapter adapter=new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Mssv",$"%{mssv}%");
                    adapter.Fill(ds, "Students");
                }
            }
            return ds;
        }

        public static DataSet ASCSort()
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(connect))
            {
                string query = @"
            SELECT DISTINCT h.Id, h.Name, h.Birth, s.Mssv, s.Grade,sc.Subject, sc.Score
            FROM Human h
            JOIN Student s ON h.Id = s.Id
            LEFT JOIN Score sc ON s.Mssv = sc.Mssv
            ORDER BY h.Name ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Open the connection
                        connection.Open();

                        // Fill the DataSet
                        adapter.Fill(dataSet);
                    }
                }
            }

            return dataSet;
        }

        public static DataSet ASCSort_ad()
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(connect))
            {
                string query = @"
            SELECT DISTINCT h.Id, h.Name, h.Birth, s.Mssv, s.Grade,sc.Subject, sc.Score,s.Password
            FROM Human h
            JOIN Student s ON h.Id = s.Id
            LEFT JOIN Score sc ON s.Mssv = sc.Mssv
            ORDER BY h.Name ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Open the connection
                        connection.Open();

                        // Fill the DataSet
                        adapter.Fill(dataSet);
                    }
                }
            }

            return dataSet;
        }

        public static DataSet GetDataSet_S()
        {
            DataSet dataSet =GetDataSet_H();
            try
            {
                using(SqlConnection connection = new SqlConnection(connect))
                {
                    string query = "SELECT * FROM Student";
                    connection.Open();
                    using(SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataSet,"Student");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}");
            }
            

            return dataSet;
        }
        public static bool checkUser(string mssv, string password)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string checkIdQuery = "SELECT COUNT(1) FROM Student WHERE Mssv = @Mssv AND Password=@Password";
                using (SqlCommand checkIdCommand = new SqlCommand(checkIdQuery, connection))
                {
                    checkIdCommand.Parameters.AddWithValue("@Mssv", mssv);
                    checkIdCommand.Parameters.AddWithValue("@Password", password);
                    int count = (int)checkIdCommand.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        //public static void upDate(string id, string name, string date, string mssv, string grade, string password)
        //{

        //}
    } 
}// Them class score