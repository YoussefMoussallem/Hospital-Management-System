using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
    public class SharedRoom : Room
    {
        public SharedRoom(int roomId, int roomNo, string floorNo) : base(roomId, roomNo, floorNo) { }
        public SharedRoom(SharedRoom sharedRoom) : base(sharedRoom.roomid, sharedRoom.room_no, sharedRoom.floor_no) { }

        public override void setPricePerHour()
        {
            price_per_hour = 100;
        }
        public override string roomType()
        {
            return "Shared Room";
        }
        public override Room clone()
        {
            return new SharedRoom(this);
        }

    }
}
