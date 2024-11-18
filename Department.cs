using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu_YT
{
    public class Department
    {
        private string name;
        public string Name { get => name; set => name = value; }
        public Department(string name)
        {
            this.Name = name;
        }
    }
}
