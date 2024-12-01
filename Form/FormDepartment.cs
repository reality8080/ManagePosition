using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhanSu_YT
{
    public partial class FormDepartment : Form
    {
        int index = -1;
        public FormDepartment()
        {
            InitializeComponent();
        }
        void LoadListDepartment()
        {
            lbDepartment.DataSource = null;
            lbDepartment.DataSource = Const.ListDepartment;
            //lbDepartment.DisplayMember = "Name";
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            LoadListDepartment();
        }

        private void lbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lbDepartment.SelectedIndex;
            if(index < 0) { return; }
            txbDepartmentName.Text = Const.ListDepartment[index];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string departmentName = txbDepartmentName.Text;
            foreach(var i in Const.ListDepartment)
            {
                if(departmentName == i)
                {
                    MessageBox.Show("Lớp này đã có trong danh sách!", "Cảnh báo");
                    flag = true; break;
                }
            }
            if (!flag)
            {
                Const.ListDepartment.Add(departmentName);
            }
            LoadListDepartment();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string departmentName = txbDepartmentName.Text;

            Const.ListDepartment[index] = departmentName;
            LoadListDepartment();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Const.ListDepartment.RemoveAt(index);
            LoadListDepartment();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
