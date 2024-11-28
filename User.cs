using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLiNhanSu_YT
{
    public class User:Human
    {
        private static string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=Person;Integrated Security=True;";

        public User(string Id, string name, string date,string User,string Pass) :base(Id,name,date)
        {
            CreateTableUser();
            if (!CheckUser(Id))
            {
                InsertUser(Id,User,Pass);
            }
        }

        public void InsertUser(string Id, string User,String Password)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string insert = @"INSERT INTO User(Id, USER,PASSWORD, STATUS)
                VALUES(@Id,@USER,@PASSWORD,@STATUS)";
                using (SqlCommand command = new SqlCommand(insert, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@USER", User);
                    command.Parameters.AddWithValue("@PASSWORD", Password);
                    command.Parameters.AddWithValue("@STATUS",false);
                    try
                    {
                        command.ExecuteNonQuery();
                        //MessageBox.Show("Người dùng đã được thêm thành công.","Success",MessageBoxButtons.OK);
                    }
                    catch (SqlException ex)
                    {
                        // Kiểm tra mã lỗi để xác định loại lỗi
                        if (ex.Number == 2627) // Mã lỗi cho vi phạm unique constraint
                        {
                            MessageBox.Show("Tên người dùng đã tồn tại. Vui lòng chọn tên khác.","Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi: " + ex.Message,"Canh bao", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }
        public void CreateTableUser()
        {
            using (SqlConnection connection = new SqlConnection(connect)) 
            { 
                connection.Open();
                string query = @"
                IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLE WHERE TABLE_NAME='User')
                BEGIN
                    CREATE TABLE User(
                    Id NVARCHAR(50) PRIMARY KEY,
                    USER VARCHAR(100) UNIQUE,
                    PASS VARCHAR(100),
                    STATUS bit,
                    FOREIGN KEY(Id) REFERENCE Human(Id)
                    )
                END
";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public bool CheckUser(string Id)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM User Where Id=@Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public override string ToString()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string str = ""; str += $"{base.ToString()}\n";
                string Query = @"SELECT USER, PASS, STATUS FROM USER WHERE Id=@Id";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            str += $"User {reader.GetString(0)}, Password {reader.GetString(1)}, STATUS {reader.GetString(2)}\n";

                        }
                    }
                } return str;
            }
        }
    }
}
// quản lí user có 