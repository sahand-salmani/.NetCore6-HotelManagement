using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities
{
    // customer entity
    public class Customer : Entity
    {
        [Required]
        [MaxLength(255)]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(1080)]
        public string Email { get; set; }
        [Phone]
        [MaxLength(255)]
        [Required]
        public string Phone { get; set; }
        [MaxLength(1080)]
        [Required]
        public string Address { get; set; }
        
    }
}
