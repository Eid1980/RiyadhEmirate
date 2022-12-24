
using Emirates.Core.Application.Dtos.AboutUs;
using Emirates.Core.Application.Dtos.MainPoints;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.AboutUs
{
    public interface IAboutUsService
    {
        IApiResponse GetAll();
        IApiResponse Create(CreateAboutUsDto createModel);
        IApiResponse CreateMainPoint(CreateMainPoints createMainPoint);
        IApiResponse Update(UpdateAboutUsDto updateModel);
        IApiResponse UpdateMainPoint(UpdateMainPoint updateMainPoint);
        IApiResponse DeleteMainPoint(int id);
    }
}
