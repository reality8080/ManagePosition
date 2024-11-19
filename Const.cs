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
        public static List<string> ListDepartment = new List<string>() {"Luật", "IT", "Kinh tế", "Kỹ thuật", "Điện - điện tử" };

        public static List<string> listSex = new List<string>() { "Nam", "Nữ", "Không xác định"};
        public static List<string> listContract = new List<string>() { "Đang học", "Bảo lưu", "Thôi học" }; 
    }
}
