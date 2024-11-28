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
    public partial class FormGrade : Form
    {
        public FormGrade()
        {
            InitializeComponent();
        }

        private void FormGrade_Load(object sender, EventArgs e)
        {
            // Gắn sự kiện CellClick cho DataGridView
            dtgvGrade.CellClick += dtgvGrade_CellClick;

            // Tải dữ liệu vào DataGridView
            BindGrid();
        }
        private void BindGrid()
        {
            dtgvGrade.DataSource = null;

            var dataSource = ListEmployee.Instance.ListEmploy
                .Select(emp => new
                {
                    FullName = emp.Name,
                    StudentID = emp.EmployeeCode,
                    Grade = emp.Grade
                }).ToList();

            dtgvGrade.DataSource = dataSource;

            // Đặt tiêu đề cho các cột
            dtgvGrade.Columns[0].HeaderText = "Họ và Tên";
            dtgvGrade.Columns[1].HeaderText = "Mã số sinh viên";
            dtgvGrade.Columns[2].HeaderText = "Điểm số";
        }

        private void dtgvGrade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Khi click vào một hàng trong DataGridView
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvGrade.Rows[e.RowIndex];
                txbName.Text = row.Cells[0].Value?.ToString() ?? "";
                txbID.Text = row.Cells[1].Value?.ToString() ?? "";
                txbGrade.Text = row.Cells[2].Value?.ToString() ?? "0";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Thêm sinh viên mới
            string fullName = txbName.Text;
            int studentID = int.Parse(txbID.Text);
            if (double.TryParse(txbGrade.Text, out double grade))
            {
                ListEmployee.Instance.ListEmploy.Add(new Employee(fullName, studentID, grade));
                BindGrid();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Điểm không hợp lệ!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Xóa điểm (đặt về 0)
            int studentID = int.Parse(txbID.Text);
            var student = ListEmployee.Instance.ListEmploy.FirstOrDefault(s => s.EmployeeCode == studentID);
            if (student != null && double.TryParse(txbGrade.Text, out double newGrade))
            {
                student.Grade = 0;
                BindGrid();
                ClearTextBoxes();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int studentID = int.Parse(txbID.Text);
            var student = ListEmployee.Instance.ListEmploy.FirstOrDefault(s => s.EmployeeCode == studentID);
            if (student != null && double.TryParse(txbGrade.Text, out double newGrade))
            {
                student.Grade = newGrade;
                BindGrid();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên hoặc điểm không hợp lệ!");
            }
        }
        private void ClearTextBoxes()
        {
            txbName.Clear();
            txbID.Clear();
            txbGrade.Clear();
        }


        private void dtgvGrade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra chỉ số hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại từ DataGridView
                DataGridViewRow row = dtgvGrade.Rows[e.RowIndex];

                // Gán giá trị vào các ô TextBox
                txbName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txbID.Text = row.Cells["StudentID"].Value?.ToString() ?? "";
                txbGrade.Text = row.Cells["Grade"].Value?.ToString() ?? "0";
            }
        }

    }
};
