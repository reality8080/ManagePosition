using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLiNhanSu_YT
{
    public partial class FormMain : Form
    {
        int index = -1;
        public bool isExit = true;
        public event EventHandler Logout;
        public FormMain()
        {
            InitializeComponent();
        }

        
        #region Method
        void Decentralization()
        {
            if(Const.AccountType == 1)
            {
                tsmiDepartment.Enabled = tsmiEmployee.Enabled = tsmiUser.Enabled = false;
            }
            if(Const.AccountType == 2)
            {
                tsmiDepartment.Enabled = tsmiUser.Enabled =  false;
            }
        }

        void LoadListEmployee()
        {
            dtgvEmployee.Rows.Clear();

            foreach (var item in ListEmployee.Instance.ListEmploy)
            {
                dtgvEmployee.Rows.Add(item.EmployeeCode, item.Name, item.BirthDay.ToShortDateString(), item.Sex, item.Department, item.Position, item.Contract);
            }
        }
        #endregion


        #region Event
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isExit)
                Application.Exit();

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            btnShow.Enabled = btnAddNew.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            Decentralization();

            LoadListEmployee();
        }
        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }
        private void tsmiEmployee_Click(object sender, EventArgs e)
        {
            btnShow.Enabled = btnAddNew.Enabled = btnDelete.Enabled = btnEdit.Enabled = true;
        }
        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Const.AccountType < 2)
                MessageBox.Show("Bạn không phải là giảng viên hay admin", "Cảnh báo");
        }
        private void tsmiUser_Click(object sender, EventArgs e)
        {
            FormUser f = new FormUser();
            f.ShowDialog();
        }
        private void tsmiDepartment_Click(object sender, EventArgs e)
        {
            if (Const.AccountType == 2) MessageBox.Show("Bạn không phải là admin", "Cảnh báo");
            FormDepartment f = new FormDepartment();
            f.ShowDialog();
        }
        private void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if(index < 0 || index >= ListEmployee.Instance.ListEmploy.Count)
                return;

            Const.NewEmploy = new Employee();
            Const.NewEmploy.Name = ListEmployee.Instance.ListEmploy[index].Name;
            Const.NewEmploy.BirthDay = ListEmployee.Instance.ListEmploy[index].BirthDay;
            Const.NewEmploy.Sex = ListEmployee.Instance.ListEmploy[index].Sex;
            
            Const.NewEmploy.EmployeeCode = ListEmployee.Instance.ListEmploy[index].EmployeeCode;
            Const.NewEmploy.Department = ListEmployee.Instance.ListEmploy[index].Department;
            Const.NewEmploy.Position = ListEmployee.Instance.ListEmploy[index].Position;
            Const.NewEmploy.Contract = ListEmployee.Instance.ListEmploy[index].Contract;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListEmployee.Instance.ListEmploy.Count)
                return;
            FormShowInfoEmployee f = new FormShowInfoEmployee();
            f.ShowDialog();
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Const.NewEmploy = null;
            FormAddNewEmployee f = new FormAddNewEmployee();
            f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListEmployee.Instance.ListEmploy.Add(Const.NewEmploy);
            LoadListEmployee();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = txbName.Text.Trim();
            string studentID = txbStudentID.Text.Trim();
            SearchEmployee(name, studentID);
        }
        private void SearchEmployee(string name, string employeeCode)
        {
            dtgvEmployee.Rows.Clear();

            var filteredList = ListEmployee.Instance.ListEmploy
                                .Where(emp =>
                                    (string.IsNullOrEmpty(name) || emp.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0) &&
                                    (string.IsNullOrEmpty(employeeCode) || emp.EmployeeCode.ToString().Contains(employeeCode)))
                                .ToList();

            foreach (var item in filteredList)
            {
                dtgvEmployee.Rows.Add(item.EmployeeCode, item.Name, item.BirthDay.ToShortDateString(), item.Sex, item.Department, item.Position, item.Contract);
            }

            if (filteredList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo");
            }
        }
        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListEmployee.Instance.ListEmploy.Count)
            {
                MessageBox.Show("Hãy chọn 1 bản ghi", "Thông báo");
                return;
            }
            FormEditEmployee f = new FormEditEmployee();
            f.FormClosed += F_FormClosed1; 
            f.ShowDialog();
        }
        private void F_FormClosed1(object sender, FormClosedEventArgs e)
        {
            ListEmployee.Instance.ListEmploy[index].Name = Const.NewEmploy.Name;
            ListEmployee.Instance.ListEmploy[index].BirthDay = Const.NewEmploy.BirthDay;
            ListEmployee.Instance.ListEmploy[index].Sex = Const.NewEmploy.Sex;
            ListEmployee.Instance.ListEmploy[index].EmployeeCode = Const.NewEmploy.EmployeeCode;
            ListEmployee.Instance.ListEmploy[index].Department = Const.NewEmploy.Department;
            ListEmployee.Instance.ListEmploy[index].Position = Const.NewEmploy.Position;
            ListEmployee.Instance.ListEmploy[index].Contract = Const.NewEmploy.Contract;

            LoadListEmployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListEmployee.Instance.ListEmploy.Count)
            {
                MessageBox.Show("Hãy chọn 1 bản ghi", "Thông báo");
                return;
            }
            ListEmployee.Instance.ListEmploy.RemoveAt(index);
            LoadListEmployee() ;
        }
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmiGrade_Click(object sender, EventArgs e)
        {
            FormGrade f = new FormGrade();
            f.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Const.AccountType < 3) MessageBox.Show("Bạn không phải admin", "Cảnh báo");
        }
    }
}
