using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhanSu_YT
{
    public partial class Form1 : Form
    {
        public Teacher teacher;
        public Administrator admin;
        public Form1()
        {
            InitializeComponent();
        }
        bool checkLogin(string userName, string passWord)
        {
            //for(int i = 0; i < ListUser.Instance.ListUsers.Count; i++)
            //{
            //    if (userName == ListUser.Instance.ListUsers[i].UserName && passWord == ListUser.Instance.ListUsers[i].UserName)
            //    {
            //        Const.AccountType = ListUser.Instance.ListAccountUser[i].AccountType;
            //        return true;
            //    }
            //}
            if (userName == teacher.Mscb && passWord == teacher.Password)
            {
                Const.AccountType=2; return true;
            }
            if (userName == admin.Username && passWord == admin.Password)
            {
                Const.AccountType = 3; return true;
            }
            if (Student.checkUser(userName, passWord))
            {
                Const.Mssv=userName;
                Const.AccountType = 1; return true;
            }
            return false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (checkLogin(userName, passWord))
            {
                if (Const.AccountType == 2)
                {
                    Const.TeacherCourse = teacher.List;
                }
                FormMain f = new FormMain();
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK);
                txbUserName.Focus();
                return;
            }
        }

        private void F_Logout(object sender, EventArgs e)
        {
            (sender as FormMain).isExit = false;
            (sender as FormMain).Close();
            this.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            teacher = new Teacher("Reality", "1102");
            teacher.List = new List<string>(){"Toan","Li","Hoa"};
            admin = new Administrator("Tran", "1104");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPassWord.Checked)
                txbPassWord.UseSystemPasswordChar = false;
            if (!ckbShowPassWord.Checked)
                txbPassWord.UseSystemPasswordChar = true;
        }
    }
}
