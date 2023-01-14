using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Services.RequestTreatmentRecommendations;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestTreatmentRecommendationController : BaseController, IRequestTreatmentRecommendationService
    {
        private readonly IRequestTreatmentRecommendationService _requestTreatmentRecommendationService;
        public RequestTreatmentRecommendationController(ILocalizationService localizationService,
            IRequestTreatmentRecommendationService requestTreatmentRecommendationService) : base(localizationService)
        {
            _requestTreatmentRecommendationService = requestTreatmentRecommendationService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(Guid id)
        {
            return _requestTreatmentRecommendationService.GetById(id);
        }

        [HttpGet("GetDetailsById/{id}")]
        public IApiResponse GetDetailsById(Guid id)
        {
            return _requestTreatmentRecommendationService.GetDetailsById(id);
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateRequestTreatmentRecommendationDto createModel)
        {
            createModel.UserId = UserId;
            return _requestTreatmentRecommendationService.Create(createModel);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateRequestTreatmentRecommendationDto updateModel)
        {
            return _requestTreatmentRecommendationService.Update(updateModel);
        }
    }
}
