using CoreMovieApi.Application.Features.CQRS.Results.MovieResults;
using CoreMovieApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CoreMovieApi.Application.Features.CQRS.Handlers.MovieHandlers;
public class GetMovieQueryHandler(MovieContext context)
{
    public async Task<List<GetMovieQueryResult>> Handle()
    {
        var movies = await context.Movies.ToListAsync();
        return movies.Select(m => new GetMovieQueryResult
        {
            MovieId = m.MovieId,
            Title = m.Title,
            Description = m.Description,
            Duration = m.Duration,
            CoverImageUrl = m.CoverImageUrl,
            CreatedYear = m.CreatedYear,
            ReleaseDate = m.ReleaseDate,
            Rating = m.Rating,
            IsStatus = m.IsStatus
        }).ToList();
    }
}