using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<WebApp.MovieDB.MovieCastRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = WebApp.MovieDB.MovieCastRow;

namespace WebApp.MovieDB;

public interface IMovieCastSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class MovieCastSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastSaveHandler
{
    public MovieCastSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}