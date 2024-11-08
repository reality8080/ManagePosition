using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class
{
    public class Student : Human
    {
        private string _id;
        private string grade;
        private Decimal? score;

        public string Id { get => _id; set => _id = value; }
        public string Grade { get => grade; set => grade = value; }
        public decimal? Score { get => score; set => score = value; }
        public Student(string name, int age, string date, string sick, bool status, string id, string grade) :
            base(name, age, date, sick, status)
        {
            Id = id;
            Grade = grade;
        }

        public override string ToString()
        {
            return base.ToString() +
                    $"ID: {Id}" +
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
    }
}