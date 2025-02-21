using CoreMovieApi.Application.Features.CQRS.Commands.MovieCommands;
using CoreMovieApi.Persistence.Context;

namespace CoreMovieApi.Application.Features.CQRS.Handlers.MovieHandlers;
public class RemoveMovieCommandHandler(MovieContext context)
{
    public async Task Handle(RemoveMovieCommand command)
    {
        var movie = await context.Movies.FindAsync(command.MovieId);
        context.Movies.Remove(movie);
        await context.SaveChangesAsync();
    }
}