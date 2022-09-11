using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.LatestNewsComments
{
    public interface ILatestNewsCommentService
    {
        IApiResponse GetById(int id);
        IApiResponse GetByLatestNewsId(int latestNewsId);
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateLatestNewsCommentDto createModel);
        IApiResponse Update(UpdateLatestNewsCommentDto updateModel);
        IApiResponse Delete(int id);

    }
}
