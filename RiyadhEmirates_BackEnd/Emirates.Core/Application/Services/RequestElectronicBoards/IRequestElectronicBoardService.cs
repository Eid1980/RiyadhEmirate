using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.RequestElectronicBoards
{
    public interface IRequestElectronicBoardService
    {
        IApiResponse GetById(Guid id);
        IApiResponse GetDetailsById(Guid id);
        IApiResponse Create(CreateRequestElectronicBoardDto createModel);
        IApiResponse Update(UpdateRequestElectronicBoardDto updateModel);
    }
}
