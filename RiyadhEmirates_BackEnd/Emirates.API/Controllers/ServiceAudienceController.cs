
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.ServiceAudiences;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceAudienceController : BaseController, IServiceAudienceService
    {
        private readonly IServiceAudienceService _serviceAudienceService;
        public ServiceAudienceController(ILocalizationService localizationService, IServiceAudienceService serviceAudienceService) : base(localizationService)
        {
            _serviceAudienceService = serviceAudienceService;
        }

        [AllowAnonymous, HttpGet("GetByServiceId/{serviceId}")]
        public IApiResponse GetByServiceId(int serviceId)
        {
            return _serviceAudienceService.GetByServiceId(serviceId);
        }
        [HttpPost("Create")]
        public IApiResponse Create(CreateServiceAudienceDto createDto)
        {
            return _serviceAudienceService.Create(createDto);
        }
        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _serviceAudienceService.Delete(id);
        }

    }
}
