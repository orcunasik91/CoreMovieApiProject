using CoreMovieApi.Application.Features.Mediator.Results.CastResults;
using MediatR;

namespace CoreMovieApi.Application.Features.Mediator.Queries.CastQueries;
public class GetCastQuery : IRequest<List<GetCastQueryResult>>
{
}