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
        string adminKey;
        bool reg;
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

        public bool Register(string name, string pass, string houseNmb, string adminKey)
        {
            /*if (true)
            {

            }
            this.name = name;
            this.pass = pass;
            this.houseNmb = houseNmb;
            this.adminKey = adminKey;
            UserList.Add(new User()
            {
                Name = name,
                Pass = pass,
                AdminKey = adminKey,
                House = houseNmb
            });*/
            return reg;
        }   
    }
}
