using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class StageRepository : Repository<Stage, EmiratesContext>, IStageRepository
    {
        public StageRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
