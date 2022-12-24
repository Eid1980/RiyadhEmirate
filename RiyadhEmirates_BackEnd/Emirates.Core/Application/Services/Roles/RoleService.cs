using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using X.PagedList;
using AutoMapper;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.Roles
{
    public class RoleService : BaseService, IRoleService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public RoleService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var role = _emiratesUnitOfWork.Roles.FirstOrDefault(l => l.Id.Equals(id));
            if (role == null)
                throw new NotFoundException(typeof(Role).Name);
            return GetResponse(data: _mapper.Map<GetRoleDetailsDto>(role));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.Roles.GetQueryable()
               .ProjectTo<GetRoleListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetRoleListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var Roles = _emiratesUnitOfWork.Roles.Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetRoleListDto>>(Roles));
        }

        public IApiResponse Create(CreateRoleDto createModel)
        {
            if (_emiratesUnitOfWork.Roles.Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.Roles.Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _emiratesUnitOfWork.Roles.Add(_mapper.Map<Role>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateRoleDto updateModel)
        {
            var role = _emiratesUnitOfWork.Roles.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (role == null)
                throw new NotFoundException(typeof(Role).Name);

            if (_emiratesUnitOfWork.Roles.Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.Roles.Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            _emiratesUnitOfWork.Roles.Update(role, _mapper.Map<Role>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var role = _emiratesUnitOfWork.Roles.FirstOrDefault(n => n.Id == id);
            if (role == null)
                throw new NotFoundException(typeof(Role).Name);

            role.IsActive = !role.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var role = _emiratesUnitOfWork.Roles.FirstOrDefault(n => n.Id == id, x => x.UserRoles);
            if (role == null)
                throw new NotFoundException(typeof(Role).Name);
            if (role.UserRoles.Count > 0)
                throw new BusinessException("الصلاحية مضافة على مستخدمين");

            _emiratesUnitOfWork.Roles.Remove(role);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }

        public IApiResponse GetLookupList()
        {
            return GetResponse(data: _emiratesUnitOfWork.Roles.Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
    }
}
