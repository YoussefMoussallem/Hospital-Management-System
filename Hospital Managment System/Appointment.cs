using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public Room room { get; set; }
        public Bill bill { get; set; }
        Doctor doctor { get; set; }
        public Appointment(int AppointmentID, DateTime AppointmentDate, int PatientID,int DoctorID,Room room,Doctor doctor)
        {
            this.AppointmentID = AppointmentID;
            this.AppointmentDate = AppointmentDate;
            this.PatientID = PatientID;
            this.DoctorID = DoctorID;
            this.room = room;
            this.doctor = doctor;
            bill = new Bill(room,doctor );
        } 
    }
}
