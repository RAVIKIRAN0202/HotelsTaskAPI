using System.Collections.Generic;

namespace HotelAPI.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
        public string ImageUrl { get; set; }
        public List<string> DatesOfTravel { get; set; }
        public string BoardBasis { get; set; }
        public List<Room> Rooms { get; set; }
    }

    public class Room
    {
        public string RoomType { get; set; }
        public int Amount { get; set; }
    }
}
