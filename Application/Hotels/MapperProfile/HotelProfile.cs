using Application.Hotels.Commands;
using Application.Hotels.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Hotels.MapperProfile
{
    public class HotelProfile : Profile
    {
        public HotelProfile()
        {
            CreateMap<Hotel, GetHotelDto>().ReverseMap();
            CreateMap<List<Hotel>, PaginatedHotelDto>()
                .ForMember(member => member.Hotels, opt => 
                    opt.MapFrom(src => src));
            CreateMap<CreateHotelCommand, Hotel>();
        }
    }
}
