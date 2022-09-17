using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Services.UserRoles;
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
        public IApiResponse GetUsersByRoleId(int roleId)
        {
            return _userRoleService.GetUsersByRoleId(roleId);
        }
    }
}
