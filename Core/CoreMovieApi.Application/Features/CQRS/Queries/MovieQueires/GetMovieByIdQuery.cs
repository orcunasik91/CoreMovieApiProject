namespace CoreMovieApi.Application.Features.CQRS.Queries.MovieQueires;
public class GetMovieByIdQuery
{
    public int MovieId { get; set; }

    public GetMovieByIdQuery(int movieId)
    {
        MovieId = movieId;
    }
}