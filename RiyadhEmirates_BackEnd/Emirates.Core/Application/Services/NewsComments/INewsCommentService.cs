using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.NewsComments
{
    public interface INewsCommentService
    {
        IApiResponse GetById(int id);
        IApiResponse GetByNewsId(int latestNewsId);
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateNewsCommentDto createModel);
        IApiResponse Update(UpdateNewsCommentDto updateModel);
        IApiResponse Delete(int id);

    }
}
