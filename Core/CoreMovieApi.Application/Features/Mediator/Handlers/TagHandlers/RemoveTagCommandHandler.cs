using CoreMovieApi.Application.Features.Mediator.Commands.TagCommands;
using CoreMovieApi.Persistence.Context;
using MediatR;

namespace CoreMovieApi.Application.Features.Mediator.Handlers.TagHandlers;
public class RemoveTagCommandHandler(MovieContext context) : IRequestHandler<RemoveTagCommand>
{
    public async Task Handle(RemoveTagCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Tags.FindAsync(request.TagId);
        if (entity is not null)
        {
            context.Tags.Remove(entity);
            await context.SaveChangesAsync();
        }
    }
}