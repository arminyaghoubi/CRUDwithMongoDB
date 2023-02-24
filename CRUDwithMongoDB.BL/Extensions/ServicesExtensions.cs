using CRUDwithMongoDB.BL.Services;
using CRUDwithMongoDB.Common.Models;
using Microsoft.Extensions.DependencyInjection;

namespace CRUDwithMongoDB.BL.Extensions;

public static class ServicesExtensions
{
    public static IServiceCollection AddBusinessLogicServices(this IServiceCollection services) =>
        services.AddSingleton<BaseService<Book>, BookService>();
}