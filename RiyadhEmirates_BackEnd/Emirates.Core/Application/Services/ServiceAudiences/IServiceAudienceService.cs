using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.ServiceAudiences
{
    public interface IServiceAudienceService
    {
        IApiResponse GetByServiceId(int serviceId);
        IApiResponse GetCheckedAudience(int serviceId);
        IApiResponse Create(CreateServiceAudienceDto createModel);
        IApiResponse Delete(int id);
    }
}
