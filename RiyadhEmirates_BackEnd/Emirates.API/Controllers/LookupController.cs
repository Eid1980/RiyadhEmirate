using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.Lookups;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : BaseController, ILookupService
    {
        private readonly ILookupService _lookupService;
        public LookupController(ILookupService lookupService, ILocalizationService localizationService) : base(localizationService)
        {
            _lookupService=lookupService;
        }


        [HttpGet("GetMaritalStatusLookupList")]
        public IApiResponse GetMaritalStatusLookupList()
        {
            return _lookupService.GetMaritalStatusLookupList();
        }
        [HttpGet("GetGovernorateLookupList")]
        public IApiResponse GetGovernorateLookupList()
        {
            return _lookupService.GetGovernorateLookupList();
        }
        [HttpGet("GetNationalityLookupList")]
        public IApiResponse GetNationalityLookupList()
        {
            return _lookupService.GetNationalityLookupList();
        }
    }
}
