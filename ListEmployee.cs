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
            listEmploy.Add(new Employee("Nguyen", new DateTime(2005, 10, 16), "Nam", 1, "Phong IT", "Truong phong", "Dang cong tac"));
            listEmploy.Add(new Employee("Van", new DateTime(2000, 1, 6), "Nu", 2, "Phong ke toan", "Nhan vien", "Dang cong tac"));
            listEmploy.Add(new Employee("Quang", new DateTime(2003, 10, 1), "Nam", 3, "Phong ky thuat", "Nhan Vien", "Dang cong tac"));
            listEmploy.Add(new Employee("Duy", new DateTime(2001, 1, 16), "Nam", 4, "Phong Marketing", "Truong phong", "Nghi viec"));
            listEmploy.Add(new Employee("Real", new DateTime(1999, 7, 8), "Nam", 5, "Phong nhan su", "Truong phong", "Dang cong tac"));
        }
    }
}
