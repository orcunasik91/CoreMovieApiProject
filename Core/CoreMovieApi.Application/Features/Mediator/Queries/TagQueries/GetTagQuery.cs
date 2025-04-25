using CoreMovieApi.Application.Features.Mediator.Results.TagResults;
using MediatR;

namespace CoreMovieApi.Application.Features.Mediator.Queries.TagQueries;
public class GetTagQuery : IRequest<List<GetTagQueryResult>>
{
}