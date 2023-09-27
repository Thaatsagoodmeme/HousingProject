using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HousingStudentProject
{
    class User
    {
        private string password;
        private string name;
        private string house;

        public string Name { get { return name; } set { name = value; } }
        public string Pass { get { return password; }  set { password = value; } }
        public string House { get { return house; } set { house = value; } }

    }
}
