using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QuanLiNhanSu_YT
{
    public partial class FormAddNewEmployee : Form
    {
        private static string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=Person;Integrated Security=True;";

        public FormAddNewEmployee()
        {
            InitializeComponent();
        }

        public void LoadData(string Id)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                string query = @"
            SELECT h.Id, h.Name, h.Birth,s.Id, s.Mssv,s.Grade, s.Password
            FROM Human h
            JOIN Student s ON h.Id = s.Id
            WHERE h.Name LIKE @Name";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader= command.ExecuteReader())
                    {
                        // Open the connection
                        connection.Open();

                        // Fill the DataSet
                        if (reader.Read())
                        {
                            txbName.Text= reader["Name"].ToString();
                            txbMSSv.Text = reader["Mssv"].ToString();
                            TxtCCcd.Text = reader["Id"].ToString();
                            BirthTxt.Text = reader["Birth"].ToString() ;
                            cboDepartment.Text = reader["Grade"].ToString();
                            Passtxt.Text = reader["Password"].ToString();
                        }
                    }
                }
            }
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Const.NewEmploy = new Employee(name, birthDay, sex, employeeID, department, position, contract);
            Administrator.addStudent(TxtCCcd.Text,txbName.Text, BirthTxt.Text,txbMSSv.Text,cboDepartment.Text,Passtxt.Text);
            this.Close();
        }

        private void FormAddNewEmployee_Load(object sender, EventArgs e)
        {
            //cboSex.DataSource = Const.listSex;
            cboDepartment.DataSource = Const.ListDepartment;
            //cboContract.DataSource = Const.listContract;
        }

        private void cboSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
