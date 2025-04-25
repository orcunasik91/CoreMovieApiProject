using CoreMovieApi.Application.Features.Mediator.Queries.CastQueries;
using CoreMovieApi.Application.Features.Mediator.Results.CastResults;
using CoreMovieApi.Persistence.Context;
using MediatR;

namespace CoreMovieApi.Application.Features.Mediator.Handlers.CastHandlers;
public class GetCastByIdQueryHandler(MovieContext context) : IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResult>
{
    public async Task<GetCastByIdQueryResult> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await context.Casts.FindAsync(request.CastId);
        return new GetCastByIdQueryResult
        {
            CastId = entity.CastId,
            Title = entity.Title,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Biography = entity.Biography,
            Overview = entity.Overview,
            ImageUrl = entity.ImageUrl
        };
    }
}