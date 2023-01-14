using Emirates.API.Filters;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Services.OpenDataCategueries;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenDataCategueryController : BaseController, IOpenDataCategueryService
    {
        private readonly IOpenDataCategueryService _openDataCategueryService;
        public OpenDataCategueryController(ILocalizationService localizationService,
            IOpenDataCategueryService openDataCategueryService) : base(localizationService)
        {
            _openDataCategueryService = openDataCategueryService;
        }

        [HttpGet("GetById/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse GetById(int id)
        {
            return _openDataCategueryService.GetById(id);
        }

        [HttpPost("GetListPage")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _openDataCategueryService.GetAll(searchModelDto);
        }

        [HttpGet("GetAll")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse GetAll()
        {
            return _openDataCategueryService.GetAll();
        }

        [AllowAnonymous]
        [HttpGet("GetAllCategoryWithReports")]
        public IApiResponse GetAllCategoryWithReports()
        {
            return _openDataCategueryService.GetAllCategoryWithReports();
        }

        [HttpPost("Create")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Create(CreateOpenDataCategueryDto createDto)
        {
            return _openDataCategueryService.Create(createDto);
        }
        [HttpPut("Update")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Update(UpdateOpenDataCategueryDto updateDto)
        {
            return _openDataCategueryService.Update(updateDto);
        }

        [HttpGet("ChangeStatus/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse ChangeStatus(int id)
        {
            return _openDataCategueryService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Delete(int id)
        {
            return _openDataCategueryService.Delete(id);
        }

        [HttpGet("GetLookupList")]
        public IApiResponse GetLookupList()
        {
            return _openDataCategueryService.GetLookupList();
        }
    }
}
