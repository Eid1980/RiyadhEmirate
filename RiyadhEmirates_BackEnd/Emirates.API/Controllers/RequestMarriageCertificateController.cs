using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Services.RequestMarriageCertificates;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestMarriageCertificateController : BaseController, IRequestMarriageCertificateService
    {
        private readonly IRequestMarriageCertificateService _requestMarriageCertificateService;
        public RequestMarriageCertificateController(ILocalizationService localizationService,
            IRequestMarriageCertificateService requestMarriageCertificateService) : base(localizationService)
        {
            _requestMarriageCertificateService = requestMarriageCertificateService;
        }


        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(Guid id)
        {
            return _requestMarriageCertificateService.GetById(id);
        }

        [HttpGet("GetDetailsById/{id}")]
        public IApiResponse GetDetailsById(Guid id)
        {
            return _requestMarriageCertificateService.GetDetailsById(id);
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateRequestMarriageCertificateDto createModel)
        {
            createModel.UserId = UserId;
            return _requestMarriageCertificateService.Create(createModel);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateRequestMarriageCertificateDto updateModel)
        {
            return _requestMarriageCertificateService.Update(updateModel);
        }
    }
}
