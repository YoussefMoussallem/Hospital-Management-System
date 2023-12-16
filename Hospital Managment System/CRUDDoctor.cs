using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Managment_System;

public partial class CRUDDoctor : Form
{
    public string name;
    public string password;
    public string dep;
    public string email;
    public string gender;
    public string phone;
    public string role;
    public string price;
    public DateTime start;
    public DateTime end;
    public CRUDDoctor()
    {
        InitializeComponent();
        dateTimePicker1.Format = DateTimePickerFormat.Time;
        dateTimePicker1.ShowUpDown = true;
        dateTimePicker2.Format = DateTimePickerFormat.Time;
        dateTimePicker2.ShowUpDown = true;
        textBoxTel.KeyPress += new KeyPressEventHandler(MyTextBox_KeyPress);
        priceperappointment.KeyPress += new KeyPressEventHandler(MyTextBox_KeyPress);

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
        if (priceperappointment.Text.Length != 0 && textBoxName.Text.Length != 0 && textBoxTel.Text.Length != 0 && passtxt.Text.Length != 0 && emailtxt.Text.Length != 0 && deptxt.Text.Length != 0 && roletxt.Text.Length != 0 && sextxt.Text.Length != 0)
        {
            name = textBoxName.Text;
            phone = textBoxTel.Text;
            role = roletxt.Text;
            price = priceperappointment.Text;
            dep = deptxt.Text;
            gender = sextxt.Text;
            email = emailtxt.Text;
            password = passtxt.Text;
            start = dateTimePicker1.Value;
            end = dateTimePicker2.Value;
            this.Close();
        }
        else
        {
            MessageBox.Show("Wrong input!");
        }
    }



}
