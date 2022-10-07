using Application.Commons.Wrappers;
using Application.Hotels.Commands;
using Application.Hotels.Dtos;
using Application.Hotels.Repositories;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Commons.Repositories;
using Infrastructure.Commons.Response;

namespace Application.Hotels.CommandHandlers
{
    public class CreateHotelCommandHandler : IRequestHandlerWrapper<CreateHotelCommand, GetHotelDto>
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IPersistence _persistence;
        private readonly IMapper _mapper;

        public CreateHotelCommandHandler(IHotelRepository hotelRepository,
                                         IPersistence persistence,
                                         IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _persistence = persistence;
            _mapper = mapper;
        }
        public async Task<Response<GetHotelDto>> Handle(CreateHotelCommand request, CancellationToken cancellationToken)
        {
            Hotel hotel = _mapper.Map<Hotel>(request);

            await _hotelRepository.AddAsync(hotel, cancellationToken);

            var persistenceResult = await _persistence.SaveChanges();

            if (persistenceResult == 0)
            {
                return Response.Fail<GetHotelDto>("Failed to create hotel");
            }

            return Response.Success(_mapper.Map<GetHotelDto>(hotel), $"Hotel with id #{hotel.Id} created successfully");
        }
    }
}
