using CRUDwithMongoDB.BL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CRUDwithMongoDB.BL.Extensions;

public static class ServicesExtensions
{
    public static IServiceCollection AddBusinessLogicServices(this IServiceCollection services) =>
        services.AddSingleton<BookService>();
}