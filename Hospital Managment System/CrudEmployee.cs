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
    public partial class CrudEmployee : Form
    {

        public string name;
        public string dep;
        public string email;
        public string gender;
        public string phone;
        public string role;
        public string address;
        public string pass;
        public CrudEmployee()
        {
            InitializeComponent();
            this.ControlBox = true;
            textBoxTel.KeyPress += new KeyPressEventHandler(MyTextBox_KeyPress);

        }
        private void MyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is not a digit or a control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suppress the character
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (password.Text.Length != 0 && textBoxName.Text.Length != 0 && textBoxEmail.Text.Length != 0 && textBoxTel.Text.Length != 0 && roletxt.Text.Length != 0 && sextxt.Text.Length != 0 && departmentxt.Text.Length != 0)
            {
                name = textBoxName.Text;
                phone = textBoxTel.Text;
                role = roletxt.Text;
                dep = departmentxt.Text;
                email = textBoxEmail.Text;
                gender = sextxt.Text;
                pass = password.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong input!");
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
