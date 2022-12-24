using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Services.OpenDataRequests;
using Microsoft.AspNetCore.Authorization;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;
using Emirates.API.Filters;
using Emirates.Core.Application.Shared;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenDataRequestController : BaseController, IOpenDataRequestService
    {
        private readonly IOpenDataRequestService _openDataRequestService;
        public OpenDataRequestController(ILocalizationService localizationService,
            IOpenDataRequestService openDataRequestService) : base(localizationService)
        {
            _openDataRequestService = openDataRequestService;
        }

        [HttpGet("GetById/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse GetById(int id)
        {
            return _openDataRequestService.GetById(id);
        }
        [HttpPost("GetListPage")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _openDataRequestService.GetAll(searchModelDto);
        }

        [AllowAnonymous, HttpPost("Create")]
        public IApiResponse Create(CreateOpenDataRequestDto createDto)
        {
            return _openDataRequestService.Create(createDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse ChangeStatus(int id)
        {
            return _openDataRequestService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Delete(int id)
        {
            return _openDataRequestService.Delete(id);
        }
    }
}
