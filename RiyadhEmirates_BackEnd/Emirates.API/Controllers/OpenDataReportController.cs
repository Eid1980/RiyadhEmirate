using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.OpenDataReports;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenDataReportController : BaseController, IOpenDataReportService
    {
        private readonly IOpenDataReportService _openDataReportService;
        public OpenDataReportController(ILocalizationService localizationService,
            IOpenDataReportService openDataReportService) : base(localizationService)
        {
            _openDataReportService = openDataReportService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _openDataReportService.GetById(id);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _openDataReportService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _openDataReportService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateOpenDataReportDto createDto)
        {
            return _openDataReportService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateOpenDataReportDto updateDto)
        {
            return _openDataReportService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _openDataReportService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _openDataReportService.Delete(id);
        }
    }
}
