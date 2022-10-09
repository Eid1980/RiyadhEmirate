using AutoMapper;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Helpers;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.FileManagers;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Emirates.Core.Application.Services.Home
{
    public class HomeService : BaseService, IHomeService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileManagerService _fileManagerService;

        public HomeService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper, 
            IFileManagerService fileManagerService)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
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
            var servicesQuerable = _emiratesUnitOfWork.Services.GetQueryable();
            var query = (from service in servicesQuerable
                        where service.IsActive
                        select new GetAllServiceListDto
                        {
                            Id = service.Id,
                            NameAr = service.NameAr,
                            NameEn = service.NameEn,
                            DescriptionAr = service.DescriptionAr,
                            DescriptionEn = service.DescriptionEn,
                            RequestLink = service.RequestLink,
                            IsExternal = service.IsExternal,
                            RequestCount = service.Requests.Count,
                            Image = _fileManagerService.GetBase64File(service.Id, "Services")
                        }).OrderByDescending(r => r.RequestCount);
            return GetResponse(data: query.ToList());
        }
        public IApiResponse GetNewsSearch(string filter)
        {
            var newsResult = _emiratesUnitOfWork.News.GetQueryable().Where(x =>
            x.TitleAr.Contains(filter) || x.TitleEn.Contains(filter) ||
            x.DescriptionAr.Contains(filter) || x.DescriptionEn.Contains(filter)).Select(model=>
            new GetNewsSearchListDto
            {
                Id = model.Id,
                Title = model.TitleAr,
                Description = model.DescriptionAr,
                Date = model.Date.ToString("yyyy-MM-dd"),
                IsLatestNews = false,
                Image = _fileManagerService.GetBase64File(model.Id, "News"),
            }).ToList();

            var latestResult = _emiratesUnitOfWork.LatestNews.GetQueryable().Where(x =>
            x.Title.Contains(filter) || x.Content.Contains(filter) || x.NewsOrigin.Contains(filter) || 
            x.NewsCateguery.NameAr.Contains(filter) || x.NewsCateguery.NameEn.Contains(filter)).Select(model =>
            new GetNewsSearchListDto
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Content,
                Date = model.Date.ToString("yyyy-MM-dd"),
                IsLatestNews = true,
                Image = _fileManagerService.GetBase64File(model.Id, "LatestNews"),
            }).ToList();
            return GetResponse(data: newsResult.Concat(latestResult).ToList());
        }
    }
}
