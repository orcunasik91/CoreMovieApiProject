using CoreMovieApi.Application.Features.CQRS.Queries.MovieQueires;
using CoreMovieApi.Application.Features.CQRS.Results.MovieResults;
using CoreMovieApi.Persistence.Context;

namespace CoreMovieApi.Application.Features.CQRS.Handlers.MovieHandlers;
public class GetMovieByIdQueryHandler(MovieContext context)
{
    public async Task<GetMovieByIdQueryResult> Handle(GetMovieByIdQuery query)
    {
        var movie = await context.Movies.FindAsync(query.MovieId);
        return new GetMovieByIdQueryResult
        {
            MovieId = movie.MovieId,
            Title = movie.Title,
            Description = movie.Description,
            Duration = movie.Duration,
            CreatedYear = movie.CreatedYear,
            CoverImageUrl = movie.CoverImageUrl,
            ReleaseDate = movie.ReleaseDate,
            Rating = movie.Rating,
            IsStatus = movie.IsStatus,
        };
    }
}