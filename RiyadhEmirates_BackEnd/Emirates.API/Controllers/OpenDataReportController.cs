using Emirates.API.Filters;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Services.OpenDataReports;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenDataReportController : BaseController, IOpenDataReportService
    {
        private readonly IOpenDataReportService _openDataReportService;
        public OpenDataReportController(ILocalizationService localizationService,
            IOpenDataReportService openDataReportService) : base(localizationService)
        {
            _openDataReportService = openDataReportService;
        }

        [HttpGet("GetById/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse GetById(int id)
        {
            return _openDataReportService.GetById(id);
        }

        [HttpPost("GetListPage")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _openDataReportService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse GetAll()
        {
            return _openDataReportService.GetAll();
        }

        [HttpPost("Create")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Create(CreateOpenDataReportDto createDto)
        {
            return _openDataReportService.Create(createDto);
        }
        [HttpPut("Update")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Update(UpdateOpenDataReportDto updateDto)
        {
            return _openDataReportService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse ChangeStatus(int id)
        {
            return _openDataReportService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Delete(int id)
        {
            return _openDataReportService.Delete(id);
        }
    }
}
