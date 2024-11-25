using System;
using System.Collections.Generic;
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
        private string connect = "Data Source=LAPTOP-49M0TBTC;Initial Catalog=person;Integrated Security=True;";


        private SqlConnection _connection;
        private string id;
<<<<<<<< HEAD:Human-Student/Human.cs
        private string _name;
        //private int _age;
        private date _birth;
        //private string sick;
        //private bool status;

        public string Name { get => _name; set => _name = value; }
        //public int Age { get => _age; set => _age = value; }
        public string Birth { get => _birth.ToString();/* set => _birth.String_ToDate(value);*/ }
        //public string Sick { get => sick; set => sick = value; }
        //public bool Status { get => status; set => status = value; }
========

>>>>>>>> 9e84fdc4caf764c9d6a40d5c684bdbc14732ea36:Human.cs
        public string Id { get => id; set => id = value; }
        //public SqlConnection Connection { get => _connection; set => _connection = value; }

<<<<<<<< HEAD:Human-Student/Human.cs
        public Human(string id,string name/*, int age*/, string date) 
        {
            Id = id;
            Name = name;
            //Age = age;
            _birth=new date();
            _birth.String_ToDate(date);
========
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
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("ID cannot be null or empty.", nameof(id));
            }

            CreateTableIfNotExists();

            if (!CheckIdExists(Id))
            {
                InsertHumanInfo(Id, name, date);
            }

            
>>>>>>>> 9e84fdc4caf764c9d6a40d5c684bdbc14732ea36:Human.cs
        }

        private void CreateTableIfNotExists()
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

                string insertHuman = "INSERT INTO Human (Id, Name, Birth) VALUES (@Id, @Name, @Birth)";
                using (SqlCommand command = new SqlCommand(insertHuman, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Birth", date);
                    command.ExecuteNonQuery();
                }
            }
        }


        public override string ToString()
        {
<<<<<<<< HEAD:Human-Student/Human.cs
            return $"ID:{Id}" +
                    $"Name: {Name}\n" +
                    //$"Age: {Age}\n" +
                    $"BirthDay: {Birth}\n";
                    //$"Sick: {Sick}" +
                    //$"Status: {Status}";
========
            string result = "";
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();

                string query = "SELECT Id, Name, Birth FROM Human WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = $"Id: {reader.GetString(0)}\nName: {reader.GetString(1)}\nBirth: {reader.GetString(2)}";
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy");
                        }
                    }
                }
            }
            return result;

>>>>>>>> 9e84fdc4caf764c9d6a40d5c684bdbc14732ea36:Human.cs
        }
    }
}