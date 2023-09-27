using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HousingStudentProject
{
    class User
    {
        private static string adminKey = "8B1";
        public string password;
        public string name;
        public string house;

        public string Name { get => name; set => name = value; }
        public string Pass { get => password; set => password = value; }
        public string AdminKey { get => adminKey; set => adminKey = value; }
        public string House { get => house; set => house = value; }

    }
}
