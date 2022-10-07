using Domain.Common;
#pragma warning disable CS8618

namespace Domain.Entities
{
    // Room entity
    public class Room : Entity
    {
        public string RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public ICollection<RoomImage> RoomImages { get; set; }
        public ICollection<RoomService> RoomServices { get; set; }

    }
}
