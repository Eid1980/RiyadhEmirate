using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.LatestNews
{
    public interface ILatestNewsService
    {
        IApiResponse GetById(int id);
        IApiResponse GetByLang(bool isArabic = true);
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse GetAll();
        IApiResponse Create(CreateLatestNewsDto createModel);
        IApiResponse Update(UpdateLatestNewsDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse ChangecommentStatus(int id);
        IApiResponse Delete(int id);
    }
}
