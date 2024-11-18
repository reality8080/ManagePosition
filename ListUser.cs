using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu_YT
{
    public class ListUser
    {
        private static ListUser instance; 
        //private List<User> _listAccountUser;
        private List<User> _listAccountUser;
        public List<User> ListAccountUser { get => _listAccountUser; set => _listAccountUser = value; }
        public static ListUser Instance {
            get
            { if(instance == null)
            {
                if(instance == null)
                    instance = new ListUser();
                }
                return instance;
            }
            set => instance = value;
        }
        

        public ListUser()
        {
            ListAccountUser = new List<User>();
            ListAccountUser.Add(new User("QuangDuyReal", "Duy161005.", true));
            ListAccountUser.Add(new User("fansjaki@gmail.com", "3380", false));
        }
    }
}
