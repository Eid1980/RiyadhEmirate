using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Services.FileManagers;
using Emirates.Core.Application.Shared;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using X.PagedList;

namespace Emirates.Core.Application.Services
{
    public class ServicesService : BaseService, IServicesService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileManagerService _fileManagerService;
        private readonly IConfigurationProvider _mapConfig;

        public ServicesService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper,
            IFileManagerService fileManagerService)
        {
            _mapConfig = mapper.ConfigurationProvider;
            _mapper = mapper;
            _fileManagerService = fileManagerService;
            _emiratesUnitOfWork = emiratesUnitOfWork;
        }

        public IApiResponse GetById(int id)
        {
            var service = _emiratesUnitOfWork.Services.FirstOrDefault(l => l.Id.Equals(id));
            if (service == null)
                throw new NotFoundException(typeof(Service).Name);
            return GetResponse(data: _mapper.Map<GetServiceDetailsDto>(service));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.Services.GetQueryable()
               .ProjectTo<GetServiceListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetServiceListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var services = _emiratesUnitOfWork.Services.Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetServiceListDto>>(services));
        }
        public IApiResponse GetAllServiceGuide(SearchModel searchModel)
        {
            searchModel.PageSize = 2;
            var serchResult = _emiratesUnitOfWork.Services.GetQueryable()
               .ProjectTo<GetServiceListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetServiceListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse SearchByFilter(string filter)
        {
            var services = _emiratesUnitOfWork.Services.Where(x => x.IsActive && !x.IsExternal &&
                (string.IsNullOrEmpty(filter) || filter.Equals("null") || x.NameAr.Contains(filter) || x.NameEn.Contains(filter) ||
                x.SectorAr.Contains(filter) || x.SectorEn.Contains(filter) ||
                x.DescriptionAr.Contains(filter) || x.DescriptionEn.Contains(filter)));
            return GetResponse(data: _mapper.Map<List<GetServiceListDto>>(services));
        }

        public IApiResponse Create(CreateServiceDto createModel)
        {
            if (_emiratesUnitOfWork.Services.Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.Services.Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _emiratesUnitOfWork.Services.Add(_mapper.Map<Service>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: new FileToUploadDto { Id = addedModel.Id, FileName = addedModel.ImageName });
        }
        public IApiResponse Update(UpdateServiceDto updateModel)
        {
            var service = _emiratesUnitOfWork.Services.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (service == null)
                throw new NotFoundException(typeof(Service).Name);

            if (_emiratesUnitOfWork.Services.Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.Services.Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var newService = _mapper.Map<Service>(updateModel);
            newService.ImageName = string.IsNullOrEmpty(newService.ImageName) ? service.ImageName : newService.ImageName;
            string oldImageName = service.ImageName;

            _emiratesUnitOfWork.Services.Update(service, newService);
            if (_emiratesUnitOfWork.Complete() > 0)
            {
                if (!string.IsNullOrEmpty(updateModel.ImageName) && !string.IsNullOrEmpty(oldImageName))
                    _fileManagerService.Delete(new DeleteFileDto
                    {
                        CategueryName = SystemEnums.FileCateguery.Services,
                        Name = oldImageName
                    });
            }
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: new FileToUploadDto { Id = updateModel.Id, FileName = newService.ImageName });
        }
        public IApiResponse ChangeStatus(int id)
        {
            var service = _emiratesUnitOfWork.Services.FirstOrDefault(n => n.Id == id);
            if (service == null)
                throw new NotFoundException(typeof(Service).Name);

            service.IsActive = !service.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var service = _emiratesUnitOfWork.Services.FirstOrDefault(n => n.Id == id,
                x => x.ServiceAudiences, x => x.ServiceBenefits,
                x => x.ServiceStages, x => x.RequestTypes, x => x.RequestAttachmentTypes, x => x.Requests);
            if (service == null)
                throw new NotFoundException(typeof(Service).Name);
            if (service.ServiceStages.Count > 0)
                throw new BusinessException("الخدمة مرتبطة بطلبات في مراحل الخدمات");
            if (service.RequestTypes.Count > 0)
                throw new BusinessException("الخدمة مرتبطة بطلبات في أنواع الخدمات");
            if (service.RequestAttachmentTypes.Count > 0)
                throw new BusinessException("الخدمة مرتبطة بطلبات في مرفقات الخدمات");
            if (service.Requests.Count > 0)
                throw new BusinessException("الخدمة مرتبطة بطلبات في طلبات الخدمات");

            _emiratesUnitOfWork.ServiceAudiences.RemoveRange(service.ServiceAudiences);
            _emiratesUnitOfWork.ServiceBenefits.RemoveRange(service.ServiceBenefits);
            _emiratesUnitOfWork.Services.Remove(service);
            if (_emiratesUnitOfWork.Complete() > 0)
                _fileManagerService.Delete(new DeleteFileDto
                {
                    CategueryName = SystemEnums.FileCateguery.Services,
                    Name = service.ImageName
                });
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
        public IApiResponse GetLookupList()
        {
            return GetResponse(data: _emiratesUnitOfWork.Services.Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
        public IApiResponse GetStagesLookupList()
        {
            return GetResponse(data: _emiratesUnitOfWork.Stages.Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
        public IApiResponse GetNotifiedStagesLookupList()
        {
            return GetResponse(data: _emiratesUnitOfWork.Stages.Where(l => l.IsActive && l.SendNotification).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
        public IApiResponse GetServiceExplainAttachment(int id)
        {
            return GetResponse(data: _fileManagerService.GetBase64File(id, "ServiceExplain"));
        }

    }
}
