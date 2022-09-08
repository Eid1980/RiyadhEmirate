using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.ServiceBenefits
{
    public interface IServiceBenefitService
    {
        IApiResponse GetAllCountByServiceId(int serviceId);
        IApiResponse Create(CreateServiceBenefitDto createModel);
    }
}
