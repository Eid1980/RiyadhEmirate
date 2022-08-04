using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.RequestPrisonerTempReleases;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestPrisonerTempReleaseController : BaseController, IRequestPrisonerTempReleaseService
    {
        private readonly IRequestPrisonerTempReleaseService _requestPrisonerTempReleaseService;
        public RequestPrisonerTempReleaseController(ILocalizationService localizationService,
            IRequestPrisonerTempReleaseService requestPrisonerTempReleaseService) : base(localizationService)
        {
            _requestPrisonerTempReleaseService = requestPrisonerTempReleaseService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(Guid id)
        {
            return _requestPrisonerTempReleaseService.GetById(id);  
        }

        [HttpGet("GetDetailsById/{id}")]
        public IApiResponse GetDetailsById(Guid id)
        {
            return _requestPrisonerTempReleaseService.GetDetailsById(id);  
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateRequestPrisonerTempReleaseDto createModel)
        {
            createModel.UserId = UserId;
           return _requestPrisonerTempReleaseService.Create(createModel);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateRequestPrisonerTempReleaseDto updateModel)
        {
            return _requestPrisonerTempReleaseService.Update(updateModel);
        }
    }
}
