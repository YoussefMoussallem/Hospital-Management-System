using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Managment_System
{
    public partial class AdminHomeControl : Form
    {
        public Hospital hospital;
        bool isProgrammaticClose = false;
        public AdminHomeControl()
        {
            hospital = Hospital.getInstance();
            InitializeComponent();
            this.FormClosed += OnFormClosed;
        }
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isProgrammaticClose)
            {
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (form != this)
                    {
                        form.Close();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var bindableList = hospital.doctors.Select(kvp => new
            {
                ID = kvp.Value.ID,
                Name = kvp.Value.Name,
                Email = kvp.Value.Email,
                Gender = kvp.Value.Gender,
                Tel = kvp.Value.Tel,
                Dep = kvp.Value.Department,
                Price_Dollar = kvp.Value.PricePerAppointment,
                StartTime = kvp.Value.starttime,
                EndTime = kvp.Value.endtime

            }).ToList();

            Font rowFont = new Font("Arial", 12, FontStyle.Regular);

            // Apply this font to the DefaultCellStyle of the DataGridView
            dataGridView1.DefaultCellStyle.Font = rowFont;
            dataGridView1.DataSource = bindableList;
        }




        private void button4_Click(object sender, EventArgs e)
        {
            var bindableList = hospital.employees.Select(kvp => new
            {
                ID = kvp.Value.ID,
                Name = kvp.Value.Name,
                Email = kvp.Value.Email,
                Gender = kvp.Value.Gender,
                Tel = kvp.Value.Tel,
                Dep = kvp.Value.Department,

            }).ToList();

            Font rowFont = new Font("Arial", 12, FontStyle.Regular);

            // Apply this font to the DefaultCellStyle of the DataGridView
            dataGridView1.DefaultCellStyle.Font = rowFont;
            dataGridView1.DataSource = bindableList;
        }



        private void button6_Click(object sender, EventArgs e)
        {
            CRUDDoctor docinfo = new CRUDDoctor();
            docinfo.ShowDialog();
            if (!(docinfo.name == null || docinfo.email == null || docinfo.password == null || docinfo.phone == null || docinfo.gender == null || docinfo.dep == null || docinfo.price == null))
            {
                Doctor doc = new Doctor(0, docinfo.name, docinfo.email, docinfo.password, docinfo.phone, docinfo.gender, docinfo.dep, double.Parse(docinfo.price), docinfo.start, docinfo.end);
                hospital.AddDoctor(doc);
            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();

            isProgrammaticClose = true;
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CrudEmployee employeeinfo = new CrudEmployee();
            employeeinfo.ShowDialog();


            if (!(employeeinfo.name == null || employeeinfo.email == null || employeeinfo.pass == null || employeeinfo.phone == null || employeeinfo.gender == null || employeeinfo.dep == null || employeeinfo.role == null))
            {
                Employee emp = new Employee(0, employeeinfo.name, employeeinfo.email, employeeinfo.pass, employeeinfo.phone, employeeinfo.gender, employeeinfo.role, employeeinfo.dep);
                hospital.AddEmployee(emp);
            }
        }



        private void button9_Click(object sender, EventArgs e)
        {
            var bindableList = hospital.appointments.Select(kvp => new
            {
                ID = kvp.Value.AppointmentID,
                PatientID = kvp.Value.PatientID,
                DocID = kvp.Value.DoctorID,
                Date = kvp.Value.AppointmentDate

            }).ToList();

            Font rowFont = new Font("Arial", 12, FontStyle.Regular);

            // Apply this font to the DefaultCellStyle of the DataGridView
            dataGridView1.DefaultCellStyle.Font = rowFont;
            dataGridView1.DataSource = bindableList;
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            var bindableList = hospital.patients.Select(kvp => new
            {
                ID = kvp.Value.ID,
                Name = kvp.Value.Name,
                Email = kvp.Value.Email,
                Gender = kvp.Value.Gender,
                Tel = kvp.Value.Tel,
                CreationDate = kvp.Value.Date,
                CreatedBy = "Doc. " + kvp.Value.CreatedBy.Name
            }).ToList();

            Font rowFont = new Font("Arial", 12, FontStyle.Regular);

            // Apply this font to the DefaultCellStyle of the DataGridView
            dataGridView1.DefaultCellStyle.Font = rowFont;
            dataGridView1.DataSource = bindableList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrudRoom roominfo = new CrudRoom();
            roominfo.ShowDialog();
            if (!(roominfo.floor == null || roominfo.room == null || roominfo.RoomType == null))
            {
                hospital.addRoom(roominfo.room);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var bindableList = hospital.rooms.Select(kvp => new
            {
                ID = kvp.Value.roomid,
                RoomNo = kvp.Value.room_no,
                RoomType = kvp.Value.roomType(),
                FloorNo = kvp.Value.floor_no,
                PricePerH = kvp.Value.price_per_hour
            }).ToList();

            Font rowFont = new Font("Arial", 12, FontStyle.Regular);

            // Apply this font to the DefaultCellStyle of the DataGridView
            dataGridView1.DefaultCellStyle.Font = rowFont;
            dataGridView1.DataSource = bindableList;
        }
    }
}
