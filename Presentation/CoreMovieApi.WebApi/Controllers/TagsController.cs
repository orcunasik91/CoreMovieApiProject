using CoreMovieApi.Application.Features.Mediator.Commands.TagCommands;
using CoreMovieApi.Application.Features.Mediator.Queries.TagQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieApi.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TagsController : ControllerBase
{
    private readonly IMediator mediator;
    public TagsController(IMediator _mediator)
    {
        mediator = _mediator;
    }
    [HttpGet]
    public async Task<IActionResult> TagList()
    {
        var data = await mediator.Send(new GetTagQuery());
        return Ok(data);
    }
    [HttpGet("GetTag")]
    public async Task<IActionResult> GetTag(int id)
    {
        var data = await mediator.Send(new GetTagByIdQuery(id));
        return Ok(data);
    }
    [HttpPost]
    public async Task<IActionResult> CreateTag(CreateTagCommand command)
    {
        await mediator.Send(command);
        return Ok("Ekleme İşlemi Başarılı");
    }
    [HttpDelete]
    public async Task<IActionResult> RemoveTag(int id)
    {
        await mediator.Send(new RemoveTagCommand(id));
        return Ok("Silme İşlemi Başarılı");
    }
    [HttpPut]
    public async Task<IActionResult> UpdateTag(UpdateTagCommand command)
    {
        await mediator.Send(command);
        return Ok("Güncelleme İşlemi Başarılı");
    }
}