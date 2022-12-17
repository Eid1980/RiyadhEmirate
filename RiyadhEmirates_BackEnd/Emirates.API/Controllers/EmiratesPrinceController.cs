using Emirates.API.Filters;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.EmiratesPrinces;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmiratesPrinceController : BaseController, IEmiratesPrinceService
    {
        private readonly IEmiratesPrinceService _emiratesPrinceService;
        public EmiratesPrinceController(ILocalizationService localizationService,
            IEmiratesPrinceService emiratesPrinceService) : base(localizationService)
        {
            _emiratesPrinceService = emiratesPrinceService;
        }

        [AllowAnonymous, HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _emiratesPrinceService.GetById(id);
        }
        [HttpPost("GetListPage")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _emiratesPrinceService.GetAll(searchModelDto);
        }
        [AllowAnonymous, HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _emiratesPrinceService.GetAll();
        }

        [HttpPost("Create")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Create(CreateEmiratesPrinceDto createDto)
        {
            return _emiratesPrinceService.Create(createDto);
        }
        [HttpPut("Update")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Update(UpdateEmiratesPrinceDto updateDto)
        {
            return _emiratesPrinceService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse ChangeStatus(int id)
        {
            return _emiratesPrinceService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Delete(int id)
        {
            return _emiratesPrinceService.Delete(id);
        }
    }
}
