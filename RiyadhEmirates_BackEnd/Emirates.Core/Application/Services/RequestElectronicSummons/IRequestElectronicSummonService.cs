using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.RequestElectronicSummons
{
    public interface IRequestElectronicSummonService
    {
        IApiResponse GetById(Guid id);
        IApiResponse GetDetailsById(Guid id);
        IApiResponse Create(CreateRequestElectronicSummonDto createModel);
        IApiResponse Update(UpdateRequestElectronicSummonDto updateModel);
    }
}
