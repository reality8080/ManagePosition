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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace QuanLiNhanSu_YT
{
    public partial class FormEditEmployee : Form
    {
        public FormEditEmployee()
        {
            InitializeComponent();
        }
        void LoadInfo()
        {
            txbName.Text = Const.NewEmploy.Name;
            cboSex.Text = Const.NewEmploy.Sex;
            dtpkBirthDay.Value= Const.NewEmploy.BirthDay;

            txbEmployeeID.Text = Const.NewEmploy.EmployeeCode.ToString();
            cboDepartment.Text = Const.NewEmploy.Department;
            txbPosition.Text = Const.NewEmploy.Position;
            cboContract.Text = Const.NewEmploy.Contract;
        }
        private void FormEditEmployee_Load(object sender, EventArgs e)
        {
            cboSex.DataSource = Const.listSex;
            cboDepartment.DataSource = Const.ListDepartment;
            cboContract.DataSource = Const.listContract;

            LoadInfo();
        }

        private void btnEdit_Click(object sender, EventArgs e)
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

        private void txbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
