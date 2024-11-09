using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLiNhanSu_YT
{
    public abstract class Human
    {
        private string id;
        private string _name;
        private int _age;
        private date _birth;
        private string sick;
        private bool status;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Birth { get => _birth.ToString(); set => _birth.String_ToDate(value); }
        public string Sick { get => sick; set => sick = value; }
        public bool Status { get => status; set => status = value; }
        public string Id { get => id; set => id = value; }

        public Human(string id,string name, int age, string date,string sick="Binh thuong",bool status=true) 
        { 
            Id = id;
            Name = name;
            Age = age;
            Birth= date;
        }
        public override string ToString()
        {
            return  $"ID:{Id}" +
                    $"Name: {Name}\n" +
                    $"Age: {Age}\n" +
                    $"BirthDay: {Birth.ToString()}" +
                    $"Sick: {Sick}" +
                    $"Status: {Status}";
        }
    }
}