using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities
{
    public class Image : Entity
    {
        [Required]
        [MaxLength(1080)]
        public string ImageUrl { get; set; }
        [MaxLength(1080)]
        public string ImageTitle { get; set; }

        public ImageType ImageType { get; set; }

        public ICollection<RoomImage> RoomImages { get; set; }
        public ICollection<HotelImage> HotelImages { get; set; }
    }
}
