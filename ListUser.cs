using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLiNhanSu_YT
{
    public class ListUser
    {
        private static ListUser instance;
        public static ListUser Instance
        {
            get 
            { if(instance == null)
                {
                    instance = new ListUser();
                }
                return instance; 
            }
            set { instance = value; }
        }
        private List<User> listAccountUser;

        private ListUser()
        {
            listAccountUser = new List<User>();
            listAccountUser.Add(new User("Nguyen Tran Thien Phu","231102",true));

        }

        public List<User> ListAccountUser
        {
            get=>listAccountUser; set => listAccountUser = value;
        }
    }
}