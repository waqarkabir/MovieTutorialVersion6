using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<WebApp.MovieDB.PersonRow>;
using MyRow = WebApp.MovieDB.PersonRow;

namespace WebApp.MovieDB;

public interface IPersonListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class PersonListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPersonListHandler
{
    public PersonListHandler(IRequestContext context)
            : base(context)
    {
    }
}