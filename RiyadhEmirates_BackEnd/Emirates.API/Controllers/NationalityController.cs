﻿using Emirates.API.Filters;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Services.Nationalities;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalityController : BaseController, INationalityService
    {
        private readonly INationalityService _nationalityService;
        public NationalityController(ILocalizationService localizationService,
            INationalityService nationalityService) : base(localizationService)
        {
            _nationalityService = nationalityService;
        }

        [HttpGet("GetById/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse GetById(int id)
        {
            return _nationalityService.GetById(id);
        }
        [HttpPost("GetListPage")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _nationalityService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse GetAll()
        {
            return _nationalityService.GetAll();
        }

        [HttpPost("Create")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Create(CreateNationalityDto createDto)
        {
            return _nationalityService.Create(createDto);
        }
        [HttpPut("Update")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Update(UpdateNationalityDto updateDto)
        {
            return _nationalityService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse ChangeStatus(int id)
        {
            return _nationalityService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.SettingPermission)]
        public IApiResponse Delete(int id)
        {
            return _nationalityService.Delete(id);
        }

    }
}
