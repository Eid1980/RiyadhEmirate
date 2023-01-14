using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace Emirates.Core.Application.Services.RequestTypes
{
    public class RequestTypeService : BaseService, IRequestTypeService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public RequestTypeService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var requestType = _emiratesUnitOfWork.RequestTypes.FirstOrDefault(l => l.Id.Equals(id), includes: include => include.Service);
            if (requestType == null)
                throw new NotFoundException(typeof(RequestType).Name);
            return GetResponse(data: _mapper.Map<GetRequestTypeDetailsDto>(requestType));
        }
        public IApiResponse GetByServiceId(int serviceId)
        {
            var requestTypes = _emiratesUnitOfWork.RequestTypes.Where(x => x.IsActive && x.ServiceId.Equals(serviceId)).Include(s => s.Service).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetRequestTypeListDto>>(requestTypes));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.RequestTypes.GetQueryable()
               .ProjectTo<GetRequestTypeListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetRequestTypeListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var requestTypes = _emiratesUnitOfWork.RequestTypes.Where(l => l.IsActive).Include(s => s.Service).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetRequestTypeListDto>>(requestTypes));
        }

        public IApiResponse Create(CreateRequestTypeDto createModel)
        {
            if (_emiratesUnitOfWork.RequestTypes.Where(x => x.NameAr.Equals(createModel.NameAr) && x.ServiceId.Equals(createModel.ServiceId)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا على نفس الخدمة");
            if (_emiratesUnitOfWork.RequestTypes.Where(x => x.NameEn.Equals(createModel.NameEn) && x.ServiceId.Equals(createModel.ServiceId)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا على نفس الخدمة");

            var addedModel = _emiratesUnitOfWork.RequestTypes.Add(_mapper.Map<RequestType>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateRequestTypeDto updateModel)
        {
            var requestType = _emiratesUnitOfWork.RequestTypes.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (requestType == null)
                throw new NotFoundException(typeof(RequestType).Name);

            if (_emiratesUnitOfWork.RequestTypes.Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr) && x.ServiceId.Equals(updateModel.ServiceId)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا على نفس الخدمة");
            if (_emiratesUnitOfWork.RequestTypes.Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn) && x.ServiceId.Equals(updateModel.ServiceId)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا على نفس الخدمة");

            _emiratesUnitOfWork.RequestTypes.Update(requestType, _mapper.Map<RequestType>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var requestType = _emiratesUnitOfWork.RequestTypes.FirstOrDefault(n => n.Id == id);
            if (requestType == null)
                throw new NotFoundException(typeof(RequestType).Name);

            requestType.IsActive = !requestType.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var requestType = _emiratesUnitOfWork.RequestTypes.FirstOrDefault(n => n.Id == id,
                x => x.RequestElectronicBoards, x => x.RequestPrisonerTempReleases, x => x.RequestPrisonersServices,
                x => x.RequestLandsInfringements, x => x.RequestElectronicSummons, x => x.RequestMarriageCertificates, x => x.RequestTreatmentRecommendations);
            if (requestType == null)
                throw new NotFoundException(typeof(RequestType).Name);
            if (requestType.RequestElectronicBoards.Count > 0)
                throw new BusinessException("نوع الطلب مرتبط بطلبات في خدمة المجلس الالكتروني");
            if (requestType.RequestPrisonerTempReleases.Count > 0)
                throw new BusinessException("نوع الطلب مرتبط بطلبات في خدمة الخروج المؤقت لسجين");
            if (requestType.RequestPrisonersServices.Count > 0)
                throw new BusinessException("نوع الطلب مرتبط بطلبات في خدمة خدمات السجناء");
            if (requestType.RequestLandsInfringements.Count > 0)
                throw new BusinessException("نوع الطلب مرتبط بطلبات في خدمة التعديات على الأراضي الحكومية");
            if (requestType.RequestElectronicSummons.Count > 0)
                throw new BusinessException("نوع الطلب مرتبط بطلبات في خدمة الاستدعاء الالكتروني");
            if (requestType.RequestMarriageCertificates.Count > 0)
                throw new BusinessException("نوع الطلب مرتبط بطلبات في خدمة توثيق زواج");
            if (requestType.RequestTreatmentRecommendations.Count > 0)
                throw new BusinessException("نوع الطلب مرتبط بطلبات في خدمة طلب علاج");

            _emiratesUnitOfWork.RequestTypes.Remove(requestType);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
        public IApiResponse GetLookupList()
        {
            return GetResponse(data: _emiratesUnitOfWork.RequestTypes.Where(x => x.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
        public IApiResponse GetLookupListByServiceId(int serviceId)
        {
            return GetResponse(data: _emiratesUnitOfWork.RequestTypes.Where(x => x.ServiceId.Equals(serviceId) && x.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
    }
}
