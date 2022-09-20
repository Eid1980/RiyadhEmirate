﻿using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.Roles;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseController, IRoleService
    {
        private readonly IRoleService _roleService;
        public RoleController(ILocalizationService localizationService,
            IRoleService roleService) : base(localizationService)
        {
            _roleService = roleService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _roleService.GetById(id);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _roleService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _roleService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateRoleDto createDto)
        {
            return _roleService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateRoleDto updateDto)
        {
            return _roleService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _roleService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _roleService.Delete(id);
        }

        [HttpGet("GetLookupList")]
        public IApiResponse GetLookupList()
        {
            return _roleService.GetLookupList();
        }
    }
}