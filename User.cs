using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu_YT
{
    public class User
    {
        private string userName;
        private string passWord;
        private bool accountType;
        public string UserName { get { return userName; } set { userName = value; } }
        public string PassWord { get { return passWord; } set { passWord = value; } }

        public bool AccountType { get => accountType; set => accountType = value; }

        public User(string userName, string passWord, bool accountType)
        {
            this.UserName = userName;
            this.PassWord = passWord;
            this.AccountType = accountType;
        }
    }
}
