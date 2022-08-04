using AutoMapper;
using Emirates.Core.Application.Services.Nationality;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalitiesController : BaseController
    {
        private readonly INationalityService _nationalityService;
        private readonly IMapper _mapper;

        public NationalitiesController(ILocalizationService localizationService,
          INationalityService nationalityService,
          IMapper mapper) : base(localizationService)
        {
            _nationalityService = nationalityService;   
            _mapper = mapper;   
        }

        [HttpGet]
        [Route("get/all")]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            var result = _nationalityService.GetAll();
            return Ok(GetResponse(true, result));
        }

    }
}
