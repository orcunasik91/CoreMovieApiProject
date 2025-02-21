using CoreMovieApi.Application.Features.CQRS.Results.CategoryResults;
using CoreMovieApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CoreMovieApi.Application.Features.CQRS.Handlers.CategoryHandlers;
public class GetCategoryQueryHandler(MovieContext context)
{
    public  async Task<List<GetCategoryQueryResult>> Handle()
    {
        var categories = await context.Categories.ToListAsync();
        return categories.Select(c => new GetCategoryQueryResult
        {
            CategoryId = c.CategoryId,
            CategoryName = c.CategoryName
        }).ToList();
    }
}