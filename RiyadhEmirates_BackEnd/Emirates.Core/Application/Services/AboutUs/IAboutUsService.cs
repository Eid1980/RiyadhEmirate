
using Emirates.Core.Application.Dtos.AboutUs;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.AboutUs
{
    public interface IAboutUsService
    {
        IApiResponse GetAll();
        IApiResponse Create(CreateAboutUsDto createModel);
        IApiResponse Update(UpdateAboutUsDto updateModel);
    }
}
