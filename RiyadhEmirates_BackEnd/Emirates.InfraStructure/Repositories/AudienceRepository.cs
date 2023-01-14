using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class AudienceRepository : Repository<Audience, EmiratesContext>, IAudienceRepository
    {
        public AudienceRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
