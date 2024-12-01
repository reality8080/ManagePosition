using QuanLiNhanSu_YT;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace QuanLiNhanSu_YT
{
    public class Administrator 
    {
        private static string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=Person;Integrated Security=True;";
        private /*readonly*/ String _username;
        private /*readonly*/ String _password;
        private bool _status = true;
        public String Username { get => _username; private set => _username = value; }
        public string Password { get => _password; private set => _password = value; }

        public Administrator( string username, string password)
        {
            Username = username;
            Password = password;
        }

        public static void addStudent(string id, string name, string date, string mssv, string grade, string password)
        {
            Student stu= new Student(id,name,date,mssv,grade,password);
            Coursecs.addScore(mssv,"");
            //return stu;
        }

        public static void updateStu(string id, string name, string date, string mssv, string grade, string password)
        {

        }

        public static Teacher addTeacher(string id, string name, string birth, string mscb, string subject, string edcation, string password)
        {
            return new Teacher(mscb,password);
        }

        //public void addCourse(string NameTeacher, string subject)// Thêm Môn học cho giảng viên
        //{
        //    Coursecs.addCourse(NameTeacher, subject);
        //}
        public static void addCourse(string mssv, string Subject)// Thêm môn học cho sinh viên
        {
            Coursecs.addScore(mssv, Subject);
        }
        public static void addScore(string mssv, string Subject, string score)//Thêm điểm cho sinh viên
        {
            Coursecs.addScore(mssv, Subject, score);
        }
        public static void Delete(string mssv, string Subject)
        {
            Coursecs.deleteScore(mssv ,Subject);
        }
        public static void FindScore(string mssv, string Subject)
        {
            Coursecs.checkScore(mssv,Subject);
        }
    }
}