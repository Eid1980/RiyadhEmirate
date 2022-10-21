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

namespace Emirates.Core.Application.Services.Prisons
{
    public class PrisonService : BaseService, IPrisonService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public PrisonService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var prison = _emiratesUnitOfWork.Prisons.FirstOrDefault(l => l.Id.Equals(id));
            if (prison == null)
                throw new NotFoundException(typeof(Prison).Name);
            return GetResponse(data: _mapper.Map<GetPrisonDetailsDto>(prison));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.Prisons.GetQueryable()
               .ProjectTo<GetPrisonListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetPrisonListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var Prisons = _emiratesUnitOfWork.Prisons.Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetPrisonListDto>>(Prisons));
        }

        public IApiResponse Create(CreatePrisonDto createModel)
        {
            if (_emiratesUnitOfWork.Prisons.Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.Prisons.Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _emiratesUnitOfWork.Prisons.Add(_mapper.Map<Prison>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdatePrisonDto updateModel)
        {
            var prison = _emiratesUnitOfWork.Prisons.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (prison == null)
                throw new NotFoundException(typeof(Prison).Name);

            if (_emiratesUnitOfWork.Prisons.Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.Prisons.Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            _emiratesUnitOfWork.Prisons.Update(prison, _mapper.Map<Prison>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var prison = _emiratesUnitOfWork.Prisons.FirstOrDefault(n => n.Id == id);
            if (prison == null)
                throw new NotFoundException(typeof(Prison).Name);

            prison.IsActive = !prison.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var prison = _emiratesUnitOfWork.Prisons.FirstOrDefault(n => n.Id == id, x => x.RequestPrisonerTempReleases, x => x.RequestPrisonersServices);
            if (prison == null)
                throw new NotFoundException(typeof(Prison).Name);
            if (prison.RequestPrisonerTempReleases.Count > 0)
                throw new BusinessException("السجن مرتبط بطلبات في خدمة الخروج المؤقت لسجين");
            if (prison.RequestPrisonersServices.Count > 0)
                throw new BusinessException("السجن مرتبط بطلبات في خدمات السجناء");

            _emiratesUnitOfWork.Prisons.Remove(prison);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }

        public IApiResponse GetLookupList()
        {
            return GetResponse(data: _emiratesUnitOfWork.Prisons.Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
    }
}
