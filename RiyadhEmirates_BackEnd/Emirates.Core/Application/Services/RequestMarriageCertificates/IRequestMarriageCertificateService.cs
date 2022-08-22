using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.RequestMarriageCertificates
{
    public interface IRequestMarriageCertificateService
    {
        IApiResponse GetById(Guid id);
        IApiResponse GetDetailsById(Guid id);
        IApiResponse Create(CreateRequestMarriageCertificateDto createModel);
        IApiResponse Update(UpdateRequestMarriageCertificateDto updateModel);
    }
}
