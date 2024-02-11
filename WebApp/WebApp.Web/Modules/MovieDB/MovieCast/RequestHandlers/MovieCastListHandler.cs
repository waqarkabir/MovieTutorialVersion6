using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<WebApp.MovieDB.MovieCastRow>;
using MyRow = WebApp.MovieDB.MovieCastRow;

namespace WebApp.MovieDB;

public interface IMovieCastListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class MovieCastListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastListHandler
{
    public MovieCastListHandler(IRequestContext context)
            : base(context)
    {
    }
}