using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class
{
    public class Teacher : Human
    {
        private string _mscb;
        private string _subject;
        private string _education;
        
        
        public string Subject { get => _subject; set => _subject = value; }
        public string Education { get => _education; set => _education = value; }
        public string Mscb { get => _mscb; set => _mscb = value; }

        public Teacher(string id,string name, int age, string birth,string sick,bool status,string mscb,string subject, string edcation):
            base(id, name,age,birth,sick,status)
        {
            Mscb = mscb;
            Subject = subject;
            Education = edcation;
        }
        public override string ToString()
        {
            return base.ToString()+$"" +
                    $"MSCB: {Mscb}" +
                    $"Subject: {Subject}" +
                    $"Education: {Education}";
        }
    }
}