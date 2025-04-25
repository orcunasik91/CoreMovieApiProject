using CoreMovieApi.Application.Features.Mediator.Commands.TagCommands;
using CoreMovieApi.Persistence.Context;
using MediatR;

namespace CoreMovieApi.Application.Features.Mediator.Handlers.TagHandlers;
public class UpdateTagCommandHandler(MovieContext context) : IRequestHandler<UpdateTagCommand>
{
    public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Tags.FindAsync(request.TagId);
        if(entity is not null)
        {
            entity.TagId = request.TagId;
            entity.Title = request.Title;
            context.Tags.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}