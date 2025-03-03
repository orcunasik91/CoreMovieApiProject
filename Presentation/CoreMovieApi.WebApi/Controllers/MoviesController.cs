using CoreMovieApi.Application.Features.CQRS.Commands.MovieCommands;
using CoreMovieApi.Application.Features.CQRS.Handlers.MovieHandlers;
using CoreMovieApi.Application.Features.CQRS.Queries.MovieQueires;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieApi.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly GetMovieQueryHandler getMovieQueryHandler;
    private readonly GetMovieByIdQueryHandler getMovieByIdQueryHandler;
    private readonly CreateMovieCommandHandler createMovieCommandHandler;
    private readonly UpdateMovieCommandHandler updateMovieCommandHandler;
    private readonly RemoveMovieCommandHandler removeMovieCommandHandler;

    public MoviesController(GetMovieQueryHandler _getMovieQueryHandler, GetMovieByIdQueryHandler _getMovieByIdQueryHandler, CreateMovieCommandHandler _createMovieCommandHandler, UpdateMovieCommandHandler _updateMovieCommandHandler, RemoveMovieCommandHandler _removeMovieCommandHandler)
    {
        getMovieQueryHandler = _getMovieQueryHandler;
        getMovieByIdQueryHandler = _getMovieByIdQueryHandler;
        createMovieCommandHandler = _createMovieCommandHandler;
        updateMovieCommandHandler = _updateMovieCommandHandler;
        removeMovieCommandHandler = _removeMovieCommandHandler;
    }
    [HttpGet]
    public async Task<IActionResult> MovieList()
    {
        var movies = await getMovieQueryHandler.Handle();
        return Ok(movies);
    }
    [HttpGet("GetMovie")]
    public async Task<IActionResult> GetMovie(int id)
    {
        var movie = await getMovieByIdQueryHandler.Handle(new GetMovieByIdQuery(id));
        return Ok(movie);
    }
    [HttpPost]
    public async Task<IActionResult> CreateMovie(CreateMovieCommand command)
    {
        await createMovieCommandHandler.Handle(command);
        return Ok("Film Başarılı ile Eklendi");
    }
    [HttpPut]
    public async Task<IActionResult> UpdateMovie(UpdateMovieCommand command)
    {
        await updateMovieCommandHandler.Handle(command);
        return Ok("Film Başarı ile Güncellendi");
    }
    [HttpDelete]
    public async Task<IActionResult> DeleteMovie(int id)
    {
        await removeMovieCommandHandler.Handle(new RemoveMovieCommand(id));
        return Ok("Film Başarı ile Silindi");
    }
}