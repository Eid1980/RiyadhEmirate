using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class GovernorateRepository : Repository<Governorate, EmiratesContext>, IGovernorateRepository
    {
        public GovernorateRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
