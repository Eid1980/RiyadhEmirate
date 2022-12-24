using Emirates.API.Filters;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Services.RequestAttachmentTypes;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
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
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
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
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _requestAttachmentTypeService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
        public IApiResponse GetAll()
        {
            return _requestAttachmentTypeService.GetAll();
        }

        [HttpPost("Create")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
        public IApiResponse Create(CreateRequestAttachmentTypeDto createDto)
        {
            return _requestAttachmentTypeService.Create(createDto);
        }
        [HttpPut("Update")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
        public IApiResponse Update(UpdateRequestAttachmentTypeDto updateDto)
        {
            return _requestAttachmentTypeService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
        public IApiResponse ChangeStatus(int id)
        {
            return _requestAttachmentTypeService.ChangeStatus(id);
        }
        [HttpDelete("Delete/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
        public IApiResponse Delete(int id)
        {
            return _requestAttachmentTypeService.Delete(id);
        }

        [HttpGet("ChangeRequire/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
        public IApiResponse ChangeRequire(int id)
        {
            return _requestAttachmentTypeService.ChangeRequire(id);
        }

    }
}
