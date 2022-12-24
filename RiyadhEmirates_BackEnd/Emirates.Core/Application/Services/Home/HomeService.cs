using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Services.FileManagers;
using Emirates.Core.Application.Shared;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace Emirates.Core.Application.Services.Home
{
    public class HomeService : BaseService, IHomeService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        private readonly IFileManagerService _fileManagerService;

        public HomeService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper, 
            IFileManagerService fileManagerService)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
            _fileManagerService = fileManagerService;
        }

        public IApiResponse GetCounts()
        {
            var response = new HomeCountsDto
            {
                UserCount = _emiratesUnitOfWork.Users.Count(),
                ServiceCount = _emiratesUnitOfWork.Services.Where(x => x.IsActive).Count(),
                RequestCount = _emiratesUnitOfWork.Requests.Where(x => x.StageId != (int)SystemEnums.Stages.Draft).Count(),
                RateCount = _emiratesUnitOfWork.ServiceRates.Count()
            };
            return GetResponse(data: response);
        }
        public IApiResponse CreateDesignEvaluation(CreateDesignEvaluationDto createDto)
        {
            var addedModel = _emiratesUnitOfWork.DesignEvaluations.Add(_mapper.Map<DesignEvaluation>(createDto));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse GetAllServices()
        {
            var services = _emiratesUnitOfWork.Services.Where(l => l.IsActive).Include(x => x.Requests);
            var serviceMapped = _mapper.Map<List<GetAllServiceListDto>>(services);
            return GetResponse(data: serviceMapped.OrderByDescending(r => r.RequestCount).ToList());
        }

        #region News
        public IApiResponse GetNewsSearch(string filter)
        {
            var newsResult = _emiratesUnitOfWork.News.Where(x => x.IsActive &&
            (x.Title.Contains(filter) || x.Content.Contains(filter) || x.NewsOrigin.Contains(filter) ||
             x.NewsCateguery.NameAr.Contains(filter) || x.NewsCateguery.NameEn.Contains(filter))).Select(model =>
                new GetNewsSearchListDto
                {
                    Id = model.Id,
                    Title = model.Title,
                    Content = model.Content,
                    Date = model.Date,
                    NewsTypeId = model.NewsTypeId,
                    ImageName = model.ImageName
                });
            return GetResponse(data: newsResult.ToList());
        }
        public IApiResponse GetAllNews(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.News.GetQueryable().Where(x => x.IsActive)
               .ProjectTo<GetNewsListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetNewsListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetTop5NewsByLang(bool isArabic = true)
        {
            var newsResult = _emiratesUnitOfWork.News.Where(x => x.IsActive && x.IsArabic == isArabic).Select(model =>
                new GetNewsSearchListDto
                {
                    Id = model.Id,
                    Title = model.Title,
                    Content = model.Content,
                    Date = model.Date,
                    NewsTypeId = model.NewsTypeId,
                    ImageName = model.ImageName
                }).ToList();

            var latest = newsResult.Where(x => x.NewsTypeId.Equals((int)SystemEnums.NewsTypes.LatestNews)).OrderByDescending(d => d.Date).Take(5);
            var governorate = newsResult.Where(x => x.NewsTypeId.Equals((int)SystemEnums.NewsTypes.GovernorateNews)).OrderByDescending(d => d.Date).Take(5);
            var reports = newsResult.Where(x => x.NewsTypeId.Equals((int)SystemEnums.NewsTypes.Reports)).OrderByDescending(d => d.Date).Take(5);
            return GetResponse(data: latest.Concat(governorate).Concat(reports).ToList());
        }
        #endregion
    }
}
