using CRUDwithMongoDB.Common.Models;
using CRUDwithMongoDB.DAL.Repositories.Contracts;
using CRUDwithMongoDB.DAL.Repositories.Implements;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CRUDwithMongoDB.BL.Services;

public abstract class BaseService<T>
    where T : BaseModel
{
    protected readonly IBaseRepository<T> _repository;

    public BaseService(IBaseRepository<T> repository) => _repository = repository;

    public async Task<IEnumerable<T>> GetAsync() => await _repository.GetAsync();

    public async Task<T> GetAsync(string id) => await _repository.GetAsync(id);

    public async Task InsertAsync(T book) => await _repository.InsertAsync(book);

    public async Task UpdateAsync(T book) => await _repository.UpdateAsync(book);

    public async Task DeleteAsync(string id) => await _repository.DeleteAsync(id);
}