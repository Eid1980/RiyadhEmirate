using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.RequestTreatmentRecommendations
{
    public interface IRequestTreatmentRecommendationService
    {
        IApiResponse GetById(Guid id);
        IApiResponse GetDetailsById(Guid id);
        IApiResponse Create(CreateRequestTreatmentRecommendationDto createModel);
        IApiResponse Update(UpdateRequestTreatmentRecommendationDto updateModel);
    }
}
