using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.DynamicSearch;
using Emirates.Core.Application.Helpers;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.FileManagers;
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
            return GetResponse(data: _mapper.Map<GetGovernorateDetailsDto>(governorate));
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
            var governorates = _emiratesUnitOfWork.Governorates.Where(l => l.IsActive).OrderByDescending(d => d.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetGovernorateListDto>>(governorates));
        }

        public IApiResponse Create(CreateGovernorateDto createModel)
        {
            if (_emiratesUnitOfWork.Governorates.Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.Governorates.Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _emiratesUnitOfWork.Governorates.Add(_mapper.Map<Governorate>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: new FileToUploadDto { Id = addedModel.Id, FileName = addedModel.ImageName });
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

            var newGovernorate = _mapper.Map<Governorate>(updateModel);
            newGovernorate.ImageName = string.IsNullOrEmpty(newGovernorate.ImageName) ? governorate.ImageName : newGovernorate.ImageName;
            string oldImageName = governorate.ImageName;

            _emiratesUnitOfWork.Governorates.Update(governorate, newGovernorate);
            if (_emiratesUnitOfWork.Complete() > 0)
            {
                if (!string.IsNullOrEmpty(updateModel.ImageName) && !string.IsNullOrEmpty(oldImageName))
                    _fileManagerService.Delete(new DeleteFileDto
                    {
                        CategueryName = SystemEnums.FileCateguery.Governorates,
                        Name = oldImageName
                    });
            }
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: new FileToUploadDto { Id = updateModel.Id, FileName = newGovernorate.ImageName });
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
            if (_emiratesUnitOfWork.Complete() > 0)
                _fileManagerService.Delete(new DeleteFileDto
                {
                    CategueryName = SystemEnums.FileCateguery.Governorates,
                    Name = governorate.ImageName
                });
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
