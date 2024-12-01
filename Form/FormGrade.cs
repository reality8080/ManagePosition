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

namespace QuanLiNhanSu_YT
{
    public partial class FormGrade : Form
    {
        private static string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=Person;Integrated Security=True;";

        public FormGrade()
        {
            InitializeComponent();
        }

        private void FormGrade_Load(object sender, EventArgs e)
        {
            // Gắn sự kiện CellClick cho DataGridView
            dtgvGrade.CellClick += dtgvGrade_CellClick;
            CBOSubject.DataSource=Const.TeacherCourse;
            // Tải dữ liệu vào DataGridView
            //BindGrid();
            loadScore();
        }
        //private void BindGrid()
        //{
        //dtgvGrade.DataSource = null;

        //var dataSource = ListEmployee.Instance.ListEmploy
        //    .Select(emp => new
        //    {
        //        FullName = emp.Name,
        //        StudentID = emp.EmployeeCode,
        //        Grade = emp.Grade
        //    }).ToList();

        //dtgvGrade.DataSource = dataSource;

        //// Đặt tiêu đề cho các cột
        //dtgvGrade.Columns[0].HeaderText = "Họ và Tên";
        //dtgvGrade.Columns[1].HeaderText = "Mã số sinh viên";
        //dtgvGrade.Columns[2].HeaderText = "Điểm số";


        //}

        //private DataSet GetEmployeesFromDatabase()
        //{
        //    using (SqlConnection conn = new SqlConnection(connect))
        //    {
        //        string query = @"SELECT * FROM Score";
        //        DataSet ds = new DataSet();
        //        conn.Open();
        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            using(SqlDataAdapter adapter=new SqlDataAdapter(cmd))
        //            {
        //                adapter.Fill(ds);
        //            }
        //        }
        //    return ds;
        //    }
        //}

        private void dtgvGrade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvGrade.AutoGenerateColumns=true;
            // Khi click vào một hàng trong DataGridView
            loadScore();
        }

        void loadScore()
        {
            DataSet ds = Coursecs.ASCsort();
            dtgvGrade.DataSource=ds.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbScore != null)
            {
                Coursecs.addScore(txbMssv.Text, CBOSubject.Text, txbScore.Text);
            }
            else
            {
                Coursecs.addScore(txbMssv.Text, CBOSubject.Text);
            }
           
            FormGrade_Load(this, EventArgs.Empty);
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Coursecs.deleteScore(txbMssv.Text, CBOSubject.Text);
            loadScore();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Coursecs.deleteScore(txbMssv.Text, CBOSubject.Text);
            //Coursecs.addScore(txbMssv.Text, txbSubject.Text);
            Coursecs.addScore(txbMssv.Text, CBOSubject.Text, txbScore.Text);
            FormGrade_Load(this, EventArgs.Empty);
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            CBOSubject.Items.Clear();
            txbMssv.Clear();
            txbScore.Clear();
        }


        private void dtgvGrade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra chỉ số hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại từ DataGridView
                DataGridViewRow row = dtgvGrade.Rows[e.RowIndex];

                // Gán giá trị vào các ô TextBox
                CBOSubject.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txbMssv.Text = row.Cells["StudentID"].Value?.ToString() ?? "";
                txbScore.Text = row.Cells["Grade"].Value?.ToString() ?? "0";
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
};
