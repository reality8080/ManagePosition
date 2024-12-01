using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
//using System.Windows.Forms;

namespace QuanLiNhanSu_YT
{
    public abstract class Human
    {
        private static string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=person;Integrated Security=True;";


        private SqlConnection _connection;
        private string id;

        public string Id { get => id; set => id = value; }
        //public SqlConnection Connection { get => _connection; set => _connection = value; }

        public bool CheckIdExists(string id)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Human WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Return true if ID exists, otherwise false
                }
            }
        }
        public Human(string id, string name, string date)
        {
            Id = id;
            //if (string.IsNullOrEmpty(id))
            //{
            //    throw new ArgumentException("ID cannot be null or empty.", nameof(id));
            //}

            CreateTableIfNotExists();

            //if (!CheckIdExists(Id))
            //{
                InsertHumanInfo(Id, name, date);
            //}

            
        }

        public static void CreateTableIfNotExists()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();

                string checkTable = @"
                    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Human')
                    BEGIN
                        CREATE TABLE HUMAN(
                            Id NVARCHAR(50) PRIMARY KEY,
                            Name NVARCHAR(100),
                            Birth VARCHAR(20)
                        )
                    END";

                using (SqlCommand command = new SqlCommand(checkTable, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void InsertHumanInfo(string id, string name, string date)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();

                //string insertHuman = "INSERT INTO Human (Id, Name, Birth) VALUES (@Id, @Name, @Birth)";
                //using (SqlCommand command = new SqlCommand(insertHuman, connection))
                //{
                //    command.Parameters.AddWithValue("@Id", id);
                //    command.Parameters.AddWithValue("@Name", name);
                //    command.Parameters.AddWithValue("@Birth", date);
                //    command.ExecuteNonQuery();
                //}
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string queryHuman = @"
                        MERGE INTO Human AS target
                        USING(VALUES (@Id,@Name,@Birth)) AS Source (Id,Name,Birth)
                        ON target.Id = source.Id
                        WHEN MATCHED THEN
                            UPDATE SET Id=source.Id, Name = source.Name, Birth = source.Birth
                        WHEN NOT MATCHED THEN
                            INSERT (Id, Name, Birth) 
                            VALUES (source.Id, source.Name, source.Birth);
";
                    using (SqlCommand command = new SqlCommand(queryHuman, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Birth", date);
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback(); // Rollback nếu có lỗi
                    throw;
                }
            }
        }


        //public override string ToString()
        //{
        //    string result = "";
        //    using (SqlConnection connection = new SqlConnection(connect))
        //    {
        //        connection.Open();

        //        string query = "SELECT Id, Name, Birth FROM Human WHERE Id = @Id";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@Id", Id);
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    result = $"Id: {reader.GetString(0)}\nName: {reader.GetString(1)}\nBirth: {reader.GetString(2)}";
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Không tìm thấy");
        //                }
        //            }
        //        }
        //    }
        //    return result;

        //}

        public static DataSet GetDataSet_H()
        {
            DataSet table = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connect ))
                {
                    connection.Open();
                    string query = "SELECT * FROM Human";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table,"Human");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}");
            }
            return table;
        }
    }
}