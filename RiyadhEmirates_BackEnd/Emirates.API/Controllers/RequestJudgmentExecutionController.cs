using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.RequestJudgmentExecutions;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestJudgmentExecutionController : BaseController, IRequestJudgmentExecutionService
    {
        private readonly IRequestJudgmentExecutionService _requestJudgmentExecutionService;
        public RequestJudgmentExecutionController(ILocalizationService localizationService,
            IRequestJudgmentExecutionService requestJudgmentExecutionService) : base(localizationService)
        {
            _requestJudgmentExecutionService = requestJudgmentExecutionService;
        }


        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(Guid id)
        {
            return _requestJudgmentExecutionService.GetById(id);
        }

        [HttpGet("GetDetailsById/{id}")]
        public IApiResponse GetDetailsById(Guid id)
        {
            return _requestJudgmentExecutionService.GetDetailsById(id);
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateRequestJudgmentExecutionDto createModel)
        {
            createModel.UserId = UserId;
            return _requestJudgmentExecutionService.Create(createModel);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateRequestJudgmentExecutionDto updateModel)
        {
            return _requestJudgmentExecutionService.Update(updateModel);
        }
    }
}
