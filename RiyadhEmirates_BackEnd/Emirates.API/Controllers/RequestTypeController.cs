using AutoMapper;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.RequestTypes;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestTypeController : BaseController, IRequestTypeService
    {
        private readonly IRequestTypeService _requestTypeService;
        public RequestTypeController(ILocalizationService localizationService,
            IRequestTypeService requestTypeService) : base(localizationService)
        {
            _requestTypeService = requestTypeService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _requestTypeService.GetById(id);
        }
        [HttpGet("GetByServiceId/{serviceId}")]
        public IApiResponse GetByServiceId(int serviceId)
        {
            return _requestTypeService.GetByServiceId(serviceId);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _requestTypeService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _requestTypeService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateRequestTypeDto createDto)
        {
            return _requestTypeService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateRequestTypeDto updateDto)
        {
            return _requestTypeService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _requestTypeService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _requestTypeService.Delete(id);
        }

        [HttpGet("GetLookupList")]
        public IApiResponse GetLookupList()
        {
            return _requestTypeService.GetLookupList();
        }

        [AllowAnonymous]
        [HttpGet("GetLookupListByServiceId/{serviceId}")]
        public IApiResponse GetLookupListByServiceId(int serviceId)
        {
            return _requestTypeService.GetLookupListByServiceId(serviceId);
        }
    }
}
