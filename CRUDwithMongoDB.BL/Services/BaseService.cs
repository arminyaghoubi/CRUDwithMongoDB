using CRUDwithMongoDB.Common.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CRUDwithMongoDB.BL.Services;

public abstract class BaseService<T>
    where T : BaseModel
{
    protected readonly IMongoCollection<T> _mongoCollection;

    public BaseService(IOptions<BookStoreDatabaseSettings> options)
    {
        MongoClient mongoClient = new(options.Value.ConnectionString);

        var database = mongoClient.GetDatabase(options.Value.DataBaseName);

        _mongoCollection = database.GetCollection<T>(options.Value.BooksCollectionName);
    }

    public async Task<IEnumerable<T>> GetAsync() => await _mongoCollection.Find(_ => true).ToListAsync();

    public async Task<T> GetAsync(string id) => await _mongoCollection.Find(b => b.Id == id).FirstOrDefaultAsync();

    public async Task InsertAsync(T book) => await _mongoCollection.InsertOneAsync(book);

    public async Task UpdateAsync(T book) => await _mongoCollection.ReplaceOneAsync(b => b.Id == book.Id, book);

    public async Task DeleteAsync(string id) => await _mongoCollection.DeleteOneAsync(b => b.Id == id);
}