using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.News;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : BaseController, INewsService
    {
        private readonly INewsService _newsService;
        public NewsController(ILocalizationService localizationService,
            INewsService newsService) : base(localizationService)
        {
            _newsService = newsService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _newsService.GetById(id);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _newsService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll/{typeId}")]
        public IApiResponse GetAll(int typeId)
        {
            return _newsService.GetAll(typeId);
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateNewsDto createDto)
        {
            return _newsService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateNewsDto updateDto)
        {
            return _newsService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _newsService.ChangeStatus(id);
        }

    }
}
