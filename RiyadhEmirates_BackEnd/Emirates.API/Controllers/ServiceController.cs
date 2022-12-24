using Microsoft.AspNetCore.Mvc;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.API.Filters;
using Emirates.Core.Application.Shared;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : BaseController, IServicesService
    {
        private readonly IServicesService _serviceService;
        public ServiceController(ILocalizationService localizationService, IServicesService serviceService) : base(localizationService)
        {
            _serviceService = serviceService;
        }


        [AllowAnonymous, HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _serviceService.GetById(id);
        }

        [AllowAnonymous, HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _serviceService.GetAll();
        }

        [HttpPost("GetListPage")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
        public IApiResponse GetAll(SearchModel searchModel)
        {
            return _serviceService.GetAll(searchModel);
        }

        [AllowAnonymous, HttpPost("GetAllServiceGuide")]
        public IApiResponse GetAllServiceGuide(SearchModel searchModel)
        {
            return _serviceService.GetAllServiceGuide(searchModel);
        }

        [AllowAnonymous, HttpGet("SearchByFilter/{filter}")]
        public IApiResponse SearchByFilter(string filter)
        {
            return _serviceService.SearchByFilter(filter);
        }

        [HttpPost("Create")]
        [AuthorizeAdmin()]
        public IApiResponse Create(CreateServiceDto createDto)
        {
            return _serviceService.Create(createDto);
        }

        [HttpPut("Update")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
        public IApiResponse Update(UpdateServiceDto updateDto)
        {
            return _serviceService.Update(updateDto);
        }

        [HttpGet("ChangeStatus/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
        public IApiResponse ChangeStatus(int id)
        {
            return _serviceService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
        public IApiResponse Delete(int id)
        {
            return _serviceService.Delete(id);
        }

        [HttpGet("GetLookupList")]
        public IApiResponse GetLookupList()
        {
            return _serviceService.GetLookupList();
        }

        [HttpGet("GetStagesLookupList")]
        public IApiResponse GetStagesLookupList()
        {
            return _serviceService.GetStagesLookupList();
        }

        [AllowAnonymous, HttpGet("GetServiceExplainAttachment/{id}")]
        public IApiResponse GetServiceExplainAttachment(int id)
        {
            return _serviceService.GetServiceExplainAttachment(id);
        }
    }
}
