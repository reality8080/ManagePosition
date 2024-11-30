using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhanSu_YT
{
    public class User: Human
    {
        private static string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=Person;Integrated Security=True";
        private string userName;
        private string passWord;
        private int accountType;
        public string UserName { get { return userName; } set { userName = value; } }
        public string PassWord { get { return passWord; } set { passWord = value; } }

        public int AccountType { get => accountType; set => accountType = value; }

        public User(string id,string Name,string date, string userName, string passWord)
            :base(id,Name,date)
        {
            UserName=userName;
            PassWord=passWord;
            CreateTableUser();
            if (!CheckUser())
            {
                Insert();
            }
        }

        public void Insert()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string query = @"INSERT INTO User(Id, userName,PASSWORD)
                VALUES(@Id,@userName,@PASSWORD)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@userName", UserName);
                    command.Parameters.AddWithValue(@"PASSWORD", PassWord);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void CreateTableUser()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string query = @"
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLE WHERE TABLE_NAME='USER')
                BEGIN
                    CREATE TABLE USER(
                        Id NVARCHAR(50) PRIMARY KEY,
                        userName VARCHAR(100),
                        PASSWORD VARCHAR(100),
                        FOREGIN KEY (Id) REFERENCES Human(Id),
                END
";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public bool CheckUser()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string query = @"SELECT COUNT(*) FROM User WHERE Id=@Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public static DataSet GetDataSet_U()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    string query = "SELECT * FROM User";
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
// quản lí user có 