using CRUDwithMongoDB.Common.Models;
using CRUDwithMongoDB.DAL.Repositories.Contracts;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CRUDwithMongoDB.DAL.Repositories.Implements;

public class BaseRepository<T> : IBaseRepository<T>
    where T : BaseModel
{
    private readonly IMongoCollection<T> _collection;

    public BaseRepository(IOptions<BookStoreDatabaseSettings> options, string collectionName)
    {
        MongoClient mongoClient = new(options.Value.ConnectionString);

        var database = mongoClient.GetDatabase(options.Value.DataBaseName);

        _collection = database.GetCollection<T>(collectionName);
    }

    public async Task<IEnumerable<T>> GetAsync() => await _collection.Find(_ => true).ToListAsync();

    public async Task<T> GetAsync(string id) => await _collection.Find(e => e.Id == id).FirstOrDefaultAsync();

    public async Task InsertAsync(T entity) => await _collection.InsertOneAsync(entity);

    public async Task UpdateAsync(T entity) => await _collection.ReplaceOneAsync(e => e.Id == entity.Id, entity);

    public async Task DeleteAsync(string id) => await _collection.DeleteOneAsync(e => e.Id == id);
}
