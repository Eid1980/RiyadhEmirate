using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Services.RequestPrisonersServices;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestPrisonersServiceController : BaseController, IRequestPrisonersServiceService
    {
        private readonly IRequestPrisonersServiceService _requestPrisonersServiceService;
        public RequestPrisonersServiceController(ILocalizationService localizationService,
            IRequestPrisonersServiceService requestPrisonersServiceService) : base(localizationService)
        {
            _requestPrisonersServiceService = requestPrisonersServiceService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(Guid id)
        {
            return _requestPrisonersServiceService.GetById(id);
        }

        [HttpGet("GetDetailsById/{id}")]
        public IApiResponse GetDetailsById(Guid id)
        {
            return _requestPrisonersServiceService.GetDetailsById(id);
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateRequestPrisonersServiceDto createModel)
        {
            createModel.UserId = UserId;
            return _requestPrisonersServiceService.Create(createModel);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateRequestPrisonersServiceDto updateModel)
        {
            return _requestPrisonersServiceService.Update(updateModel);
        }

    }
}
