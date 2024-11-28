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
    public partial class FormShowInfoEmployee : Form
    {
        public FormShowInfoEmployee()
        {
            InitializeComponent();
        }
        void LoadInfo()
        {
            txbName.Text = Const.NewEmploy.Name;
            txbSex.Text = Const.NewEmploy.Sex;
            dtpkBirthday.Value = Const.NewEmploy.BirthDay;

            txbEmployeeID.Text = Const.NewEmploy.EmployeeCode.ToString();
            txbDepartment.Text = Const.NewEmploy.Department;
            txbPosition.Text = Const.NewEmploy.Position;
            txbContract.Text = Const.NewEmploy.Contract;
        }

        private void FormShowInfoEmployee_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
