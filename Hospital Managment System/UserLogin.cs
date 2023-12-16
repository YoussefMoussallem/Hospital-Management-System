using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
    public abstract class UserLogin
    {
        public string email { get; set; }
        public string password { get; set; }
        public UserLogin(string email,string password) { 
            this.email = email;
            this.password = password;
        }
        public abstract bool login();
    }
}
