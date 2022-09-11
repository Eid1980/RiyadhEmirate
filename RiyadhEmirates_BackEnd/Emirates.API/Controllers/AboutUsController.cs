using Emirates.Core.Application.Dtos.AboutUs;
using Emirates.Core.Application.Dtos.MainPoints;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.AboutUs;
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

        [AllowAnonymous]
        [HttpGet]
        public IApiResponse GetAll()
        {
            return _aboutUsService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateAboutUsDto createDto)
        {
            return _aboutUsService.Create(createDto);
        }

        [HttpPost("CreateMainPoint")]
        public IApiResponse CreateMainPoint(CreateMainPoints mainPoint)
        {
            return _aboutUsService.CreateMainPoint(mainPoint);
        }

        [HttpPut("Update")]
        public IApiResponse Update(UpdateAboutUsDto updateDto)
        {
            return _aboutUsService.Update(updateDto);
        }
    }
}
