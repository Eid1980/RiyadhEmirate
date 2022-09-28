using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.LatestNewsComments;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LatestNewsCommentController : BaseController, ILatestNewsCommentService
    {
        private readonly ILatestNewsCommentService _latestNewsCommentService;
        public LatestNewsCommentController(ILocalizationService localizationService,
            ILatestNewsCommentService latestNewsCommentService) : base(localizationService)
        {
            _latestNewsCommentService = latestNewsCommentService;
        }


        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _latestNewsCommentService.GetById(id);
        }
        [AllowAnonymous, HttpGet("GetByLatestNewsId/{latestNewsId}")]
        public IApiResponse GetByLatestNewsId(int latestNewsId)
        {
            return _latestNewsCommentService.GetByLatestNewsId(latestNewsId);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _latestNewsCommentService.GetAll(searchModelDto);
        }
        [AllowAnonymous, HttpPost("Create")]
        public IApiResponse Create(CreateLatestNewsCommentDto createDto)
        {
            return _latestNewsCommentService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateLatestNewsCommentDto updateDto)
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
