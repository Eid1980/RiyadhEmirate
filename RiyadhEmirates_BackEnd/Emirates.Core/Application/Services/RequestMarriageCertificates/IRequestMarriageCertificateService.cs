using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Shared;

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
