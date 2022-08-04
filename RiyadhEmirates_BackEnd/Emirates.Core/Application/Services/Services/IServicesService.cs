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
        IApiResponse Create(CreateServiceDto createModel);
        IApiResponse Update(UpdateServiceDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse GetLookupList();
        IApiResponse GetStagesLookupList();
    }
}
