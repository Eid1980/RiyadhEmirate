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

namespace Emirates.Core.Application.Services.Governorates
{
    public class GovernorateService : BaseService, IGovernorateService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        private readonly IFileManagerService _fileManagerService;
        public GovernorateService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper, IFileManagerService fileManagerService)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
            _fileManagerService = fileManagerService;
        }

        public IApiResponse GetById(int id)
        {
            var governorate = _emiratesUnitOfWork.Governorates.FirstOrDefault(l => l.Id.Equals(id));
            if (governorate == null)
                throw new NotFoundException(typeof(Governorate).Name);
            var mappedModel = _mapper.Map<GetGovernorateDetailsDto>(governorate);
            mappedModel.Image = _fileManagerService.GetBase64File(id, "Governorate");
            return GetResponse(data: mappedModel);
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.Governorates.GetQueryable()
               .ProjectTo<GetGovernorateListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetGovernorateListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var governoratesQuerable = _emiratesUnitOfWork.Governorates.GetQueryable().OrderByDescending(s => s.CreatedDate);
            var query = from governorate in governoratesQuerable
                         where  governorate.IsActive
                         select new GetGovernorateListDto
                         {
                             Id = governorate.Id,
                             NameAr = governorate.NameAr,
                             NameEn = governorate.NameEn,
                             DescriptionAr = governorate.DescriptionAr,
                             DescriptionEn = governorate.DescriptionEn,
                             PhoneNumber = governorate.PhoneNumber,
                             LocationLink = governorate.LocationLink,
                             PortalLink = governorate.PortalLink,
                             Image = _fileManagerService.GetBase64File(governorate.Id, "Governorate")
                         };
            return GetResponse(data: query.ToList());
        }

        public IApiResponse Create(CreateGovernorateDto createModel)
        {
            if (_emiratesUnitOfWork.Governorates.Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.Governorates.Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _emiratesUnitOfWork.Governorates.Add(_mapper.Map<Governorate>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateGovernorateDto updateModel)
        {
            var governorate = _emiratesUnitOfWork.Governorates.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (governorate == null)
                throw new NotFoundException(typeof(Governorate).Name);

            if (_emiratesUnitOfWork.Governorates.Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.Governorates.Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            _emiratesUnitOfWork.Governorates.Update(governorate, _mapper.Map<Governorate>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var governorate = _emiratesUnitOfWork.Governorates.FirstOrDefault(n => n.Id == id);
            if (governorate == null)
                throw new NotFoundException(typeof(Governorate).Name);

            governorate.IsActive = !governorate.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var governorate = _emiratesUnitOfWork.Governorates.FirstOrDefault(n => n.Id == id, x => x.RequestLandsInfringements, x => x.RequestForeignersRealtyOwners);
            if (governorate == null)
                throw new NotFoundException(typeof(Governorate).Name);
            if (governorate.RequestLandsInfringements.Count > 0)
                throw new BusinessException("المحافظة مرتبطة بطلبات في خدمة التعديات على الأراضي");
            if (governorate.RequestForeignersRealtyOwners.Count > 0)
                throw new BusinessException("المحافظة مرتبطة بطلبات في خدمات تملك عقار للأجانب");

            _emiratesUnitOfWork.Governorates.Remove(governorate);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }

        public IApiResponse GetLookupList()
        {
            return GetResponse(data: _emiratesUnitOfWork.Governorates.Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
    }
}
