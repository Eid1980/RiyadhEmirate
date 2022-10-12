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
using Emirates.Core.Domain.Interfaces;
using X.PagedList;
namespace Emirates.Core.Application.Services.News
{
    public class NewsService : BaseService, INewsService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        private readonly IFileManagerService _fileManagerService;
        public NewsService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper, IFileManagerService fileManagerService)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
            _fileManagerService = fileManagerService;
        }

        public IApiResponse GetById(int id)
        {
            var news = _emiratesUnitOfWork.News.FirstOrDefault(l => l.Id.Equals(id),includes: x => x.NewsCateguery);
            if (news == null)
                throw new NotFoundException(typeof(Domain.Entities.News).Name);
            return GetResponse(data: _mapper.Map<GetNewsDetailsDto>(news));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.News.GetQueryable()
               .ProjectTo<GetNewsListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetNewsListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse Create(CreateNewsDto createModel)
        {
            var addedModel = _emiratesUnitOfWork.News.Add(_mapper.Map<Domain.Entities.News>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: new FileToUploadDto { Id = addedModel.Id, FileName = addedModel.ImageName });
        }
        public IApiResponse Update(UpdateNewsDto updateModel)
        {
            var news = _emiratesUnitOfWork.News.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (news == null)
                throw new NotFoundException(typeof(Domain.Entities.News).Name);

            var newNews = _mapper.Map<Domain.Entities.News>(updateModel);
            newNews.ImageName = string.IsNullOrEmpty(newNews.ImageName) ? news.ImageName : newNews.ImageName;
            string oldImageName = news.ImageName;

            _emiratesUnitOfWork.News.Update(news, newNews);
            if (_emiratesUnitOfWork.Complete() > 0)
            {
                if (!string.IsNullOrEmpty(updateModel.ImageName) && !string.IsNullOrEmpty(oldImageName))
                    _fileManagerService.Delete(new DeleteFileDto
                    {
                        CategueryName = SystemEnums.FileCateguery.News,
                        Name = oldImageName
                    });
            }
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: new FileToUploadDto { Id = updateModel.Id, FileName = newNews.ImageName });
        }
        public IApiResponse ChangeStatus(int id)
        {
            var news = _emiratesUnitOfWork.News.FirstOrDefault(n => n.Id == id);
            if (news == null)
                throw new NotFoundException(typeof(Domain.Entities.News).Name);

            news.IsActive = !news.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse ChangecommentStatus(int id)
        {
            var news = _emiratesUnitOfWork.News.FirstOrDefault(n => n.Id == id);
            if (news == null)
                throw new NotFoundException(typeof(Domain.Entities.News).Name);

            news.OpenComments = !news.OpenComments;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var news = _emiratesUnitOfWork.News.FirstOrDefault(n => n.Id == id);
            if (news == null)
                throw new NotFoundException(typeof(Domain.Entities.News).Name);

            _emiratesUnitOfWork.News.Remove(news);
            if (_emiratesUnitOfWork.Complete() > 0)
                _fileManagerService.Delete(new DeleteFileDto
                {
                    CategueryName = SystemEnums.FileCateguery.News,
                    Name = news.ImageName
                });
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }

    }
}
