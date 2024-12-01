using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private static string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=Person;Integrated Security=True;";

        int index = -1;
        public bool isExit = true;
        public event EventHandler Logout;
        public FormMain()
        {
            InitializeComponent();
            //this.Load += new System.EventHandler(this.FormMain_Load);
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
            //dtgvEmployee.Rows.Clear();
            DataSet ds = Student.ASCSort();
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connect))
            //    {
            //        string query = @"SELECT * FROM Score";
            //        using(SqlDataAdapter adapter=new SqlDataAdapter(query, conn))
            //        {
            //            adapter.Fill(ds,"Score");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}");
            //}
            //if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            //{
            //    MessageBox.Show("Không có dữ liệu để hiển thị.");
            //    return;
            //}
            dtgvEmployee.DataSource = ds.Tables[0];
            //dtgvEmployee.DataSource = ds.Tables[1];
            //dtgvEmployee.DataSource = ds.Tables[2];

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
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            Student.CreateStudentTableIfNotExists();
            Coursecs.CreateTableCourse();
            Decentralization();

            LoadListEmployee();
        }
        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }
        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Const.AccountType < 2)
                MessageBox.Show("Bạn không phải là giảng viên hay admin", "Cảnh báo");
        }
        //private void tsmiUser_Click(object sender, EventArgs e)
        //{
        //    FormUser f = new FormUser();
        //    f.ShowDialog();
        //}
        private void tsmiDepartment_Click(object sender, EventArgs e)
        {
            if (Const.AccountType == 2) MessageBox.Show("Bạn không phải là admin", "Cảnh báo");
            FormDepartment f = new FormDepartment();
            f.ShowDialog();
        }
        private void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            
        }
        //private void btnShow_Click(object sender, EventArgs e)
        //{
        //    if (index < 0 || index >= ListEmployee.Instance.ListEmploy.Count)
        //        return;
        //    FormShowInfoEmployee f = new FormShowInfoEmployee();
        //    f.ShowDialog();
        //}
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //Const.NewEmploy = null;
            FormAddNewEmployee f = new FormAddNewEmployee();
            f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ListEmployee.Instance.ListEmploy.Add(Const.NewEmploy);
            LoadListEmployee();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = txbName.Text.Trim();
            string studentID = txbStudentID.Text.Trim();
            DataSet result=SearchStu(name, studentID);
            if (result.Tables.Count > 0)
            {
                dtgvEmployee.DataSource = result.Tables[0];
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin sinh viên.");
            }
        }
        private DataSet SearchStu(string name, string mssv)
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(connect))
            {
                string query = @"
            SELECT h.Id, h.Name, h.Birth, s.Mssv, s.Grade,sc.Subject, sc.Score
            FROM Human h
            JOIN Student s ON h.Id = s.Id
            LEFT JOIN Score sc ON s.Mssv = sc.Mssv
            WHERE h.Name LIKE @Name AND s.Mssv LIKE @Mssv";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Name",name);
                    command.Parameters.AddWithValue("@Mssv", mssv);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Open the connection
                        connection.Open();

                        // Fill the DataSet
                        adapter.Fill(dataSet);
                    }
                }
            }
            return dataSet;
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
            dtgvEmployee.AutoGenerateColumns = true;
            LoadListEmployee();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormAddNewEmployee f = new FormAddNewEmployee();
            f.FormClosed += F_FormClosed;
            f.ShowDialog();

        }
        //private void F_FormClosed1(object sender, FormClosedEventArgs e)
        //{

        //    LoadListEmployee();
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (index < 0 || index >= ListEmployee.Instance.ListEmploy.Count)
            //{
            //    MessageBox.Show("Hãy chọn 1 bản ghi", "Thông báo");
            //    return;
            //}
            //ListEmployee.Instance.ListEmploy.RemoveAt(index);

            Delete(txbName.Text,txbStudentID.Text);
            LoadListEmployee();
        }

        private void Delete(string name, string mssv)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string queryHuman = @"DELETE FROM Human WHERE Name=@Name";
                        using (SqlCommand command = new SqlCommand(queryHuman, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Name", name);
                            command.ExecuteNonQuery();
                        }
                        string queryStu = @"DELETE FROM Student WHERE Mssv=@Mssv";
                        using (SqlCommand command = new SqlCommand(queryStu, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Mssv", mssv);
                            command.ExecuteNonQuery();
                        }
                        string querySco = @"DELETE FROM Score WHERE Mssv=@Mssv";
                        using (SqlCommand command = new SqlCommand(querySco, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Mssv", mssv);
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        LoadListEmployee();
                    }
                    catch (Exception ex) 
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmiGrade_Click(object sender, EventArgs e)
        {
            FormGrade f = new FormGrade();
            f.ShowDialog();
            LoadListEmployee();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Const.AccountType < 3) MessageBox.Show("Bạn không phải admin", "Cảnh báo");
        }

        private void tsmiEmployee_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = true;
        }
    }
}
