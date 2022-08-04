using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.Requests
{
    public interface IRequestService
    {
        IApiResponse GetById(Guid id);
        IApiResponse ChangeStage(RequestChangeStageDto changeStageDto);

        IApiResponse GetAttachments(Guid id);
        IApiResponse GetRequestAttachments(Guid id);
        IApiResponse GetRequestStageLogs(Guid id);

        IApiResponse MyRequests(SearchModel searchModel);
        IApiResponse Inbox(SearchModel searchModel);
    }
}
