using Application.Commons.Pagination;
using Application.Commons.Wrappers;
using Application.Hotels.Dtos;

namespace Application.Hotels.Queries
{
    public class GetAllHotelPaginatedQuery : IRequestWrapper<PaginatedDto<GetHotelDto>>
    {
        private GetAllHotelPaginatedQuery(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public static GetAllHotelPaginatedQuery Create(int pageNumber, int pageSize)
        {
            return new GetAllHotelPaginatedQuery(pageNumber, pageSize);
        }
    }
}
