using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.UserRoles
{
    public interface IUserRoleService
    {
        IApiResponse GetUsersByRoleId(int roleId);
        IApiResponse GetRolesByUserId(int userId);
        IApiResponse Create(CreateUserRoleDto createModel);
        IApiResponse Delete(int id);
        IApiResponse GetAdminUsers(SearchModel searchModel);
        IApiResponse IsAuthorize(string roles);
    }
}
