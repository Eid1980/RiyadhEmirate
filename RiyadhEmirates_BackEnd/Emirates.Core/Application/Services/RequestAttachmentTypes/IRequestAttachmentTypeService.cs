using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.RequestAttachmentTypes
{
    public interface IRequestAttachmentTypeService
    {
        IApiResponse GetById(int id);
        IApiResponse GetByServiceId(int serviceId);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateRequestAttachmentTypeDto createModel);
        IApiResponse Update(UpdateRequestAttachmentTypeDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse ChangeRequire(int id);
    }
}
