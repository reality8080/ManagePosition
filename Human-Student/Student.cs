using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLiNhanSu_YT
{
    public class Student : Human
    {
        /// <summary> SQL
        private SqlConnection _connection;
        /// </summary>


        private string _mssv;
        private string grade;
        private bool _status = false;
        private string _password;

        private Dictionary<(String, String), Decimal?> courses;



        public string Mssv { get => _mssv; set => _mssv = value; }
        public string Grade { get => grade; set => grade = value; }
        public Dictionary<(string, string), decimal?> Courses { get => courses; set => courses = value; }
        public string Password { get => _password; set => _password = value; }
        //public decimal? Score { get => score; set => score = value; }
        public Student(string id,string name/*, int age*/, string date, string mssv, string grade, string password) :
            base(id,name/*, age*/, date)
        {
            string connect = "Data Source = LAPTOP - 49M0TBTC; Initial Catalog = Person; Integrated Security = True";
            _connection = new SqlConnection(connect);
            //Mssv = mssv;
            //Grade = grade;
            //Courses = new Dictionary<(String, String), Decimal?>();
            //Password= password;
            try
            {
                _connection.Open();
                CheckStu();
                string insertStu =
                    "INSERT INTO Student(Id,Mssv, Grade,Status,Password,NameCourse, Teacher,Score)" +
                    "VALUES(@Id,@Mssv,@Grade,@Status,@Password,@NameCourse,@Teacher,@Score)";
                using (SqlCommand insert = new SqlCommand(insertStu, _connection))
                {
                    insert.Parameters.AddWithValue("@Id", id);
                    insert.Parameters.AddWithValue("@Mssv", Mssv);
                    insert.Parameters.AddWithValue("@Grade", Grade);
                    insert.Parameters.AddWithValue("@Status", _status);
                    insert.Parameters.AddWithValue("@Password", Password);

                    insert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
            finally
            {
                _connection.Close();
            }
        }

        public void CheckStu()
        {
                /////
            string checkTable = @"
            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Student')
            BEGIN
                CREATE TABLE Student (
                    Id NVARCHAR(50) PRIMARY KEY,
                    Mssv NVARCHAR(50),
                    Grade NVARCHAR(50),
                    Status bit,
                    Password NVARCHAR(100),
                    FOREIGN KEY (Id) REFERENCES Human(Id)
                )
            END
            ";
            /////
            using (SqlCommand check = new SqlCommand(checkTable,_connection))
            {
                check.ExecuteNonQuery();
            }
        }

        public void addScore(String teacher, String subject, Decimal? score)
        {
            try
            {
                _connection.Open();
                CheckScore();
                string insertScore =
                    "INSERT INTO Score(Id, Teacher, Subject,Score)" +
                    "VALUES(@Id, @Teacher, @Subject, @Score)";
                using (SqlCommand insert=new SqlCommand(insertScore, _connection))
                {
                    insert.Parameters.AddWithValue("@Id", Mssv);
                    insert.Parameters.AddWithValue("@Teacher",teacher);
                    insert.Parameters.AddWithValue("@Subject", subject);
                    insert.Parameters.AddWithValue("@Score", score);
                    insert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loi: {ex.Message}");
            }
            finally
            {

            }
        }

        public void CheckScore()
        {
            string Check = @"
            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Score')
                BEGIN
                    CREATE TABLE Score(
                        Id  VARCHAR(50) PRIMARY KEY,
                        Teacher VARCHAR(50),
                        Subject VARCHAR(50),
                        Score Decimal(2,2),
                        FOREIGN KEY (Id) REFERRENCES Student(Mssv)
            ";
            using ( SqlCommand check = new SqlCommand(Check, _connection))
            {
                check.ExecuteNonQuery();
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                    $"MSSV: {Mssv} " +
                    $"Grade: {Grade}\n" /*+*/;
                    //detailCourse();
            //$"Score {display}";
        }
        //    //public Decimal scoreDisplay
        //    //{
        //    //    get
        //    //    {
        //    //        return courses[(course,teacher)].HasValue ? courses[(course, teacher)].Value.ToString() : "Chưa có giá trị";
        //    //    }
        //    //}

        //    //public void enrollCourse(string Course)
        //    //{
        //    //    courses += $"{Course}\n";
        //    //}

        //    public void enrollCourse(string course, string teacher)
        //    {
        //        Courses[(course, teacher)] = null;
        //    }

        //    //public void addScore(string course, string teacher, Decimal diem)
        //    //{
        //    //    Courses[(course, teacher)] = diem;
        //    //}

        //    public string detailCourse()
        //    {
        //        StringBuilder details = new StringBuilder("Danh sách Khoa học:\n");
        //        try
        //        {
        //            foreach (var key in this.Courses.Keys)
        //            {
        //                //courses[(course, teacher)].HasValue ? courses[(course, teacher)].Value.ToString() : "Chưa có giá trị";
        //                details.AppendLine($"Môn: {key.Item1}, Giảng viên: {key.Item2}, Điểm {(courses[key].HasValue ? courses[key].Value.ToString() :"Chưa có giá trị")}");
        //            }

        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show(e.Message, "Canh bao", MessageBoxButtons.OK);
        //        }
        //        return details.ToString();
        //    }
    }
}