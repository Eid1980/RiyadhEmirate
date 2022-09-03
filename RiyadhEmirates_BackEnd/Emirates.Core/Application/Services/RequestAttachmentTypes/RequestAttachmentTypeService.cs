using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.DynamicSearch;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Dtos.Search;

namespace Emirates.Core.Application.Services.RequestAttachmentTypes
{
    public class RequestAttachmentTypeService : BaseService, IRequestAttachmentTypeService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public RequestAttachmentTypeService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var requestAttachmentType = _emiratesUnitOfWork.RequestAttachmentTypes.FirstOrDefault(l => l.Id.Equals(id), includes: include => include.Service);
            if (requestAttachmentType == null)
                throw new NotFoundException(typeof(RequestAttachmentType).Name);
            return GetResponse(data: _mapper.Map<GetRequestAttachmentTypeDetailsDto>(requestAttachmentType));
        }
        public IApiResponse GetByServiceId(int serviceId)
        {
            var requestAttachmentTypes = _emiratesUnitOfWork.RequestAttachmentTypes.Where(x => x.IsActive && x.ServiceId.Equals(serviceId)).Include(s => s.Service).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetRequestAttachmentTypeListDto>>(requestAttachmentTypes));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.RequestAttachmentTypes.GetQueryable()
               .ProjectTo<GetRequestAttachmentTypeListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetRequestAttachmentTypeListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var requestAttachmentTypes = _emiratesUnitOfWork.RequestAttachmentTypes.Where(l => l.IsActive).Include(s => s.Service).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetRequestAttachmentTypeListDto>>(requestAttachmentTypes));
        }
        public IApiResponse Create(CreateRequestAttachmentTypeDto createModel)
        {
            if (_emiratesUnitOfWork.RequestAttachmentTypes.Where(x => x.NameAr.Equals(createModel.NameAr) && x.ServiceId.Equals(createModel.ServiceId)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا على نفس الخدمة");
            if (_emiratesUnitOfWork.RequestAttachmentTypes.Where(x => x.NameEn.Equals(createModel.NameEn) && x.ServiceId.Equals(createModel.ServiceId)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا على نفس الخدمة");

            var addedModel = _emiratesUnitOfWork.RequestAttachmentTypes.Add(_mapper.Map<RequestAttachmentType>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateRequestAttachmentTypeDto updateModel)
        {
            var requestAttachmentType = _emiratesUnitOfWork.RequestAttachmentTypes.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (requestAttachmentType == null)
                throw new NotFoundException(typeof(RequestAttachmentType).Name);

            if (_emiratesUnitOfWork.RequestAttachmentTypes.Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr) && x.ServiceId.Equals(updateModel.ServiceId)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا على نفس الخدمة");
            if (_emiratesUnitOfWork.RequestAttachmentTypes.Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn) && x.ServiceId.Equals(updateModel.ServiceId)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا على نفس الخدمة");

            _emiratesUnitOfWork.RequestAttachmentTypes.Update(requestAttachmentType, _mapper.Map<RequestAttachmentType>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var requestAttachmentType = _emiratesUnitOfWork.RequestAttachmentTypes.FirstOrDefault(n => n.Id == id);
            if (requestAttachmentType == null)
                throw new NotFoundException(typeof(RequestAttachmentType).Name);

            requestAttachmentType.IsActive = !requestAttachmentType.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse(data: true);
        }
        public IApiResponse Delete(int id)
        {
            var requestAttachmentType = _emiratesUnitOfWork.RequestAttachmentTypes.FirstOrDefault(n => n.Id == id);
            if (requestAttachmentType == null)
                throw new NotFoundException(typeof(RequestAttachmentType).Name);

            _emiratesUnitOfWork.RequestAttachmentTypes.Remove(requestAttachmentType);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
        public IApiResponse ChangeRequire(int id)
        {
            var requestAttachmentType = _emiratesUnitOfWork.RequestAttachmentTypes.FirstOrDefault(n => n.Id == id);
            if (requestAttachmentType == null)
                throw new NotFoundException(typeof(RequestAttachmentType).Name);

            requestAttachmentType.IsRequired = !requestAttachmentType.IsRequired;
            _emiratesUnitOfWork.Complete();
            return GetResponse(data: true);
        }

    }
}
