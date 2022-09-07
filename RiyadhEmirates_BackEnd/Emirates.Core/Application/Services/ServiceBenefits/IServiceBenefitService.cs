using Emirates.Core.Application.Dtos.ServiceBenefits;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.ServiceBenefits
{
    public interface IServiceBenefitService
    {
        IApiResponse GetAllCountByServiceId(int serviceId);
        IApiResponse GetBenefitCountByServiceId(int serviceId);
        IApiResponse Create(CreateServiceBenefitDto createModel);
    }
}
