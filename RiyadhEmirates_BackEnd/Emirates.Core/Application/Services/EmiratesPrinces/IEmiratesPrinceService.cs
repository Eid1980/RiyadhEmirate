using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.EmiratesPrinces
{
    public interface IEmiratesPrinceService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateEmiratesPrinceDto createModel);
        IApiResponse Update(UpdateEmiratesPrinceDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse Delete(int id);
    }
}
