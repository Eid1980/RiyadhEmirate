using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Services.RequestLandsInfringements;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestLandsInfringementController : BaseController, IRequestLandsInfringementService
    {
        private readonly IRequestLandsInfringementService _requestLandsInfringementService;
        public RequestLandsInfringementController(ILocalizationService localizationService,
            IRequestLandsInfringementService requestLandsInfringementService) : base(localizationService)
        {
            _requestLandsInfringementService = requestLandsInfringementService;
        }


        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(Guid id)
        {
            return _requestLandsInfringementService.GetById(id);
        }

        [HttpGet("GetDetailsById/{id}")]
        public IApiResponse GetDetailsById(Guid id)
        {
            return _requestLandsInfringementService.GetDetailsById(id);
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateRequestLandsInfringementDto createModel)
        {
            createModel.UserId = UserId;
            return _requestLandsInfringementService.Create(createModel);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateRequestLandsInfringementDto updateModel)
        {
            return _requestLandsInfringementService.Update(updateModel);
        }
    }
}
