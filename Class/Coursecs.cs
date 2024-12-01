using QuanLiNhanSu_YT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLiNhanSu_YT
{
    public class Coursecs
    {
        private static string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=Person;Integrated Security=True;";
        public static void addScore(string mssv, string subject, string score="")
        {
            CreateTableCourse();
            if (checkCourse(mssv, subject))
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    string updateScore =
                        @"MERGE INTO Score AS target
                        USING(SELECT @Mssv AS Mssv, @Subject AS Subject, @Score AS Score) AS source
                        ON target.Mssv=source.Mssv AND target.Subject=source.Subject
                        WHEN MATCHED THEN
                            UPDATE SET target.Score=source.Score
                        WHEN NOT MATCHED THEN
                            INSERT(Mssv,Subject,Score)
                            VALUES(source.Mssv,source.Subject,source.Score);
";
                    using (SqlCommand update = new SqlCommand(updateScore, connection))
                    {
                        update.Parameters.AddWithValue("@Mssv", mssv);
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

        public static void addScore(string mssv, string subject)
        {
            CreateTableCourse();
            if (!checkCourse(mssv,subject))
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    string insertScore =
                        "INSERT INTO Score(Mssv, Subject)" +
                        "VALUES(@Mssv, @Subject)";
                    using (SqlCommand insert = new SqlCommand(insertScore, connection))
                    {
                        insert.Parameters.AddWithValue("@Mssv", mssv);
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
                    Subject NVARCHAR(50),
                    Score DECIMAL(5, 2), -- Thay đổi kích thước nếu cần
                    CONSTRAINT UQ_Score_Mssv_Subject UNIQUE (mssv, subject),
                    FOREIGN KEY (Mssv) REFERENCES Student(Mssv) ON DELETE CASCADE,
                )
            END";
                using (SqlCommand checkCommand = new SqlCommand(check, connection))
                {
                    checkCommand.ExecuteNonQuery(); // Thực thi lệnh
                }
            } // Kết nối sẽ tự động đóng ở đây
        }
        public static bool checkCourse(string mssv, string subject)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string CheckCourse = "SELECT COUNT(*) FROM Score WHERE Mssv=@Mssv ";
                using (SqlCommand CheckCourseCommand = new SqlCommand(CheckCourse, connection))
                {
                    //CheckCourseCommand.Parameters.AddWithValue("@Subject", subject);
                    //CheckCourseCommand.Parameters.AddWithValue("@MMH",Mmh);
                    CheckCourseCommand.Parameters.AddWithValue("@Mssv", mssv);
                    int count = (int)CheckCourseCommand.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        //public static bool checkCourse(/*string mssv,*/ string teacher, string subject)
        //{
        //    using (SqlConnection connection = new SqlConnection(connect))
        //    {
        //        connection.Open();
        //        string CheckCourse = "SELECT COUNT(*) FROM Score WHERE Mssv=@Mssv ";
        //        using (SqlCommand CheckCourseCommand = new SqlCommand(CheckCourse, connection))
        //        {
        //            CheckCourseCommand.Parameters.AddWithValue("@Subject", subject);
        //            //CheckCourseCommand.Parameters.AddWithValue("@MMH",Mmh);
        //            //CheckCourseCommand.Parameters.AddWithValue("@Mssv", mssv);
        //            int count = (int)CheckCourseCommand.ExecuteScalar();
        //            return count > 0;
        //        }
        //    }
        //}

        public static void deleteScore(string mssv,string subject)
        {
            if(checkCourse(mssv, subject) /*&& checkTableScore()*/)
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                   
                    string query = "DELETE FROM Score WHERE Mssv = @Mssv AND Subject = @Subject";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào câu lệnh
                        command.Parameters.AddWithValue("@Mssv", mssv);
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
                if(!checkCourse(mssv, subject))
                {
                    MessageBox.Show("Khong tim thay Course");
                }
                
            }
        }
        public static DataSet ASCsort()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                DataSet dataSet = new DataSet();
                connection.Open();
                string query = @"
                SELECT *
                FROM Score
";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet);
                    }
                }
                return dataSet;
            }
        }
        public static string checkScore(string mssv, string Subject)// kiểm tra điểm
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                string str = "";
                connection.Open();
                string query = @"SELECT score FROM course WHERE Mssv = @Mssv AND Subject = @Subject";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Mssv", mssv); // Mã sinh viên
                    command.Parameters.AddWithValue("@Subject", Subject); // Tên môn học
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Kiểm tra xem có dữ liệu không
                        {
                            str += reader.GetString(0); // Lấy giá trị từ cột score
                            //Console.WriteLine($"Score: {score}");
                        }
                    }
                }
                return str;
            }
        }
        public static DataSet GetData()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    string query = "SELECT * FROM Score";
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}");
            }
            return ds;
        }
    }
}
