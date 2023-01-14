using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class PrisonRepository : Repository<Prison, EmiratesContext>, IPrisonRepository
    {
        public PrisonRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
