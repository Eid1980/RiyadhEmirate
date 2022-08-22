using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories.Security;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestJudgmentExecutionRepository : Repository<RequestJudgmentExecution, EmiratesContext>, IRequestJudgmentExecutionRepository
    {
        public RequestJudgmentExecutionRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
