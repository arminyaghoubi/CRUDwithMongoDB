using CRUDwithMongoDB.Common.Models;
using CRUDwithMongoDB.DAL.Repositories.Contracts;
using Microsoft.Extensions.Options;

namespace CRUDwithMongoDB.BL.Services;

public class BookService : BaseService<Book>
{
    public BookService(IBaseRepository<Book> repository) : base(repository)
    {
    }
}
