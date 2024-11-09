using QuanLiNhanSu_YT;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Class
{
    public class Administrator : QuanLiNhanSu_YT.Human
    {
        private /*readonly*/ String _username;
        private /*readonly*/ String _password;
        public String Username { get=> _username; private set => _username = value; }
        public string Password { get => _password;private set => _password = value; }

        public Administrator(string id, string name, int age, string date,string username, string password):
            base(id, name, age, date) 
        {
            
        }
        // them danh sach sinh vien nhu the nao, o dau?
        // them vao sql duoi dang nao
        public Student addStudent(string id, string name, int age, string date, string sick, bool status, string mssv, string grade)
        {
            return new Student(id, name, age,  date, mssv,  grade);
        }

        public Student addStudent(string id, string name, int age, string date, string mssv, string grade)
        {
            return new Student(id,name, age, date, mssv,grade);
        }
        public Teacher addTeacher(string id, string name, int age, string birth, string mscb, string course, string edcation)
        {
            return new Teacher(id, name, age, birth,mscb, course,edcation);
        }
    }
}