using CoreMovieApi.Application.Features.Mediator.Commands.TagCommands;
using CoreMovieApi.Persistence.Context;
using CoreMovieApi.Domain.Entities;
using MediatR;

namespace CoreMovieApi.Application.Features.Mediator.Handlers.TagHandlers;
public class CreateTagCommandHandler(MovieContext context) : IRequestHandler<CreateTagCommand>
{
    public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
    {
        await context.Tags.AddAsync(new Tag
        {
            Title = request.Title
        });
        await context.SaveChangesAsync();
    }
}