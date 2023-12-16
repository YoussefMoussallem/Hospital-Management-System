using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
    public abstract class Room
    {
        public int room_no;
        public string floor_no;
        public int price_per_hour;
        public int roomid;

        protected Room(int roomId, int roomNo, string floorNo)
        {
            roomid = roomId;
            room_no = roomNo;
            floor_no = floorNo;
        }
        public abstract void setPricePerHour();
        public abstract string roomType();
        public abstract Room clone();

    }
}
