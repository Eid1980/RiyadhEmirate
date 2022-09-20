using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.DynamicSearch;
using Emirates.Core.Application.Helpers;
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

        public IApiResponse GetById(int id)
        {
            var latestNewsComment = _emiratesUnitOfWork.LatestNewsComments.FirstOrDefault(n => n.Id == id, x => x.CommentStage);
            if (latestNewsComment == null)
                throw new NotFoundException(typeof(LatestNewsComment).Name);
            return GetResponse(data: _mapper.Map<GetLatestNewsCommentDetailsDto>(latestNewsComment));
        }
        public IApiResponse GetByLatestNewsId(int latestNewsId)
        {
            var latestNewsComments = _emiratesUnitOfWork.LatestNewsComments.Where(l => l.LatestNewsId.Equals(latestNewsId) && l.CommentStageId.Equals((int)SystemEnums.CommentStages.Approved)).OrderBy(x => x.CreatedDate).ToList();
            var mappedModel = _mapper.Map<List<GetLatestNewsCommentListDto>>(latestNewsComments);
            return GetResponse(data: mappedModel);
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.LatestNewsComments.GetQueryable()
               .ProjectTo<GetLatestNewsCommentListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetLatestNewsCommentListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }

        public IApiResponse Create(CreateLatestNewsCommentDto createModel)
        {
            var addedModel = _emiratesUnitOfWork.LatestNewsComments.Add(_mapper.Map<LatestNewsComment>(createModel));
            addedModel.CommentStageId = (int)SystemEnums.CommentStages.New;
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.MsgSuccess("تم اضافة التعليق بنجاح وسيتم عرضة بعد الموافقة عليه من قبل مدير النظام"), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateLatestNewsCommentDto updateModel)
        {
            var latestNewsComment = _emiratesUnitOfWork.LatestNewsComments.FirstOrDefault(n => n.Id == updateModel.Id);
            if (latestNewsComment == null)
                throw new NotFoundException(typeof(LatestNewsComment).Name);

            latestNewsComment.CommentStageId = updateModel.CommentStageId;
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse Delete(int id)
        {
            var latestNewsComment = _emiratesUnitOfWork.LatestNewsComments.FirstOrDefault(n => n.Id == id);
            if (latestNewsComment == null)
                throw new NotFoundException(typeof(LatestNewsComment).Name);

            _emiratesUnitOfWork.LatestNewsComments.Remove(latestNewsComment);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
