using PharmacyProject.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProject.Users
{
    internal class User:AbstractBaseProp
    {
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static List<User> UserList = new List<User>();



        public static bool UserLogin(string username, string password)
        {
            bool LoginStatus = false;
            LoginForm loginForm = new LoginForm();
            foreach (var user in UserList)
            {
                if (user.Username==username && user.Password==password)
                {
                    LoginStatus = true;
                }

            }

            return LoginStatus ;


        }
    }

    

}
