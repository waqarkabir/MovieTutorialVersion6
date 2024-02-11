using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<WebApp.MovieDB.PersonRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = WebApp.MovieDB.PersonRow;

namespace WebApp.MovieDB;

public interface IPersonSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class PersonSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonSaveHandler
{
    public PersonSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}