using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<WebApp.MovieDB.MovieCastRow>;
using MyRow = WebApp.MovieDB.MovieCastRow;

namespace WebApp.MovieDB;

public interface IMovieCastRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class MovieCastRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastRetrieveHandler
{
    public MovieCastRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}