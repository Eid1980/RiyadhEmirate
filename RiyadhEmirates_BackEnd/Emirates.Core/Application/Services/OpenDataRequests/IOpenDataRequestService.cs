using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.OpenDataRequests
{
    public interface IOpenDataRequestService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateOpenDataRequestDto createModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse Delete(int id);
    }
}
