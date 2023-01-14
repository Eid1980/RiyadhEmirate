using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.ServiceRates;
using Emirates.Core.Application.Services.ServiceRates;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ServiceRateController : BaseController, IServiceRateService
    {
        private readonly IServiceRateService _serviceRateService;
        public ServiceRateController(ILocalizationService localizationService,
            IServiceRateService serviceRateService) : base(localizationService)
        {
            _serviceRateService = serviceRateService;
        }

        [HttpGet("GetByServiceId/{serviceId}")]
        public IApiResponse GetByServiceId(int serviceId)
        {
            return _serviceRateService.GetByServiceId(serviceId);
        }

        [HttpGet("GetServiceRate/{serviceId}")]
        public IApiResponse GetServiceRate(int serviceId)
        {
            return _serviceRateService.GetServiceRate(serviceId);
        }

        [HttpPost("GetServiceRateToUser")]
        public IApiResponse GetServiceRateToUser(GetServiceRateToUserRequestDto requestDto)
        {
            requestDto.UserId = UserId;
            return _serviceRateService.GetServiceRateToUser(requestDto);
        }

        [HttpGet("CanRate/{serviceId}")]
        public IApiResponse CanRate(int serviceId)
        {
            return _serviceRateService.CanRate(serviceId);
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateServiceRateDto createDto)
        {
            return _serviceRateService.Create(createDto);
        }

    }
}
