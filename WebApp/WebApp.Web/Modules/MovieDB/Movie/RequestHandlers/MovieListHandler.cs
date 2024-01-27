using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<WebApp.MovieDB.MovieRow>;
using MyRow = WebApp.MovieDB.MovieRow;

namespace WebApp.MovieDB;

public interface IMovieListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class MovieListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieListHandler
{
    public MovieListHandler(IRequestContext context)
            : base(context)
    {
    }
}