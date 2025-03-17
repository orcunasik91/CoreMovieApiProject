using CoreMovieApi.Application.Features.Mediator.Results.CastResults;
using MediatR;

namespace CoreMovieApi.Application.Features.Mediator.Queries.CastQueries;
public class GetCastByIdQuery : IRequest<GetCastByIdQueryResult>
{
    public int CastId { get; set; }

    public GetCastByIdQuery(int castId)
    {
        CastId = castId;
    }
}