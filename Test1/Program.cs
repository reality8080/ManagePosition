using QuanLiNhanSu_YT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("011","Nguyen Tran","30/07/2005","2311","231102","12@1Nttp");
            Teacher teacher = new Teacher("0797","Hai","30/07/2005","12345","Toan","PGT.TS","1111");
            Administrator administrator = new Administrator("0791","T","20/10/2000","Ttt","123");
            stu.addCourse("Hai","Toan");
            teacher.addScore(stu.Mssv,"10");
            teacher.updateScore(stu.Mssv,"9");
            administrator.Delete(stu.Mssv,"Hai","Toan");
        }
    }
}
