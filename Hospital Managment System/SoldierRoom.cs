using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
    public class SoldierRoom : Room
    {
        public SoldierRoom(int roomId, int roomNo, string floorNo) : base(roomId, roomNo, floorNo) { }
        public SoldierRoom(SoldierRoom soldierRoom) : base(soldierRoom.roomid, soldierRoom.room_no, soldierRoom.floor_no) { }

        public override void setPricePerHour()
        {
            price_per_hour = 25;
        }
        public override string roomType()
        {
            return "Soldier Room";
        }

        public override Room clone()
        {
            return new SoldierRoom(this);
        }
    }
}
