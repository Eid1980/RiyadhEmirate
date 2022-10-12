using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
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

        [AllowAnonymous, HttpGet("GetAllServices")]
        public IApiResponse GetAllServices()
        {
            return _homeService.GetAllServices();
        }

        #region News
        [AllowAnonymous, HttpGet("GetNewsSearch/{filter}")]
        public IApiResponse GetNewsSearch(string filter)
        {
            return _homeService.GetNewsSearch(filter);
        }

        [AllowAnonymous, HttpPost("GetAllNews")]
        public IApiResponse GetAllNews(SearchModel searchModel)
        {
            return _homeService.GetAllNews(searchModel);
        }

        [AllowAnonymous, HttpGet("GetTop5NewsByLang/{isArabic}")]
        public IApiResponse GetTop5NewsByLang(bool isArabic = true)
        {
            return _homeService.GetTop5NewsByLang(isArabic);
        }
        #endregion
    }
}
