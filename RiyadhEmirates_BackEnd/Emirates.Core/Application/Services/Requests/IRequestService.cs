using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.Requests
{
    public interface IRequestService
    {
        IApiResponse GetById(Guid id);
        IApiResponse ChangeStage(RequestChangeStageDto changeStageDto);
        IApiResponse ChangeStageAdmin(RequestChangeStageDto changeStageDto);

        IApiResponse GetAttachments(Guid id);
        IApiResponse GetRequestAttachments(Guid id);
        IApiResponse GetRequestStageLogs(Guid id);

        IApiResponse MyRequests(SearchModel searchModel);
        IApiResponse Inbox(SearchModel searchModel);

        IApiResponse GetElectronicCouncilRequests(SearchModel searchModel);
        IApiResponse InboxShamel(SearchModel searchModel);
        IApiResponse RequestSearch(SearchModel searchModel);
        IApiResponse GetRequestSmsData(Guid id);
    }
}
