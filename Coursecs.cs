using QuanLiNhanSu_YT;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Thu_1_
{
    public class Coursecs
    {
        private static string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=Person;Integrated Security=True;";
        public static void addScore(string mssv, string teacher, string subject, string score)
        {
            CreateTableCourse();
            if (checkCourse(mssv, teacher, subject))
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    string updateScore =
                        "UPDATE Score SET Score = @Score " +
                        "WHERE Mssv = @Mssv AND Teacher = @Teacher AND Subject = @Subject";
                    using (SqlCommand update = new SqlCommand(updateScore, connection))
                    {
                        update.Parameters.AddWithValue("@Mssv", mssv);
                        update.Parameters.AddWithValue("@Teacher", teacher);
                        update.Parameters.AddWithValue("@Subject", subject);
                        update.Parameters.AddWithValue("@Score", score);

                        int rowsAffected = update.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Khong tim thay", "Canh bao", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Cap nhat diem thanh cong", "Thong bao", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay", "Canh bao", MessageBoxButtons.OK);
            }
        }

        public static void addScore(string mssv, string teacher, string subject)
        {
            CreateTableCourse();
            if (!checkCourse(mssv, teacher, subject))
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    string insertScore =
                        "INSERT INTO Score(Mssv, Teacher, Subject)" +
                        "VALUES(@Mssv, @Teacher, @Subject)";
                    using (SqlCommand insert = new SqlCommand(insertScore, connection))
                    {
                        insert.Parameters.AddWithValue("@Mssv", mssv);
                        insert.Parameters.AddWithValue("@Teacher", teacher);
                        insert.Parameters.AddWithValue("@Subject", subject);
                        //insert.Parameters.AddWithValue("@Score", score);
                        insert.ExecuteNonQuery();
                    }
                }
            }
        }
        public static void CreateTableCourse()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open(); // Mở kết nối
                string check = @"
            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Score')
            BEGIN
                CREATE TABLE Score(
                    Mssv NVARCHAR(50),
                    Teacher NVARCHAR(50),
                    Subject NVARCHAR(50),
                    Score DECIMAL(5, 2), -- Thay đổi kích thước nếu cần
                    PRIMARY KEY(Mssv,Teacher,Subject),
                    FOREIGN KEY (Mssv) REFERENCES Student(Mssv)
                )
            END";
                using (SqlCommand checkCommand = new SqlCommand(check, connection))
                {
                    checkCommand.ExecuteNonQuery(); // Thực thi lệnh
                }
            } // Kết nối sẽ tự động đóng ở đây
        }
        public static bool checkCourse(string mssv, string teacher, string subject)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string CheckCourse = "SELECT COUNT(*) FROM Score WHERE Mssv=@Mssv ";
                using (SqlCommand CheckCourseCommand = new SqlCommand(CheckCourse, connection))
                {
                    CheckCourseCommand.Parameters.AddWithValue("@Teacher", teacher);
                    CheckCourseCommand.Parameters.AddWithValue("@Subject", subject);
                    //CheckCourseCommand.Parameters.AddWithValue("@MMH",Mmh);
                    CheckCourseCommand.Parameters.AddWithValue("@Mssv", mssv);
                    int count = (int)CheckCourseCommand.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        public static void deleteScore(string mssv, string teacher, string subject)
        {
            if (checkCourse(mssv, teacher, subject) /*&& checkTableScore()*/)
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();

                    string query = "DELETE FROM Score WHERE Mssv = @Mssv AND Teacher = @Teacher AND Subject = @Subject";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào câu lệnh
                        command.Parameters.AddWithValue("@Mssv", mssv);
                        command.Parameters.AddWithValue("@Teacher", teacher);
                        command.Parameters.AddWithValue("@Subject", subject);
                        int rowsAffected = command.ExecuteNonQuery(); // Thực hiện câu lệnh xóa
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã xóa thành công bản ghi điểm.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy bản ghi nào để xóa.");
                        }
                    }

                }
            }
            else
            {
                /*if (!checkTableScore())
                {
                    MessageBox.Show("Khong co bang");
                }*/
                if (!checkCourse(mssv, teacher, subject))
                {
                    MessageBox.Show("Khong tim thay Course");
                }

            }
        }
    }
}