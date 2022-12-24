using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.RequestPrisonerTempReleases
{
    public interface IRequestPrisonerTempReleaseService
    {
        IApiResponse GetById(Guid id);
        IApiResponse GetDetailsById(Guid id);
        IApiResponse Create(CreateRequestPrisonerTempReleaseDto createModel);
        IApiResponse Update(UpdateRequestPrisonerTempReleaseDto updateModel);
    }
}
