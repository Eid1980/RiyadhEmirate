using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestPrisonerTempReleaseRepository : Repository<RequestPrisonerTempRelease, EmiratesContext>, IRequestPrisonerTempReleaseRepository
    {
        public RequestPrisonerTempReleaseRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
