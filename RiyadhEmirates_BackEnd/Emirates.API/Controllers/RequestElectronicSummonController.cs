using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Services.RequestElectronicSummons;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestElectronicSummonController : BaseController, IRequestElectronicSummonService
    {
        private readonly IRequestElectronicSummonService _requestElectronicSummonService;
        public RequestElectronicSummonController(ILocalizationService localizationService,
            IRequestElectronicSummonService requestElectronicSummonService) : base(localizationService)
        {
            _requestElectronicSummonService = requestElectronicSummonService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(Guid id)
        {
            return _requestElectronicSummonService.GetById(id);
        }

        [HttpGet("GetDetailsById/{id}")]
        public IApiResponse GetDetailsById(Guid id)
        {
            return _requestElectronicSummonService.GetDetailsById(id);
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateRequestElectronicSummonDto createModel)
        {
            createModel.UserId = UserId;
            return _requestElectronicSummonService.Create(createModel);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateRequestElectronicSummonDto updateModel)
        {
            return _requestElectronicSummonService.Update(updateModel);
        }
    }
}
