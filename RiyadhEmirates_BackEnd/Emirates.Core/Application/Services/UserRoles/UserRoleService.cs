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
        public IApiResponse GetAdminUsers(SearchModel searchModel)
        {
            searchModel.SearchFields.Add(new SearchField { FieldName = "IsEmployee", Operator = "Equal", Value = true.ToString() });
            var serchResult = _emiratesUnitOfWork.Users.GetQueryable()
               .ProjectTo<GetUserListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetUserListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
    }
}
