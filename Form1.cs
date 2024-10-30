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

        bool CheckLogin(string userName, string passWord)
        {
            for(int i = 0;i<ListUser.Instance.ListAccountUser.Count; i++)
            {
                if (userName == ListUser.Instance.ListAccountUser[i].UserName&& passWord == ListUser.Instance.ListAccountUser[i].PassWord)
                {
                    Const.accountType = ListUser.Instance.ListAccountUser[i].AccountType;
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

            string USERNAME= usertextBox.Text;
            string PASSWORD= passwordTextBox.Text;
            if (CheckLogin(USERNAME,PASSWORD))
            {
                mainForm f=new mainForm();
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }
            else
            {
                MessageBox.Show("Ten tai khoan hoac mat khau khong dung", "Loi", MessageBoxButtons.OK);
                usertextBox.Focus();
                return;
            }
        }

        private void F_Logout(object sender,EventArgs e)
        {
            (sender as mainForm).isExit=false;
            (sender as mainForm).Close();
            this.Show();
            //mainForm mainForm = new mainForm();
            //mainForm.ShowDialog();
            //this.Close();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passwordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheckbox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            if (!passwordCheckbox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
