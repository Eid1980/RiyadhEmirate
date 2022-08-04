using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories.Security;

namespace Emirates.InfraStructure.Repositories
{
    public class StageRepository : Repository<Stage, EmiratesContext>, IStageRepository
    {
        public StageRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
