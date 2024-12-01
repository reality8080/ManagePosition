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
    public partial class Course : Form
    {
        int index = -1;
        public Course()
        {
            InitializeComponent();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            lbGrade.DataSource = null;
            lbGrade.DataSource = Const.TeacherCourse;
        }

        private void lbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            index=lbGrade.SelectedIndex;
            if (index < 0) { return; }
            txbGradeName.Text = Const.TeacherCourse[index];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool flag=false;
            string grade=txbGradeName.Text;
            foreach (var i in Const.TeacherCourse)
            {
                if (grade == i)
                {
                    MessageBox.Show("Môn học đã thêm");
                    flag = true; break;
                }
            }
            if (!flag)
            {
                Const.TeacherCourse.Add(grade);
            }
            LoadList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string grade=txbGradeName.Text;
            Const.TeacherCourse[index]=grade;
            LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Const.TeacherCourse.RemoveAt(index);
            LoadList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
