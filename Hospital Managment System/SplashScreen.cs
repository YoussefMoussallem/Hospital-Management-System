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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Timer tmr;
        private void Form1_Shown(object sender, EventArgs e)
        {
            tmr = new System.Windows.Forms.Timer();
            //set time interval 3 sec
            tmr.Interval = 1000;
            //starts the timer
            tmr.Start();
            tmr.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //after 3 sec stop the timer
            tmr.Stop();
            //display mainform
            Login frm = new Login();
            frm.Show();
            //hide this form
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
