using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;

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
        IApiResponse GetNotifiedStagesLookupList();
        IApiResponse GetServiceExplainAttachment(int id);
    }
}
