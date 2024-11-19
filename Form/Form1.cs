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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool checkLogin(string userName, string passWord)
        {
            for(int i = 0; i < ListUser.Instance.ListUsers.Count; i++)
            {
                if (userName == ListUser.Instance.ListUsers[i].UserName && passWord == ListUser.Instance.ListUsers[i].UserName)
                {
                    Const.AccountType = ListUser.Instance.ListUsers[i].AccountType;    
                    return true;
                }
            }
            return false;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (checkLogin(userName, passWord))
            {
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

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
