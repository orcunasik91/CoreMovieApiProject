using CoreMovieApi.Application.Features.CQRS.Queries.CategoryQueries;
using CoreMovieApi.Application.Features.CQRS.Results.CategoryResults;
using CoreMovieApi.Persistence.Context;

namespace CoreMovieApi.Application.Features.CQRS.Handlers.CategoryHandlers;
public class GetCategoryByIdQueryHandler(MovieContext context)
{
    public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
    {
        var category = await context.Categories.FindAsync(query.CategoryId);
        return new GetCategoryByIdQueryResult
        {
            CategoryId = category.CategoryId,
            CategoryName = category.CategoryName
        };
    }
}