﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.DynamicSearch;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using X.PagedList;

namespace Emirates.Core.Application.Services.OpenDataReports
{
    public class OpenDataReportService : BaseService, IOpenDataReportService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public OpenDataReportService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var openDataReport = _emiratesUnitOfWork.OpenDataReports.FirstOrDefault(l => l.Id.Equals(id));
            if (openDataReport == null)
                throw new NotFoundException(typeof(OpenDataReport).Name);
            return GetResponse(data: _mapper.Map<GetOpenDataReportDetailsDto>(openDataReport));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.OpenDataReports.GetQueryable()
               .ProjectTo<GetOpenDataReportListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetOpenDataReportListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var OpenDataReports = _emiratesUnitOfWork.OpenDataReports.Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetOpenDataReportListDto>>(OpenDataReports));
        }

        public IApiResponse Create(CreateOpenDataReportDto createModel)
        {
            if (_emiratesUnitOfWork.OpenDataReports.Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.OpenDataReports.Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _emiratesUnitOfWork.OpenDataReports.Add(_mapper.Map<OpenDataReport>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateOpenDataReportDto updateModel)
        {
            var openDataReport = _emiratesUnitOfWork.OpenDataReports.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (openDataReport == null)
                throw new NotFoundException(typeof(OpenDataReport).Name);

            if (_emiratesUnitOfWork.OpenDataReports.Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.OpenDataReports.Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            _emiratesUnitOfWork.OpenDataReports.Update(openDataReport, _mapper.Map<OpenDataReport>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var openDataReport = _emiratesUnitOfWork.OpenDataReports.FirstOrDefault(n => n.Id == id);
            if (openDataReport == null)
                throw new NotFoundException(typeof(OpenDataReport).Name);

            openDataReport.IsActive = !openDataReport.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var openDataReport = _emiratesUnitOfWork.OpenDataReports.FirstOrDefault(n => n.Id == id);
            if (openDataReport == null)
                throw new NotFoundException(typeof(OpenDataReport).Name);

            _emiratesUnitOfWork.OpenDataReports.Remove(openDataReport);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}