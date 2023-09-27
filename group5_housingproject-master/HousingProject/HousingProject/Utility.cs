using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingStudentProject
{
    class Utility
    {
        List<User> myList = new List<User>();

        public List<User> UserList { get => myList; set => myList = value; }

        string name;
        string pass;
        string houseNmb;
        string adminKey = "8B1";
        bool reg = false;
        bool login = false;
        public void DeafultUser(string name, string pass)
        {
            this.name = name;
            this.pass = pass;
            UserList.Add(new User()
            {
                Name = name,
                Pass = pass
            });
        }
        public bool Login(string name, string pass)
        {
            List<string> NameList = new List<string>();
            List<string> PassList = new List<string>();
            NameList = UserList.Select(x => x.Name).ToList();
            PassList = UserList.Select(x => x.Pass).ToList();
            if (NameList.Contains(name) && PassList.Contains(pass))
            {
                login = true;
            }
            else
            {
                login = false;
            }
            return login;
        }

        public bool Register(string name, string pass, string houseNmb, string adminKey)
        {

            this.name = name;
            this.pass = pass;
            this.houseNmb = houseNmb;
            
            if (this.adminKey == adminKey)
            {
                UserList.Add(new User()
                {
                    Name = name,
                    Pass = pass,
                    House = houseNmb,
                });
                reg = true;
            }
            else
            {
                reg = false;
            }
            return reg = true;
        }   
    }
}
