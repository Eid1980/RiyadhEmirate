using Emirates.Core.Application.Dtos.AboutUs;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.WomanSection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WomanSectionController : ControllerBase, IWomanSectionService
    {
        private readonly IWomanSectionService _womanSectionService;
        public WomanSectionController(IWomanSectionService womanSectionService)
        {
            _womanSectionService = womanSectionService;
        }

        [AllowAnonymous]
        [HttpGet]
        public IApiResponse GetAll()
        {
            return _womanSectionService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateAboutUsDto createDto)
        {
            return _womanSectionService.Create(createDto);
        }

        [HttpPut("Update")]
        public IApiResponse Update(UpdateAboutUsDto updateDto)
        {
            return _womanSectionService.Update(updateDto);
        }
    }
}
