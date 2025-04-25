using CoreMovieApi.Application.Features.Mediator.Commands.CastCommands;
using CoreMovieApi.Application.Features.Mediator.Queries.CastQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieApi.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CastsController : ControllerBase
{
    private readonly IMediator mediator;
    public CastsController(IMediator _mediator)
    {
        mediator = _mediator;
    }
    [HttpGet]
    public async Task<IActionResult> CastList()
    {
        var data = await mediator.Send(new GetCastQuery());
        return Ok(data);
    }
    [HttpGet("GetCastById")]
    public async Task<IActionResult> GetCastById(int id)
    {
        var data = await mediator.Send(new GetCastByIdQuery(id));
        return Ok(data);
    }
    [HttpPost]
    public async Task<IActionResult> CreateCast(CreateCastCommand command)
    {
        await mediator.Send(command);
        return Ok("Ekleme İşlemi Başarılı");
    }
    [HttpDelete]
    public async Task<IActionResult> RemoveCast(int id)
    {
        await mediator.Send(new RemoveCastCommand(id));
        return Ok("Silme İşlemi Başarılı");
    }
    [HttpPut]
    public async Task<IActionResult> UpdateCast(UpdateCastCommand command)
    {
        await mediator.Send(command);
        return Ok("Güncelleme İşlemi Başarılı");
    }
}