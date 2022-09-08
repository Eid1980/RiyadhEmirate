using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.ServiceBenefits;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceBenefitController : BaseController, IServiceBenefitService
    {
        private readonly IServiceBenefitService _serviceBenefitService;
        public ServiceBenefitController(ILocalizationService localizationService, IServiceBenefitService serviceBenefitService) : base(localizationService)
        {
            _serviceBenefitService = serviceBenefitService;
        }

        [AllowAnonymous, HttpGet("GetAllCountByServiceId/{serviceId}")]
        public IApiResponse GetAllCountByServiceId(int serviceId)
        {
            return _serviceBenefitService.GetAllCountByServiceId(serviceId);
        }

        [AllowAnonymous, HttpPost("Create")]
        public IApiResponse Create(CreateServiceBenefitDto createDto)
        {
            return _serviceBenefitService.Create(createDto);
        }
    }
}
