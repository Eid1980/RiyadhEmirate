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

namespace Emirates.Core.Application.Services.NewsComments
{
    public class NewsCommentService : BaseService, INewsCommentService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public NewsCommentService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var latestNewsComment = _emiratesUnitOfWork.NewsComments.FirstOrDefault(n => n.Id == id, x => x.CommentStage, x => x.News);
            if (latestNewsComment == null)
                throw new NotFoundException(typeof(NewsComment).Name);
            return GetResponse(data: _mapper.Map<GetNewsCommentDetailsDto>(latestNewsComment));
        }
        public IApiResponse GetByNewsId(int latestNewsId)
        {
            var latestNewsComments = _emiratesUnitOfWork.NewsComments.Where(l => l.NewsId.Equals(latestNewsId) && l.CommentStageId.Equals((int)SystemEnums.CommentStages.Approved)).OrderBy(x => x.CreatedDate).ToList();
            var mappedModel = _mapper.Map<List<GetNewsCommentListDto>>(latestNewsComments);
            return GetResponse(data: mappedModel);
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.NewsComments.GetQueryable()
               .ProjectTo<GetNewsCommentListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetNewsCommentListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }

        public IApiResponse Create(CreateNewsCommentDto createModel)
        {
            var addedModel = _emiratesUnitOfWork.NewsComments.Add(_mapper.Map<NewsComment>(createModel));
            addedModel.CommentStageId = (int)SystemEnums.CommentStages.New;
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.MsgSuccess("تم اضافة التعليق بنجاح وسيتم عرضة بعد الموافقة عليه من قبل مدير النظام"), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateNewsCommentDto updateModel)
        {
            var latestNewsComment = _emiratesUnitOfWork.NewsComments.FirstOrDefault(n => n.Id == updateModel.Id);
            if (latestNewsComment == null)
                throw new NotFoundException(typeof(NewsComment).Name);

            latestNewsComment.CommentStageId = updateModel.CommentStageId;
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse Delete(int id)
        {
            var latestNewsComment = _emiratesUnitOfWork.NewsComments.FirstOrDefault(n => n.Id == id);
            if (latestNewsComment == null)
                throw new NotFoundException(typeof(NewsComment).Name);

            _emiratesUnitOfWork.NewsComments.Remove(latestNewsComment);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
