namespace WebApp.Modules.MovieDB.Movie;

public class MovieListRequest : ListRequest
{
    public List<int> Genres { get; set; }
}
