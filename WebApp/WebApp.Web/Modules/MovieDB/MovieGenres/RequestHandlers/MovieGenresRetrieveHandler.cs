using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<WebApp.MovieDB.MovieGenresRow>;
using MyRow = WebApp.MovieDB.MovieGenresRow;

namespace WebApp.MovieDB;

public interface IMovieGenresRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class MovieGenresRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresRetrieveHandler
{
    public MovieGenresRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}