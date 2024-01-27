using MyRequest = WebApp.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<WebApp.Administration.UserRow>;
using MyRow = WebApp.Administration.UserRow;

namespace WebApp.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}