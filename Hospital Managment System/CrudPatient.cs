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
    public partial class CrudPatient : Form
    {

        public string name;
        public string email;
        public string gender;
        public string phone;
        public CrudPatient()
        {
            InitializeComponent();
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
            if (textBoxName.Text.Length != 0 && textBoxTel.Text.Length != 0 && sextxt.Text.Length != 0 && emailtxt.Text.Length != 0)
            {
                name = textBoxName.Text;
                phone = textBoxTel.Text;
                gender = sextxt.Text;
                email = emailtxt.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong input!");
            }
        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
