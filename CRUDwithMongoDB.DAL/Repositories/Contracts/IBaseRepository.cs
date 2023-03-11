namespace CRUDwithMongoDB.DAL.Repositories.Contracts;

public interface IBaseRepository<T>
{
    Task<IEnumerable<T>> GetAsync();
    Task<T> GetAsync(string id);
    Task InsertAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(string id);
}