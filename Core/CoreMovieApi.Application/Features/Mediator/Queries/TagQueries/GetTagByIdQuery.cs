using CoreMovieApi.Application.Features.Mediator.Results.TagResults;
using MediatR;

namespace CoreMovieApi.Application.Features.Mediator.Queries.TagQueries;
public class GetTagByIdQuery : IRequest<GetTagByIdQueryResult>
{
    public int TagId { get; set; }

    public GetTagByIdQuery(int tagId)
    {
        TagId = tagId;
    }
}