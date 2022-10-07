using Application.Commons.Wrappers;
using Application.Hotels.Dtos;
using Application.Hotels.Queries;
using Application.Hotels.Repositories;
using AutoMapper;
using Infrastructure.Commons.Response;

namespace Application.Hotels.QueryHandlers
{
    public class GetAllHotelsQueryHandler : IRequestHandlerWrapper<GetAllHotels, List<GetHotelDto>>
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;

        public GetAllHotelsQueryHandler(IHotelRepository hotelRepository,
                                        IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }
        public async Task<Response<List<GetHotelDto>>> Handle(GetAllHotels request, CancellationToken cancellationToken)
        {
            var hotels = await _hotelRepository.GetAllAsNoTracking(cancellationToken);
            if (!hotels.Any())
            {
                return Response.Fail<List<GetHotelDto>>("No hotel was found");
            }

            var hotelsDto = _mapper.Map<List<GetHotelDto>>(hotels);

            return Response.Success(hotelsDto, "Hotels were fetched successfully");
        }
    }
}
