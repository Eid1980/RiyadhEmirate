using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.ServiceConditions;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceConditionController : BaseController, IServiceConditionService
    {
        private readonly IServiceConditionService _serviceConditionService;
        public ServiceConditionController(ILocalizationService localizationService,
            IServiceConditionService serviceConditionService) : base(localizationService)
        {
            _serviceConditionService = serviceConditionService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _serviceConditionService.GetById(id);
        }

        [HttpGet("GetByServiceId/{serviceId}")]
        public IApiResponse GetByServiceId(int serviceId)
        {
            return _serviceConditionService.GetByServiceId(serviceId);
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateServiceConditionDto createDto)
        {
            return _serviceConditionService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateServiceConditionDto updateDto)
        {
            return _serviceConditionService.Update(updateDto);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _serviceConditionService.Delete(id);
        }
    }
}
