using Emirates.Core.Application.Services.ServiceStages;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;
using Emirates.Core.Application.Dtos.Search;

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
        public IApiResponse GetById(int id)
        {
            return _serviceStageService.GetById(id);
        }

        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _serviceStageService.GetAll(searchModelDto);
        }

        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _serviceStageService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateServiceStageDto createDto)
        {
            return _serviceStageService.Create(createDto);
        }

        [HttpPut("Update")]
        public IApiResponse Update(UpdateServiceStageDto updateDto)
        {
            return _serviceStageService.Update(updateDto);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _serviceStageService.Delete(id);
        }
    }
}
