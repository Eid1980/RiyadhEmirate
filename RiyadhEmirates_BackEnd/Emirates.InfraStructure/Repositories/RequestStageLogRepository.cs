using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestStageLogRepository : Repository<RequestStageLog, EmiratesContext>, IRequestStageLogRepository
    {
        public RequestStageLogRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
