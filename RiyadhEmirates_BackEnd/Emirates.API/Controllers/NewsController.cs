using Emirates.API.Filters;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.News;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : BaseController, INewsService
    {
        private readonly INewsService _latestNewsService;
        public NewsController(ILocalizationService localizationService,
            INewsService latestNewsService) : base(localizationService)
        {
            _latestNewsService = latestNewsService;
        }

        [AllowAnonymous, HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _latestNewsService.GetById(id);
        }

        [HttpPost("GetListPage")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.NewsPermission)]
        public IApiResponse GetAll(SearchModel searchModel)
        {
            return _latestNewsService.GetAll(searchModel);
        }

        [HttpPost("Create")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.NewsPermission)]
        public IApiResponse Create(CreateNewsDto createDto)
        {
            return _latestNewsService.Create(createDto);
        }

        [HttpPut("Update")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.NewsPermission)]
        public IApiResponse Update(UpdateNewsDto updateDto)
        {
            return _latestNewsService.Update(updateDto);
        }

        [HttpGet("ChangeStatus/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.NewsPermission)]
        public IApiResponse ChangeStatus(int id)
        {
            return _latestNewsService.ChangeStatus(id);
        }

        [HttpGet("ChangecommentStatus/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.NewsPermission)]
        public IApiResponse ChangecommentStatus(int id)
        {
            return _latestNewsService.ChangecommentStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.NewsPermission)]
        public IApiResponse Delete(int id)
        {
            return _latestNewsService.Delete(id);
        }
    }
}
