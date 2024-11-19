using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu_YT
{
    public class ListDepartment
    {
        private static ListDepartment instance;
        private List<Department> listDepartmen;
        public List<Department> ListDepartmen { get => listDepartmen; set => listDepartmen = value; }
        public static ListDepartment Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListDepartment();
                return instance;
            }
            set => instance = value;
        }

        public ListDepartment()
        {
            listDepartmen = new List<Department>();
            listDepartmen.Add(new Department("IT"));
            listDepartmen.Add(new Department("Kinh tế"));
            listDepartmen.Add(new Department("Kỹ thuật"));
            listDepartmen.Add(new Department("Luật"));
            listDepartmen.Add(new Department("Điện - điện tử"));
        }
    }
}
