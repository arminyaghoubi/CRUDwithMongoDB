using CRUDwithMongoDB.BL.Services;
using CRUDwithMongoDB.Common.Models;

namespace CRUDwithMongoDB.API.Controllers;

public class BookController : BaseController<Book>
{
    public BookController(BaseService<Book> service) : base(service)
    {
    }
}
