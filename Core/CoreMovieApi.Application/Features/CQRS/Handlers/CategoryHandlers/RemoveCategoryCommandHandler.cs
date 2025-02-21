using CoreMovieApi.Application.Features.CQRS.Commands.CategoryCommands;
using CoreMovieApi.Persistence.Context;

namespace CoreMovieApi.Application.Features.CQRS.Handlers.CategoryHandlers;
public class RemoveCategoryCommandHandler(MovieContext context)
{
    public async Task Handle(RemoveCategoryCommand command)
    {
        var category = await context.Categories.FindAsync(command.CategoryId);
        context.Categories.Remove(category);
        await context.SaveChangesAsync();
    }
}