using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System
{
    public partial class Login : Form
    {
        Hospital hospital;
        bool isProgrammaticClose = false;
        public Login()
        {
            hospital = Hospital.getInstance();
            InitializeComponent();
            this.FormClosed += OnFormClosed;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text.Length != 0 && textBoxUsername.Text.Length != 0)
            {
                loginEmployee loginemployee = new loginEmployee(textBoxUsername.Text, textBoxPass.Text);
                if (loginemployee.login())
                {
                    EmployeeHomeControl employeectrl = new EmployeeHomeControl(hospital.employees[textBoxUsername.Text]);
                    employeectrl.Show();
                    isProgrammaticClose = true;
                    this.Close();
                }
                else
                {
                    textboxError.Visible = true;
                    button1.BackColor = Color.FromArgb(textboxError.ForeColor.ToArgb());
                }
            }
            else
            {
                textboxError.Visible = true;
                button1.BackColor = Color.FromArgb(textboxError.ForeColor.ToArgb());
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
            DoctorLogin doctorLogin = new DoctorLogin();
            doctorLogin.Show();
            isProgrammaticClose = true;
            this.Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            isProgrammaticClose = true;

            this.Close();
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
    }

    public class loginEmployee : UserLogin
    {
        public loginEmployee(string email, string password) : base(email, password) { }
        public override bool login()
        {
            return Hospital.getInstance().employeeLogin(email, password);
        }
    }


}
