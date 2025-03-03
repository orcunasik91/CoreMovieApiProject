using CoreMovieApi.Persistence.Context;
using Microsoft.Extensions.DependencyInjection;

namespace CoreMovieApi.Persistence;
public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddDbContext<MovieContext>();
        return services;
    }
}