using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.DynamicSearch;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using X.PagedList;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Emirates.Core.Application.Services.UserRoles
{
    public class UserRoleService : BaseService, IUserRoleService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public UserRoleService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetUsersByRoleId(int roleId)
        {
            var roleUsers = _emiratesUnitOfWork.UserRoles.Where(l => l.RoleId.Equals(roleId)).Include(x => x.User);
            return GetResponse(data: _mapper.Map<List<GetRolUsersDto>>(roleUsers));
        }
    }
}
