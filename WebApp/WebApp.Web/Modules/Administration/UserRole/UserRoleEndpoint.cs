﻿using MyRepository = WebApp.Administration.Repositories.UserRoleRepository;
using MyRow = WebApp.Administration.UserRoleRow;

namespace WebApp.Administration.Endpoints;
[Route("Services/Administration/UserRole/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class UserRoleEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, UserRoleUpdateRequest request)
    {
        return new MyRepository(Context).Update(uow, request);
    }

    public UserRoleListResponse List(IDbConnection connection, UserRoleListRequest request)
    {
        return new MyRepository(Context).List(connection, request);
    }
}
