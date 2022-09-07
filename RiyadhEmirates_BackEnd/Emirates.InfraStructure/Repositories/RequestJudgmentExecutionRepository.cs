using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestJudgmentExecutionRepository : Repository<RequestJudgmentExecution, EmiratesContext>, IRequestJudgmentExecutionRepository
    {
        public RequestJudgmentExecutionRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
