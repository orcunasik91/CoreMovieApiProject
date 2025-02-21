using CoreMovieApi.Application.Features.CQRS.Commands.CategoryCommands;
using CoreMovieApi.Domain.Entities;
using CoreMovieApi.Persistence.Context;

namespace CoreMovieApi.Application.Features.CQRS.Handlers.CategoryHandlers;
public class CreateCategoryCommandHandler(MovieContext context)
{
    public async Task Handle(CreateCategoryCommand command)
    {
        await context.Categories.AddAsync(new Category
        {
            CategoryName = command.CategoryName
        });
        await context.SaveChangesAsync();
    }
}