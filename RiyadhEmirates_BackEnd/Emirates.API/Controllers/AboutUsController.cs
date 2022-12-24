using Emirates.API.Filters;
using Emirates.Core.Application.Dtos.AboutUs;
using Emirates.Core.Application.Dtos.MainPoints;
using Emirates.Core.Application.Services.AboutUs;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase, IAboutUsService
    {
        private readonly IAboutUsService _aboutUsService;
        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        [AllowAnonymous, HttpGet]
        public IApiResponse GetAll()
        {
            return _aboutUsService.GetAll();
        }

        [HttpPost("Create")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Create(CreateAboutUsDto createDto)
        {
            return _aboutUsService.Create(createDto);
        }

        [HttpPost("CreateMainPoint")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse CreateMainPoint(CreateMainPoints mainPoint)
        {
            return _aboutUsService.CreateMainPoint(mainPoint);
        }

        [HttpPut("Update")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Update(UpdateAboutUsDto updateDto)
        {
            return _aboutUsService.Update(updateDto);
        }

        [HttpPut("Update/MainPoint")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse UpdateMainPoint(UpdateMainPoint updateMainPoint)
        {
            return _aboutUsService.UpdateMainPoint(updateMainPoint);
        }

        [HttpPut("Delete/MainPoint/{mainPointid}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse DeleteMainPoint(int mainPointid)
        {
            return _aboutUsService.DeleteMainPoint(mainPointid);
        }
    }
}
