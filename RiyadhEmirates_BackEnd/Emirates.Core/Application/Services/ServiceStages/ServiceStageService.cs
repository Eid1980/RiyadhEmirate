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

namespace Emirates.Core.Application.Services.ServiceStages
{
    public class ServiceStageService : BaseService, IServiceStageService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public ServiceStageService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var serviceStage = _emiratesUnitOfWork.ServiceStages.FirstOrDefault(l => l.Id.Equals(id), x => x.Service, x => x.Stage);
            if (serviceStage == null)
                throw new NotFoundException(typeof(ServiceStage).Name);
            return GetResponse(data: _mapper.Map<GetServiceStageDetailsDto>(serviceStage));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.ServiceStages.GetQueryable().ProjectTo<GetServiceStageListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetServiceStageListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var serviceStages = _emiratesUnitOfWork.ServiceStages.IncludeMultiple(x => x.Service, x => x.Stage).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetServiceStageListDto>>(serviceStages));
        }

        public IApiResponse Create(CreateServiceStageDto createModel)
        {
            if (_emiratesUnitOfWork.ServiceStages.Where(x => x.ServiceId.Equals(createModel.ServiceId) && x.StageId.Equals(createModel.StageId)).Any())
                throw new BusinessException("المرحلة مضافة مسبقا على الخدمة");

            var addedModel = _emiratesUnitOfWork.ServiceStages.Add(_mapper.Map<ServiceStage>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateServiceStageDto updateModel)
        {
            var serviceStage = _emiratesUnitOfWork.ServiceStages.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (serviceStage == null)
                throw new NotFoundException(typeof(ServiceStage).Name);

            if (_emiratesUnitOfWork.ServiceStages.Where(x => x.Id != updateModel.Id && x.ServiceId.Equals(updateModel.ServiceId) && x.StageId.Equals(updateModel.StageId)).Any())
                throw new BusinessException("المرحلة مضافة مسبقا على الخدمة");

            _emiratesUnitOfWork.ServiceStages.Update(serviceStage, _mapper.Map<ServiceStage>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse Delete(int id)
        {
            var serviceStage = _emiratesUnitOfWork.ServiceStages.FirstOrDefault(n => n.Id == id);
            if (serviceStage == null)
                throw new NotFoundException(typeof(ServiceStage).Name);

            _emiratesUnitOfWork.ServiceStages.Remove(serviceStage);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
