using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
    
    public abstract class Person
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Tel { get; set; }

        public string Password;
        protected Person()
        {

        }
        protected Person(int iD, string name, string email,string password,string tel,string gender)
        {
            ID = iD;
            Name = name;
            Email = email;
            Gender = gender;
            Tel = tel;
            Password = password;
        }

        public abstract string GetRole();
        public abstract Person shallowClone();
        public abstract Person deepClone();


    }
}
