using AutoMapper;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.DynamicSearch;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.InternalPortal.FileManager;
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
            var news = _emiratesUnitOfWork.News.FirstOrDefault(l => l.Id.Equals(id));
            if (news == null)
                throw new NotFoundException(typeof(Domain.Entities.News).Name);
            var mappedModel = _mapper.Map<GetNewsDetailsDto>(news);
            mappedModel.Image = _fileManagerService.GetBase64File(id, "News");
            return GetResponse(data: mappedModel);
        }

        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.News.GetQueryable()
                .Select(news => new GetNewsListDto()
                {
                    Id = news.Id,
                    TitleAr = news.TitleAr,
                    TitleEn = news.TitleEn,
                    DescriptionAr = news.DescriptionAr,
                    DescriptionEn = news.DescriptionEn,
                    NewsTypeId = news.NewsTypeId,
                    Date = news.Date,
                    IsActive = news.IsActive,

                    Image = _fileManagerService.GetBase64File(news.Id, "News")
                })

                .OrderByDescending(s => s.Date)
                .DynamicSearch(searchModel)
                .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetNewsListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }

        public IApiResponse GetByNewsTypeId(int typeId)
        {
            var newsQuerable = _emiratesUnitOfWork.News.GetQueryable();
            var filesQuerable = _emiratesUnitOfWork.UploadedFiles.GetQueryable();
            var query = (from news in newsQuerable
                         join files in filesQuerable on news.Id.ToString() equals files.EntityId
                         where files.EntityName == "News" && news.IsActive == true && news.NewsTypeId == typeId
                         select new GetNewsListDto
                         {
                             Id = news.Id,
                             TitleAr = news.TitleAr,
                             TitleEn = news.TitleEn,
                             DescriptionAr = news.DescriptionAr,
                             DescriptionEn = news.DescriptionEn,
                             NewsTypeId = news.NewsTypeId,
                             Date = news.Date,
                             IsActive = news.IsActive,

                             Image = _fileManagerService.GetBase64File(news.Id, "News")
                         }).OrderByDescending(s => s.Date);

            return GetResponse(data: query);
        }

        public IApiResponse GetAll()
        {
            var newsQuerable = _emiratesUnitOfWork.News.GetQueryable();
            var filesQuerable = _emiratesUnitOfWork.UploadedFiles.GetQueryable();
            var query = (from news in newsQuerable
                         join files in filesQuerable on news.Id.ToString() equals files.EntityId
                         where files.EntityName == "News" && news.IsActive == true
                         select new GetNewsListDto
                         {
                             Id = news.Id,
                             TitleAr = news.TitleAr,
                             TitleEn = news.TitleEn,
                             DescriptionAr = news.DescriptionAr,
                             DescriptionEn = news.DescriptionEn,
                             NewsTypeId = news.NewsTypeId,
                             Date = news.Date,
                             IsActive = news.IsActive,
                             Image = _fileManagerService.GetBase64File(news.Id, "News")
                         }).OrderByDescending(s => s.Date);

            return GetResponse(data: query);
        }

        public IApiResponse Create(CreateNewsDto createModel)
        {
            var addedModel = _emiratesUnitOfWork.News.Add(_mapper.Map<Domain.Entities.News>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }

        public IApiResponse Update(UpdateNewsDto updateModel)
        {
            try 
            {
                var caseType = _emiratesUnitOfWork.News.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
                if (caseType == null)
                    throw new NotFoundException(typeof(Domain.Entities.News).Name);

                _emiratesUnitOfWork.News.Update(caseType, _mapper.Map<Domain.Entities.News>(updateModel));
                _emiratesUnitOfWork.Complete();
                return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
            }
            catch (Exception ex) 
            {
                // TODO 
                // log the exception
                return null;
            }
           
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

        public IApiResponse Delete(int id)
        {
            var news = _emiratesUnitOfWork.News.FirstOrDefault(n => n.Id == id);
            if (news == null)
                throw new NotFoundException(typeof(Domain.Entities.News).Name);

            _emiratesUnitOfWork.News.Remove(news);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
