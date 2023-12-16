using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System
{
    public partial class DoctorHomeControl : Form
    {
        public Doctor doc { get; set; }
        public Hospital hospital { get; set; }
        bool isProgrammaticClose = false;
        public DoctorHomeControl(Doctor doc)
        {
            InitializeComponent();
            hospital = Hospital.getInstance();
            this.doc = doc;
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
                StartTime = kvp.Value.starttime.ToString("\"HH:mm\""),
                EndTime = kvp.Value.endtime.ToString("\"HH:mm\"")

            }).ToList();

            Font rowFont = new Font("Arial", 12, FontStyle.Regular);

            // Apply this font to the DefaultCellStyle of the DataGridView
            dataGridView1.DefaultCellStyle.Font = rowFont;
            dataGridView1.DataSource = bindableList;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var bindableList = hospital.patients.Select(kvp => new
            {
                ID = kvp.Value.ID,
                Name = kvp.Value.Name,
                Email = kvp.Value.Email,
                Gender = kvp.Value.Gender,
                Tel = kvp.Value.Tel,
                CreationDate = kvp.Value.Date,
                CreatedBy = kvp.Value.CreatedBy.GetRole()
            }).ToList();

            Font rowFont = new Font("Arial", 12, FontStyle.Regular);

            // Apply this font to the DefaultCellStyle of the DataGridView
            dataGridView1.DefaultCellStyle.Font = rowFont;
            dataGridView1.DataSource = bindableList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //InpatientUserControl inpatientUserControl = new InpatientUserControl();
            //ControlClass.ShowControl(inpatientUserControl, Content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //RoomCRUD roomCRUD = new RoomCRUD();
            //ControlClass.ShowControl(roomCRUD, Content);
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void buttonAppointments_Click(object sender, EventArgs e)
        {
            //    DoctorsAppointmentUserControl doctorsAppointmentUserControl = new DoctorsAppointmentUserControl();
            //    ControlClass.ShowControl(doctorsAppointmentUserControl, Content);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CRUDDoctor docinfo = new CRUDDoctor();
            docinfo.ShowDialog();

            Doctor doc = new Doctor(0, docinfo.name, docinfo.email, docinfo.password, docinfo.phone, docinfo.gender, docinfo.dep, double.Parse(docinfo.price), docinfo.start, docinfo.end);

            hospital.AddDoctor(doc);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            isProgrammaticClose = true;
            this.Close();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            CrudPatient patientinfo = new CrudPatient();
            patientinfo.ShowDialog();

            if (!(patientinfo.name == null || patientinfo.email == null || patientinfo.phone == null || patientinfo.gender == null))
            {
                Patient patient = new Patient(0, patientinfo.name, patientinfo.email, patientinfo.phone, patientinfo.gender, doc, DateTime.Today);
                hospital.addPatient(patient);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string patientusername = row.Cells[2].Value.ToString();

                CrudAppointment appointmentinfo = new CrudAppointment();
                appointmentinfo.ShowDialog();

                Appointment appt = new Appointment(0, appointmentinfo.start, hospital.patients[patientusername].ID, doc.ID, appointmentinfo.room, doc);

                hospital.addAppointment(appt);
                doc.addAppointment(appt);
                hospital.AppointmentID++;
            }
            else
            {
                MessageBox.Show("bad selection");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var bindableList = doc.appointments.Select(kvp => new
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
    }
}
