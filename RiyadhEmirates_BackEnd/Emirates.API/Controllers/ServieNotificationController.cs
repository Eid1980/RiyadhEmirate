using Emirates.API.Filters;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Services.ServieNotifications;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServieNotificationController : BaseController, IServieNotificationService
    {
        private readonly IServieNotificationService _servieNotificationService;
    public ServieNotificationController(ILocalizationService localizationService,
        IServieNotificationService servieNotificationService) : base(localizationService)
    {
        _servieNotificationService = servieNotificationService;
    }

    [HttpGet("GetById/{id}")]
    [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
    public IApiResponse GetById(int id)
    {
        return _servieNotificationService.GetById(id);
    }
    [HttpPost("GetListPage")]
    [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
    public IApiResponse GetAll(SearchModel searchModelDto)
    {
        return _servieNotificationService.GetAll(searchModelDto);
    }
    [HttpGet("GetAll")]
    [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
    public IApiResponse GetAll()
    {
        return _servieNotificationService.GetAll();
    }

    [HttpPost("Create")]
    [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
    public IApiResponse Create(CreateServieNotificationDto createDto)
    {
        return _servieNotificationService.Create(createDto);
    }
    [HttpPut("Update")]
    [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
    public IApiResponse Update(UpdateServieNotificationDto updateDto)
    {
        return _servieNotificationService.Update(updateDto);
    }
    [HttpGet("ChangeStatus/{id}")]
    [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
    public IApiResponse ChangeStatus(int id)
    {
        return _servieNotificationService.ChangeStatus(id);
    }

    [HttpDelete("Delete/{id}")]
    [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin)]
    public IApiResponse Delete(int id)
    {
        return _servieNotificationService.Delete(id);
    }
}
}
