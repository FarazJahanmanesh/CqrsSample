using CqrsSample.Api.Contracts;
using CqrsSample.Api.Contracts.Repository;
using CqrsSample.Api.Repository;

namespace CqrsSample.Api;

public static class IOC
{
    public static IServiceCollection Register(this IServiceCollection services)
    {
        services.AddScoped<IReadProductRepository, ReadProductRepository>()
            .AddScoped<IWriteProductRepository, WriteProductRepository>()
            .AddScoped<IReadUnitOfWork, ReadUnitOfWork>()
            .AddScoped<IWriteUnitOfWork, WriteUnitOfWork>();
        return services;
    }
}
