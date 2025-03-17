using CoreMovieApi.Application.Features.Mediator.Queries.CastQueries;
using CoreMovieApi.Application.Features.Mediator.Results.CastResults;
using CoreMovieApi.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CoreMovieApi.Application.Features.Mediator.Handlers.CastHandlers;
public class GetCastQueryHandler(MovieContext context) : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
{
    public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
    {
        var entities = await context.Casts.ToListAsync();
        return entities.Select(c => new GetCastQueryResult
        {
            CastId = c.CastId,
            Title = c.Title,
            FirstName = c.FirstName,
            LastName = c.LastName,
            Biography = c.Biography,
            Overview = c.Overview,
            ImageUrl = c.ImageUrl
        }).ToList();
    }
}