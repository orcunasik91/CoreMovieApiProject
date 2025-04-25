using CoreMovieApi.Application.Features.CQRS.Handlers.CategoryHandlers;
using CoreMovieApi.Application.Features.CQRS.Handlers.MovieHandlers;
using CoreMovieApi.Persistence;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CoreMovieApi.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddPersistence();
        #region CategoryServiceRegistrations
        services.AddScoped<CreateCategoryCommandHandler>();
        services.AddScoped<UpdateCategoryCommandHandler>();
        services.AddScoped<RemoveCategoryCommandHandler>();
        services.AddScoped<GetCategoryByIdQueryHandler>();
        services.AddScoped<GetCategoryQueryHandler>();
        #endregion
        #region MovieServiceRegistrations
        services.AddScoped<CreateMovieCommandHandler>();
        services.AddScoped<UpdateMovieCommandHandler>();
        services.AddScoped<RemoveMovieCommandHandler>();
        services.AddScoped<GetMovieByIdQueryHandler>();
        services.AddScoped<GetMovieQueryHandler>();
        #endregion
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return services;
    }
}