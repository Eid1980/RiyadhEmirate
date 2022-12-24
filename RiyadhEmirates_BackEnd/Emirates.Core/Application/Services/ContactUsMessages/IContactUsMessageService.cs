using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.ContactUsMessages
{
    public interface IContactUsMessageService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateContactUsMessageDto createModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse Delete(int id);
    }
}
