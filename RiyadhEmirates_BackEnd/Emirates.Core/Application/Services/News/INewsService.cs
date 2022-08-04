using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.News
{
    public interface INewsService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll(int typeId);
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateNewsDto createModel);
        IApiResponse Update(UpdateNewsDto updateModel);
        IApiResponse ChangeStatus(int id);
    }
}
