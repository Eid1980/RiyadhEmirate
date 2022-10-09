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

namespace Emirates.Core.Application.Services.EmiratesPrinces
{
    public class EmiratesPrinceService : BaseService, IEmiratesPrinceService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        private readonly IFileManagerService _fileManagerService;

        public EmiratesPrinceService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper,
            IFileManagerService fileManagerService)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
            _fileManagerService = fileManagerService;
        }

        public IApiResponse GetById(int id)
        {
            var emiratesPrince = _emiratesUnitOfWork.EmiratesPrinces.FirstOrDefault(l => l.Id.Equals(id));
            if (emiratesPrince == null)
                throw new NotFoundException(typeof(EmiratesPrince).Name);
            return GetResponse(data: _mapper.Map<GetEmiratesPrinceDetailsDto>(emiratesPrince));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.EmiratesPrinces.GetQueryable()
               .ProjectTo<GetEmiratesPrinceListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetEmiratesPrinceListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var emiratesPrinces = _emiratesUnitOfWork.EmiratesPrinces.Where(l => l.IsActive).OrderByDescending(d => d.FromDate);
            return GetResponse(data: _mapper.Map<List<GetEmiratesPrinceListDto>>(emiratesPrinces));
        }

        public IApiResponse Create(CreateEmiratesPrinceDto createModel)
        {
            var addedModel = _emiratesUnitOfWork.EmiratesPrinces.Add(_mapper.Map<EmiratesPrince>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: new FileToUploadDto { Id = addedModel.Id, FileName = addedModel.ImageName });
        }
        public IApiResponse Update(UpdateEmiratesPrinceDto updateModel)
        {
            var emiratesPrince = _emiratesUnitOfWork.EmiratesPrinces.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (emiratesPrince == null)
                throw new NotFoundException(typeof(EmiratesPrince).Name);

            var newEmiratesPrince = _mapper.Map<EmiratesPrince>(updateModel);
            newEmiratesPrince.ImageName = string.IsNullOrEmpty(newEmiratesPrince.ImageName) ? emiratesPrince.ImageName : newEmiratesPrince.ImageName;
            string oldImageName = emiratesPrince.ImageName;

            _emiratesUnitOfWork.EmiratesPrinces.Update(emiratesPrince, newEmiratesPrince);
            if (_emiratesUnitOfWork.Complete() > 0)
            {
                if (!string.IsNullOrEmpty(updateModel.ImageName) && !string.IsNullOrEmpty(oldImageName))
                    _fileManagerService.Delete(new DeleteFileDto
                    {
                        CategueryName = SystemEnums.FileCateguery.Princes,
                        Name = oldImageName
                    });
            }
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: new FileToUploadDto { Id = updateModel.Id, FileName = newEmiratesPrince.ImageName });
        }
        public IApiResponse ChangeStatus(int id)
        {
            var emiratesPrince = _emiratesUnitOfWork.EmiratesPrinces.FirstOrDefault(n => n.Id == id);
            if (emiratesPrince == null)
                throw new NotFoundException(typeof(EmiratesPrince).Name);

            emiratesPrince.IsActive = !emiratesPrince.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var emiratesPrince = _emiratesUnitOfWork.EmiratesPrinces.FirstOrDefault(n => n.Id == id);
            if (emiratesPrince == null)
                throw new NotFoundException(typeof(EmiratesPrince).Name);

            _emiratesUnitOfWork.EmiratesPrinces.Remove(emiratesPrince);
            if (_emiratesUnitOfWork.Complete() > 0)
                _fileManagerService.Delete(new DeleteFileDto
                {
                    CategueryName = SystemEnums.FileCateguery.Princes,
                    Name = emiratesPrince.ImageName
                });
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
