using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.Home
{
    public interface IHomeService
    {
        IApiResponse GetCounts();
        IApiResponse CreateDesignEvaluation(CreateDesignEvaluationDto createDto);
        IApiResponse CreateNewsSubscriper(CreateNewsSubscriperDto createDto);
        IApiResponse GetAllServices();
    }
}
