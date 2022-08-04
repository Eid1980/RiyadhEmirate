using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.DynamicSearch;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.InternalPortal.FileManager;
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
            var mappedModel = _mapper.Map<GetServiceDetailsDto>(service);
            mappedModel.Image = _fileManagerService.GetBase64File(id, "Services");
            return GetResponse(data: mappedModel);
        }
        public IApiResponse GetAll()
        {
            var services = _emiratesUnitOfWork.Services.Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            var mappedList = _mapper.Map<List<GetServiceListDto>>(services);
            foreach (var item in mappedList)
            {
                item.Image = _fileManagerService.GetBase64File(item.Id, "Services");
            }
            return GetResponse(data: mappedList);
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

        public IApiResponse Create(CreateServiceDto createModel)
        {
            if (_emiratesUnitOfWork.Services.Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.Services.Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _emiratesUnitOfWork.Services.Add(_mapper.Map<Service>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
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

            _emiratesUnitOfWork.Services.Update(service, _mapper.Map<Service>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
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
    }
}
