using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.Prisons;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrisonController : BaseController, IPrisonService
    {
        private readonly IPrisonService _prisonService;
        public PrisonController(ILocalizationService localizationService,
            IPrisonService prisonService) : base(localizationService)
        {
            _prisonService = prisonService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _prisonService.GetById(id);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _prisonService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _prisonService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreatePrisonDto createDto)
        {
            return _prisonService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdatePrisonDto updateDto)
        {
            return _prisonService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _prisonService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _prisonService.Delete(id);
        }

        [HttpGet("GetLookupList")]
        public IApiResponse GetLookupList()
        {
            return _prisonService.GetLookupList();
        }
    }
}
