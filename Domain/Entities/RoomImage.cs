namespace Domain.Entities
{
    public class RoomImage
    {
        public Guid RoomId { get; set; }
        public Guid ImageId { get; set; }
        public Room Room { get; set; }
        public Image Image { get; set; }
    }
}
