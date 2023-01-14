using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.ServiceRates;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.ServiceRates
{
    public interface IServiceRateService
    {
        IApiResponse GetByServiceId(int serviceId);
        IApiResponse GetServiceRate(int serviceId);
        IApiResponse GetServiceRateToUser(GetServiceRateToUserRequestDto requestDto);
        IApiResponse CanRate(int serviceId);
        IApiResponse Create(CreateServiceRateDto createModel);
    }
}
