using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLiNhanSu_YT
{
    public partial class FormUser : Form
    {
        List<string> listAccountType = new List<string>() { "Sinh viên", "Giảng viên", "Admin" };
        int index = -1;
        public FormUser()
        {
            InitializeComponent();
        }

        void LoadListUser()
        {
            dtgvUser.DataSource = null;
            dtgvUser.DataSource = ListUser.Instance.ListAccountUser;
            dtgvUser.Refresh();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            cboStaff.DataSource = listAccountType;
            LoadListUser();
        }

        private void dtgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            index = e.RowIndex;
            if (index < 0) {  return; }

            txbUserName.Text = dtgvUser.Rows[index].Cells[0].Value.ToString();
            txbPassword.Text = dtgvUser.Rows[index].Cells[1].Value.ToString();

            switch (ListUser.Instance.ListAccountUser[index].AccountType)
            {
                case 1:
                    cboStaff.Text = "Sinh viên";
                    break;
                case 2:
                    cboStaff.Text = "Giảng viên";
                    break;
                case 3:
                    cboStaff.Text = "Admin";
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassword.Text;
            int accountType = 0;

            switch (cboStaff.Text)
            {
                case "Sinh viên":
                    accountType = 1;
                    cboStaff.Text = "Sinh viên";
                    break;
                case "Giảng viên":
                    accountType = 2;
                    cboStaff.Text = "Giảng viên";
                    break;
                case "Admin":
                    accountType = 3;
                    cboStaff.Text = "Admin";
                    break;
            }

            ListUser.Instance.ListAccountUser.Add(new User(userName, passWord, accountType));

            LoadListUser();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (index < 0) {
                MessageBox.Show("Vui lòng chọn 1 bản ghi");    
                return; 
            }
            string userName = txbUserName.Text;
            string passWord = txbPassword.Text;
            int accountType = 0;

            switch (cboStaff.Text)
            {
                case "Sinh viên":
                    accountType = 1;
                    cboStaff.Text = "Sinh viên";
                    break;
                case "Giảng viên":
                    accountType = 2;
                    cboStaff.Text = "Giảng viên";
                    break;
                case "Admin":
                    accountType = 3;
                    cboStaff.Text = "Admin";
                    break;
            }
            ListUser.Instance.ListAccountUser[index].UserName = userName;
            ListUser.Instance.ListAccountUser[index].PassWord = passWord;
            ListUser.Instance.ListAccountUser[index].AccountType = accountType;
            LoadListUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi");
                return;
            }
            ListUser.Instance.ListAccountUser.RemoveAt(index);
            LoadListUser();
        }
    }
}
