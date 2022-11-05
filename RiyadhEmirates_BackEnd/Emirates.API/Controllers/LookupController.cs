using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.Lookups;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous, HttpGet("GetGovernorateLookupList")]
        public IApiResponse GetGovernorateLookupList()
        {
            return _lookupService.GetGovernorateLookupList();
        }
        [AllowAnonymous, HttpGet("GetNationalityLookupList")]
        public IApiResponse GetNationalityLookupList()
        {
            return _lookupService.GetNationalityLookupList();
        }
        [HttpGet("GetDefendantTypeLookupList")]
        public IApiResponse GetDefendantTypeLookupList()
        {
            return _lookupService.GetDefendantTypeLookupList();
        }
        [HttpGet("GetBuildingTypeLookupList")]
        public IApiResponse GetBuildingTypeLookupList()
        {
            return _lookupService.GetBuildingTypeLookupList();
        }
        [HttpGet("GetReligionLookupList")]
        public IApiResponse GetReligionLookupList()
        {
            return _lookupService.GetReligionLookupList();
        }
        [HttpGet("GetCommentStageLookupList")]
        public IApiResponse GetCommentStageLookupList()
        {
            return _lookupService.GetCommentStageLookupList();
        }
        [AllowAnonymous, HttpGet("GetContactUsMessageTypeLookupList")]
        public IApiResponse GetContactUsMessageTypeLookupList()
        {
            return _lookupService.GetContactUsMessageTypeLookupList();
        }
        [HttpGet("GetOpenDataSubCategueryLookupList")]
        public IApiResponse GetOpenDataSubCategueryLookupList()
        {
            return _lookupService.GetOpenDataSubCategueryLookupList();
        }
    }
}
