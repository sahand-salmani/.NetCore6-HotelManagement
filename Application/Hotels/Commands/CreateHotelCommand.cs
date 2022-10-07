using Application.Commons.Wrappers;
using Application.Hotels.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Application.Hotels.Commands
{
    public record CreateHotelCommand : IRequestWrapper<GetHotelDto>
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
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(1080)]
        public string Description { get; set; }

        private CreateHotelCommand(string name, string address, string city, string email, string description)
        {
            Name = name;
            Address = address;
            City = city;
            Email = email;
            Description = description;
        }

        public static CreateHotelCommand Create(string name, string address, string city, string email, string description)
        {
            return new CreateHotelCommand(name, address, city, email, description);
        }
    }
}
