using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.OpenDataCategueries;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.DynamicSearch;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using X.PagedList;

namespace Emirates.Core.Application.Services.OpenDataCategueries
{
    public class OpenDataCategueryService : BaseService, IOpenDataCategueryService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public OpenDataCategueryService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var openDataCateguery = _emiratesUnitOfWork.OpenDataCategueries.FirstOrDefault(l => l.Id.Equals(id), x => x.OpenDataSubCateguery);
            if (openDataCateguery == null)
                throw new NotFoundException(typeof(OpenDataCateguery).Name);
            return GetResponse(data: _mapper.Map<GetOpenDataCategueryDetailsDto>(openDataCateguery));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.OpenDataCategueries.GetQueryable()
               .ProjectTo<GetOpenDataCategueryListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetOpenDataCategueryListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }

        public IApiResponse GetAllCategoryWithReports()
        {
            SearchModel searchModel = new SearchModel();
            searchModel.PageNumber = 1;
            searchModel.PageSize = 5;

            var result = _emiratesUnitOfWork.OpenDataCategueries.IncludeMultiple(d=> d.OpenDataSubCateguery , d => d.OpenDataReports).Where(c =>c.IsActive == true).ToList()
                .GroupBy(h => new { h.Id, h.NameAr, OpenDataSubCategueryNameAr = h.OpenDataSubCateguery.NameAr}, (key, g) => new
                {
                    key = key,
                    PagingMetaData = g.Select(r => r.OpenDataReports).FirstOrDefault().ToPagedList(searchModel.PageNumber, searchModel.PageSize).GetMetaData(),
                    DataReports = g.Select(r=> r.OpenDataReports).FirstOrDefault().ToPagedList(searchModel.PageNumber, searchModel.PageSize)

                }).ToList();

            return GetResponse(data: result);

        }
        public IApiResponse GetAll()
        {
            var OpenDataCategueries = _emiratesUnitOfWork.OpenDataCategueries.Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetOpenDataCategueryListDto>>(OpenDataCategueries));
        }

        public IApiResponse Create(CreateOpenDataCategueryDto createModel)
        {
            if (_emiratesUnitOfWork.OpenDataCategueries.Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.OpenDataCategueries.Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _emiratesUnitOfWork.OpenDataCategueries.Add(_mapper.Map<OpenDataCateguery>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateOpenDataCategueryDto updateModel)
        {
            var openDataCateguery = _emiratesUnitOfWork.OpenDataCategueries.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (openDataCateguery == null)
                throw new NotFoundException(typeof(OpenDataCateguery).Name);

            if (_emiratesUnitOfWork.OpenDataCategueries.Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.OpenDataCategueries.Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            _emiratesUnitOfWork.OpenDataCategueries.Update(openDataCateguery, _mapper.Map<OpenDataCateguery>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var openDataCateguery = _emiratesUnitOfWork.OpenDataCategueries.FirstOrDefault(n => n.Id == id);
            if (openDataCateguery == null)
                throw new NotFoundException(typeof(OpenDataCateguery).Name);

            openDataCateguery.IsActive = !openDataCateguery.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var openDataCateguery = _emiratesUnitOfWork.OpenDataCategueries.FirstOrDefault(n => n.Id == id, x => x.OpenDataReports);
            if (openDataCateguery == null)
                throw new NotFoundException(typeof(OpenDataCateguery).Name);
            if (openDataCateguery.OpenDataReports.Count > 0)
                throw new BusinessException("هذه المجموعة مرتبطة بملفات");

            _emiratesUnitOfWork.OpenDataCategueries.Remove(openDataCateguery);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }

        public IApiResponse GetLookupList()
        {
            return GetResponse(data: _emiratesUnitOfWork.OpenDataCategueries.Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
    }
}
