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

namespace Emirates.Core.Application.Services.Auctions
{
    public class AuctionService : BaseService, IAuctionService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public AuctionService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var auction = _emiratesUnitOfWork.Auctions.FirstOrDefault(l => l.Id.Equals(id));
            if (auction == null)
                throw new NotFoundException(typeof(Auction).Name);
            return GetResponse(data: _mapper.Map<GetAuctionDetailsDto>(auction));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.Auctions.GetQueryable()
               .ProjectTo<GetAuctionListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetAuctionListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var Auctions = _emiratesUnitOfWork.Auctions.Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetAuctionListDto>>(Auctions));
        }

        public IApiResponse Create(CreateAuctionDto createModel)
        {
            var addedModel = _emiratesUnitOfWork.Auctions.Add(_mapper.Map<Auction>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateAuctionDto updateModel)
        {
            var auction = _emiratesUnitOfWork.Auctions.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (auction == null)
                throw new NotFoundException(typeof(Auction).Name);

            _emiratesUnitOfWork.Auctions.Update(auction, _mapper.Map<Auction>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var auction = _emiratesUnitOfWork.Auctions.FirstOrDefault(n => n.Id == id);
            if (auction == null)
                throw new NotFoundException(typeof(Auction).Name);

            auction.IsActive = !auction.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var auction = _emiratesUnitOfWork.Auctions.FirstOrDefault(n => n.Id == id);
            if (auction == null)
                throw new NotFoundException(typeof(Auction).Name);
            _emiratesUnitOfWork.Auctions.Remove(auction);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
