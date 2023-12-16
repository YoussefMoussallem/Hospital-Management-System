using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
    public enum EmployeeDepartment
    {
        Medical,
        Nursing,
        Administrative,
        Research,
        Education,
        AlliedHealth,
        outsideremployee
    }
    public class Employee : Person
    {
        public EmployeeDepartment Department { get; set; }
        public string Role { get; set; }
        public Employee() : base() { }

        public Employee(int iD, string name, string email, string password, string tel,string gender, string Role,string Department) : base(iD, name, email, password,tel,gender)
        {
            switch (Department)
            {
                case "Medical":
                    this.Department = EmployeeDepartment.Medical;
                    break;
                case "Nursing":
                    this.Department = EmployeeDepartment.Nursing;
                    break;
                case "Administrative":
                    this.Department = EmployeeDepartment.Administrative;
                    break;
                case "Research":
                    this.Department = EmployeeDepartment.Research;
                    break;
                case "Education":
                    this.Department = EmployeeDepartment.Education;
                    break;
                case "AlliedHealth":
                    this.Department = EmployeeDepartment.AlliedHealth;
                    break;
                default:
                    this.Department = EmployeeDepartment.outsideremployee;
                    break;
            }
            this.Role = Role;
        }
        public Employee(Employee emp) : base(emp.ID, emp.Name, emp.Email, emp.Password, emp.Tel, emp.Gender)
        {
            this.Department = emp.Department;
            this.Role = emp.Role;
        }

        public override string GetRole()
        {
            return Role+". "+Name;
        }
        public override Person shallowClone()
        {
            return new Employee(this);
        }
        public override Person deepClone()
        {
            return new Employee(this);
        }
    }
}
