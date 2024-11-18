using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu_YT
{
    public class Const
    {
        public static Employee NewEmploy = null;
        public static bool AccountType;
        public static List<string> ListDepartment = new List<string>() {"Phong nhan su", "Phong IT", "Phong ke toan", "Phong van tai", "Phong Marketing" };

        public static List<string> listSex = new List<string>() { "nam", "nu", "khong xac dinh" };
        public static List<string> listContract = new List<string>() { "dang cong tac", "da nghi" }; 
    }
}
