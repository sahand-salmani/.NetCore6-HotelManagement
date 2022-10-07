using Application.Commons.Pagination;
using Application.Commons.Wrappers;
using Application.Hotels.Dtos;
using Application.Hotels.Queries;
using Application.Hotels.Repositories;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Commons.Response;

namespace Application.Hotels.QueryHandlers
{
    public class GetAllHotelPaginatedQueryHandler : IRequestHandlerWrapper<GetAllHotelPaginatedQuery, PaginatedDto<GetHotelDto>>
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;

        public GetAllHotelPaginatedQueryHandler(IHotelRepository hotelRepository,
                                                IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }
        public async Task<Response<PaginatedDto<GetHotelDto>>> Handle(GetAllHotelPaginatedQuery request, CancellationToken cancellationToken)
        {
            var hotels = _hotelRepository.GetAllAsQueryable().OrderByDescending(e => e.CreatedAt);

            var paginatedHotels = await PaginatedList<Hotel>.CreateAsync(hotels, request.PageNumber, request.PageSize);

            if (!paginatedHotels.Any())
            {
                return Response.Fail<PaginatedDto<GetHotelDto>>("No Hotel was found");
            }

            var result = _mapper.Map<PaginatedDto<GetHotelDto>>(paginatedHotels.ToList());
            result.PageIndex = paginatedHotels.PageIndex;
            result.TotalPages = paginatedHotels.TotalPages;


            return Response.Success(result, "Hotels were fetched successfully");
        }
    }
}
