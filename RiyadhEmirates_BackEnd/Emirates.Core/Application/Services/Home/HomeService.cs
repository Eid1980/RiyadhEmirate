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

        #region Statistics
        public IApiResponse GetStatistics()
        {
            List<ChartColors> colors = FillColorList();
            var serviceRequests = _emiratesUnitOfWork.Services.Where(x => x.IsActive).Include(x => x.Requests).ToList().Select((model, i) =>
                new GetRequestStatisticsDto
                {
                    Id = model.Id,
                    Name = model.NameAr,
                    Count = model.Requests.Count,
                    BackGroungColor = colors[i].BackGroungColor,
                    BorderColor = colors[i].BorderColor
                }).ToList();

            var stageRequests = _emiratesUnitOfWork.Stages.Where(x => x.IsActive).Include(x => x.Requests).ToList().Select((model, i) =>
                new GetRequestStatisticsDto
                {
                    Name = model.NameAr,
                    Count = model.Requests.Count,
                    BackGroungColor = colors[i].BackGroungColor,
                    BorderColor = colors[i].BorderColor
                }).ToList();
            var governorateRequests = (from governorate in _emiratesUnitOfWork.Governorates.GetQueryable()
                                       join user in _emiratesUnitOfWork.Users.GetQueryable() on governorate.Id equals user.GovernorateId into all
                                       from leftUser in all.DefaultIfEmpty()
                                       where governorate.IsActive
                                       select new GetRequestStatisticsDto
                                       {
                                           Name = governorate.NameAr,
                                           Count = leftUser.CreatedRequests.Count
                                       }).ToList();

            var requests = _emiratesUnitOfWork.Requests.Where(x => x.Service.IsActive && x.Stage.IsActive).Include(x => x.CreatedUser).Select(model =>
                new
                {
                    ServiceId = model.ServiceId,
                    StageId = model.StageId
                }).ToList();

            var serviceStageRequestStatistics = GetServiceStageRequestStatistics(serviceRequests);
            serviceStageRequestStatistics.Labels = stageRequests.Select(n => n.Name).ToList();

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
                StageRequests = stageRequests,
                GovernorateRequests = governorateRequests,
                ServiceStageRequestStatistics = serviceStageRequestStatistics
            };
            return GetResponse(data: statistics);
        }

        private ServiceStageRequestStatistics GetServiceStageRequestStatistics(List<GetRequestStatisticsDto> requestStatisticsDto)
        {
            var serviceStageRequestStatisticsDatasets = new List<ServiceStageRequestStatisticsDatasets>();
            foreach (var item in requestStatisticsDto)
            {
                serviceStageRequestStatisticsDatasets.Add(new ServiceStageRequestStatisticsDatasets
                {
                    Label = item.Name,
                    Data = _emiratesUnitOfWork.Stages.Include(x => x.Requests)
                    .Select(model => model.Requests.Where(x => x.ServiceId == item.Id).Count()).ToList(),
                    Fill = true,
                    BackgroundColor = item.BackGroungColor,
                    BorderColor = item.BorderColor,
                    PointBackgroundColor = item.BorderColor,
                    PointBorderColor = "#fff",
                    PointHoverBackgroundColor = "#fff",
                    PointHoverBorderColor = item.BorderColor
                });
            }

            return new ServiceStageRequestStatistics
            {
                Datasets = serviceStageRequestStatisticsDatasets
            };
        }

        private List<ChartColors> FillColorList()
        {
            List<ChartColors> lst = new List<ChartColors>();
            // أخضر فاتح
            lst.Add(new ChartColors
            {
                BackGroungColor = "#a0eabf",
                BorderColor = "#2d4436"
            });
            // Blue Dark
            lst.Add(new ChartColors
            {
                BackGroungColor = "#003462",
                BorderColor = "#102d3d"
            });
            // سماوي غامق
            lst.Add(new ChartColors
            {
                BackGroungColor = "#1a6312",
                BorderColor = "#116778"
            });
            // أحمر طوبي
            lst.Add(new ChartColors
            {
                BackGroungColor = "#d45d3f",
                BorderColor = "#873926"
            });
            // برتقالي غامق
            lst.Add(new ChartColors
            {
                BackGroungColor = "#d19852",
                BorderColor = "#825e31"
            });
            // بنفسجي غامق
            lst.Add(new ChartColors
            {
                BackGroungColor = "#8127db",
                BorderColor = "#4b1680"
            });
            // أصفر
            lst.Add(new ChartColors
            {
                BackGroungColor = "#eef26d",
                BorderColor = "#aaad4c"
            });
            // وردي
            lst.Add(new ChartColors
            {
                BackGroungColor = "#fa46af",
                BorderColor = "#942867"
            });
            // أصفر ليموني
            lst.Add(new ChartColors
            {
                BackGroungColor = "#cfc44e",
                BorderColor = "#948c37"
            });
            // أخضر غامق
            lst.Add(new ChartColors
            {
                BackGroungColor = "#2a941e",
                BorderColor = "#1a6312"
            });
            // أزرق غامق
            lst.Add(new ChartColors
            {
                BackGroungColor = "#2c63d1",
                BorderColor = "#183673"
            });
            return lst;
        }
        private ChartColors GenerateColor(List<ChartColors> lstColors)
        {
            Random _random = new Random();
            int i = _random.Next(0, lstColors.Count);
            return lstColors[i];
        }
        #endregion	
    }
}
