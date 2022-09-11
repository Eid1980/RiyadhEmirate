
using Emirates.Core.Application.Dtos.AboutUs;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.WomanSection
{
    public interface IWomanSectionService
    {
        IApiResponse GetAll();
        IApiResponse Create(CreateAboutUsDto createModel);
        IApiResponse Update(UpdateAboutUsDto updateModel);
    }
}
