using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.Posters;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PosterController : BaseController, IPosterService
    {
        private readonly IPosterService _posterService;
        public PosterController(ILocalizationService localizationService,
            IPosterService posterService) : base(localizationService)
        {
            _posterService = posterService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _posterService.GetById(id);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _posterService.GetAll(searchModelDto);
        }
        [AllowAnonymous, HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _posterService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreatePosterDto createDto)
        {
            return _posterService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdatePosterDto updateDto)
        {
            return _posterService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _posterService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _posterService.Delete(id);
        }
    }
}
