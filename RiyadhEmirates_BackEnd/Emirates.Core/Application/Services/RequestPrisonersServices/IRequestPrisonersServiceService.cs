using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.RequestPrisonersServices
{
    public interface IRequestPrisonersServiceService
    {
        IApiResponse GetById(Guid id);
        IApiResponse GetDetailsById(Guid id);
        IApiResponse Create(CreateRequestPrisonersServiceDto createModel);
        IApiResponse Update(UpdateRequestPrisonersServiceDto updateModel);
    }
}
