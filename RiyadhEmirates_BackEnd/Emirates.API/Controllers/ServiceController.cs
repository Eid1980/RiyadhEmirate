using Microsoft.AspNetCore.Mvc;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;

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


        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _serviceService.GetById(id);
        }

        [AllowAnonymous]
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _serviceService.GetAll();
        }

        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModel)
        {
            return _serviceService.GetAll(searchModel);
        }


        [HttpPost("Create")]
        public IApiResponse Create(CreateServiceDto createDto)
        {
            return _serviceService.Create(createDto);
        }

        [HttpPut("Update")]
        public IApiResponse Update(UpdateServiceDto updateDto)
        {
            return _serviceService.Update(updateDto);
        }

        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _serviceService.ChangeStatus(id);
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
    }
}
