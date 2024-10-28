using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLiNhanSu_YT
{
    public class User
    {
        private string userName;
        private string password;
        private bool accountType;
        public User(string userName, string passWord, bool accountType)
        {
            this.userName = userName;
            this.password = passWord;
            this.accountType = accountType;
        }

        public string UserName
        {
            get=> userName;
            set => userName = value;
        }

        public string PassWord
        {
            get =>password;
            set => password = value;
        }
        public bool AccountType
        {
            get => accountType;
            set => accountType = value;
        }
    }
}