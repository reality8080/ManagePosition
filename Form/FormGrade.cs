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

            // Tải dữ liệu vào DataGridView
            //BindGrid();
            DataSet ds = GetEmployeesFromDatabase();
            dtgvGrade.DataSource = ds;
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

        private DataSet GetEmployeesFromDatabase()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string query = @"SELECT * FROM Score";
                DataSet ds = new DataSet();
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using(SqlDataAdapter adapter=new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(ds);
                    }
                }
            return ds;
            }
        }

        private void dtgvGrade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Khi click vào một hàng trong DataGridView
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvGrade.Rows[e.RowIndex];
                txbSubject.Text = row.Cells[0].Value?.ToString() ?? "";
                txbMssv.Text = row.Cells[1].Value?.ToString() ?? "";
                txbScore.Text = row.Cells[2].Value?.ToString() ?? "0";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbScore != null)
            {
                Coursecs.addScore(txbMssv.Text, txbSubject.Text, txbScore.Text);
            }
            Coursecs.addScore(txbMssv.Text, txbSubject.Text);
            FormGrade_Load(this, EventArgs.Empty);
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Coursecs.deleteScore(txbMssv.Text, txbSubject.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Coursecs.deleteScore(txbMssv.Text, txbSubject.Text);
            Coursecs.addScore(txbMssv.Text, txbSubject.Text);
            Coursecs.addScore(txbMssv.Text, txbSubject.Text, txbScore.Text);
            FormGrade_Load(this, EventArgs.Empty);
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            txbSubject.Clear();
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
                txbSubject.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txbMssv.Text = row.Cells["StudentID"].Value?.ToString() ?? "";
                txbScore.Text = row.Cells["Grade"].Value?.ToString() ?? "0";
            }
        }

    }
};
