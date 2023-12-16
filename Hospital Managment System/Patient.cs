using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hospital_Managment_System
{
    public class Patient : Person
    {
        public Person CreatedBy { get; set; }
        public DateTime Date { get; set; }
        public Patient() : base() { }
        public Patient(int iD, string name,string email, string tel, string gender, Person createdby, DateTime date) : base(iD, name, email, "", tel, gender)
        {
            this.CreatedBy = createdby;
            this.Date = date;
        }

        public Patient(Patient pat) : base(pat.ID, pat.Name, pat.Email, pat.Password, pat.Tel, pat.Gender)
        {
            this.CreatedBy = pat.CreatedBy;
            this.Date = pat.Date;
        }
        public override string GetRole()
        {
            return "Patient. " + Name;
        }

        public override Person shallowClone()
        {
            return new Patient(this);
        }
        public override Person deepClone()
        {
            Patient temp = new Patient(this);
            temp.CreatedBy =null;
            return temp;
        }
    }
}
