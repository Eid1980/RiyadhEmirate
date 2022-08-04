using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.RequestAttachmentTypes;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestAttachmentTypeController : BaseController, IRequestAttachmentTypeService
    {
        private readonly IRequestAttachmentTypeService _requestAttachmentTypeService;
        public RequestAttachmentTypeController(ILocalizationService localizationService,
            IRequestAttachmentTypeService requestAttachmentTypeService) : base(localizationService)
        {
            _requestAttachmentTypeService = requestAttachmentTypeService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _requestAttachmentTypeService.GetById(id);
        }
        [HttpGet("GetByServiceId/{serviceId}")]
        public IApiResponse GetByServiceId(int serviceId)
        {
            return _requestAttachmentTypeService.GetByServiceId(serviceId);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _requestAttachmentTypeService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _requestAttachmentTypeService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateRequestAttachmentTypeDto createDto)
        {
            return _requestAttachmentTypeService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateRequestAttachmentTypeDto updateDto)
        {
            return _requestAttachmentTypeService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _requestAttachmentTypeService.ChangeStatus(id);
        }
        [HttpGet("ChangeRequire/{id}")]
        public IApiResponse ChangeRequire(int id)
        {
            return _requestAttachmentTypeService.ChangeRequire(id);
        }

    }
}
