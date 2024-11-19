using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu_YT
{
    public class ListEmployee
    {
        private static ListEmployee instance;
        private List<Employee> listEmploy;

        public List<Employee> ListEmploy { get => listEmploy; set => listEmploy = value; }
        public static ListEmployee Instance {
            get
            {
                if (instance == null) 
                    instance = new ListEmployee();
                return instance;
            }
            set => instance = value;
        }
            
        private ListEmployee()
        {
            listEmploy = new List<Employee>();
            listEmploy.Add(new Employee("Nguyen", new DateTime(2005, 10, 16), "Nam", 1, "Lớp IT", "Học sinh", "Đang học"));
            listEmploy.Add(new Employee("Van", new DateTime(2000, 1, 6), "Nữ", 2, "Lớp kinh tế", "Thủ quỹ", "Đang học"));
            listEmploy.Add(new Employee("Quang", new DateTime(2003, 10, 1), "Nam", 3, "Lớp kỹ thuật", "Ban cán sự", "Đang học"));
            listEmploy.Add(new Employee("Duy", new DateTime(2001, 1, 16), "Nam", 4, "Lớp luật", "Lớp trưởng", "Bảo lưu"));
            listEmploy.Add(new Employee("Real", new DateTime(1999, 7, 8), "Nam", 5, "Lớp điện - điện tử", "Lớp trưởng", "Đang học"));
        }
    }
}
