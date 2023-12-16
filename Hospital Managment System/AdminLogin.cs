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
    public partial class AdminLogin : Form
    {
        public Hospital hospital;
        bool isProgrammaticClose = false;
        public AdminLogin()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text.Length != 0 && textBoxUsername.Text.Length != 0)
            {
                loginAdmin loginadmin = new loginAdmin(textBoxUsername.Text, textBoxPass.Text);

                if (loginadmin.login())
                {
                    isProgrammaticClose = true;
                    this.Close();
                    AdminHomeControl admincontrol = new AdminHomeControl();
                    admincontrol.Show();
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
            Login login = new Login();
            login.Show();
            isProgrammaticClose = true;
            this.Close();
        }
    }

    public class loginAdmin : UserLogin
    {
        public loginAdmin(string email, string password) : base(email, password) { }
        public override bool login()
        {
            return Hospital.getInstance().adminLogin(email, password);
        }
    }
}
