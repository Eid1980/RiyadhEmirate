using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class ServiceAudienceRepository : Repository<ServiceAudience, EmiratesContext>, IServiceAudienceRepository
    {
        public ServiceAudienceRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
