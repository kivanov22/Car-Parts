namespace CarParts.API.Infrastructure.Data.Common
{
    public interface IRepository<T> where T : class
    {

        Task<T> AddAsync(T entity);

        Task<bool> DeleteAsync(int id);

        //Task<bool> DeleteAsync(T entity);
        Task UpdateAsync(int id,T entity);
        List<T> GetAllAsync();
        //Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
    }
}
