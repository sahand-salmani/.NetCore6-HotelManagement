using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entities
{
    // service entity
    public class Service : Entity
    {
        [Required]
        [MaxLength(255)]
        public string ServiceName { get; set; }
        [Required]
        [MaxLength(1080)]
        public string ServiceDescription { get; set; }
        [Required]
        [MaxLength(1080)]
        public string ServiceImage { get; set; }
        [Required]
        [MaxLength(1080)]
        public string ServiceIcon { get; set; }
        [Required]
        [MaxLength(1080)]
        [DataType(dataType: DataType.Url)]
        public string ServiceLink { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ServicePrice { get; set; }

        public ICollection<RoomService> RoomServices { get; set; }
    }
}
