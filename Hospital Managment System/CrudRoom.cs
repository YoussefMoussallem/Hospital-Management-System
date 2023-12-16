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
    public partial class CrudRoom : Form
    {

        public string RoomNo;
        public string RoomType;
        public string floor;
        public Room room;
        public CrudRoom()
        {
            InitializeComponent();
            textBoxNO.KeyPress += new KeyPressEventHandler(MyTextBox_KeyPress);
            floortxt.KeyPress += new KeyPressEventHandler(MyTextBox_KeyPress);
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
            if (floortxt.Text.Length == 0 || textBoxNO.Text.Length == 0 || typetxt.Text.Length == 0)
            {
                MessageBox.Show("Fill in all inputs!!");
            }
            else if (typetxt.Text != "Private" && typetxt.Text != "Shared" && typetxt.Text != "Normal" && typetxt.Text != "Deluxe")
            {
                MessageBox.Show("Type can only be: Deluxe, Private, Normal, Shared, Soldier; UPPERCASE FIRST LETTERS");
            }
            else
            {
                RoomNo = textBoxNO.Text;
                RoomType = typetxt.Text;
                floor = floortxt.Text;
                if (typetxt.Text == "Shared")
                {
                    room = new SharedRoom(0, int.Parse(textBoxNO.Text), floortxt.Text);
                }
                else if (typetxt.Text == "Normal")
                {
                    room = new NormalRoom(0, int.Parse(textBoxNO.Text), floortxt.Text);
                }
                else if (typetxt.Text == "Private")
                {
                    room = new PrivateRoom(0, int.Parse(textBoxNO.Text), floortxt.Text);
                }
                else if (typetxt.Text == "Deluxe")
                {
                    room = new DeluxeRoom(0, int.Parse(textBoxNO.Text), floortxt.Text, "jacuzzy, king sized bed, sauna, big tv");
                }
                else if (typetxt.Text == "Soldier")
                {
                    room = new SoldierRoom(0, int.Parse(textBoxNO.Text), floortxt.Text);
                }
                room.setPricePerHour();
                this.Close();
            }
        }

        //private void OnFormClosed(object sender, FormClosedEventArgs e)
        //{
        //    if (floortxt.Text.Length == 0 || textBoxNO.Text.Length == 0 || typetxt.Text.Length == 0)
        //    {
        //        this.Close();
        //    }
        //}

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
