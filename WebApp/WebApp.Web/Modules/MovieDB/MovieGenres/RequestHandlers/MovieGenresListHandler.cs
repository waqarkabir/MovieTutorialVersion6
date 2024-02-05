using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<WebApp.MovieDB.MovieGenresRow>;
using MyRow = WebApp.MovieDB.MovieGenresRow;

namespace WebApp.MovieDB;

public interface IMovieGenresListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class MovieGenresListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresListHandler
{
    public MovieGenresListHandler(IRequestContext context)
            : base(context)
    {
    }
}