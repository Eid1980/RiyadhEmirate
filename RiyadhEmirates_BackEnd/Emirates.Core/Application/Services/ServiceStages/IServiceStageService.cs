using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.ServiceStages
{
    public interface IServiceStageService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateServiceStageDto createModel);
        IApiResponse Update(UpdateServiceStageDto updateModel);
        IApiResponse Delete(int id);
    }
}
