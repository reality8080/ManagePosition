using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu_YT
{
    public class Employee
    {
        private string name;
        private DateTime birthDay;
        private string sex;
        private int employeeCode;
        private string department;
        private string position;
        private string contract;
        private double grade;
        public string Name { get => name; set => name = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string Sex { get => sex; set => sex = value; }
        public int EmployeeCode { get => employeeCode; set => employeeCode = value; }
        public string Department { get => department; set => department = value; }
        public string Position { get => position; set => position = value; }
        public string Contract { get => contract; set => contract = value; }
        public double Grade
        {
            get => grade;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Điểm số phải nằm trong khoảng từ 0 đến 100.");
                grade = value;
            }
        }


        public Employee(string name, DateTime birthDay, string sex, int employeeCode, string department, string position, string contract)
        {
            this.Name = name;
            this.BirthDay = birthDay;
            this.Sex = sex;
            this.EmployeeCode = employeeCode;
            this.Department = department;
            this.Position = position;
            this.Contract = contract;
        }
        public Employee(string name, int employeeCode, double grade)
        {
            this.Name = name;
            this.EmployeeCode = employeeCode;
            this.Grade = grade;
        }
        public Employee()
        {

        }
    }
}
