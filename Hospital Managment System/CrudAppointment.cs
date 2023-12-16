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

namespace Hospital_Managment_System;

public partial class CrudAppointment : Form
{
    public DateTime start;
    public Room room;
    public Hospital hospital;
    public CrudAppointment()
    {
        hospital = Hospital.getInstance();
        InitializeComponent();
        dateTimePicker1.Format = DateTimePickerFormat.Custom;
        dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt";
        dateTimePicker1.ShowUpDown = true;

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

    private void button2_Click(object sender, EventArgs e)
    {
        start = dateTimePicker1.Value;
        if (dataGridView1.SelectedRows.Count == 1)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = int.Parse(row.Cells[0].Value.ToString());
            room = hospital.rooms[id];

        }
        else
        {
            MessageBox.Show("Please Select a room");
        }
    }


}
