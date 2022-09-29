using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.Home;
using Emirates.Core.Application.Services.Shared;
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

        [HttpGet("GetCounts")]
        public IApiResponse GetCounts()
        {
            return _homeService.GetCounts();
        }
    }
}
