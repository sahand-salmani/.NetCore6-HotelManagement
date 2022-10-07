using Application.Commons.Wrappers;
using Application.Hotels.Dtos;
using Application.Hotels.Queries;
using Application.Hotels.Repositories;
using AutoMapper;
using Infrastructure.Commons.Response;

namespace Application.Hotels.QueryHandlers
{
    public class GetHotelByIdQueryHandler : IRequestHandlerWrapper<GetHotelByIdQuery, GetHotelDto>
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;

        public GetHotelByIdQueryHandler(IHotelRepository hotelRepository,
                                        IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }
        public async Task<Response<GetHotelDto>> Handle(GetHotelByIdQuery request, CancellationToken cancellationToken)
        {
            var hotel = await _hotelRepository.GetByIdAsNoTracking(request.Id, cancellationToken);
            if (hotel is null)
            {
                return Response.Fail<GetHotelDto>("Hotel was not found");
            }

            var result = _mapper.Map<GetHotelDto>(hotel);

            return Response.Success(result, $"Hotel with id {result.Id} was fetched successfully");
        }
    }
}
