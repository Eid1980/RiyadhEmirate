using Emirates.Core.Application.Dtos.Posters;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.Posters
{
    public interface IPosterService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreatePosterDto createModel);
        IApiResponse Update(UpdatePosterDto updateModel);
        IApiResponse ChangeStatus(int id);
    }
}
