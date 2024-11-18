using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiNhanSu_YT
{
    public class Student : Human
    {
        private string _mssv;
        private string grade;
        private bool _status = false;
        private string _password;


        //private Decimal? score;
        private Dictionary<(String, String), Decimal?> courses;
        public string Mssv { get => _mssv; set => _mssv = value; }
        public string Grade { get => grade; set => grade = value; }
        public Dictionary<(string, string), decimal?> Courses { get => courses; set => courses = value; }
        public string Password { get => _password; set => _password = value; }

        //public decimal? Score { get => score; set => score = value; }
        public Student(string id,string name, int age, string date, string mssv, string grade, string password) :
            base(id,name, age, date)
        {
            Mssv = mssv;
            Grade = grade;
            Courses = new Dictionary<(String, String), Decimal?>();
            Password= password;
        }

        public override string ToString()
        {
            return base.ToString() +
                    $"MSSV: {Mssv} " +
                    $"Grade: {Grade}\n"+
                    detailCourse();
            //$"Score {display}";
        }
        //public Decimal scoreDisplay
        //{
        //    get
        //    {
        //        return courses[(course,teacher)].HasValue ? courses[(course, teacher)].Value.ToString() : "Chưa có giá trị";
        //    }
        //}

        //public void enrollCourse(string Course)
        //{
        //    courses += $"{Course}\n";
        //}

        public void enrollCourse(string course, string teacher)
        {
            Courses[(course, teacher)] = null;
        }

        //public void addScore(string course, string teacher, Decimal diem)
        //{
        //    Courses[(course, teacher)] = diem;
        //}

        public string detailCourse()
        {
            StringBuilder details = new StringBuilder("Danh sách Khoa học:\n");
            try
            {
                foreach (var key in this.Courses.Keys)
                {
                    //courses[(course, teacher)].HasValue ? courses[(course, teacher)].Value.ToString() : "Chưa có giá trị";
                    details.AppendLine($"Môn: {key.Item1}, Giảng viên: {key.Item2}, Điểm {(courses[key].HasValue ? courses[key].Value.ToString() :"Chưa có giá trị")}");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Canh bao", MessageBoxButtons.OK);
            }
            return details.ToString();
        }
    }
}