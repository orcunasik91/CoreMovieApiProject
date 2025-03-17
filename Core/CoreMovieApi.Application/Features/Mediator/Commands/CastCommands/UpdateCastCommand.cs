using MediatR;

namespace CoreMovieApi.Application.Features.Mediator.Commands.CastCommands;
public class UpdateCastCommand : IRequest
{
    public int CastId { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ImageUrl { get; set; }
    public string? Overview { get; set; }
    public string? Biography { get; set; }
}