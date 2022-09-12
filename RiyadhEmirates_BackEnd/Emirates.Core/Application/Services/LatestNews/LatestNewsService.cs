using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.DynamicSearch;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.InternalPortal.FileManager;
using Emirates.Core.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
namespace Emirates.Core.Application.Services.LatestNews
{
    public class LatestNewsService : BaseService, ILatestNewsService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        private readonly IFileManagerService _fileManagerService;
        public LatestNewsService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper, IFileManagerService fileManagerService)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
            _fileManagerService = fileManagerService;
        }

        public IApiResponse GetById(int id)
        {
            var latestNews = _emiratesUnitOfWork.LatestNews.FirstOrDefault(l => l.Id.Equals(id),includes: x => x.NewsCateguery);
            if (latestNews == null)
                throw new NotFoundException(typeof(Domain.Entities.LatestNews).Name);
            var mappedModel = _mapper.Map<GetLatestNewsDetailsDto>(latestNews);
            mappedModel.Image = _fileManagerService.GetBase64File(id, "LatestNews");
            return GetResponse(data: mappedModel);
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {

            var serchResult = _emiratesUnitOfWork.LatestNews.GetQueryable()
               .ProjectTo<GetLatestNewsListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetLatestNewsListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });

            ////searchModel.OrderBy = ""
            //var serchResult = _emiratesUnitOfWork.LatestNews.Include(x => x.NewsCateguery).ToList()
            //    .Select(latestNews => new GetLatestNewsListDto()
            //    {
            //        Id = latestNews.Id,
            //        Title = latestNews.Title,
            //        Content = latestNews.Content,
            //        NewsCategueryName = latestNews.NewsCateguery.NameAr,
            //        NewsOrigin = latestNews.NewsOrigin,
            //        Date = latestNews.Date,
            //        OpenComments = latestNews.OpenComments,
            //        Image = _fileManagerService.GetBase64File(latestNews.Id, "LatestNews")
            //    }).AsQueryable()
            //    .DynamicSearch(searchModel)
            //    .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            //return GetResponse(data: new ListPageModel<GetLatestNewsListDto>
            //{
            //    GridItemsVM = serchResult,
            //    PagingMetaData = serchResult.GetMetaData()
            //});
        }
        public IApiResponse GetByLang(bool isArabic = true)
        {
            var latestNewsQuerable = _emiratesUnitOfWork.LatestNews.GetQueryable().Where(x => x.IsActive).Include(x => x.NewsCateguery);
            var filesQuerable = _emiratesUnitOfWork.UploadedFiles.GetQueryable();
            var query = (from latestNews in latestNewsQuerable
                         join files in filesQuerable on latestNews.Id.ToString() equals files.EntityId
                         where files.EntityName == "LatestNews" && latestNews.IsArabic == isArabic
                         select new GetLatestNewsListDto
                         {
                             Id = latestNews.Id,
                             Title = latestNews.Title,
                             Content = latestNews.Content,
                             NewsCategueryName = latestNews.NewsCateguery.NameAr,
                             NewsOrigin = latestNews.NewsOrigin,
                             Date = latestNews.Date,
                             OpenComments = latestNews.OpenComments,
                             Image = _fileManagerService.GetBase64File(latestNews.Id, "LatestNews")
                         }).OrderByDescending(s => s.Date);
            return GetResponse(data: query);
        }
        public IApiResponse GetByLangTop5(bool isArabic = true)
        {
            var latestNewsQuerable = _emiratesUnitOfWork.LatestNews.GetQueryable().Where(x => x.IsActive).OrderByDescending(s => s.Date).Take(5).Include(x => x.NewsCateguery);
            var filesQuerable = _emiratesUnitOfWork.UploadedFiles.GetQueryable();
            var query = (from latestNews in latestNewsQuerable
                         join files in filesQuerable on latestNews.Id.ToString() equals files.EntityId
                         where files.EntityName == "LatestNews" && latestNews.IsArabic == isArabic
                         select new GetLatestNewsListDto
                         {
                             Id = latestNews.Id,
                             Title = latestNews.Title,
                             Content = latestNews.Content,
                             NewsCategueryName = latestNews.NewsCateguery.NameAr,
                             NewsOrigin = latestNews.NewsOrigin,
                             Date = latestNews.Date,
                             OpenComments = latestNews.OpenComments,
                             Image = _fileManagerService.GetBase64File(latestNews.Id, "LatestNews")
                         });
            return GetResponse(data: query);
        }

        public IApiResponse GetAll()
        {
            var latestNewsQuerable = _emiratesUnitOfWork.LatestNews.GetQueryable().Where(x => x.IsActive).Include(x => x.NewsCateguery);
            var filesQuerable = _emiratesUnitOfWork.UploadedFiles.GetQueryable();
            var query = (from latestNews in latestNewsQuerable
                         join files in filesQuerable on latestNews.Id.ToString() equals files.EntityId
                         where files.EntityName == "LatestNews"
                         select new GetLatestNewsListDto
                         {
                             Id = latestNews.Id,
                             Title = latestNews.Title,
                             Content = latestNews.Content,
                             NewsCategueryName = latestNews.NewsCateguery.NameAr,
                             NewsOrigin = latestNews.NewsOrigin,
                             Date = latestNews.Date,
                             OpenComments = latestNews.OpenComments,
                             Image = _fileManagerService.GetBase64File(latestNews.Id, "LatestNews")
                         }).OrderByDescending(s => s.Date);
            return GetResponse(data: query);
        }

        public IApiResponse Create(CreateLatestNewsDto createModel)
        {
            var addedModel = _emiratesUnitOfWork.LatestNews.Add(_mapper.Map<Domain.Entities.LatestNews>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateLatestNewsDto updateModel)
        {
            var latestNews = _emiratesUnitOfWork.LatestNews.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (latestNews == null)
                throw new NotFoundException(typeof(Domain.Entities.LatestNews).Name);

            _emiratesUnitOfWork.LatestNews.Update(latestNews, _mapper.Map<Domain.Entities.LatestNews>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var latestNews = _emiratesUnitOfWork.LatestNews.FirstOrDefault(n => n.Id == id);
            if (latestNews == null)
                throw new NotFoundException(typeof(Domain.Entities.LatestNews).Name);

            latestNews.IsActive = !latestNews.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse ChangecommentStatus(int id)
        {
            var latestNews = _emiratesUnitOfWork.LatestNews.FirstOrDefault(n => n.Id == id);
            if (latestNews == null)
                throw new NotFoundException(typeof(Domain.Entities.LatestNews).Name);

            latestNews.OpenComments = !latestNews.OpenComments;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var latestNews = _emiratesUnitOfWork.LatestNews.FirstOrDefault(n => n.Id == id);
            if (latestNews == null)
                throw new NotFoundException(typeof(Domain.Entities.LatestNews).Name);

            _emiratesUnitOfWork.LatestNews.Remove(latestNews);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
