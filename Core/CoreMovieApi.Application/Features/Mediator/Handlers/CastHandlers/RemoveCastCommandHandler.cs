using CoreMovieApi.Application.Features.Mediator.Commands.CastCommands;
using CoreMovieApi.Persistence.Context;
using MediatR;

namespace CoreMovieApi.Application.Features.Mediator.Handlers.CastHandlers;
public class RemoveCastCommandHandler(MovieContext context) : IRequestHandler<RemoveCastCommand>
{
    public async Task Handle(RemoveCastCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Casts.FindAsync(request.CastId);
        if(entity is not null)
        {
            context.Casts.Remove(entity);
            await context.SaveChangesAsync();
        } 
    }
}