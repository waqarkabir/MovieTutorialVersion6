using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<WebApp.MovieDB.GenreRow>;
using MyRow = WebApp.MovieDB.GenreRow;

namespace WebApp.MovieDB;

public interface IGenreListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class GenreListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGenreListHandler
{
    public GenreListHandler(IRequestContext context)
            : base(context)
    {
    }
}