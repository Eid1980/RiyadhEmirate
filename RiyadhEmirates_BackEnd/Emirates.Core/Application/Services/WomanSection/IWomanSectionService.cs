
using Emirates.Core.Application.Dtos.MainPoints;
using Emirates.Core.Application.Dtos.WomanSection;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.WomanSection
{
    public interface IWomanSectionService
    {
        IApiResponse GetAll();
        IApiResponse Create(CreateWomanSectionDto createModel);
        IApiResponse CreateMainPoint(CreateMainPoints createMainPoint);
        IApiResponse Update(UpdateWomanSectionDto updateModel);
        IApiResponse UpdateMainPoint(UpdateMainPoint updateMainPoint);
        IApiResponse DeleteMainPoint(int id);
    }
}
