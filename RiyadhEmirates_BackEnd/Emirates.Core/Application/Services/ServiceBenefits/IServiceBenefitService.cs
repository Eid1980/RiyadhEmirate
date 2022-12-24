using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.ServiceBenefits
{
    public interface IServiceBenefitService
    {
        IApiResponse GetAllCountByServiceId(int serviceId);
        IApiResponse Create(CreateServiceBenefitDto createModel);
    }
}
