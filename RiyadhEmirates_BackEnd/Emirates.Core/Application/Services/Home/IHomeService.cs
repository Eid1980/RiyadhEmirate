using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.Home
{
    public interface IHomeService
    {
        IApiResponse GetCounts();
        IApiResponse CreateDesignEvaluation(CreateDesignEvaluationDto createDto);
        IApiResponse GetAllServices();

        IApiResponse GetNewsSearch(string filter);
        IApiResponse GetAllNews(SearchModel searchModel);
        IApiResponse GetTop5NewsByLang(bool isArabic = true);

        IApiResponse GetStatistics();
    }
}
