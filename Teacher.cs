using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class
{
    public class Teacher : Human
    {
        private string _id;
        private string _subject;
        private string _education;
        
        public string Id { get => _id; set => _id = value; }
        public string Subject { get => _subject; set => _subject = value; }
        public string Education { get => _education; set => _education = value; }
        public Teacher(string name, int age, string birth,string sick,bool status,string id,string subject, string edcation):
            base(name,age,birth,sick,status)
        {
            Id = id;
            Subject = subject;
            Education = edcation;
        }
        public override string ToString()
        {
            return base.ToString()+$"" +
                    $"ID: {Id}" +
                    $"Subject: {Subject}" +
                    $"Education: {Education}";
        }
    }
}