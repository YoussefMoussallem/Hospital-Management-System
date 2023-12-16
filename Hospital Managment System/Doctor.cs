using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
    public enum DocDepartment
    {
        Cardiology,
        orthopedics,
        Anesthesiology,
        ColonandRectal,
        Dermatology,
        Neurology,
        outsiderphysician
    }
    public class Doctor : Person
    {
        public DocDepartment Department { get; set; }

        public double PricePerAppointment { get; set; }
        public DateTime starttime { get; set; }

        public DateTime endtime { get; set; }
        public Dictionary<int,Appointment> appointments { get; set; }
        public int AppointmentID = 0;
        public Doctor() : base() {
            Name = "doc";
            Password = "doc";
        }

        public  void addAppointment(Appointment appointment)
        {
            appointment.AppointmentID = AppointmentID;
            appointments.Add(AppointmentID, appointment);
            AppointmentID++;
        }

        public Doctor(int iD, string name, string email,string password,string tel, string gender, string depart,double PricePerAppointment,DateTime starttime,DateTime endtime) : base(iD, name, email,password,tel,gender)
        {

            switch (depart)
            {
                case "Cardiology":
                    Department = DocDepartment.Cardiology;
                    break;
                case "orthopedics":
                    Department = DocDepartment.orthopedics;
                    break;
                case "ColonandRectal":
                    Department = DocDepartment.ColonandRectal;
                    break;
                case "Anesthesiology":
                    Department = DocDepartment.Anesthesiology;
                    break;
                case "Dermatology":
                    Department = DocDepartment.Dermatology;
                    break;
                case "Neurology":
                    Department = DocDepartment.Neurology;
                    break;
                default:
                    Department = DocDepartment.outsiderphysician;
                    break;
            }
            this.PricePerAppointment = PricePerAppointment;
            this.starttime = starttime;
            this.endtime = endtime; 
            appointments = new Dictionary<int, Appointment>();
        }
        public Doctor(Doctor doc) : base(doc.ID, doc.Name, doc.Email, doc.Password, doc.Tel, doc.Gender)
        {
            this.Department = doc.Department;
            this.PricePerAppointment = doc.PricePerAppointment;
            this.starttime = doc.starttime;
            this.endtime = doc.endtime;
            appointments = doc.appointments;
        }

        public override string GetRole()
        {
            return "Doc. " + Name;
        }

        public override Person shallowClone()
        {
            return new Doctor(this);
        }
        public override Person deepClone()
        {
            Doctor temp=new Doctor(this);
            temp.appointments = new Dictionary<int, Appointment>();
            foreach (var kvp in this.appointments)
            {
                temp.appointments.Add(kvp.Key, kvp.Value);
            }
            return temp;
        }
    }
}
