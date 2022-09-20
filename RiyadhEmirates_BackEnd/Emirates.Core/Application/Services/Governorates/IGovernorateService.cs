using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.Governorates
{
    public interface IGovernorateService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateGovernorateDto createModel);
        IApiResponse Update(UpdateGovernorateDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse Delete(int id);
        IApiResponse GetLookupList();
    }
}
