using AutoMapper;
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

namespace Emirates.Core.Application.Services.CaseTypes
{
    public class CaseTypeService : BaseService, ICaseTypeService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public CaseTypeService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var caseType = _emiratesUnitOfWork.CaseTypes.FirstOrDefault(l => l.Id.Equals(id));
            if (caseType == null)
                throw new NotFoundException(typeof(CaseType).Name);
            return GetResponse(data: _mapper.Map<GetCaseTypeDetailsDto>(caseType));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.CaseTypes.GetQueryable()
               .ProjectTo<GetCaseTypeListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetCaseTypeListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var CaseTypes = _emiratesUnitOfWork.CaseTypes.Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetCaseTypeListDto>>(CaseTypes));
        }

        public IApiResponse Create(CreateCaseTypeDto createModel)
        {
            if (_emiratesUnitOfWork.CaseTypes.Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("Arabic Name Already Exist");
            if (_emiratesUnitOfWork.CaseTypes.Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _emiratesUnitOfWork.CaseTypes.Add(_mapper.Map<CaseType>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateCaseTypeDto updateModel)
        {
            var caseType = _emiratesUnitOfWork.CaseTypes.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (caseType == null)
                throw new NotFoundException(typeof(CaseType).Name);

            if (_emiratesUnitOfWork.CaseTypes.Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.CaseTypes.Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            _emiratesUnitOfWork.CaseTypes.Update(caseType, _mapper.Map<CaseType>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var caseType = _emiratesUnitOfWork.CaseTypes.FirstOrDefault(n => n.Id == id);
            if (caseType == null)
                throw new NotFoundException(typeof(CaseType).Name);

            caseType.IsActive = !caseType.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse GetLookupList()
        {
            return GetResponse(data: _emiratesUnitOfWork.CaseTypes.Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
    }
}
