using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.RequestJudgmentExecutions
{
    public interface IRequestJudgmentExecutionService
    {
        IApiResponse GetById(Guid id);
        IApiResponse GetDetailsById(Guid id);
        IApiResponse Create(CreateRequestJudgmentExecutionDto createModel);
        IApiResponse Update(UpdateRequestJudgmentExecutionDto updateModel);
    }
}
