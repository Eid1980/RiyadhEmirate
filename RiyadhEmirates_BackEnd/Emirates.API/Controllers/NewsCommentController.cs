using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.NewsComments;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsCommentController : BaseController, INewsCommentService
    {
        private readonly INewsCommentService _latestNewsCommentService;
        public NewsCommentController(ILocalizationService localizationService,
            INewsCommentService latestNewsCommentService) : base(localizationService)
        {
            _latestNewsCommentService = latestNewsCommentService;
        }


        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _latestNewsCommentService.GetById(id);
        }
        [AllowAnonymous, HttpGet("GetByNewsId/{latestNewsId}")]
        public IApiResponse GetByNewsId(int latestNewsId)
        {
            return _latestNewsCommentService.GetByNewsId(latestNewsId);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _latestNewsCommentService.GetAll(searchModelDto);
        }
        [AllowAnonymous, HttpPost("Create")]
        public IApiResponse Create(CreateNewsCommentDto createDto)
        {
            return _latestNewsCommentService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateNewsCommentDto updateDto)
        {
            return _latestNewsCommentService.Update(updateDto);
        }
        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _latestNewsCommentService.Delete(id);
        }
    }
}
