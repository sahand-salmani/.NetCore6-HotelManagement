namespace Application.Commons.Pagination
{
    public class PaginatedDto<T>
    {
        public List<T> Data { get; set; }
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;

    }
}
