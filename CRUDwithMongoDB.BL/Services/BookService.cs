using CRUDwithMongoDB.Common.Models;
using Microsoft.Extensions.Options;

namespace CRUDwithMongoDB.BL.Services;

public class BookService : BaseService<Book>
{
    public BookService(IOptions<BookStoreDatabaseSettings> options) : base(options)
    {
    }
}
