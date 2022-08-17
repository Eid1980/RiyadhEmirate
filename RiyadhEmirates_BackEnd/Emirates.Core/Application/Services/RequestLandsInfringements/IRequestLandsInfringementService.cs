using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.RequestLandsInfringements
{
    public interface IRequestLandsInfringementService
    {
        IApiResponse GetById(Guid id);
        IApiResponse GetDetailsById(Guid id);
        IApiResponse Create(CreateRequestLandsInfringementDto createModel);
        IApiResponse Update(UpdateRequestLandsInfringementDto updateModel);
    }
}
