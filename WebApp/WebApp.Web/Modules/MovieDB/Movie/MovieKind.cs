namespace WebApp.Modules.MovieDB.Movie;

[EnumKey("MovieDB.MovieKind")]
public enum MovieKind
{
    [Description("Film")]
    Film = 1,
    [Description("Tv Series")]
    TvSeries = 2,
    [Description("Mini Series")]
    MiniSeries = 3
}
