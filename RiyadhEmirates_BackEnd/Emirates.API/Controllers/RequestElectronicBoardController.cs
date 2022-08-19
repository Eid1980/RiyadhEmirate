using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.RequestElectronicBoards;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestElectronicBoardController : BaseController, IRequestElectronicBoardService
    {
        private readonly IRequestElectronicBoardService _requestElectronicBoardService;
        public RequestElectronicBoardController(ILocalizationService localizationService,
            IRequestElectronicBoardService requestElectronicBoardService) : base(localizationService)
        {
            _requestElectronicBoardService = requestElectronicBoardService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(Guid id)
        {
            return _requestElectronicBoardService.GetById(id);
        }

        [HttpGet("GetDetailsById/{id}")]
        public IApiResponse GetDetailsById(Guid id)
        {
            return _requestElectronicBoardService.GetDetailsById(id);
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateRequestElectronicBoardDto createModel)
        {
            createModel.UserId = UserId;
            return _requestElectronicBoardService.Create(createModel);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateRequestElectronicBoardDto updateModel)
        {
            return _requestElectronicBoardService.Update(updateModel);
        }
    }
}
