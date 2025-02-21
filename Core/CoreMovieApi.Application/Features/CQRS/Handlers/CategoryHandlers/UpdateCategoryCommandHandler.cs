using CoreMovieApi.Application.Features.CQRS.Commands.CategoryCommands;
using CoreMovieApi.Persistence.Context;

namespace CoreMovieApi.Application.Features.CQRS.Handlers.CategoryHandlers;
public class UpdateCategoryCommandHandler(MovieContext context)
{
    public async Task Handle(UpdateCategoryCommand command)
    {
        var category = await context.Categories.FindAsync(command.CategoryId);
        category.CategoryName = command.CategoryName;
        context.Categories.Update(category);
        await context.SaveChangesAsync();
    }
}