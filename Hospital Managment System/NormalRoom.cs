using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
    public class NormalRoom:Room
    {
        public NormalRoom(int roomId, int roomNo, string floorNo) : base(roomId, roomNo, floorNo) { }
        public NormalRoom(NormalRoom normalRoom) : base(normalRoom.roomid, normalRoom.room_no, normalRoom.floor_no) { }
        public override void setPricePerHour()
        {
            price_per_hour = 500;
        }
        public override string roomType()
        {
            return "Normal Room";
        }
        public override Room clone()
        {
            return new NormalRoom(this);
        }
    }
}
