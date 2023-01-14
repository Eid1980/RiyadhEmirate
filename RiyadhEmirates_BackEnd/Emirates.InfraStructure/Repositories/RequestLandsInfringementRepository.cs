using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestLandsInfringementRepository : Repository<RequestLandsInfringement, EmiratesContext>, IRequestLandsInfringementRepository
    {
        public RequestLandsInfringementRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
