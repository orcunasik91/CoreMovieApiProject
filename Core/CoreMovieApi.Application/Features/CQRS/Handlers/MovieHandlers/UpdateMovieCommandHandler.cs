using CoreMovieApi.Application.Features.CQRS.Commands.MovieCommands;
using CoreMovieApi.Persistence.Context;

namespace CoreMovieApi.Application.Features.CQRS.Handlers.MovieHandlers;
public class UpdateMovieCommandHandler(MovieContext context)
{
    public async Task Handle(UpdateMovieCommand command)
    {
        var movie = await context.Movies.FindAsync(command.MovieId);
        movie.Title = command.Title;
        movie.Description = command.Description;
        movie.Rating = command.Rating;
        movie.Duration = command.Duration;
        movie.CoverImageUrl = command.CoverImageUrl;
        movie.IsStatus = command.IsStatus;
        movie.CreatedYear = command.CreatedYear;
        movie.ReleaseDate = command.ReleaseDate;
        context.Movies.Update(movie);
        await context.SaveChangesAsync();
    }
}