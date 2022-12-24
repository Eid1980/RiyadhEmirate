using Emirates.API.Filters;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Services.UserRoles;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : BaseController, IUserRoleService
    {
        private readonly IUserRoleService _userRoleService;
        public UserRoleController(ILocalizationService localizationService,
            IUserRoleService userRoleService) : base(localizationService)
        {
            _userRoleService = userRoleService;
        }

        [HttpGet("GetUsersByRoleId/{roleId}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.UsersPermission)]
        public IApiResponse GetUsersByRoleId(int roleId)
        {
            return _userRoleService.GetUsersByRoleId(roleId);
        }

        [HttpGet("GetRolesByUserId/{userId}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.UsersPermission)]
        public IApiResponse GetRolesByUserId(int userId)
        {
            return _userRoleService.GetRolesByUserId(userId);
        }

        [HttpPost("Create")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.UsersPermission)]
        public IApiResponse Create(CreateUserRoleDto createDto)
        {
            return _userRoleService.Create(createDto);
        }

        [HttpDelete("Delete/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.UsersPermission)]
        public IApiResponse Delete(int id)
        {
            return _userRoleService.Delete(id);
        }

        [HttpPost("GetListPage")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.UsersPermission)]
        public IApiResponse GetAdminUsers(SearchModel searchModelDto)
        {
            return _userRoleService.GetAdminUsers(searchModelDto);
        }

        [HttpGet("IsAuthorize/{roles}")]
        public IApiResponse IsAuthorize(string roles)
        {
            return _userRoleService.IsAuthorize(roles);
        }

    }
}
