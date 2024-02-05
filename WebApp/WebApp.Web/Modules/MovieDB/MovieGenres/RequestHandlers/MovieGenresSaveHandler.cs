using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<WebApp.MovieDB.MovieGenresRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = WebApp.MovieDB.MovieGenresRow;

namespace WebApp.MovieDB;

public interface IMovieGenresSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class MovieGenresSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresSaveHandler
{
    public MovieGenresSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}