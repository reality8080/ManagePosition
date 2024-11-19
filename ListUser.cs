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
        private List<User> listAccountUser;
        public List<User> ListAccountUser { get => listAccountUser; set => listAccountUser = value; }
        public static ListUser Instance {
            get
            {
                if(instance == null)
                    instance = new ListUser();
                return instance;
            }
            set => instance = value;
        }

        public ListUser()
        {
            listAccountUser = new List<User>();
            listAccountUser.Add(new User("QuangDuyReal", "Duy161005.", true));
            listAccountUser.Add(new User("fansjaki@gmail.com", "3380", false));
        }
    }
}
