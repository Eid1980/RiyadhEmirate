using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.News
{
    public interface INewsService
    {
        IApiResponse GetById(int id);
        IApiResponse GetByNewsTypeId(int typeId);
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse GetAll();
        IApiResponse Create(CreateNewsDto createModel);
        IApiResponse Update(UpdateNewsDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse Delete(int id);
    }
}
