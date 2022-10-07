using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities
{
    public class Booking : Entity
    {
        public Guid CustomerId { get; set; }
        public Guid RoomId { get; set; }
        public Customer Customer { get; set; }
        public Room Room { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime From { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Till { get; set; }
        public Payment Payment { get; set; }

    }
}
