using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.CaseTypes
{
    public interface ICaseTypeService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateCaseTypeDto createModel);
        IApiResponse Update(UpdateCaseTypeDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse GetLookupList();
    }
}
