using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.LatestNews;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LatestNewsController : BaseController, ILatestNewsService
    {
        private readonly ILatestNewsService _latestNewsService;
        public LatestNewsController(ILocalizationService localizationService,
            ILatestNewsService latestNewsService) : base(localizationService)
        {
            _latestNewsService = latestNewsService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _latestNewsService.GetById(id);
        }

        [AllowAnonymous, HttpGet("GetByLang/{isArabic}")]
        public IApiResponse GetByLang(bool isArabic = true)
        {
            return _latestNewsService.GetByLang(isArabic);
        }

        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModel)
        {
            return _latestNewsService.GetAll(searchModel);
        }

        [AllowAnonymous, HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _latestNewsService.GetAll();
        }


        [HttpPost("Create")]
        public IApiResponse Create(CreateLatestNewsDto createDto)
        {
            return _latestNewsService.Create(createDto);
        }

        [HttpPut("Update")]
        public IApiResponse Update(UpdateLatestNewsDto updateDto)
        {
            return _latestNewsService.Update(updateDto);
        }

        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _latestNewsService.ChangeStatus(id);
        }

        [HttpGet("ChangecommentStatus/{id}")]
        public IApiResponse ChangecommentStatus(int id)
        {
            return _latestNewsService.ChangecommentStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _latestNewsService.Delete(id);
        }
    }
}
