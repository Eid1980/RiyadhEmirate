using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.ServieNotifications
{
    public interface IServieNotificationService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateServieNotificationDto createModel);
        IApiResponse Update(UpdateServieNotificationDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse Delete(int id);
    }
}
