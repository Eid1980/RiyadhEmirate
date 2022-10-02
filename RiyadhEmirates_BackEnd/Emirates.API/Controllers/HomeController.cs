using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.Home;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : BaseController, IHomeService
    {
        private readonly IHomeService _homeService;
        public HomeController(ILocalizationService localizationService,
            IHomeService homeService) : base(localizationService)
        {
            _homeService = homeService;
        }

        [AllowAnonymous, HttpGet("GetCounts")]
        public IApiResponse GetCounts()
        {
            return _homeService.GetCounts();
        }


        [AllowAnonymous, HttpPost("CreateDesignEvaluation")]
        public IApiResponse CreateDesignEvaluation(CreateDesignEvaluationDto createDto)
        {
            return _homeService.CreateDesignEvaluation(createDto);
        }

        [AllowAnonymous, HttpPost("CreateNewsSubscriper")]
        public IApiResponse CreateNewsSubscriper(CreateNewsSubscriperDto createDto)
        {
            return _homeService.CreateNewsSubscriper(createDto);
        }


        [AllowAnonymous, HttpGet("GetAllServices")]
        public IApiResponse GetAllServices()
        {
            return _homeService.GetAllServices();
        }
    }
}
