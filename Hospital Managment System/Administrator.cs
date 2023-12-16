using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hospital_Managment_System
{
    public class Administrator: Person
    {
        

        public Administrator() : base(0,"admin","admin@gmail.com","admin","05000000","male") { }

        public Administrator(int iD, string name, string email, string password, string tel, string gender) : base(iD, name, email, password, tel, gender) { }
        public Administrator(Administrator admin) : base(admin.ID, admin.Name, admin.Email, admin.Password, admin.Tel, admin.Gender) { }
        public override string GetRole()
        {
            return "Admin. " + Name;
        }
        public override Person shallowClone()
        {
            return new Administrator(this);
        }
        public override Person deepClone()
        {
            return new Administrator(this);
        }

    }
}
