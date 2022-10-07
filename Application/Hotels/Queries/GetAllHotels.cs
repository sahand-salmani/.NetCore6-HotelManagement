using Application.Commons.Wrappers;
using Application.Hotels.Dtos;

namespace Application.Hotels.Queries
{
    public class GetAllHotels : IRequestWrapper<List<GetHotelDto>>
    {
        private GetAllHotels()
        {
            
        }
        public static GetAllHotels GetAll()
        {
            return new GetAllHotels();
        }
    }
}
