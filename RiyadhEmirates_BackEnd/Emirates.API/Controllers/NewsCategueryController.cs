using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.NewsCategueries;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsCategueryController : BaseController, INewsCategueryService
    {
        private readonly INewsCategueryService _newsCategueryService;
        public NewsCategueryController(ILocalizationService localizationService,
            INewsCategueryService newsCategueryService) : base(localizationService)
        {
            _newsCategueryService = newsCategueryService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _newsCategueryService.GetById(id);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _newsCategueryService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _newsCategueryService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateNewsCategueryDto createDto)
        {
            return _newsCategueryService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateNewsCategueryDto updateDto)
        {
            return _newsCategueryService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _newsCategueryService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _newsCategueryService.Delete(id);
        }

        [HttpGet("GetLookupList")]
        public IApiResponse GetLookupList()
        {
            return _newsCategueryService.GetLookupList();
        }
    }
}
