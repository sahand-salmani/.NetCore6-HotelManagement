using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entities
{
    public class Payment : Entity
    {
        public Booking Booking { get; set; }
        public Guid BookingId { get; set; }
        public Guid CustomerRoomId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PaidAmount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public PaymentType PaymentType { get; set; }
    }
}
