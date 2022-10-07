using System.ComponentModel.DataAnnotations;

namespace Domain.Common
{
    public class Entity : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [DataType(DataType.DateTime)]
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
