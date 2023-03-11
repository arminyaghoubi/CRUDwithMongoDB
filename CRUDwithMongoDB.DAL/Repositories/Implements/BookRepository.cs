using CRUDwithMongoDB.Common.Models;
using Microsoft.Extensions.Options;

namespace CRUDwithMongoDB.DAL.Repositories.Implements;

public class BookRepository : BaseRepository<Book>
{
    public BookRepository(IOptions<BookStoreDatabaseSettings> options) : base(options, options.Value.BooksCollectionName)
    {
    }
}