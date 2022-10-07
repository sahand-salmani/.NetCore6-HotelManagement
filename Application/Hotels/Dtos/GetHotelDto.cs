namespace Application.Hotels.Dtos
{

    // Dto for Hotel class
    public class GetHotelDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
