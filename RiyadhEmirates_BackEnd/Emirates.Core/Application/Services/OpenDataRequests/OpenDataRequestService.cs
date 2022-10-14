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

namespace Emirates.Core.Application.Services.OpenDataRequests
{
    public class OpenDataRequestService : BaseService, IOpenDataRequestService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public OpenDataRequestService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var openDataRequest = _emiratesUnitOfWork.OpenDataRequests.FirstOrDefault(l => l.Id.Equals(id));
            if (openDataRequest == null)
                throw new NotFoundException(typeof(OpenDataRequest).Name);
            return GetResponse(data: _mapper.Map<GetOpenDataRequestDetailsDto>(openDataRequest));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.OpenDataRequests.GetQueryable()
               .ProjectTo<GetOpenDataRequestListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetOpenDataRequestListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }

        public IApiResponse Create(CreateOpenDataRequestDto createModel)
        {
            var addedModel = _emiratesUnitOfWork.OpenDataRequests.Add(_mapper.Map<OpenDataRequest>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var openDataRequest = _emiratesUnitOfWork.OpenDataRequests.FirstOrDefault(n => n.Id == id);
            if (openDataRequest == null)
                throw new NotFoundException(typeof(OpenDataRequest).Name);

            openDataRequest.IsReplied = !openDataRequest.IsReplied;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var openDataRequest = _emiratesUnitOfWork.OpenDataRequests.FirstOrDefault(n => n.Id == id);
            if (openDataRequest == null)
                throw new NotFoundException(typeof(OpenDataRequest).Name);

            _emiratesUnitOfWork.OpenDataRequests.Remove(openDataRequest);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
