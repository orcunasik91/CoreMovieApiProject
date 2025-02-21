using CoreMovieApi.Application.Features.CQRS.Commands.MovieCommands;
using CoreMovieApi.Domain.Entities;
using CoreMovieApi.Persistence.Context;

namespace CoreMovieApi.Application.Features.CQRS.Handlers.MovieHandlers;
public class CreateMovieCommandHandler(MovieContext context)
{
    public async Task Handle(CreateMovieCommand command)
    {
        await context.Movies.AddAsync(new Movie
        {
            Title = command.Title,
            Description = command.Description,
            CoverImageUrl = command.CoverImageUrl,
            CreatedYear = command.CreatedYear,
            Duration = command.Duration,
            Rating = command.Rating,
            ReleaseDate = command.ReleaseDate,
            IsStatus = command.IsStatus
        });
        await context.SaveChangesAsync();
    }
}