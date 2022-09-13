using Emirates.Core.Application.Dtos.AboutUs;
using Emirates.Core.Application.Dtos.MainPoints;
using Emirates.Core.Application.Dtos.WomanSection;
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
        public IApiResponse Create(CreateWomanSectionDto createDto)
        {
            return _womanSectionService.Create(createDto);
        }

        [HttpPost("CreateMainPoint")]
        public IApiResponse CreateMainPoint(CreateMainPoints mainPoint)
        {
            return _womanSectionService.CreateMainPoint(mainPoint);
        }

        [HttpPut("Update")]
        public IApiResponse Update(UpdateWomanSectionDto updateDto)
        {
            return _womanSectionService.Update(updateDto);
        }

        [HttpPut("Update/MainPoint")]
        public IApiResponse UpdateMainPoint(UpdateMainPoint updateMainPoint)
        {
            return _womanSectionService.UpdateMainPoint(updateMainPoint);
        }

        [HttpPut("Delete/MainPoint/{mainPointid}")]
        public IApiResponse DeleteMainPoint(int mainPointid)
        {
            return _womanSectionService.DeleteMainPoint(mainPointid);
        }
    }
}
