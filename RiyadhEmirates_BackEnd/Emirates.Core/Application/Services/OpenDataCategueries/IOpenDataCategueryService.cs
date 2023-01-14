using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.OpenDataCategueries
{
    public interface IOpenDataCategueryService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse GetAllCategoryWithReports();
        IApiResponse Create(CreateOpenDataCategueryDto createModel);
        IApiResponse Update(UpdateOpenDataCategueryDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse Delete(int id);
        IApiResponse GetLookupList();
    }
}
