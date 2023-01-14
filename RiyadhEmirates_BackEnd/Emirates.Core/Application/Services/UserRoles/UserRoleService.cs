using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using X.PagedList;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.UserRoles
{
    public class UserRoleService : BaseService, IUserRoleService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserRoleService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper, 
            IHttpContextAccessor httpContextAccessor)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
            _httpContextAccessor = httpContextAccessor;
        }

        public IApiResponse GetUsersByRoleId(int roleId)
        {
            var roleUsers = _emiratesUnitOfWork.UserRoles.Where(l => l.RoleId.Equals(roleId)).Include(x => x.User);
            return GetResponse(data: _mapper.Map<List<GetRolUsersDto>>(roleUsers));
        }
        public IApiResponse GetRolesByUserId(int userId)
        {
            var roleUsers = _emiratesUnitOfWork.UserRoles.Where(l => l.UserId.Equals(userId)).Include(x => x.Role);
            return GetResponse(data: _mapper.Map<List<GetUserRoleListDto>>(roleUsers));
        }

        public IApiResponse Create(CreateUserRoleDto createModel)
        {
            if (_emiratesUnitOfWork.UserRoles.Where(x => x.UserId.Equals(createModel.UserId) && x.RoleId.Equals(createModel.RoleId)).Any())
                throw new BusinessException("الصلاحية مضافة مسبقا على نفس المستخدم");

            var addedModel = _emiratesUnitOfWork.UserRoles.Add(_mapper.Map<UserRole>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Delete(int id)
        {
            var userRole = _emiratesUnitOfWork.UserRoles.FirstOrDefault(n => n.Id == id);
            if (userRole == null)
                throw new NotFoundException(typeof(UserRole).Name);

            _emiratesUnitOfWork.UserRoles.Remove(userRole);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
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

        public IApiResponse IsAuthorize(string roles)
        {
            var arrRoles = roles.Split(',');
            int usreId = GetUserId();
            var isAuthorize = _emiratesUnitOfWork.UserRoles.Where(r => r.UserId.Equals(usreId) && r.User.IsEmployee && arrRoles.Contains(r.RoleId.ToString())).Any();
            return GetResponse(isSuccess:isAuthorize, data: isAuthorize);
        }

        private int GetUserId()
        {
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                int.TryParse(_httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type.ToLower().Contains("userid")).Value, out int userId);
                return userId;
            }
            return 1;
        }

    }
}
