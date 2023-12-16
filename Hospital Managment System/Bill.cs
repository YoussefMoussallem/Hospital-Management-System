using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
    public class Bill
    {
        public Room room { get; set; }
        public Doctor doc {  get; set; }


        public Bill(Room room,Doctor doc )
        {
            this.doc = doc;
            this.room = room;
        }

        public string getBill()
        {

            double RoomCharge = room.price_per_hour*24 ;
            double ServiceCharge = 1500 ;
            double NursingCharge = 1500 ;
            double DocCharge = doc.PricePerAppointment;
            double total = RoomCharge + ServiceCharge + NursingCharge + DocCharge;
            return " Room Charge:" + RoomCharge + "\n Service Charge: " + ServiceCharge + "\n Nursing Charge: " + NursingCharge + "\n Doctor Charge: " + DocCharge + "\n Total: " +total;
        }
    }
}
