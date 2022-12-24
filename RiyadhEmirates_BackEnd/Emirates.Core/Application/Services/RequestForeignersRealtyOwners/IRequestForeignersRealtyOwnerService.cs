using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.RequestForeignersRealtyOwners
{
    public interface IRequestForeignersRealtyOwnerService
    {
        IApiResponse GetById(Guid id);
        IApiResponse GetDetailsById(Guid id);
        IApiResponse Create(CreateRequestForeignersRealtyOwnerDto createModel);
        IApiResponse Update(UpdateRequestForeignersRealtyOwnerDto updateModel);
    }
}
