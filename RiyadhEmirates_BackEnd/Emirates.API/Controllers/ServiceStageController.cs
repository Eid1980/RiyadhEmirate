using Emirates.Core.Application.Services.ServiceStages;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;
using Emirates.Core.Application.Dtos.Search;
using Emirates.API.Filters;
using Emirates.Core.Application.Shared;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceStageController : BaseController, IServiceStageService
    {
        private readonly IServiceStageService _serviceStageService;
        public ServiceStageController(ILocalizationService localizationService,
            IServiceStageService serviceStageService) : base(localizationService)
        {
            _serviceStageService = serviceStageService;
        }


        [HttpGet("GetById/{id}")]
        [AuthorizeAdmin()]
        public IApiResponse GetById(int id)
        {
            return _serviceStageService.GetById(id);
        }

        [HttpPost("GetListPage")]
        [AuthorizeAdmin()]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _serviceStageService.GetAll(searchModelDto);
        }

        [HttpGet("GetAll")]
        [AuthorizeAdmin()]
        public IApiResponse GetAll()
        {
            return _serviceStageService.GetAll();
        }

        [HttpPost("Create")]
        [AuthorizeAdmin()]
        public IApiResponse Create(CreateServiceStageDto createDto)
        {
            return _serviceStageService.Create(createDto);
        }

        [HttpPut("Update")]
        [AuthorizeAdmin()]
        public IApiResponse Update(UpdateServiceStageDto updateDto)
        {
            return _serviceStageService.Update(updateDto);
        }

        [HttpDelete("Delete/{id}")]
        [AuthorizeAdmin()]
        public IApiResponse Delete(int id)
        {
            return _serviceStageService.Delete(id);
        }
    }
}
