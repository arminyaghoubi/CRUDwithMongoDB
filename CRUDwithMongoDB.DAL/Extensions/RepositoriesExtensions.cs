using CRUDwithMongoDB.Common.Models;
using CRUDwithMongoDB.DAL.Repositories.Contracts;
using CRUDwithMongoDB.DAL.Repositories.Implements;
using Microsoft.Extensions.DependencyInjection;

namespace CRUDwithMongoDB.DAL.Extensions;

public static class RepositoriesExtensions
{
    public static IServiceCollection AddDataAccessRepositories(this IServiceCollection services) =>
        services.AddScoped<IBaseRepository<Book>, BookRepository>();
}
