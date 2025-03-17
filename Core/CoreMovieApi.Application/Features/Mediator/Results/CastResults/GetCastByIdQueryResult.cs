namespace CoreMovieApi.Application.Features.Mediator.Results.CastResults;
public class GetCastByIdQueryResult
{
    public int CastId { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ImageUrl { get; set; }
    public string? Overview { get; set; }
    public string? Biography { get; set; }
}