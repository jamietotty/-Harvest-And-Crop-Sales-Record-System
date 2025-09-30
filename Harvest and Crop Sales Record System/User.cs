using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_and_Crop_Sales_Record_System
{
   
        public class User
        {
        public string Username { get; set; }
        public string Password { get; set; } // optional
        public string Role { get; set; }

        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }

    
}
