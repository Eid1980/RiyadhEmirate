using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.Governorates;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GovernorateController : BaseController, IGovernorateService
    {
        private readonly IGovernorateService _governorateService;
        public GovernorateController(ILocalizationService localizationService,
            IGovernorateService governorateService) : base(localizationService)
        {
            _governorateService = governorateService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _governorateService.GetById(id);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _governorateService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _governorateService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateGovernorateDto createDto)
        {
            return _governorateService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateGovernorateDto updateDto)
        {
            return _governorateService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _governorateService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _governorateService.Delete(id);
        }

        [HttpGet("GetLookupList")]
        public IApiResponse GetLookupList()
        {
            return _governorateService.GetLookupList();
        }
    }
}
