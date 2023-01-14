using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.Nationalities
{
    public interface INationalityService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateNationalityDto createModel);
        IApiResponse Update(UpdateNationalityDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse Delete(int id);
    }
}
