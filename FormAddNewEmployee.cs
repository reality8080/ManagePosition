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
    public partial class FormAddNewEmployee : Form
    {
        public FormAddNewEmployee()
        {
            InitializeComponent();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            DateTime birthDay = dtpkBirthDay.Value;
            string sex = cboSex.Text;
            int employeeID = Convert.ToInt32(txbEmployeeID.Text);
            string department = cboDepartment.Text;
            string position = txbPosition.Text;
            string contract = cboContract.Text;

            Const.NewEmploy = new Employee(name, birthDay, sex, employeeID, department, position, contract);
            this.Close();
        }

        private void FormAddNewEmployee_Load(object sender, EventArgs e)
        {
            cboSex.DataSource = Const.listSex;
            cboDepartment.DataSource = Const.ListDepartment;
            cboContract.DataSource = Const.listContract;
        }

        private void cboSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
