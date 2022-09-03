using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.CaseTypes;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseTypeController : BaseController, ICaseTypeService
    {
        private readonly ICaseTypeService _caseTypeService;
        public CaseTypeController(ILocalizationService localizationService,
            ICaseTypeService caseTypeService) : base(localizationService)
        {
            _caseTypeService = caseTypeService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _caseTypeService.GetById(id);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _caseTypeService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _caseTypeService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateCaseTypeDto createDto)
        {
            return _caseTypeService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateCaseTypeDto updateDto)
        {
            return _caseTypeService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _caseTypeService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _caseTypeService.Delete(id);
        }

        [HttpGet("GetLookupList")]
        public IApiResponse GetLookupList()
        {
            return _caseTypeService.GetLookupList();
        }
    }
}
