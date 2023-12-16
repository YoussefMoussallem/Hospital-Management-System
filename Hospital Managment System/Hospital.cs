using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
    public class Hospital
    {
        // Dictionaries to store different entities
        public Dictionary<string, Doctor> doctors = new Dictionary<string, Doctor> {  };
        public Dictionary<string, Patient> patients = new Dictionary<string, Patient>();
        public Dictionary<string, Employee> employees = new Dictionary<string, Employee>();
        public Dictionary<string, Administrator> admins = new Dictionary<string, Administrator> { { "admin", new Administrator() } };

        public Dictionary<int, Room> rooms = new Dictionary<int, Room>();
        public Dictionary<int, Appointment> appointments= new Dictionary<int, Appointment>();
        public  Dictionary<int, Bill> bills = new Dictionary<int, Bill>();
        public int DocId=0;
        public int PatientID = 0;
        public int EmployeeID = 0;
        public int RoomID = 0;
        public int AppointmentID = 0;
        public int BillsID = 0;
        public int AdminID = 0;

        private static Hospital hospital;

        private Hospital() { }
        public static Hospital getInstance()
        {
            if( hospital == null)
            {
                hospital = new Hospital();
            }
            return hospital;
        }

        // Example method to add a doctor
        public  bool AddDoctor(Doctor doctor)
        {
            if (!doctors.ContainsKey(doctor.Email))
            {
                doctor.ID = DocId;
                doctors.Add(doctor.Email, doctor);
                DocId++;

                return true;           
            }
            return false;
        }

        public  bool AddEmployee(Employee employee)
        {
            if (!employees.ContainsKey(employee.Email))
            {
                employee.ID = EmployeeID;
                employees.Add(employee.Email, employee);
                EmployeeID++;
                return true;
            }
            return false;   
        }

        public  bool addAdmin(Administrator admin)
        {
            if (!admins.ContainsKey(admin.Email))
            {
                admin.ID =AdminID ;
                admins.Add(admin.Email, admin);
                AdminID++;
                return true;
            }
            return false;
        }

        public bool addPatient(Patient patient)
        {
            if (!patients.ContainsKey(patient.Email))
            {
                patient.ID = PatientID;
                patients.Add(patient.Email, patient);
                PatientID++;
                return true;
            }
            return false;
        }

        public  void addAppointment(Appointment appointment)
        {
            appointment.AppointmentID = AppointmentID;
            appointments.Add(AppointmentID, appointment);
            AppointmentID++;
        }

        public void addRoom(Room room)
        {
            room.roomid = RoomID;
            rooms.Add(RoomID, room);
            RoomID++;
        }
        public  bool employeeLogin(string username, string password)
        {
            if (employees.ContainsKey(username))
            {
                if (employees[username].Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public  bool adminLogin(string username, string password)
        {
            if (admins.ContainsKey(username))
            {
                if (admins[username].Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public  bool doctorLogin(string username, string password)
        {
            if (doctors.ContainsKey(username))
            {
                if (doctors[username].Password == password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
