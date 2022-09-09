using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services
{
    public interface IServicesService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse GetAllServiceGuide(SearchModel searchModel);
        IApiResponse SearchByFilter(string filter);
        IApiResponse Create(CreateServiceDto createModel);
        IApiResponse Update(UpdateServiceDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse Delete(int id);
        IApiResponse GetLookupList();
        IApiResponse GetStagesLookupList();
    }
}
