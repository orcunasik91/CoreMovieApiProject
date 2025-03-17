using CoreMovieApi.Application.Features.Mediator.Commands.CastCommands;
using CoreMovieApi.Persistence.Context;
using MediatR;

namespace CoreMovieApi.Application.Features.Mediator.Handlers.CastHandlers;
public class UpdateCastCommandHandler(MovieContext context) : IRequestHandler<UpdateCastCommand>
{
    public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Casts.FindAsync(request.CastId);
        if(entity is not null)
        {
            entity.CastId = request.CastId;
            entity.Title = request.Title;
            entity.FirstName = request.FirstName;
            entity.LastName = request.LastName;
            entity.Biography = request.Biography;
            entity.Overview = request.Overview;
            entity.ImageUrl = request.ImageUrl;
            context.Casts.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}