using CoreMovieApi.Application.Features.Mediator.Commands.CastCommands;
using CoreMovieApi.Domain.Entities;
using CoreMovieApi.Persistence.Context;
using MediatR;

namespace CoreMovieApi.Application.Features.Mediator.Handlers.CastHandlers;
public class CreateCastCommandHandler(MovieContext context) : IRequestHandler<CreateCastCommand>
{
    public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
    {
        await context.Casts.AddAsync(new Cast
        {
            ImageUrl = request.ImageUrl,
            Biography = request.Biography,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Overview = request.Overview,
            Title = request.Title
        });
        await context.SaveChangesAsync();
    }
}