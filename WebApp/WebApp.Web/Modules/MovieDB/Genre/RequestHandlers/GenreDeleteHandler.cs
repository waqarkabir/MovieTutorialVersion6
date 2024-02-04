using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = WebApp.MovieDB.GenreRow;

namespace WebApp.MovieDB;

public interface IGenreDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class GenreDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IGenreDeleteHandler
{
    public GenreDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}