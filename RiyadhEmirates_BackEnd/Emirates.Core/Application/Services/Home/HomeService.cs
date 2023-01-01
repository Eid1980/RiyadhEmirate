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

        public HomeService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
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

        public IApiResponse GetStatistics()
        {
            var requests = _emiratesUnitOfWork.Requests.Include(x => x.CreatedUser).Select(model =>
            new
            {
                ServiceId = model.ServiceId,
                StageId = model.StageId
            }).ToList();

            var serviceRequests = _emiratesUnitOfWork.Services.Include(x => x.Requests).Select(model =>
            new GetRequestStatisticsDto
            {
                Name = model.NameAr,
                Count = model.Requests.Count
            }).ToList();
            var stageRequests = _emiratesUnitOfWork.Stages.Include(x => x.Requests).Select(model =>
            new GetRequestStatisticsDto
            {
                Name = model.NameAr,
                Count = model.Requests.Count,
                backgroundColor = 
            }).ToList();



            var statistics = new GetStatisticsDto
            {
                UserCount = _emiratesUnitOfWork.Users.Count(),
                RequestCount = requests.Where(x => x.StageId != (int)SystemEnums.Stages.Draft).Count(),
                RequestElectronicBoardsCount  = requests.Where(x => x.ServiceId == (int)SystemEnums.Services.ElectronicBoard).Count(),
                RequestFinishedCount  = requests.Where(x => x.StageId == (int)SystemEnums.Stages.UnderProcessing ||
                                                 x.StageId == (int)SystemEnums.Stages.RequestRejectedFromAdmin ||
                                                 x.StageId == (int)SystemEnums.Stages.RequestRejected ||
                                                 x.StageId == (int)SystemEnums.Stages.RequestApproved).Count(),
                ServiceRequests = serviceRequests,
                StageRequests = stageRequests
            };
            return GetResponse(data: statistics);
        }

        //rgb(46, 71, 52)  Dark green
        //rgb(124, 201, 109)  green
        //rgb(212, 165, 23)  orange
        //rgb(212, 23, 212)  purpule
        //rgb(23, 105, 212)  blue
        //rgb(16, 141, 163)  sky
        //rgb(30, 39, 138)  dark blue
        //rgb(142, 235, 138)  white green
        //rgb(146, 158, 8)  limon
        //rgb(97, 5, 72)  bazegan
    }
}
