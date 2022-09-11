using AutoMapper;
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

namespace Emirates.Core.Application.Services.NewsCategueries
{
    public class NewsCategueryService : BaseService, INewsCategueryService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public NewsCategueryService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var newsCateguery = _emiratesUnitOfWork.NewsCategueries.FirstOrDefault(l => l.Id.Equals(id));
            if (newsCateguery == null)
                throw new NotFoundException(typeof(NewsCateguery).Name);
            return GetResponse(data: _mapper.Map<GetNewsCategueryDetailsDto>(newsCateguery));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.NewsCategueries.GetQueryable()
               .ProjectTo<GetNewsCategueryListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetNewsCategueryListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var NewsCategueries = _emiratesUnitOfWork.NewsCategueries.Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetNewsCategueryListDto>>(NewsCategueries));
        }

        public IApiResponse Create(CreateNewsCategueryDto createModel)
        {
            if (_emiratesUnitOfWork.NewsCategueries.Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.NewsCategueries.Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _emiratesUnitOfWork.NewsCategueries.Add(_mapper.Map<NewsCateguery>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateNewsCategueryDto updateModel)
        {
            var newsCateguery = _emiratesUnitOfWork.NewsCategueries.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (newsCateguery == null)
                throw new NotFoundException(typeof(NewsCateguery).Name);

            if (_emiratesUnitOfWork.NewsCategueries.Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.NewsCategueries.Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            _emiratesUnitOfWork.NewsCategueries.Update(newsCateguery, _mapper.Map<NewsCateguery>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var newsCateguery = _emiratesUnitOfWork.NewsCategueries.FirstOrDefault(n => n.Id == id);
            if (newsCateguery == null)
                throw new NotFoundException(typeof(NewsCateguery).Name);

            newsCateguery.IsActive = !newsCateguery.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var newsCateguery = _emiratesUnitOfWork.NewsCategueries.FirstOrDefault(n => n.Id == id, x => x.LatestNews);
            if (newsCateguery == null)
                throw new NotFoundException(typeof(NewsCateguery).Name);
            if (newsCateguery.LatestNews.Count > 0)
                throw new BusinessException("تصنيف الخبر مضاف على أخبار");

            _emiratesUnitOfWork.NewsCategueries.Remove(newsCateguery);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }

        public IApiResponse GetLookupList()
        {
            return GetResponse(data: _emiratesUnitOfWork.NewsCategueries.Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
    }
}
