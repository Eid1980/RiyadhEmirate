using Emirates.API.Filters;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Services.ServiceConditions;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Authorization;
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

        [AllowAnonymous, HttpGet("GetByServiceId/{serviceId}")]
        public IApiResponse GetByServiceId(int serviceId)
        {
            return _serviceConditionService.GetByServiceId(serviceId);
        }

        [HttpPost("Create")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
        public IApiResponse Create(CreateServiceConditionDto createDto)
        {
            return _serviceConditionService.Create(createDto);
        }
        [HttpPut("Update")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
        public IApiResponse Update(UpdateServiceConditionDto updateDto)
        {
            return _serviceConditionService.Update(updateDto);
        }

        [HttpDelete("Delete/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
        public IApiResponse Delete(int id)
        {
            return _serviceConditionService.Delete(id);
        }
    }
}
