using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.Roles
{
    public interface IRoleService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateRoleDto createModel);
        IApiResponse Update(UpdateRoleDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse Delete(int id);
        IApiResponse GetLookupList();
    }
}
