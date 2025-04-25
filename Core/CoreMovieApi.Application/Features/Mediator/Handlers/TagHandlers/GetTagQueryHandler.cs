using CoreMovieApi.Application.Features.Mediator.Queries.TagQueries;
using CoreMovieApi.Application.Features.Mediator.Results.TagResults;
using CoreMovieApi.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CoreMovieApi.Application.Features.Mediator.Handlers.TagHandlers;
public class GetTagQueryHandler(MovieContext context) : IRequestHandler<GetTagQuery, List<GetTagQueryResult>>
{
    public async Task<List<GetTagQueryResult>> Handle(GetTagQuery request, CancellationToken cancellationToken)
    {
        var entities = await context.Tags.ToListAsync();
        return entities.Select(t => new GetTagQueryResult
        {
            TagId = t.TagId,
            Title = t.Title
        }).ToList();
    }
}