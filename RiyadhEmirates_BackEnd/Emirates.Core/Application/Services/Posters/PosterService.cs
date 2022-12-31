using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Services.FileManagers;
using Emirates.Core.Application.Shared;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using X.PagedList;

namespace Emirates.Core.Application.Services.Posters
{
    public class PosterService : BaseService, IPosterService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        private readonly IFileManagerService _fileManagerService;
        public PosterService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper, IFileManagerService fileManagerService)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
            _fileManagerService = fileManagerService;
        }

        public IApiResponse GetById(int id)
        {
            var poster = _emiratesUnitOfWork.Posters.FirstOrDefault(l => l.Id.Equals(id));
            if (poster == null)
                throw new NotFoundException(typeof(Poster).Name);
            return GetResponse(data: _mapper.Map<GetPosterDetailsDto>(poster));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.Posters.GetQueryable()
               .ProjectTo<GetPosterListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetPosterListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var posters = _emiratesUnitOfWork.Posters.Where(l => l.IsActive).OrderBy(d => d.Order);
            return GetResponse(data: _mapper.Map<List<GetPosterListDto>>(posters));
        }

        public IApiResponse Create(CreatePosterDto createModel)
        {
            var addedModel = _emiratesUnitOfWork.Posters.Add(_mapper.Map<Poster>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: new FileToUploadDto { Id = addedModel.Id, FileName = addedModel.ImageName });
        }
        public IApiResponse Update(UpdatePosterDto updateModel)
        {
            var poster = _emiratesUnitOfWork.Posters.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (poster == null)
                throw new NotFoundException(typeof(Poster).Name);

            var newPoster = _mapper.Map<Poster>(updateModel);
            newPoster.ImageName = string.IsNullOrEmpty(newPoster.ImageName) ? poster.ImageName : newPoster.ImageName;
            string oldImageName = poster.ImageName;

            _emiratesUnitOfWork.Posters.Update(poster, newPoster);
            if (_emiratesUnitOfWork.Complete() > 0)
            {
                if (!string.IsNullOrEmpty(updateModel.ImageName) && !string.IsNullOrEmpty(oldImageName))
                    _fileManagerService.Delete(new DeleteFileDto
                    {
                        CategueryName = SystemEnums.FileCateguery.Posters,
                        Name = oldImageName
                    });
            }
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: new FileToUploadDto { Id = updateModel.Id, FileName = newPoster.ImageName });
        }
        public IApiResponse ChangeStatus(int id)
        {
            var poster = _emiratesUnitOfWork.Posters.FirstOrDefault(n => n.Id == id);
            if (poster == null)
                throw new NotFoundException(typeof(Poster).Name);

            poster.IsActive = !poster.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var poster = _emiratesUnitOfWork.Posters.FirstOrDefault(n => n.Id == id);
            if (poster == null)
                throw new NotFoundException(typeof(Poster).Name);

            _emiratesUnitOfWork.Posters.Remove(poster);
            if (_emiratesUnitOfWork.Complete() > 0)
                _fileManagerService.Delete(new DeleteFileDto
                {
                    CategueryName = SystemEnums.FileCateguery.Posters,
                    Name = poster.ImageName
                });
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
