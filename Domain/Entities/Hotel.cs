using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities
{

    // Hotel entity for asp.net core
    public class Hotel : Entity
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }
        [MaxLength(50)]
        [Required]
        public string City { get; set; }
        [MaxLength(255)]
        [Required]
        public string Email { get; set; }
        [MaxLength(1080)]
        public string Description { get; set; }

        public ICollection<Room> Rooms { get; set; }
        public ICollection<HotelImage> HotelImages { get; set; }
    }
    
}
