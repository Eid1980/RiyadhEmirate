using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Services.ContactUsMessages;
using Microsoft.AspNetCore.Authorization;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;
using Emirates.API.Filters;
using Emirates.Core.Application.Shared;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsMessageController : BaseController, IContactUsMessageService
    {
        private readonly IContactUsMessageService _contactUsMessageService;
        public ContactUsMessageController(ILocalizationService localizationService,
            IContactUsMessageService contactUsMessageService) : base(localizationService)
        {
            _contactUsMessageService = contactUsMessageService;
        }

        [HttpGet("GetById/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse GetById(int id)
        {
            return _contactUsMessageService.GetById(id);
        }
        [HttpPost("GetListPage")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _contactUsMessageService.GetAll(searchModelDto);
        }

        [AllowAnonymous, HttpPost("Create")]
        public IApiResponse Create(CreateContactUsMessageDto createDto)
        {
            return _contactUsMessageService.Create(createDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse ChangeStatus(int id)
        {
            return _contactUsMessageService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Delete(int id)
        {
            return _contactUsMessageService.Delete(id);
        }
    }
}
