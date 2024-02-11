using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<WebApp.MovieDB.PersonRow>;
using MyRow = WebApp.MovieDB.PersonRow;

namespace WebApp.MovieDB;

public interface IPersonRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class PersonRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonRetrieveHandler
{
    public PersonRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}