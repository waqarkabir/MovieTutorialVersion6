using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<WebApp.MovieDB.GenreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = WebApp.MovieDB.GenreRow;

namespace WebApp.MovieDB;

public interface IGenreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class GenreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreSaveHandler
{
    public GenreSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}