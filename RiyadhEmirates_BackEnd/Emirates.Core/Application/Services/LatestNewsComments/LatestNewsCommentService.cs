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

namespace Emirates.Core.Application.Services.LatestNewsComments
{
    public class LatestNewsCommentService : BaseService, ILatestNewsCommentService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public LatestNewsCommentService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse Create(CreateLatestNewsCommentDto createModel)
        {
            throw new NotImplementedException();
        }

        public IApiResponse Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IApiResponse GetAll(SearchModel searchModel)
        {
            throw new NotImplementedException();
        }

        public IApiResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IApiResponse GetByLatestNewsId(int latestNewsId)
        {
            throw new NotImplementedException();
        }

        public IApiResponse Update(UpdateLatestNewsCommentDto updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
