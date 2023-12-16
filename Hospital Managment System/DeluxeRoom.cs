using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
    public class DeluxeRoom:Room
    {
        public string AdditionalAmenities { get; set; }

        public DeluxeRoom(int roomId, int roomNo, string floorNo, string amenities)
            : base(roomId, roomNo, floorNo)
        {
            AdditionalAmenities = amenities;
        }
        public DeluxeRoom(DeluxeRoom deluxeRoom):base(deluxeRoom.roomid,deluxeRoom.room_no,deluxeRoom.floor_no)
        {
            AdditionalAmenities = deluxeRoom.AdditionalAmenities;    
        }
        public override void setPricePerHour()
        {
            price_per_hour = 1500;
        }
        public override string roomType()
        {
            return "Deluxe Room";
        }


        public override Room clone()
        {
            return new DeluxeRoom(this); // Shallow copy
        }

    }
}
