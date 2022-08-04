using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.RequestTypes
{
    public interface IRequestTypeService
    {
        IApiResponse GetById(int id);
        IApiResponse GetByServiceId(int serviceId);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateRequestTypeDto createModel);
        IApiResponse Update(UpdateRequestTypeDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse GetLookupList();
        IApiResponse GetLookupListByServiceId(int serviceId);
    }
}
