using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.UserRoles
{
    public interface IUserRoleService
    {
        IApiResponse GetUsersByRoleId(int roleId);
        IApiResponse GetAdminUsers(SearchModel searchModel);
    }
}
