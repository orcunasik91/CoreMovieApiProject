using CoreMovieApi.Application.Features.CQRS.Commands.CategoryCommands;
using CoreMovieApi.Application.Features.CQRS.Handlers.CategoryHandlers;
using CoreMovieApi.Application.Features.CQRS.Queries.CategoryQueries;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieApi.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly GetCategoryByIdQueryHandler getCategoryByIdQueryHandler;
    private readonly GetCategoryQueryHandler getCategoryQueryHandler;
    private readonly CreateCategoryCommandHandler createCategoryCommandHandler;
    private readonly UpdateCategoryCommandHandler updateCategoryCommandHandler;
    private readonly RemoveCategoryCommandHandler removeCategoryCommandHandler;

    public CategoriesController(GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler, GetCategoryQueryHandler _getCategoryQueryHandler, CreateCategoryCommandHandler _createCategoryCommandHandler, UpdateCategoryCommandHandler _updateCategoryCommandHandler, RemoveCategoryCommandHandler _removeCategoryCommandHandler)
    {
        getCategoryByIdQueryHandler = _getCategoryByIdQueryHandler;
        getCategoryQueryHandler = _getCategoryQueryHandler;
        createCategoryCommandHandler = _createCategoryCommandHandler;
        updateCategoryCommandHandler = _updateCategoryCommandHandler;
        removeCategoryCommandHandler = _removeCategoryCommandHandler;
    }

    [HttpGet]
    public async Task<IActionResult> CategoryList()
    {
        var categories = await getCategoryQueryHandler.Handle();
        return Ok(categories);
    }
    [HttpGet("GetCategory")]
    public async Task<IActionResult> GetCategory(int id)
    {
        var category = await getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id));
        return Ok(category);
    }
    [HttpPost]
    public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
    {
        await createCategoryCommandHandler.Handle(command);
        return Ok("Kategori Ekleme İşlemi Başarılı");
    }
    [HttpDelete]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        await removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(id));
        return Ok("Kategori Başarı ile Silindi");
    }
    [HttpPut]
    public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
    {
        await updateCategoryCommandHandler.Handle(command);
        return Ok("Kategori Başarı ile Güncellendi");
    } 
}