namespace Infrastructure.Commons.Repositories
{
    public interface IPersistence
    {
        Task<int> SaveChanges();
    }
}
