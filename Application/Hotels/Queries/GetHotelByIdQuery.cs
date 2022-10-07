using Application.Commons.Wrappers;
using Application.Hotels.Dtos;
using Infrastructure.Commons.Response;

namespace Application.Hotels.Queries
{
    public class GetHotelByIdQuery : IRequestWrapper<GetHotelDto>
    {
        public Guid Id { get; set; }

        private GetHotelByIdQuery()
        {
            
        }
        public static GetHotelByIdQuery Create(Guid id)
        {
            return new GetHotelByIdQuery
            {
                Id = id
            };
        }
    }
}
