using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
    public class PrivateRoom : Room
    {
        public PrivateRoom(int roomId, int roomNo, string floorNo) : base(roomId, roomNo, floorNo) { }
        public PrivateRoom(PrivateRoom privateRoom) : base(privateRoom.roomid, privateRoom.room_no, privateRoom.floor_no) { }

        public override void setPricePerHour()
        {
            price_per_hour = 1000;
        }

        public override string roomType()
        {
            return "Private Room";
        }

        public override Room clone()
        {
            return new PrivateRoom(this);
        }
    }
}
