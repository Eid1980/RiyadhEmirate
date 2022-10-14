using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.OpenDataRequests;
using Microsoft.AspNetCore.Authorization;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;
namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenDataRequestController : BaseController, IOpenDataRequestService
    {
        private readonly IOpenDataRequestService _openDataRequestService;
        public OpenDataRequestController(ILocalizationService localizationService,
            IOpenDataRequestService openDataRequestService) : base(localizationService)
        {
            _openDataRequestService = openDataRequestService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _openDataRequestService.GetById(id);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _openDataRequestService.GetAll(searchModelDto);
        }

        [AllowAnonymous, HttpPost("Create")]
        public IApiResponse Create(CreateOpenDataRequestDto createDto)
        {
            return _openDataRequestService.Create(createDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _openDataRequestService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _openDataRequestService.Delete(id);
        }
    }
}
