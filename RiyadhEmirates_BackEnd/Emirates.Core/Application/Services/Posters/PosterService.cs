

using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos.Posters;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.DynamicSearch;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.InternalPortal.FileManager;
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
            var mappedModel = _mapper.Map<GetPosterDetailsDto>(poster);
            mappedModel.Image = _fileManagerService.GetBase64File(id, "Poster");
            return GetResponse(data: mappedModel);
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
            var query = (from poster in _emiratesUnitOfWork.Posters
                         where poster.IsActive == true
                         select new GetPosterDetailsDto
                         {
                             Id = poster.Id,
                             TitleAr = poster.TitleAr,
                             TitleEn = poster.TitleEn,
                             IsActive = poster.IsActive,
                             Order = poster.Order,
                             Image = _fileManagerService.GetBase64File(poster.Id, "Poster")
                         }).OrderBy(s => s.Order);

            return GetResponse(data: query);

        }

        public IApiResponse Create(CreatePosterDto createModel)
        {
            var addedModel = _emiratesUnitOfWork.Posters.Add(_mapper.Map<Poster>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdatePosterDto updateModel)
        {
            var poster = _emiratesUnitOfWork.Posters.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (poster == null)
                throw new NotFoundException(typeof(Poster).Name);

            _emiratesUnitOfWork.Posters.Update(poster, _mapper.Map<Poster>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
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
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
