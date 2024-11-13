using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLiNhanSu_YT
{
    public class Student : Human
    {
        private string _mssv;
        private string grade;
        private Decimal? score;
        //Thêm khóa học
        public string Mssv { get => _mssv; set => _mssv = value; }
        public string Grade { get => grade; set => grade = value; }
        public decimal? Score { get => score; set => score = value; }
        public Student(string id,string name, int age, string date, string sick, bool status, string mssv, string grade) :
            base(id,name, age, date, sick, status)
        {
            Mssv = mssv;
            Grade = grade;
        }

        public override string ToString()
        {
            return base.ToString() +
                    $"MSSV: {Mssv}" +
                    $"Grade: {Grade}" +
                    $"Score {display}";
        }
        public string display
        {
            get
            {
                return score.HasValue ? score.Value.ToString() : "Chưa có giá trị";
            }
        }
        //thêm phương thức để thêm khóa học
    }
}