using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiNhanSu_YT
{
    public class Teacher : Human
    {
        private string _mscb;
        private string _course;
        private string _education;
        private bool _status=false;
        private string _password;

        public string Education { get => _education; set => _education = value; }
        public string Mscb { get => _mscb; set => _mscb = value; }
        public string Course { get => _course; set => _course = value; }
        public string Password { get => _password; set => _password = value; }

        public Teacher(string id,string name, int age, string birth,string mscb,string course, string edcation, string password):
            base(id, name,age,birth)
        {
            Mscb = mscb;
            Course = course;
            Education = edcation;
            Password = password;
        }
        public override string ToString()
        {
            return base.ToString()+$"" +
                    $"MSCB: {Mscb}" +
                    $"Subject: {Course}" +
                    $"Education: {Education}";
        }

        //public void toScore(Student student, Decimal score)
        //{
        //    student.Score = score;
        //}
        //public string display
        //{
        //    get
        //    {
        //        return score.HasValue ? score.Value.ToString() : "Chưa có giá trị";
        //    }
        //}

        //public void enrollCourse(string Course)
        //{
        //    courses += $"{Course}\n";
        //}

        //public void enrollCourse(string course, string teacher)
        //{
        //        Courses[(course,teacher)] = null;
        //}

        public void addScore(Student student, Decimal diem)
        {
            student.Courses[(Course, this.Name)] = diem;
        }
    }
}