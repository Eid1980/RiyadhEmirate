using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.News;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : BaseController
    {
        private readonly INewsService _newsService;
        public NewsController(ILocalizationService localizationService,
            INewsService newsService) : base(localizationService)
        {
            _newsService = newsService;
        }

        /// <summary>
        /// Get news by id
        /// </summary>
        /// <param name="id">News identifier</param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _newsService.GetById(id);
        }

        /// <summary>
        /// Get news based on search criteria, search on all the columns based on search criteria
        /// </summary>
        /// <param name="searchModelDto">Search criteria</param>
        /// <returns></returns>
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _newsService.GetAll(searchModelDto);
        }

        /// <summary>
        /// Get news based on news Type
        /// </summary>
        /// <param name="newsTypeId">News type identifier</param>
        /// <returns></returns>
        [HttpGet("GetByNewsTypeId/{newsTypeId}")]
        public IApiResponse GetByNewsTypeId(int newsTypeId)
        {
            return _newsService.GetByNewsTypeId(newsTypeId);
        }

        /// <summary>
        /// Get all news
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _newsService.GetAll();
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
