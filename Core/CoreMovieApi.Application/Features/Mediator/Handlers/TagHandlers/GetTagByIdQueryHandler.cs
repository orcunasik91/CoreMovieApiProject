using CoreMovieApi.Application.Features.Mediator.Queries.TagQueries;
using CoreMovieApi.Application.Features.Mediator.Results.TagResults;
using CoreMovieApi.Persistence.Context;
using MediatR;

namespace CoreMovieApi.Application.Features.Mediator.Handlers.TagHandlers;
public class GetTagByIdQueryHandler(MovieContext context) : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResult>
{
    public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await context.Tags.FindAsync(request.TagId);
        return new GetTagByIdQueryResult
        {
            TagId = entity.TagId,
            Title = entity.Title
        };
    }
}