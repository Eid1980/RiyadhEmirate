using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.News
{
    public interface INewsService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateNewsDto createModel);
        IApiResponse Update(UpdateNewsDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse ChangecommentStatus(int id);
        IApiResponse Delete(int id);
    }
}
