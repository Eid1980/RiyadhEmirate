using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;

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
