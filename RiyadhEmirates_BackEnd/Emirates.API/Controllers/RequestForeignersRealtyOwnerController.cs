using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Services.RequestForeignersRealtyOwners;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestForeignersRealtyOwnerController : BaseController, IRequestForeignersRealtyOwnerService
    {
        private readonly IRequestForeignersRealtyOwnerService _requestForeignersRealtyOwnerService;
        public RequestForeignersRealtyOwnerController(ILocalizationService localizationService,
            IRequestForeignersRealtyOwnerService requestForeignersRealtyOwnerService) : base(localizationService)
        {
            _requestForeignersRealtyOwnerService = requestForeignersRealtyOwnerService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(Guid id)
        {
            return _requestForeignersRealtyOwnerService.GetById(id);
        }

        [HttpGet("GetDetailsById/{id}")]
        public IApiResponse GetDetailsById(Guid id)
        {
            return _requestForeignersRealtyOwnerService.GetDetailsById(id);
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateRequestForeignersRealtyOwnerDto createModel)
        {
            createModel.UserId = UserId;
            return _requestForeignersRealtyOwnerService.Create(createModel);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateRequestForeignersRealtyOwnerDto updateModel)
        {
            return _requestForeignersRealtyOwnerService.Update(updateModel);
        }
    }
}
