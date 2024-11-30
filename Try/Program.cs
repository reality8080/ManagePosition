using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiNhanSu_YT;
namespace Try
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("1","Phu","30/02/2005","255","CNTT","12@1");
            Teacher teacher=new Teacher("Reality","1102");
            teacher.addScore(stu.Mssv, "toan");
            teacher.updateScore(stu.Mssv, "toan", "11");
            Administrator admin = new Administrator("Tran", "1104");
            admin.Delete(stu.Mssv,"toan");
        }
    }
}
